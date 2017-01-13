﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowDiagramApplication.Components;

namespace FlowDiagramApplication
{
    public partial class Form1 : Form
    {
        FlowDiagram fl;
        ToolType tool;
        private int halfSize = 20;

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
                return true;
            return false;
        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            String selected = "";
            Point position = me.Location;
            position.X -= halfSize;
            position.Y -= halfSize;

            switch (tool)
            {
                case ToolType.select:
                    selected = CheckMousePosition(position);
                    string[] str = selected.Split(new[] { ',' });
                    if (str[0] == "Component")
                    {
                        SelectComponent(Convert.ToInt32(str[1]));
                    }
                    break;
                case ToolType.delete:
                    selected = CheckMousePosition(position);
                    str = selected.Split(new[] { ',' });
                    if (str[0] == "Component")
                    {
                        DeleteComponent(Convert.ToInt32(str[1]));
                    }
                        break;
                case ToolType.addSink:
                    fl.AddComponent(position, ComponentType.Sink);
                    break;
                case ToolType.addPump:
                    fl.AddComponent(position, ComponentType.Pump);
                    break;
                case ToolType.addMerger:
                    fl.AddComponent(position, ComponentType.Merger);
                    break;
                case ToolType.addAdjSplitter:
                    fl.AddComponent(position, ComponentType.AdjustableSplitter);
                    break;
                case ToolType.addSplitter:
                    fl.AddComponent(position, ComponentType.Splitter);
                    break;
                case ToolType.addPipeline:
                    break;
                default:
                    break;
            }
            pbCanvas.Invalidate();
        }
        private void SelectComponent(int componentId)
        {
            Component component;
            foreach (Component comp in fl.Components)
            {
                if (comp.GetId() == componentId)
                {
                    component = comp;
                }
            }
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
            fl.DeleteComponent(toDelete);
        }
    }
}
