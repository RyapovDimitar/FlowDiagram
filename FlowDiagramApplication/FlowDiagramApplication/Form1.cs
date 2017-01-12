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

namespace FlowDiagramApplication
{
    public partial class Form1 : Form
    {
        FlowDiagram fl;
        public Form1()
        {
            InitializeComponent();
            fl = new FlowDiagram();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap DrawArea = new Bitmap(pbCanvas.Size.Width, pbCanvas.Size.Height);
            pbCanvas.Image = DrawArea;

            fl.Components = new List<Component>();
            Point random = new Point(20, 20);
            Point random2 = new Point(450, 200);
            Pump myPump = new Pump(random, ComponentType.Pump);
            Sink mySink = new Sink(random2, ComponentType.Sink);
            fl.Components.Add(myPump);
            fl.Components.Add(mySink);
            pbCanvas.Invalidate();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (fl.Components != null)
                foreach (Component component in fl.Components)
                {
                    e.Graphics.DrawEllipse(new Pen(Color.Red, 2f),component.Position.X, component.Position.Y, 20, 20);
                }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void btnPump_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void btnSink_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void btnSplitter_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void btnAdjSplitter_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void btnPipeline_Click(object sender, EventArgs e)
        {
            ToolstripButtonCheck(sender);
        }

        private void ToolstripButtonCheck(object sender)
        {
            // This method makes the other buttons in the toolstrip uncheck when one button is selected
            foreach (ToolStripButton item in ((ToolStripButton)sender).GetCurrentParent().Items)
            {
                if (item == sender) item.Checked = true;
                if ((item != null) && (item != sender))
                {
                    item.Checked = false;
                }
            }
        }

    }
}
