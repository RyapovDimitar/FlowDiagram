using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            fl.Components = new List<Component>();
        }
    }
}
