using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            
            
            dUd1.Items.Add("Cadiz");
            dUd1.Items.Add("Huelva");
            dUd1.Items.Add("Sevilla");
            dUd1.Items.Add("Granada");
            dUd1.Items.Add("Almeria");
            dUd1.Items.Add("Malaga");
            

           

            lb2.Hide();

            

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
                /*SelectedIndex nd SelectedItem*/

            if (chbOrdenar.Checked)
                lb2.Items.Add(dUd1.SelectedIndex + " " + dUd1.SelectedItem);
            else
                lb1.Items.Add(dUd1.SelectedIndex + " " + dUd1.SelectedItem);



            

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            dUd1.Items.Add(txbAnadir.Text);
            txbAnadir.Clear();

        }

        private void chbOrdenar_CheckedChanged(object sender, EventArgs e)
        {

            /*Sorted*/
           
            dUd1.Sorted =!dUd1.Sorted;
            if (dUd1.Sorted)
                lb2.Show();
            else
                lb2.Hide();
            
            
          
        }

        private void chbEnvolver_CheckedChanged(object sender, EventArgs e)
        {
            dUd1.Wrap =!dUd1.Wrap;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            lb2.Items.Clear();
            


            #region Anadir
            dUd1.Items.Clear();
            dUd1.Items.Add("Cadiz");
            dUd1.Items.Add("Huelva");
            dUd1.Items.Add("Sevilla");
            dUd1.Items.Add("Granada");
            dUd1.Items.Add("Almeria");
            dUd1.Items.Add("Malaga");
            #endregion


        }
    }
}
