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
    public static  class LNyAD
    {
        // Construimos nuestro adaptador y nuestra tabla para cada tabla del DS
        static AlumnosTableAdapter alumnosAdapt = new AlumnosTableAdapter();
        static DataSet1.AlumnosDataTable alumnosTabla = new DataSet1.AlumnosDataTable();

        // filaDS Nos servirá para modificar y borrar
        static DataSet1.AlumnosRow filaDS = null;

        static GruposTableAdapter gruposAdapt;
        static DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        static int idAlumnoUltimo;
        public static List<Grupo> ListaGrupos()
        {
            List<Grupo> listaGrupos = new List<Grupo>();
            Grupo grupo;

            // Obtenemos la tabla de grupos
            gruposAdapt = new GruposTableAdapter();
            gruposTabla = gruposAdapt.GetData();

            //La recorro para construir la lista de Grupos
            foreach (DataSet1.GruposRow regGrupo in gruposTabla)
            {
                grupo = new Grupo(regGrupo.idGrupo, regGrupo.nombre);
                listaGrupos.Add(grupo);
            }

            return listaGrupos;
        }

        public static  DataSet1.AlumnosDataTable TablaAlumnos(int idGrupo)
        {
            bool sonTodos = (idGrupo == 0);

            if (sonTodos)
                alumnosTabla = alumnosAdapt.GetAlumnosConAliasGrupo();
            else
                alumnosTabla = alumnosAdapt.GetDataByIdGrupo(idGrupo);

            return alumnosTabla;
        }

        public static DataView VistaDeAlumnos()
        {
            // Cargamos la tabla completa
            alumnosTabla = alumnosAdapt.GetAlumnosConAliasGrupo();

            idAlumnoUltimo = alumnosTabla[alumnosTabla.Count - 1].idAlumno;
            // Devolvemos la vista asociada a ella
            return new DataView(alumnosTabla);
        }

        public static  void BorrarAlumno(int idAlumno)
        {
            filaDS = alumnosTabla.FindByidAlumno(idAlumno);

            filaDS.Delete();

//alumnosAdapt.Update(filaDS);  // <-- Actualizamos la BD
//alumnosTabla.AcceptChanges(); 
        }

        public static  Alumno GetAlumno(int idAlumno)
        {
            filaDS = alumnosTabla.FindByidAlumno(idAlumno);
            return new Alumno(filaDS);
        }

        public static  void AddAlumno(Alumno alum)
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

            // Para poder actualizar la columna del grupo
            filaDS.Grupo = gruposTabla.FindByidGrupo(alum.IdGrupo).alias;

            // Para que el DS no le asigne un valor negativo le ponemos el nuestro
            filaDS.idAlumno = ++idAlumnoUltimo;

            // Añadimos el registro al dataset
            alumnosTabla.AddAlumnosRow(filaDS);

            // Actualizamos la BD
//alumnosAdapt.Update(filaDS);  // <-- Actualizamos la BD
//alumnosTabla.AcceptChanges();
        }

        public static  void ModificaAlumno(Alumno alum)
        {
            // rellenamos el registro con los nuevos valores
            filaDS.idGrupo = alum.IdGrupo;
            filaDS.apellidosNombre = alum.ApellidosNombre;
            filaDS.telefono = alum.Telefono;
            filaDS.movil = alum.Movil;
            filaDS.dni = alum.Dni;
            filaDS.email = alum.Email;

            // Para poder actualizar la columna del grupo
            filaDS.Grupo = gruposTabla.FindByidGrupo(alum.IdGrupo).alias;


//alumnosAdapt.Update(filaDS);  // <-- Actualizamos la BD
//alumnosTabla.AcceptChanges();
        }

        public static void ActualizarBD()
        {
            alumnosAdapt.Update(alumnosTabla);  // <-- Actualizamos la BD
            alumnosTabla.AcceptChanges();
        }

        public static bool ExisteDNI(string dni)
        {
            return (alumnosAdapt.CompruebaDNI(dni) > 0);
        }
    }

}
