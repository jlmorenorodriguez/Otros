using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.CheckState = checkBox1.CheckState;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked=!checkBox1.Checked;
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            if(checkBox1.Visible)
            {
                checkBox1.Hide();
                checkBox2.Hide();
            }
            else
            {
                checkBox1.Show();
                checkBox2.Show();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radioButton2.Appearance = Appearance.Button;
            else
                radioButton2.Appearance = Appearance.Normal;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }
    }
}
