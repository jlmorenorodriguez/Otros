using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Usamos el namespace System.Data.OleDb para usar BD´s Access
using System.Data.OleDb;
using wd4_ADOconDStipado.DSTableAdapters;

namespace wd4_ADOconDStipado
{
    public partial class FormAlumnos : Form
    {
        AlumnosTableAdapter adaptadorAlumnos = new AlumnosTableAdapter();
        DataSet.AlumnosDataTable tablaAlumnos = new DataSet.AlumnosDataTable();
        DataSet.AlumnosRow filaDS = null;

        // Creamos el FormDetalles una sola vez:
        FormAlumnoDetalle formDetalles = new FormAlumnoDetalle();

        bool comenzando = true;

        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            // Cargamos el ComboBox:
            CargaCombos();

            // Lo ponemos a false porque ya ha cargado los Combo una vez:
            comenzando = false;

            CargaAlumnosGrupo();

            // Ocultar columnas innecesarias:
            dgv.Columns["idAlumno"].Visible = false;
            dgv.Columns["idGrupo"].Visible = false;
        }

        private void CargaCombos()
        {
            List<Grupo> listaGrupos = new List<Grupo>();
            List<Grupo> listaTodos = new List<Grupo>();
            Grupo grupo;

            GruposTableAdapter adaptadorGrupos = new GruposTableAdapter();
            DataSet.GruposDataTable tablaGrupos = new DataSet.GruposDataTable();

            // Cargamos en la tabla de Grupos los grupos de la BD:
            tablaGrupos = adaptadorGrupos.GetData();

            // Le añadimos a la lista todos los grupos:
            listaTodos.Add(new Grupo(0, "Todos los Grupos"));

            foreach (DataSet.GruposRow filaDSGrupo in tablaGrupos)
            {
                // Creamos el grupo y lo añadimos a las listas:
                grupo = new Grupo(filaDSGrupo.idGrupo, filaDSGrupo.nombre);
                listaGrupos.Add(grupo);
                listaTodos.Add(grupo);
            }

            // Enlazamos la lista de Todos los Grupos al combo de FormAlumnos:
            cbGrupos.DataSource = listaTodos;
            cbGrupos.ValueMember = "IDGrupo";
            cbGrupos.DisplayMember = "Nombre";

            // Enlace de la lista de Grupos al combo de FormDetalles:
            formDetalles.cbGruposDetalle.DataSource = listaGrupos;
            formDetalles.cbGruposDetalle.ValueMember = "IdGrupo";
            formDetalles.cbGruposDetalle.DisplayMember = "Nombre";
        }

        private void CargaAlumnosGrupo()
        {
            // Cogemos el Id del elemento seleccionado en el ComboBox:
            int idGrupo = Convert.ToInt32(cbGrupos.SelectedValue);
            bool sonTodos = (idGrupo == 0);  // <-- Cuando el idGrupo de Todos los Grupos es el 0, devuelve true

            dgv.ClearSelection();

            if (sonTodos)
                tablaAlumnos = adaptadorAlumnos.GetAlumnosConAliasGrupo();

            else
                tablaAlumnos = adaptadorAlumnos.GetDataByIdGrupo(idGrupo);

            // Cargamos el DGV con la tabla de Alumnos:
            dgv.DataSource = tablaAlumnos;

            // Cuando son Todos los Alumnos (true), la columna Grupos esta visible:
            dgv.Columns["Grupo"].Visible = sonTodos;

            // Actualizamos el label que muestra el grupo de los alumnos seleccionado:
            lbCabecera.Text = String.Format("Alumnos de {0}.  {1} alumnos", cbGrupos.Text, dgv.Rows.Count);
        }
        
        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si ha pasado ya por el Load:
            if (comenzando)
                return;

            CargaAlumnosGrupo();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columna = e.ColumnIndex;

            if (columna == 0)
                EditarRegistro();

            else if (columna == 1)
                BorrarRegistro();
        }

        private void BorrarRegistro()
        {
            string mensajeBorrar = "¿Desea borrar al alumno " + dgv.SelectedRows[0].Cells["apellidosNombre"].Value.ToString() + "?";

            // Si se selecciona que NO en el mensaje, se sale:
            if (DialogResult.No == MessageBox.Show(mensajeBorrar, "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;

            // Si pulsa SI, buscamos el Id del Alumno y lo borramos:
            int idAlumno = Convert.ToInt32(dgv.SelectedRows[0].Cells["idAlumno"].Value);
            filaDS = tablaAlumnos.FindByidAlumno(idAlumno);
            filaDS.Delete();

            ActualizarBD();
        }

        private void EditarRegistro()
        {
            // Cogemos el Id del Alumno y lo añadimos a la filaDS:
            int idAlumno = Convert.ToInt32(dgv.SelectedRows[0].Cells["idAlumno"].Value);
            filaDS = tablaAlumnos.FindByidAlumno(idAlumno);

            // Le rellenamos el FilaDS con el alumno elegido y le decimos que no es nuevo:
            formDetalles.FilaDS = filaDS;
            formDetalles.EsNuevo = false;

            // Mostramos el Formulario de Detalles y esperamos la respuesta:
            if (DialogResult.OK == formDetalles.ShowDialog())
                ActualizarBD(); 
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            // Creamos una filaDS vacia:
            filaDS = tablaAlumnos.NewAlumnosRow();

            // Le rellenamos el FilaDS con el alumno elegido y le decimos que es nuevo:
            formDetalles.FilaDS = filaDS;
            formDetalles.EsNuevo = true;

            if (DialogResult.OK == formDetalles.ShowDialog())
            {
                // Creamos una fila nueva en la tabla y guardamos la filaDS con los datos introducidos:
                tablaAlumnos.AddAlumnosRow(filaDS);
                dgv.ClearSelection();

                ActualizarBD();
            }
        }

        void ActualizarBD()
        {
            // Actualizamos el Adaptador con la tabla:
            adaptadorAlumnos.Update(tablaAlumnos);
            tablaAlumnos.AcceptChanges();

            // Cargamos otra vez los Alumnos:
            CargaAlumnosGrupo();
        }
    }
}
