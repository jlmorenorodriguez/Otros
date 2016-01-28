using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions; // Para la validación con expresiones regulares

namespace wd4_ADOconDStipado
{
    public partial class FormAlumnoDetalle : Form
    {
        DataSet.AlumnosRow filaDS;
        bool esNuevo = false;

        public DataSet.AlumnosRow FilaDS
        {
            get { return filaDS; }
            set { filaDS = value; }
        }

        public bool EsNuevo
        {
            get { return esNuevo; }
            set { esNuevo = value; }
        }

        public FormAlumnoDetalle()
        {
            InitializeComponent();
        }

        private void FormAlumnoDetalle_Load(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                // Si estamos Añadiendo, limpiamos todo:
                txbApellNom.Clear(); 
                txbDni.Clear();
                txbIndice.Clear();
                txbMail.Clear();
                txbMovil.Clear();
                txbTelefono.Clear();

                cbGruposDetalle.SelectedIndex = -1;  // Para que no tome ninguno de los seleccionables
                cbGruposDetalle.Text = "Selecciona un Grupo";
            }

            else
            {
                // Si estamos Editando, mostramos el formulario con los datos recibidos:
                txbIndice.Text = filaDS.idAlumno.ToString();
                cbGruposDetalle.SelectedValue = filaDS.idGrupo;  // <-- Seleccionamos el valor del combo
                txbApellNom.Text = filaDS.apellidosNombre;
                txbTelefono.Text = filaDS.telefono;
                txbMovil.Text = filaDS.movil;
                txbDni.Text = filaDS.dni;
                txbMail.Text = filaDS.email;

                txbIndice.Visible = true; // <-- Se verá el TextBox del índice
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Si hay error en los datos, no hacemos nada:
            if (HayErrorEnDatos())
                return;

            // Rellenamos el filaDS con los campos:
            filaDS.idGrupo = Convert.ToInt32(cbGruposDetalle.SelectedValue);
            filaDS.apellidosNombre = txbApellNom.Text;
            filaDS.telefono = txbTelefono.Text;
            filaDS.movil = txbMovil.Text;
            filaDS.dni = txbDni.Text;
            filaDS.email = txbMail.Text;

            // Devolvemos los datos al Aceptar:
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #region Validación de Datos del Panel panelDetalle
        private bool HayErrorEnDatos()
        {
            bool hayError = false;
            string mensajeErrores = String.Empty;
            int valorInt;
            // Limpio los errorProviders para que aparezcan de nuevo sólo los incorrectos
            errorProvider.Clear();

            #region Validar Nombre (no puede estar vacío)
            String validaApellidos = @"^[A-ZÑÁÉÍÓÚ]{1}[a-zñáéíóú]+( [A-ZÑÁÉÍÓÚ]{1}[a-zñáéíóú]+)*$";
            String validaNombre = @"^[A-ZÑÁÉÍÓÚ]{1}[a-zñáéíóú.]+( [A-ZÑÁÉÍÓÚ]{1}[a-zñáéíóú.]+)*$";

            //String ValTelefono = @"^[0-9]{9}$";
            //String valDNI = @"^[0-9]{8}-[A-Z]{1}$";
            //String ValEmail = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            String[] tabApellidosNombre;

            //Comprobacion del campo Apellidos,Nombre
            if (txbApellNom.Text.Length <= 0)
            {
                hayError = true;
                mensajeErrores += "El campo Apellidos, Nombre no puede estar vacio\n";
                errorProvider.SetError(txbApellNom, "Debe introducir sus Apellidos, Nombre");
            }
            //else  // comprobación de Apellidos, Nombre
            //{
            //    tabApellidosNombre = txbApellNom.Text.Split(',');

            //    if (tabApellidosNombre.Count() != 2)
            //    {
            //        hayError = true;
            //        mensajeErrores += " Formato campo Apellidos, Nombre incorrecto (Apellido1 Apellido2, Nombre1 Nombre2)\n";
            //        errorProvider.SetError(txbApellNom, "Formato incorrecto");
            //    }
            //    else
            //    {
            //        //Valido los apellidos
            //        if (!Regex.IsMatch(tabApellidosNombre[0].Trim(), validaApellidos))
            //        {
            //            hayError = true;
            //            mensajeErrores += "Campo Apellidos, Nombre incorrecto\n";
            //            errorProvider.SetError(txbApellNom, "Formato Apellidos incorrecto");
            //            //pBoxApellidosNom.Show();
            //        }
            //        else if (!Regex.IsMatch(tabApellidosNombre[1].Trim(), validaNombre))
            //        {
            //            hayError = true;
            //            mensajeErrores += "Campo Apellidos, Nombre incorrecto\n";
            //            errorProvider.SetError(txbApellNom, "Formato Nombre incorrecto");
            //            //pBoxApellidosNom.Show();
            //        }
            //    }
            //}
            #endregion

            #region Validar DNI (El formato del DNI debe ser XXXXXXXX-letraMayúscula)
            string dni = txbDni.Text;
            if (dni.Length != 10 || !Int32.TryParse(dni.Substring(0, 8), out valorInt) || dni.IndexOf('-') != 8 || dni[9] < 'A' || dni[9] > 'Z')
            {
                mensajeErrores += "El formato del DNI debe ser 8cifras-letraMayúscula\n";
                errorProvider.SetError(txbDni, "Formato incorrecto");
                hayError = true;
            }
            #endregion

            #region Validar idGrupo (Debe tener uno seleccionado)
            if (cbGruposDetalle.SelectedIndex < 0)
            {
                mensajeErrores += "Debe seleccionar un grupo\n";
                errorProvider.SetError(cbGruposDetalle, "Seleccione un grupo");
                hayError = true;
            }
            #endregion

            #region Validar Teléfonos (debe haber al menos uno y correcto)

            if (txbTelefono.Text.Length == 0 && txbMovil.Text.Length == 0)
            {
                mensajeErrores += "Debe introducir al menos un teléfono\n";
                errorProvider.SetError(txbTelefono, "Debe introducir al menos un teléfono");
                errorProvider.SetError(txbMovil, "Debe introducir al menos un teléfono");
                hayError = true;
            } // Longitud del teléfono que hayas introducido
            else if ((txbTelefono.Text.Length > 0 && txbTelefono.Text.Length != 9) || (txbMovil.Text.Length > 0 && txbMovil.Text.Length != 9))
            {
                mensajeErrores += "Teléfonos: 9 cifras, el fijo comienza por 9 y el móvil por 6 o 7\n";
                hayError = true;
            }
            else if ((txbTelefono.Text.Length > 0 && txbTelefono.Text[0] != '9') || (txbMovil.Text.Length > 0 && txbMovil.Text[0] != '6' && txbMovil.Text[0] != '7'))
            {
                mensajeErrores += "Teléfonos: 9 cifras, el fijo comienza por 9 y el móvil por 6 o 7\n";
                hayError = true;
            }
            #endregion

            #region Validar e-mail (formato adecuado)
            if (!Regex.IsMatch(txbMail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                mensajeErrores += "El formato del e-mail no es correcto\n";
                errorProvider.SetError(txbMail, "Debe introducir un e-mail Correcto");
                hayError = true;
            }
            #endregion

            if (hayError)
                MessageBox.Show(mensajeErrores, "Error en los Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return hayError;
        }
        #endregion
    }
}
