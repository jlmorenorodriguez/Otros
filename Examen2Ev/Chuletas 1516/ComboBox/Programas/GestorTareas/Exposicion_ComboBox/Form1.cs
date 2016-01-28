using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Exposicion_ComboBox
{
    public partial class FormTareas : Form
    {
        StreamWriter fw = new StreamWriter("test.txt",true);
        public FormTareas()
        {
            InitializeComponent();

            ResizeRedraw = true;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            cbHorario.Items.Insert(0, "Sevilla");
            cbHorario.Items.Insert(1, "DIW");
            cbHorario.Items.Insert(2, "DWC");
            cbHorario.Items.Insert(3, "DAW");

            cbHorario.Items.RemoveAt(0);



        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {

            try
            {
                fw.WriteLine("[" + DateTime.Now + "] >> Asignatura: " + "[" + (cbHorario.SelectedItem).ToString() + "] " + txtTarea.Text);
                MessageBox.Show("Registro añadido");
                //cbHorario.Items.Insert(4, txtAnadeQuita.Text.Trim());
                txtTarea.Clear();
            }
            catch
            {
                MessageBox.Show("No ha sido posible actualizar las tareas");
            }
                

            
        }

        private void btnAnadirQuitar_Click(object sender, EventArgs e)
        {

            if (cbHorario.Text.Length != 0 && cbHorario.Text.Trim() != "" && !cbHorario.Items.Contains(cbHorario.Text.Trim()))
            {
                cbHorario.Items.Add(cbHorario.Text);
                MessageBox.Show("Asignatura añadida");
                

            }

            else if (cbHorario.Items.Contains(cbHorario.Text))
            {
                DialogResult result1 = MessageBox.Show("Ya existe esa asignatura, ¿Desea eliminarla?","AVISO",MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    cbHorario.Items.Remove(cbHorario.Text.Trim());
                    MessageBox.Show("Asignatura Borrada");

                }
            }

            else
            {
                MessageBox.Show("Introduzca algún valor");
            }
        }

        private void chkvisible_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAbrirRegistro_Click(object sender, EventArgs e)
        {
                /* StreamReader sr = new StreamReader("test.txt");
                MessageBox.Show(sr.ReadToEnd());
                sr.Close(); */
            }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbHorario.Text.Length == 0 && cbHorario.Text.Trim() == "" && cbHorario.Items.Contains(cbHorario.Text.Trim()))
            {
                MessageBox.Show("Introduzca algún valor");

            }

            else
            {
                cbHorario.Items.Add(cbHorario.Text);
                MessageBox.Show("Asignatura añadida");
            }

            
                if (cbHorario.Text.Length != 0)
                {
                    fw.WriteLine("[" + DateTime.Now + "] >> Asignatura: " + "[" + (cbHorario.Text) + "] " + txtTarea.Text);
                    MessageBox.Show("Registro añadido");
                    //cbHorario.Items.Insert(4, txtAnadeQuita.Text.Trim());
                    txtTarea.Clear();
                    
                }

                

                else
                {
                    fw.WriteLine("[" + DateTime.Now + "] >> Asignatura: " + "[" + (cbHorario.Text) + "] " + txtTarea.Text);
                    MessageBox.Show("Registro añadido");
                    //cbHorario.Items.Insert(4, txtAnadeQuita.Text.Trim());
                    txtTarea.Clear();
                    
                }

                
            }
           
   

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbHorario.Sorted = !cbHorario.Sorted;
        }

       
        }
    
}

    

