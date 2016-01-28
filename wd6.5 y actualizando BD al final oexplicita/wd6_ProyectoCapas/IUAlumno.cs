using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LogicaNegocioyADatos;

namespace InterfazUsuario
{
    public partial class IUAlumno : Form
    {
        // Vamos a trabajar con la propia clase LNyAD y métodos estáticos

        bool esNuevo;

        bool comenzando = true; // <-- Para evitar el evento del combo cuando lo cargo
        
        
        

        IUDetalleAlumno fDetalleAlumno = new IUDetalleAlumno();

        DataView dw; // Para trabajar con vistas
        public IUAlumno()
        {
            InitializeComponent();
            btnGuardarCambios.Enabled = false;
            
        }

        private void IUAlumno_Load(object sender, EventArgs e)
        {
            //Cargamos los combos (en el constructor todavía no está)
            CargaCombos(); // (comentar el evento SelectedIndexChanged al cargar y cómo evitarlo)
            comenzando = false;

            dw = LNyAD.VistaDeAlumnos();
            //dw = new DataView(LNyAD.TablaAlumnos(0));

            CargaAlumnosGrupo();

            // borramos la selección
            dgv.ClearSelection();

            //--- Voy a añadirle al dgv una columna de botones para borrar
            // Construyo la columna
            DataGridViewButtonColumn borrar = new DataGridViewButtonColumn();

            // Le doy las propiedades que me interesan
            borrar.HeaderText = "Del"; // <-- Cabecera de la columna
            borrar.Text = "X";  // <-- el texto del botón
            borrar.UseColumnTextForButtonValue = true; // <-- Que la "X" aparezca en todos los botones
            borrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            borrar.Width = 40;
            // Le coloco la columna al dgv en la última posición
            dgv.Columns.Add(borrar);

            //// Si quisiéramos colocarla en otro lugar, por ejemplo en la 4ª posición
            //dgv.Columns.Insert(3, borrar);

            // Ocultar las columnas de id's
            dgv.Columns["idAlumno"].Visible = false;
            dgv.Columns["idGrupo"].Visible = false;
        }

        private void CargaCombos()
        {
            List<Grupo> listaGrupos = LNyAD.ListaGrupos();
            List<Grupo> listaTodosMasGrupos = new List<Grupo>();

            // Enlazo el combo del panelDetalle con la listaGrupos
            fDetalleAlumno.cbGruposDetalle.DataSource = listaGrupos;		// Origen de datos
            fDetalleAlumno.cbGruposDetalle.ValueMember = "IDGrupo";	// Campo asociado a Valúe "no se verá"
            fDetalleAlumno.cbGruposDetalle.DisplayMember = "Nombre";	// Campo asociado a Display "Text"


            listaTodosMasGrupos.Add(new Grupo(0, "Todos los grupos"));

            foreach (Grupo g in listaGrupos)
                listaTodosMasGrupos.Add(g);

            // Enlazo el combo del panelControles con la listaTodosMasGrupos
            cbGrupos.DataSource = listaTodosMasGrupos;		// Origen de datos
            cbGrupos.ValueMember = "IDGrupo";	// Campo asociado a Valúe "no se verá"
            cbGrupos.DisplayMember = "Nombre";	// Campo asociado a Display "Text"


        }

        private void CargaAlumnosGrupo()
        {

            // Tomo el id del grupo a partir del elemento seleccionado del combo
            int idGrupo = Convert.ToInt32(cbGrupos.SelectedValue);
            bool sonTodos = (idGrupo == 0);

            if (sonTodos)
                dw.RowFilter = "";
            else
                dw.RowFilter = "idGrupo = '" + idGrupo + "'";

            // Enlazamos el dgv a la vista
            dgv.DataSource = dw;

            // Si son todos, que aparezca la columnas de Grupos. Si es sólo un grupo, que no aparezca
            dgv.Columns["Grupo"].Visible = sonTodos;

            lbCabecera.Text = String.Format("Alumnos de {0}.  ({1} alumnos)", cbGrupos.Text, dgv.Rows.Count);
        }

        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si estoy cargando el combo no hago nada
            if (comenzando)
                return;

            // Llamamos a 
            CargaAlumnosGrupo();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;

            if (colum == 0) // <-- He pulsado el botón editar (lo controlo por el id de columna)
                EditarRegistro();
            else if (dgv.Columns[colum].HeaderText == "Del") // <-- He pulsado el botón editar (lo controlo por la cabecera de columna)
                BorrarRegistro();
        }

        private void EditarRegistro()
        {
            //----- Busco el alumno selecionado y borro el registro
            // Capturamos el idAlumnos del registro del dgv seleccionado
            int idAlumno = Convert.ToInt32(dgv.SelectedRows[0].Cells["idAlumno"].Value); // <-- Lo obtenemos de la tabla de registros seleccionados

            fDetalleAlumno.IdAlumno = idAlumno;

            if (DialogResult.OK == fDetalleAlumno.ShowDialog()) // Si salimos con aceptar, actualizamos nuestra tabla
            {
                CargaAlumnosGrupo();
                // borramos la selección
                dgv.ClearSelection();
                btnGuardarCambios.Enabled = true;
            }
        }

        private void BorrarRegistro()
        {
            //Si no confirmo el borrado, me salgo de este método
            string mensaje = "Confirmas que quieres eliminar a este alumno?:\n\t" + dgv.SelectedRows[0].Cells["apellidosNombre"].Value.ToString();
            if (DialogResult.No == MessageBox.Show(mensaje, "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                return;

            //----- Busco el alumno selecionado y borro el registro
            // Capturamos el idAlumnos del registro del dgv seleccionado
            int idAlumno = Convert.ToInt32(dgv.SelectedRows[0].Cells["idAlumno"].Value); // <-- Lo obtenemos de la tabla de registros seleccionados

            LNyAD.BorrarAlumno(idAlumno);

            CargaAlumnosGrupo();
            // borramos la selección
            dgv.ClearSelection();

            btnGuardarCambios.Enabled = true;

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            // Asignamos al IdAlumno del fDetalle un valor negativo
            fDetalleAlumno.IdAlumno = -1;

            if (DialogResult.OK == fDetalleAlumno.ShowDialog()) // Si salimos con aceptar, actualizamos nuestra tabla
            {
                CargaAlumnosGrupo();
                dgv.ClearSelection();

                btnGuardarCambios.Enabled = true;
            }
        }

        private void IUAlumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            if(btnGuardarCambios.Enabled)
            {
                dr = MessageBox.Show(
                "   ¿Deseas guardar los cambios antes de salir?.\n\n \t Si contestas NO se perderán los cambios",
                "¡Cambios no guardados!",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                    LNyAD.ActualizarBD();
                // Si le hemos dado a Cancel, deshacemos el cierre
                else if (dr == DialogResult.Cancel)
                    e.Cancel = true; // <-- Esta sencilla instrucción deshace el cierre
            }
            else
            {
                dr = MessageBox.Show(
                "   ¿Confirmas que deseas salir?.",
                "Confirmar salida",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                // Si le hemos dado a Cancel, deshacemos el cierre
                if (dr == DialogResult.Cancel)
                    e.Cancel = true; // <-- Esta sencilla instrucción sehace el cierre
            }

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            LNyAD.ActualizarBD();
            dgv.ClearSelection();
            MessageBox.Show(
                "Las modificaciones se han guardado con éxito",
                "Base de datos actualizada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            btnGuardarCambios.Enabled = false;
        }

    }
}
