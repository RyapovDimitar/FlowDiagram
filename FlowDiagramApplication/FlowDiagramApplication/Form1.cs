using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowDiagramApplication.Components;
using System.Drawing.Imaging;

namespace FlowDiagramApplication
{
    public partial class Form1 : Form
    {
        FlowDiagram fl;
        ToolType tool;
        private int halfSize = 20;
        private Component selectedComponent = null;
        private Component unselectedComponent = null;
        private Pipeline selectedPipeline = null;

        private Component input = null;
        private Component output = null;


        private enum ToolType
        {
            select,
            delete,
            addSink,
            addPump,
            addMerger,
            addAdjSplitter,
            addSplitter,
            addPipeline
        }
        public Form1()
        {
            InitializeComponent();
            fl = new FlowDiagram();
            tool = ToolType.select;
            btnSelect.Checked = true;
            
        }


        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            // Drawing the components
            if (fl.Components != null)
                foreach (Component component in fl.Components)
                {
                    switch (component.ComponentType)
                    {
                        default:
                            break;
                        case ComponentType.Sink:
                            e.Graphics.DrawImage(component.Image, component.Position);
                            break;
                        case ComponentType.Pump:
                            e.Graphics.DrawImage(component.Image, component.Position);
                            break;
                        case ComponentType.Splitter:
                            e.Graphics.DrawImage(component.Image, component.Position);
                            break;
                        case ComponentType.AdjustableSplitter:
                            e.Graphics.DrawImage(component.Image, component.Position);
                            break;
                        case ComponentType.Merger:
                            e.Graphics.DrawImage(component.Image, component.Position);
                            break;
                    }
                    
                }
            if(fl.Connections != null)
            {
                foreach (Pipeline pipeline in fl.Connections)
                {
                    e.Graphics.DrawLine(Pens.LightBlue, pipeline.InputElement.Position, pipeline.OutputElement.Position);
                }
            }

            // Draws a rectangle around the selected component
            if (selectedComponent != null)
            {
                Rectangle selectRect = new Rectangle(selectedComponent.Position.X-1, selectedComponent.Position.Y-1, halfSize * 2 + 2, halfSize * 2 + 2);
                Pen bluePen = new Pen(Color.LightBlue, 2);
                e.Graphics.DrawRectangle(bluePen, selectRect);
            }
            if (unselectedComponent != null)
            {
                Rectangle unselectRect = new Rectangle(unselectedComponent.Position.X - 1, unselectedComponent.Position.Y - 1, halfSize * 2 + 2, halfSize * 2 + 2);
                Pen whitePen = new Pen(Color.White, 2);
                e.Graphics.DrawRectangle(whitePen, unselectRect);
                unselectedComponent = null;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
            tool = ToolType.delete;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
            tool = ToolType.select;
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void btnPump_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
            tool = ToolType.addPump;
        }

        private void btnSink_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
            tool = ToolType.addSink;
        }

        private void btnSplitter_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
            tool = ToolType.addSplitter;
        }

        private void btnAdjSplitter_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
            tool = ToolType.addAdjSplitter;
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
            tool = ToolType.addMerger;
        }

        private void btnPipeline_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
            tool = ToolType.addPipeline;
        }

        private void ToolstripButtonCheck(object sender)
        {
            // This makes the clicked button checked, and unchecks the other buttons
            foreach (ToolStripButton item in ((ToolStripButton)sender).GetCurrentParent().Items)
            {
                if (item == sender) item.Checked = true;
                if ((item != null) && (item != sender))
                {
                    item.Checked = false;
                }
            }
        }

        private String CheckMousePosition (Point mousePosition)
        {
            String result = "";
            foreach (Component component in fl.Components)
            {
                if(component.Position.X + halfSize >= mousePosition.X && component.Position.X - halfSize <= mousePosition.X && component.Position.Y - halfSize <= mousePosition.Y && component.Position.Y + halfSize >= mousePosition.Y) 
                {
                    result = "Component," + Convert.ToString(component.GetId());
                    return result;
                }
            }

            //TODO Check if the position is over a pipeline

            return null;
        }

        private bool CheckComponentOverlay(Point mousePosition)
        {
            //Checks if the added component overlaps any oother component
            Point leftUp = mousePosition, rightUp = mousePosition, leftDown = mousePosition, rightDown = mousePosition;
            leftUp.X -= halfSize;
            leftUp.Y -= halfSize;

            rightUp.X += halfSize;
            rightUp.Y -= halfSize;

            leftDown.X -= halfSize;
            leftDown.Y += halfSize;

            rightDown.X += halfSize;
            rightDown.Y += halfSize;
            if (CheckMousePosition(leftUp) != null || CheckMousePosition(rightUp) != null || CheckMousePosition(leftDown) != null || CheckMousePosition(rightDown) != null)
                return false;
            return true;
        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            String selected = "";
            string[] str;
            Point position = me.Location;
            position.X -= halfSize;
            position.Y -= halfSize;

            switch (tool)
            {
                case ToolType.select:
                    selected = CheckMousePosition(position);
                    if (selected != null)
                    {
                        str = selected.Split(new[] { ',' });
                        if (str[0] == "Component")
                        {
                            SelectComponent(Convert.ToInt32(str[1]));
                        }
                    }
                    if (selected == null)
                    {
                        unselectedComponent = selectedComponent;
                        selectedComponent = null;
                    }
                    break;
                case ToolType.delete:
                    selected = CheckMousePosition(position);
                    if(selected != null)
                    {
                        str = selected.Split(new[] { ',' });
                        if (str[0] == "Component")
                        {
                            DeleteComponent(Convert.ToInt32(str[1]));
                        }
                    }
                    else
                    {

                    }
                    break;
                case ToolType.addSink:
                    if(CheckComponentOverlay(position))
                        fl.AddComponent(position, ComponentType.Sink);
                    break;
                case ToolType.addPump:
                    if (CheckComponentOverlay(position))
                        fl.AddComponent(position, ComponentType.Pump);
                    break;
                case ToolType.addMerger:
                    if (CheckComponentOverlay(position))
                        fl.AddComponent(position, ComponentType.Merger);
                    break;
                case ToolType.addAdjSplitter:
                    if (CheckComponentOverlay(position))
                        fl.AddComponent(position, ComponentType.AdjustableSplitter);
                    break;
                case ToolType.addSplitter:
                    if (CheckComponentOverlay(position))
                        fl.AddComponent(position, ComponentType.Splitter);
                    break;
                case ToolType.addPipeline:
                    selected = CheckMousePosition(position);
                    if (selected != null)
                    {
                        str = selected.Split(new[] { ',' });
                        if (str[0] == "Component")
                        {
                            SelectComponent(Convert.ToInt32(str[1]));
                            if (input == null)
                            {
                                input = selectedComponent;
                            }
                            else if (output == null)
                            {
                                output = selectedComponent;
                                
                            }
                            else
                            {
                                fl.Connect(input, output);
                                input = null;
                                output = null;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            pbCanvas.Invalidate();
        }
        private void SelectComponent(int componentId)
        {
            foreach (Component component in fl.Components)
            {
                if (component.GetId() == componentId)
                {
                    selectedComponent = component;
                    selectedPipeline = null;
                }
            }
            pbCanvas.Invalidate();
        }
        private void DeleteComponent(int componentId)
        {
            Component toDelete = null;
            foreach (Component component in fl.Components)
            {
                if (component.GetId() == componentId)
                {
                    toDelete = component;
                }
            }
            if (toDelete == selectedComponent)
            {
                unselectedComponent = selectedComponent;
                selectedComponent = null;
            }
            fl.DeleteComponent(toDelete);
        }
    }
}
