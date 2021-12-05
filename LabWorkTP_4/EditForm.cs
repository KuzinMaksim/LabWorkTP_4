using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWorkTP_4
{
    public partial class EditForm : Form
    {
        public EditForm(Form form)
        {
            InitializeComponent();
            MdiParent = form;
        }

        private void app1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(toolStripComboBox1.Text);
            MdiParent.Opacity = i;
        }

        private void app4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(toolStripComboBox2.Text);
            int b = Convert.ToInt32(toolStripComboBox4.Text);
            Point tempPoint = new Point(a, b);
            MdiParent.DesktopLocation = tempPoint;
        }

        private void app5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(toolStripComboBox3.Text);
            int b = Convert.ToInt32(toolStripComboBox5.Text);
            MdiParent.MaximumSize = new Size(a, b);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
