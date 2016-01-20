using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingTabs
{
    public partial class UsingTabsForm : Form
    {
        public UsingTabsForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                displayLabel.ForeColor = colorDialog.Color;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Red;
        }

        private void Hello_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Hello!";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Good Bye!";
        }
    }
}
