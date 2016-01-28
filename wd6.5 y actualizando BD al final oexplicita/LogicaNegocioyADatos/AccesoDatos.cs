using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
// Usamos el namespace System.Data.OleDb para usar BD´s Access
using System.Data.OleDb;
using LogicaNegocioyADatos.DataSet1TableAdapters;

namespace LogicaNegocioyADatos
{
    class AccesoDatos
    {
        // Construimos nuestro adaptador y nuestra tabla para cada tabla del DS
        AlumnosTableAdapter alumnosAdapt = new AlumnosTableAdapter();
        DataSet1.AlumnosDataTable alumnosTabla = new DataSet1.AlumnosDataTable();

        // filaDS Nos servirá para modificar y borrar
        DataSet1.AlumnosRow filaDS = null;

        GruposTableAdapter gruposAdapt;

        internal List<Grupo> ListaGrupos()
        {
            List<Grupo> listaGrupos = new List<Grupo>();
            Grupo grupo;

            // Obtenemos la tabla de grupos
            gruposAdapt = new GruposTableAdapter();
            DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();
            gruposTabla = gruposAdapt.GetData();

            //La recorro para construir la lista de Grupos
            foreach (DataSet1.GruposRow regGrupo in gruposTabla)
            {
                grupo = new Grupo(regGrupo.idGrupo, regGrupo.nombre);
                listaGrupos.Add(grupo);
            }

            return listaGrupos;
        }

        internal DataSet1.AlumnosDataTable TablaAlumnos(int idGrupo)
        {
            bool sonTodos = (idGrupo == 0);

            if (sonTodos)
                alumnosTabla = alumnosAdapt.GetAlumnosConAliasGrupo();
            else
                alumnosTabla = alumnosAdapt.GetDataByIdGrupo(idGrupo);

            return alumnosTabla;
        }

        internal void BorrarAlumno(int idAlumno)
        {
            filaDS = alumnosTabla.FindByidAlumno(idAlumno);

            filaDS.Delete();

            alumnosAdapt.Update(filaDS);  // <-- Actualizamos la BD
            alumnosTabla.AcceptChanges(); 
        }

        internal Alumno GetAlumno(int idAlumno)
        {
            filaDS = alumnosTabla.FindByidAlumno(idAlumno);
            return new Alumno(filaDS);
        }

        internal void AddAlumno(Alumno alum)
        {
            // Obtenemos un registro vacío, del mismo tipo que los registros de la tabla
            filaDS = alumnosTabla.NewAlumnosRow();

            // rellenamos el registro
            filaDS.idGrupo = alum.IdGrupo;
            filaDS.apellidosNombre = alum.ApellidosNombre;
            filaDS.telefono = alum.Telefono;
            filaDS.movil = alum.Movil;
            filaDS.dni = alum.Dni;
            filaDS.email = alum.Email;

            // Añadimos el registro al dataset
            alumnosTabla.AddAlumnosRow(filaDS);

            // Actualizamos la BD
            alumnosAdapt.Update(filaDS);  // <-- Actualizamos la BD
            alumnosTabla.AcceptChanges();
        }

        internal void ModificaAlumno(Alumno alum)
        {
            // rellenamos el registro con los nuevos valores
            filaDS.idGrupo = alum.IdGrupo;
            filaDS.apellidosNombre = alum.ApellidosNombre;
            filaDS.telefono = alum.Telefono;
            filaDS.movil = alum.Movil;
            filaDS.dni = alum.Dni;
            filaDS.email = alum.Email;

            // Actualizamos la BD
            alumnosAdapt.Update(filaDS);  // <-- Actualizamos la BD
            alumnosTabla.AcceptChanges();
        }
    }
}
