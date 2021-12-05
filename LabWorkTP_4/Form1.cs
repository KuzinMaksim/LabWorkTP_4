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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dgOpenFile = new OpenFileDialog();
            dgOpenFile.Title = "Загрузка";
            dgOpenFile.Filter= "RTF Files (*.rtf)|*.rtf";
            if (dgOpenFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(dgOpenFile.FileName);            
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dgSaveFile = new SaveFileDialog();
            dgSaveFile.Title = "Сохраниение";
            dgSaveFile.DefaultExt = "*.rtf";
            dgSaveFile.Filter = "RTF Files|*.rtf";
            if (dgSaveFile.ShowDialog()== DialogResult.OK)
            {
                richTextBox.SaveFile(dgSaveFile.FileName.Replace(".txt", ".rtf"), RichTextBoxStreamType.RichText);
            }
        }

        private void LeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void RightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        
        }

        private void ConfirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float i = Convert.ToInt32(toolStripComboBox1.Text);
            richTextBox.Font = new Font(richTextBox.SelectionFont.FontFamily, i);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
