using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTrabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Creamos el LinkLabel.
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();

            // Configuramos su localización en el formulario. 
            this.linkLabel1.Location = new System.Drawing.Point(34, 56);
            // Especificamos el tamaño, que por defecto vendrá por el contenido.
            this.linkLabel1.AutoSize = true;

            // Añadimos un controlador de eventos que haga algo cuando se haga click en un link.
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

            // Añadimos este este al LinkLabell.
            this.linkLabel1.Text = "Ir a Google";

            // Determinamos cómo se deberá mostrar el formulario y añadimos los controles.
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.linkLabel1 });
            this.Text = "Ejemplo";
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            // Se pone que el link ha sido visitado.
            this.linkLabel1.LinkVisited = true;

            // Se va a la URL
            System.Diagnostics.Process.Start("http://www.google.com");

        }
    }
}
