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
        private bool moveComponent = false;
        Point mousePosition = new Point();
        private int halfSize = 20;
        private Component selectedComponent = null, unselectedComponent = null, 
            selectedFirstPipeComponent = null, selectedSecondPipeComponent = null;
        private Pipeline selectedPipeline = null;
        private Component input = null, output = null;

        String inputFile = String.Empty;
        String inputPos = "";
        String outputPos = "";

        private enum ToolType
        {
            //Andi
            select,
            move,
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
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fl.Components = new List<Component>();
            tool = ToolType.select;
            btnSelect.Checked = true;
            
        }


        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            //Andi
            Pen whitePen = new Pen(Color.White, 2);
            Pen bluePen = new Pen(Color.LightBlue, 2);
            Pen greenPipeline = new Pen(Color.LightGreen, 4);
            Pen yellowPipeline = new Pen(Color.Yellow, 4);
            Pen redPipeline = new Pen(Color.Red, 4);

            // Drawing the line for adding a new pipeline
            if (input != null && output == null)
            {
                e.Graphics.DrawLine(bluePen, input.Position.X+halfSize, input.Position.Y + halfSize, mousePosition.X, mousePosition.Y);
            }

            // Drawing the pipelines
            if (fl.Connections != null)
            {
                foreach (Pipeline pipeline in fl.Connections)
                {
                    Point inputPosition = new Point();
                    Point outputPosition = new Point();
                    if (pipeline.InputElement != null && pipeline.OutputElement != null)
                    {
                        inputPosition.Y = pipeline.InputElement.Position.Y + halfSize;
                        inputPosition.X = pipeline.InputElement.Position.X;
                        outputPosition.Y = pipeline.OutputElement.Position.Y + halfSize;
                        outputPosition.X = pipeline.OutputElement.Position.X + halfSize * 2;
                        if (pipeline.OutputElement.ComponentType == ComponentType.Splitter)
                        {
                            if (((Components.Splitter)pipeline.OutputElement).LowerConnectedComponent == pipeline.InputElement.GetId())
                            {
                                outputPosition.X = pipeline.OutputElement.Position.X + halfSize * 2;
                                outputPosition.Y = pipeline.OutputElement.Position.Y + halfSize * 2 - 8;
                            }
                            if (((Components.Splitter)pipeline.OutputElement).UpperConnectedComponent == pipeline.InputElement.GetId())
                            {
                                outputPosition.X = pipeline.OutputElement.Position.X + halfSize * 2;
                                outputPosition.Y = pipeline.OutputElement.Position.Y + 8;
                            }
                        }
                        if (pipeline.OutputElement.ComponentType == ComponentType.AdjustableSplitter)
                        {
                            if (((AdjustableSplitter)pipeline.OutputElement).LowerConnectedComponent == pipeline.InputElement.GetId())
                            {
                                outputPosition.X = pipeline.OutputElement.Position.X + halfSize * 2;
                                outputPosition.Y = pipeline.OutputElement.Position.Y + halfSize * 2 - 8;
                            }
                            if (((AdjustableSplitter)pipeline.OutputElement).UpperConnectedComponent == pipeline.InputElement.GetId())
                            {
                                outputPosition.X = pipeline.OutputElement.Position.X + halfSize * 2;
                                outputPosition.Y = pipeline.OutputElement.Position.Y + 8;
                            }
                        }
                        if(pipeline.InputElement.ComponentType == ComponentType.Merger)
                        {
                            if (((Merger)pipeline.InputElement).LowerConnectedComponent == pipeline.OutputElement.GetId())
                            {
                                inputPosition.Y = pipeline.InputElement.Position.Y + halfSize * 2 - 8;
                            }
                            if (((Merger)pipeline.InputElement).UpperConnectedComponent == pipeline.OutputElement.GetId())
                            {
                                inputPosition.Y = pipeline.InputElement.Position.Y + 8;
                            }
                        }
                        if (pipeline.CheckColor() == 1)
                            e.Graphics.DrawLine(greenPipeline, inputPosition, outputPosition);
                        if (pipeline.CheckColor() == 2)
                            e.Graphics.DrawLine(yellowPipeline, inputPosition, outputPosition);
                        if (pipeline.CheckColor() == 3)
                            e.Graphics.DrawLine(redPipeline, inputPosition, outputPosition);
                        using (Font myFont = new Font("Arial", 7))
                        {
                            Point flowText = new Point();
                            flowText.X = (inputPosition.X + outputPosition.X) / 2;
                            flowText.Y = (inputPosition.Y + outputPosition.Y) / 2 - 15;
                            e.Graphics.DrawString(Convert.ToString(pipeline.CurrentFlow), myFont, Brushes.Black, flowText);
                        }

                    }

                }
            }
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


            // Draws a rectangle around the selected component
            if (selectedComponent != null)
            {
                Rectangle selectRect = new Rectangle(selectedComponent.Position.X-1, selectedComponent.Position.Y-1, halfSize * 2 + 2, halfSize * 2 + 2);
                e.Graphics.DrawRectangle(bluePen, selectRect);
            }
            if (unselectedComponent != null)
            {
                Rectangle unselectRect = new Rectangle(unselectedComponent.Position.X - 1, unselectedComponent.Position.Y - 1, halfSize * 2 + 2, halfSize * 2 + 2);
                e.Graphics.DrawRectangle(whitePen, unselectRect);
                unselectedComponent = null;
            }
        }
        
        private void pbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            //Codrin
            if(input != null && output == null)
            {
                mousePosition = e.Location;
                pbCanvas.Invalidate();
            }

            if(selectedComponent != null && moveComponent == true)
            {
                Point pos = new Point();
                pos.X = e.Location.X - halfSize;
                pos.Y = e.Location.Y - halfSize;
                selectedComponent.ChangePosition(pos);
                pbCanvas.Invalidate();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
            tool = ToolType.delete;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
            tool = ToolType.select;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
            tool = ToolType.move;
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
        }

        private void btnPump_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
            tool = ToolType.addPump;
        }

        private void btnSink_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
            tool = ToolType.addSink;
        }

        private void btnSplitter_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
            tool = ToolType.addSplitter;
        }

        private void btnAdjSplitter_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
            tool = ToolType.addAdjSplitter;
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
            tool = ToolType.addMerger;
        }

        private void btnPipeline_Click(object sender, EventArgs e)
        {
            //Codrin
            ToolstripButtonCheck(sender);
            tool = ToolType.addPipeline;
        }

        private void ToolstripButtonCheck(object sender)
        {
            //Codrin
            // This makes the clicked button checked, and unchecks the other buttons
            foreach (ToolStripButton item in ((ToolStripButton)sender).GetCurrentParent().Items)
            {
                if (item == sender) item.Checked = true;
                if(sender.ToString() != "Pipeline")
                {
                    input = null;
                    output = null;
                    pbCanvas.Invalidate();
                }
                if(sender.ToString() != "Move")
                {
                    moveComponent = false;
                    pbCanvas.Invalidate();
                }
                if ((item != null) && (item != sender))
                {
                    item.Checked = false;
                }
            }
        }

        private void pbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            //Andi
            String selected = "";
            string[] str;

            Point position = e.Location;
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
                            if (selectedFirstPipeComponent != null && selectedFirstPipeComponent.GetId() != Convert.ToInt32(str[1]))
                            {
                                selectedSecondPipeComponent = selectedComponent;
                                Pipeline p = fl.GetPipelineByTwoComponents(selectedFirstPipeComponent, selectedSecondPipeComponent);
                                if (p != null)
                                {
                                    SelectPipeline(p.CurrentId);
                                    networkProperties.Visible = false;
                                    componentProperties.Visible = false;
                                    gbPipeline.Visible = true;
                                    tbPipeline.Visible = true;
                                    tbPipeline.Text = selectedPipeline.SafetyLimit.ToString();
                                }
                            }


                        }
                        if (str[0] == "Pipeline")
                        {
                            SelectPipeline(Convert.ToInt32(str[1]));
                        }
                    }
                    if (selected == null)
                    {
                        unselectedComponent = selectedComponent;
                        selectedComponent = null;
                        selectedPipeline = null;
                    }
                    break;
                case ToolType.move:
                    if (moveComponent == false)
                    {
                        selected = CheckMousePosition(position);
                        if (selected != null)
                        {
                            str = selected.Split(new[] { ',' });
                            if (str[0] == "Component")
                            {
                                SelectComponent(Convert.ToInt32(str[1]));
                                moveComponent = true;
                            }
                        }
                        if (selected == null)
                        {
                            unselectedComponent = selectedComponent;
                            selectedComponent = null;
                        }
                    }
                    else
                    {
                        //if(CheckComponentOverlay(position))
                        moveComponent = false;
                    }
                    break;
                case ToolType.delete:
                    selected = CheckMousePosition(position);
                    if (selected != null)
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
                    if (CheckComponentOverlay(position))
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
                                if (input is Components.Splitter || input is AdjustableSplitter)
                                {
                                    int part = CheckPartOfComponent(position, input);
                                    if (part == 1)
                                    {
                                        inputPos = "up";
                                    }
                                    if (part == 4)
                                    {
                                        inputPos = "down";
                                    }
                                    if (part == 2 || part == 3)
                                    {
                                        input = null;
                                    }
                                }

                            }
                            else if (output == null && input != null)
                            {
                                output = selectedComponent;
                                if ((input is Pump && output is Pump) || (input is Sink && output is Sink))
                                {
                                    output = null;
                                }
                                if (output is Merger)
                                {
                                    int part = CheckPartOfComponent(position, output);
                                    if (part == 2)
                                    {
                                        outputPos = "up";
                                    }
                                    if (part == 3)
                                    {
                                        outputPos = "down";
                                    }
                                    if (part == 1 || part == 4)
                                    {
                                        output = null;
                                    }
                                }
                                if (output != null)
                                {
                                    fl.Connect(output, input, outputPos, inputPos);
                                    input = null;
                                    output = null;
                                    inputPos = "";
                                    outputPos = "";
                                }

                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            // Checks if a Pump is selected
            if (selectedComponent != null && selectedComponent.ComponentType == ComponentType.Pump)
            {
                componentProperties.Visible = true;
                Pump selectedPump = SelectPump();
                tbCapacity.Text = Convert.ToString(selectedPump.Capacity);
                tbFlow.Text = Convert.ToString(selectedPump.Output);
            }
            else
            {
                componentProperties.Visible = false;
            }

            if (selectedPipeline != null)
            {
                gbPipeline.Visible = true;
                gbPipeline.Enabled = true;
                tbPipeline.Text = Convert.ToString(selectedPipeline.SafetyLimit);
            }
            else
            {
                gbPipeline.Enabled = false;
                gbPipeline.Visible = false;
            }
            //Checks if an adjustable splitter is selected
            if (selectedComponent != null && selectedComponent.ComponentType == ComponentType.AdjustableSplitter)
            {
                gbSetRate.Visible = true;
                AdjustableSplitter selectedAdjustableSplitter = SelectAdjustableSplitter();
                tbSetRate.Text = Convert.ToString(selectedAdjustableSplitter.DivisionRate);
            }
            else
            {
                gbSetRate.Visible = false;
            }
            if (selectedComponent == null && selectedPipeline == null)
            {
                networkProperties.Visible = true;
                tbGeneralSafetyLimit.Text = Convert.ToString(fl.GeneralSafetyLimit);
            }
            else
            {
                networkProperties.Visible = false;
            }

            pbCanvas.Invalidate();
        }
        private String CheckMousePosition(Point mousePosition)
        {
            //Andi
            String result = null;
            Point inputPosition = new Point();
            Point outputPosition = new Point();
            Point checkPos = new Point();

            foreach (Component component in fl.Components)
            {
                if (component.Position.X + halfSize >= mousePosition.X && component.Position.X - halfSize <= mousePosition.X && component.Position.Y - halfSize <= mousePosition.Y && component.Position.Y + halfSize >= mousePosition.Y)
                {
                    result = "Component," + Convert.ToString(component.GetId());
                    return result;
                }
            }
                
            //TODO Check if the position is over a pipeline
            if(selectedPipeline != null)
            {
                result = "Pipeline," + Convert.ToString(selectedPipeline.CurrentId);
                return result;
            }
            
            return null;
        }
        private bool isOnLine (Point a, Point b, Point c)
        {
            //Andi
            //return (a.Y - b.Y) * (a.X - c.X) == (a.Y - c.Y) * (a.X - b.X);
                if (c.X == (a.X + b.X) / 2 && c.Y == (a.Y + b.Y) / 2)
                    return true;
            return false;
        }
        public bool IsPointOnLine(Point a, Point b, Point c, int cushion)
        {
            //Dimitar
            float slope = (((float)a.Y - (float)a.Y) / ((float)b.X - (float)b.X));
            float YIntercept = a.Y - slope * a.X;
            float temp = (slope * c.X + YIntercept);
            if (temp >= (c.Y - cushion) && temp <= (c.Y + cushion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckComponentOverlay(Point mousePosition)
        {
            //Andi
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
        }

        private Pump SelectPump ()
        {
            //Codrin
            Pump selectedPump = (Pump)fl.Components.First(component => component.GetId() == selectedComponent.GetId());
            return selectedPump;
        }

        private AdjustableSplitter SelectAdjustableSplitter ()
        {
            //Codrin
            AdjustableSplitter selectedAdjustableSplitter = (AdjustableSplitter)fl.Components.First(component => component.GetId() == selectedComponent.GetId());
            return selectedAdjustableSplitter;
        }

        private void SelectComponent(int componentId)
        {
            //Codrin
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
        private void SelectPipeline(int pipelineId)
        {
            //Codrin
            foreach (Pipeline pipeline in fl.Connections)
            {
                if (pipeline.CurrentId == pipelineId)
                {
                    selectedPipeline = pipeline;
                    selectedFirstPipeComponent = null;
                    selectedSecondPipeComponent = null;
                    unselectedComponent = selectedComponent;
                    selectedComponent = null;
                }
            }

            pbCanvas.Invalidate();
        }
        private void DeleteComponent(int componentId)
        {
            //Andi
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
            pbCanvas.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Codrin
            if (selectedComponent != null)
            {
                MessageBox.Show(selectedComponent.ToString());
            }
            else if(selectedPipeline != null)
            {
                MessageBox.Show(selectedPipeline.ToString());
            }
            else
            {
                MessageBox.Show(fl.CalculateFlow().ToString());
            }
        }

        private void clearNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Codrin
            var confirmResult = MessageBox.Show("Are you sure you want to clear the network?", "Yes No", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                fl.ClearFlowDiagram();
                selectedComponent = null;
                unselectedComponent = null;
                selectedPipeline = null;
                input = null;
                output = null;
                pbCanvas.Invalidate();
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Codrin
            MessageBox.Show(fl.CalculateFlow().ToString());
        }
        private void tbGeneralSafetyLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Andi
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void tbFlow_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Andi
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void tbCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Andi
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void tbCapacity_TextChanged(object sender, EventArgs e)
        {
            //Andi
            if(tbCapacity.Text != "")
            {
                double capacity = Convert.ToDouble(tbCapacity.Text);
                fl.ChangeCapacity(selectedComponent, capacity);
            }
        }
        private void tbPipelineSafetyLimit_TextChanged(object sender, EventArgs e)
        {
            //Andi
            if (tbPipeline.Text != "")
            {
                double safetyLimit = Convert.ToDouble(tbPipeline.Text);
                fl.ChangeSafetyLimit(safetyLimit, selectedPipeline);
                fl.CalculateFlow();
            }
        }
        private void tbFlow_TextChanged(object sender, EventArgs e)
        {
            //Codrin
            if (tbFlow.Text != "")
            {
                double flow = Convert.ToDouble(tbFlow.Text);
                fl.ChangeCurrentFlow(selectedComponent, flow);
                fl.CalculateFlow();
                pbCanvas.Invalidate();
            }
        }

        

        private void tbSetRate_TextChanged(object sender, EventArgs e)
        {
            //Codrin
            if (tbCapacity.Text != "")
            {
                int divisionRate = Convert.ToInt32(tbSetRate.Text);
                fl.ChangeSplitterDivisionRate(divisionRate, selectedComponent);
                pbCanvas.Invalidate();
            }
        }

        private void tbSetRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Andi
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Codrin
            if (inputFile != string.Empty)
            {
                fl.SaveToFile(inputFile);
            }
            else
            {
                MessageBox.Show("You have not opened a file, please open a file first.");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Codrin
            fl = new FlowDiagram();
            this.inputFile = String.Empty;
            pbCanvas.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Andi
            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "Binary file|*.bin";
            loadFileDialog.Title = "Load a flow network";
            loadFileDialog.ShowDialog();
            if (loadFileDialog.FileName != null)
                fl.LoadFromFile(loadFileDialog.FileName);
                this.inputFile = loadFileDialog.FileName;
            pbCanvas.Invalidate();
        }

        private void tbGeneralSafetyLimit_TextChanged(object sender, EventArgs e)
        {
            //Codrin
            if (tbGeneralSafetyLimit.Text != "")
            {
                fl.ChangeSafetyLimitGeneral(Convert.ToInt32(tbGeneralSafetyLimit.Text));
                fl.CalculateFlow();
                pbCanvas.Invalidate();
            }
        }

        private void tbPipeline_TextChanged(object sender, EventArgs e)
        {
            //Codrin
            if (selectedPipeline != null)
            {
                fl.ChangeSafetyLimit(Convert.ToInt32(tbPipeline.Text), selectedPipeline);
                pbCanvas.Invalidate();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            //Dimitar
            if (tool == ToolType.select)
            {
                string selected = CheckMousePosition(new Point(e.X-halfSize, e.Y- halfSize));
                if (selected != null)
                {
                    String[] str = selected.Split(new[] { ',' });
                    if (str[0] == "Component")
                    {
                        selectedFirstPipeComponent = fl.GetComponentById(Convert.ToInt32(str[1]));
                        if (selectedFirstPipeComponent != null)
                        {
                            //MessageBox.Show(selectedFirstPipeComponent.ToString());
                        }
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Codrin
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|*.bin";
            saveFileDialog.Title = "Save the flow network";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != null)
                fl.SaveToFile(saveFileDialog.FileName);
                this.inputFile = saveFileDialog.FileName;
        }
        private int CheckPartOfComponent(Point mousePosition, Component c)
        {
            //Dimitar + Andi
            //First we have the component X and Y borders
            int minY = c.Position.Y - halfSize;
            int maxY = c.Position.Y + halfSize;
            int minX = c.Position.X - halfSize;
            int maxX = c.Position.X + halfSize;
            if (mousePosition.Y > minY + halfSize && mousePosition.Y <= maxY)
            {
                if (mousePosition.X > minX + halfSize && mousePosition.X <= maxX)
                {
                    return 4;
                }
                if (mousePosition.X >= minX && mousePosition.X <= minX + halfSize)
                {
                    return 3;
                }
            }
            else if(mousePosition.Y < minY + halfSize && mousePosition.Y >= minY)
            {
                if (mousePosition.X > minX + halfSize && mousePosition.X <= maxX)
                {
                    return 1;
                }
                if (mousePosition.X >= minX && mousePosition.X <= minX + halfSize)
                {
                    return 2;
                }
            }
            return 0;
        }
    }
}
