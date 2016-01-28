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
using System.Text.RegularExpressions;

namespace InterfazUsuario
{
    public partial class IUDetalleAlumno : Form
    {
        bool esNuevo;
        Alumno alum = new Alumno();
        string dniActual;
        public IUDetalleAlumno()
        {
            InitializeComponent();
        }

        public int IdAlumno { get; set; }

        private void IUDetalleAlumno_Load(object sender, EventArgs e)
        {
            esNuevo = (IdAlumno < 0);

            if (esNuevo)
            {
                //--- Limpiamos los controles de panelDetalle
                txbApellNom.Clear(); // en atención a Carlos Yera
                txbDni.Clear();
                txbIndice.Clear();
                txbMail.Clear();
                txbMovil.Clear();
                txbTelefono.Clear();
                cbGruposDetalle.SelectedIndex = -1; // Para que no tome ninguno de los seleccionables
                cbGruposDetalle.Text = "Selecciona un Grupo";
            }
            else
            {
                
                alum = LNyAD.GetAlumno(IdAlumno);
                //--- Actualizamos los controles del panelDetalle con los campos de dicho registro
                txbIndice.Text = alum.IdAlumno.ToString();
                cbGruposDetalle.SelectedValue = alum.IdGrupo;// <-- seleccionamos el valor del combo
                txbApellNom.Text = alum.ApellidosNombre;
                txbTelefono.Text = alum.Telefono;
                txbMovil.Text = alum.Movil;
                txbDni.Text = alum.Dni;
                txbMail.Text = alum.Email;
                txbIndice.Visible = true; // <-- Se verá el índice

                dniActual = alum.Dni;
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Si hay error en los datos Me salgo
            if (HayErrorEnDatos())
                return;

            // Actualizo los valores del alumno
            alum.IdGrupo = Convert.ToInt32(cbGruposDetalle.SelectedValue);// <-- seleccionamos el valor del combo
            alum.ApellidosNombre = txbApellNom.Text;
            alum.Telefono = txbTelefono.Text;
            alum.Movil = txbMovil.Text;
            alum.Dni = txbDni.Text;
            alum.Email = txbMail.Text;

            // Y lo guardo dependiendo de si estoy añadiendo o Modeificando
            if (esNuevo)
                LNyAD.AddAlumno(alum);
            else
                LNyAD.ModificaAlumno(alum);

            this.DialogResult = DialogResult.OK;
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
          
            #endregion

            #region Validar DNI (El formato del DNI debe ser XXXXXXXX-letraMayúscula y no debe repetirse)
            string dni = txbDni.Text;
            if (dni.Length != 10 || !Int32.TryParse(dni.Substring(0, 8), out valorInt) || dni.IndexOf('-') != 8 || dni[9] < 'A' || dni[9] > 'Z')
            {
                mensajeErrores += "El formato del DNI debe ser 8cifras-letraMayúscula\n";
                errorProvider.SetError(txbDni, "Formato incorrecto");
                hayError = true;
            }

            // Comprobamos que no esté repetido (pertenciente a OTRO alumno)
            if (dniActual != dni && LNyAD.ExisteDNI(dni))
            {
                mensajeErrores += "El formato del DNI Ya Existe";
                errorProvider.SetError(txbDni, "DNI ya existe en la BD");
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
