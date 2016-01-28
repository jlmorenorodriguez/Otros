using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cbOtrosMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

      

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int indice = cbcomunidades.FindString(cbcomunidades.Text);
            MessageBox.Show("La comunidad se encuentra en la posición " + indice);
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int siono = cbcomunidades.FindStringExact(cbcomunidades.Text);
            if (siono == -1)
            {
                
              DialogResult result1 = MessageBox.Show("La comunidad no está en la lista, ¿Desea añadirla?","AVISO",MessageBoxButtons.YesNo);
              if (result1 == DialogResult.Yes)
              {
                  cbcomunidades.Items.Add(cbcomunidades.Text.Trim());
                  MessageBox.Show("Comunidad añadida");

              }
            }
            else
            {
                MessageBox.Show("La comunidad se encuentra en la posición " + siono);
            }
        }

        private void cbcomunidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
