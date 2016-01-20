using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedControls
{
    public partial class ControlsForm : Form
    {
        public ControlsForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save File");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        public void ClearColor()
        {
            
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;

        }
    }
}
