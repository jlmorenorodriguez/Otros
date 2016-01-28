using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioyADatos
{
    // La estructura Grupo
    public struct Grupo
    {
        private int idGrupo;
        private string nombre;

        //-- El constructor
        public Grupo(int idGrupo, string nombre)
        {
            this.idGrupo = idGrupo;
            this.nombre = nombre;
        }

        //-- Las propiedades
        public int IDGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }

}
