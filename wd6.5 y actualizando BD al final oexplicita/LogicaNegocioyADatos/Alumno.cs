using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioyADatos
{
    public class Alumno
    {
        int idAlumno, idGrupo;
        string apellidosNombre, telefono, movil, dni, email;

        public Alumno(DataSet1.AlumnosRow filaDS)
        {
            idAlumno = filaDS.idAlumno;
            idGrupo = filaDS.idGrupo;// <-- seleccionamos el valor del combo
            apellidosNombre = filaDS.apellidosNombre;
            telefono = filaDS.telefono;
            movil = filaDS.movil;
            dni = filaDS.dni;
            email = filaDS.email;
        }

        // Este constroctor nos hará falta Para introducir nuevo alumno
        public Alumno()
        {
        }

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }
        public int IdGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }
        public string ApellidosNombre
        {
            get { return apellidosNombre; }
            set { apellidosNombre = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Movil
        {
            get { return movil; }
            set { movil = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
