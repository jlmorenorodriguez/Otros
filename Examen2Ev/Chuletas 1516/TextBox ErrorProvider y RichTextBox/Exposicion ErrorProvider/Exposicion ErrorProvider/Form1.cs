using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exposicion_ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if(textBox1.Text=="")
                errorProvider1.SetError(textBox1, "Introduce tu nombre");
            else
                errorProvider1.Clear();
            
            if (textBox2.Text == "")
                errorProvider1.SetError(textBox2, "Introduce tus apellidos");
            else
                errorProvider1.Clear();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.BlinkRate = 500;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            errorProvider1.Icon = new Icon(SystemIcons.Exclamation,errorProvider1.Icon.Size);
            //errorProvider1.RightToLeft = false;

            errorProvider1.SetIconPadding(this, 20);
            errorProvider1.SetIconAlignment(this, ErrorIconAlignment.BottomLeft);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (errorProvider1.RightToLeft == true)
                errorProvider1.RightToLeft = false;
            else
                errorProvider1.RightToLeft = true;
        }

       
        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Estas usando el evento RightToLeftChanged");
        }
    }
}
