using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTrabajo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
    Panel panel1 = new Panel();
    TextBox textBox1 = new TextBox();
    Label label1 = new Label();

    // Se inicializa el panel de control
    panel1.Location = new Point(56,72);
    panel1.Size = new Size(264, 152);
    // Se define el borde.
    panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

    //  Se inicializa el Label y el TextBox.
    label1.Location = new Point(16,16);
    label1.Text = "label1";
    label1.Size = new Size(104, 16);
    textBox1.Location = new Point(16,32);
    textBox1.Text = "TextBox";
    textBox1.Size = new Size(152, 20);

    // Se añade el Panel
    this.Controls.Add(panel1);
    // Se añade el Label y el TextBox al Panel    
    panel1.Controls.Add(label1);
    panel1.Controls.Add(textBox1);
 }

        }
    }

