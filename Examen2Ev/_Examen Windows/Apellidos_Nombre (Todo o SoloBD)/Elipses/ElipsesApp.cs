//Alumno:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Elipses
{
    static class ElipsesApp
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDibujo());
        }
    }
}
