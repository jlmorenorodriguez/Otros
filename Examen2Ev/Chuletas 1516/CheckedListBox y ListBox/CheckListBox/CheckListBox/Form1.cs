using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBoxEquipos.Items.Add("Real Betis");
            checkedListBoxEquipos.Items.Add("Valencia CF");
            checkedListBoxEquipos.Items.Add("FC Barcelona");
            checkedListBoxEquipos.Items.Add("Real Madrid");

            listBoxEquipos.Items.Add("Calavera CF");
            listBoxEquipos.Items.Add("Hispalis FC");
            listBoxEquipos.Items.Add("Altair CF");
            listBoxEquipos.Items.Add("Real Sociedad");

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txbAñadirEquipo.Text == "")
                MessageBox.Show("Escribe Algo", "ERROR");

            else if (checkedListBoxEquipos.Items.Contains(txbAñadirEquipo.Text.Trim()))
                MessageBox.Show("Equipo Ya Existente", "ERROR");

            else
            {
                checkedListBoxEquipos.Items.Add(txbAñadirEquipo.Text.Trim());
                txbAñadirEquipo.Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            while (checkedListBoxEquipos.CheckedItems.Count > 0)
                checkedListBoxEquipos.Items.Remove(checkedListBoxEquipos.CheckedItems[0]);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            checkedListBoxEquipos.Sorted = true;
            listBoxEquipos.Sorted = true;
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            while (listBoxEquipos.SelectedIndices.Count > 0)
            {
                checkedListBoxEquipos.Items.Add(listBoxEquipos.SelectedItems[0]);
                listBoxEquipos.Items.Remove(listBoxEquipos.SelectedItems[0]);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            while (checkedListBoxEquipos.CheckedIndices.Count > 0)
            {
                listBoxEquipos.Items.Add(checkedListBoxEquipos.CheckedItems[0]);
                checkedListBoxEquipos.Items.Remove(checkedListBoxEquipos.CheckedItems[0]);
            }
        }




    }
}
