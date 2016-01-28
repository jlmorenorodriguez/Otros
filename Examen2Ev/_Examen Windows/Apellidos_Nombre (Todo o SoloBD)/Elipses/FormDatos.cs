using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
// Usamos el namespace System.Data.OleDb para usar BD´s Access
using System.Data.OleDb;
using Elipses.DSElipsesTableAdapters;



namespace Elipses
{
    public partial class FormDatos : Form
    {
        ElipsesTableAdapter elipsesAdapt = new ElipsesTableAdapter();

        DSElipses.ElipsesDataTable elipsesTabla = new DSElipses.ElipsesDataTable();

        DSElipses.ElipsesRow filaDS = null;

        public DSElipses.ElipsesRow FilaDS
        {
            get
            {
                return this.filaDS;
            }
            set
            {
                this.filaDS = value;
            }
        }

        public DSElipses.ElipsesRow FilaVacia
        {
            get
            {
                return this.elipsesTabla.NewElipsesRow();
            }
        }

        public FormDatos()
        {
            InitializeComponent();
            CargarTabla();
        }

        void CargarTabla()
        {
            elipsesTabla = elipsesAdapt.GetData();
            dgv.DataSource = elipsesTabla;
            dgv.ClearSelection();


            lbCabecera.Text = string.Format("Número de figuras: {0}", this.dgv.Rows.Count);


            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
            dataGridViewButtonColumn.HeaderText = "Del";
            dataGridViewButtonColumn.Text = "X";
            dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewButtonColumn.Width = 40;
            dgv.Columns.Add(dataGridViewButtonColumn);
            dgv.Columns["idElipse"].Visible = false;
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSElipses.Elipses' Puede moverla o quitarla según sea necesario.
            this.elipsesTableAdapter.Fill(this.dSElipses.Elipses);
            lbCabecera.Text = string.Format("Número de figuras: {0}", this.dgv.Rows.Count);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void EditarRegistro()
        {
            int idElipse = Convert.ToInt32(dgv.SelectedRows[0].Cells["idElipse"].Value);
            filaDS = this.elipsesTabla.FindByidElipse(idElipse);
            DialogResult = DialogResult.OK;

        }

        private void BorrarRegistro()
        {
            string text = "Confirmas que quieres eliminar esta figura?:\n\t" + this.dgv.SelectedRows[0].Cells["nombre"].Value.ToString();
            if (DialogResult.No != MessageBox.Show(text, "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                int idElipse = Convert.ToInt32(this.dgv.SelectedRows[0].Cells["idElipse"].Value);
                filaDS = this.elipsesTabla.FindByidElipse(idElipse);
                filaDS.Delete();
                elipsesAdapt.Update(filaDS);
                lbCabecera.Text = string.Format("Número de figuras: {0}", this.dgv.Rows.Count);
                dgv.ClearSelection();
            }
          

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int columnIndex = e.ColumnIndex;
            if (this.dgv.Columns[columnIndex].HeaderText == "Edit")
            {
                EditarRegistro();
            }
            else if (this.dgv.Columns[columnIndex].HeaderText == "Del")
            {
                BorrarRegistro();
            }
        }

        internal DSElipses.ElipsesRow BuscaPorNombre(string nombrElipse)
        {
            DSElipses.ElipsesDataTable dataByNombre = (DSElipses.ElipsesDataTable)elipsesAdapt.GetDataByNombre(nombrElipse);
            DSElipses.ElipsesRow result;
            if (dataByNombre.Rows.Count > 0)
            {
                result = dataByNombre[0];
            }
            else
            {
                result = null;
            }
            return result;
        }

        internal void AddRegistro(DSElipses.ElipsesRow filaDS)
        {
            elipsesTabla.AddElipsesRow(filaDS);
            elipsesAdapt.Update(filaDS);
            elipsesTabla = elipsesAdapt.GetData();
            dgv.DataSource = elipsesTabla;
            elipsesTabla.AcceptChanges();
        }

        internal void ModificaRegistro(DSElipses.ElipsesRow filaDS)
        {
            elipsesAdapt.Update(filaDS);
            elipsesTabla = elipsesAdapt.GetData();
            dgv.DataSource = elipsesTabla;
            elipsesTabla.AcceptChanges();
        }



    }
}
