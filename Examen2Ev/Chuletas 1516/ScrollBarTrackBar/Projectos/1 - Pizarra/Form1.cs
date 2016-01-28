using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBar
{
    public partial class Pizarra : Form
    {
        public Pizarra()
        {
            InitializeComponent();
            
            // Podeis observar que el valor de las propiedades tambien pueden ser dadas a través de linea de código.
            scroll_alpha.Value = 255;
            
            // Coloca el control al principio del orden Z
            // scroll_alpha.BringToFront();
            // Envia el control al final del orden Z
            //scroll_blue.SendToBack();
          
            
          

        }
        private void CambiaColor(object sender, ScrollEventArgs e)
        {
            

            

            // Primero pongo el texto del label llamado poscolor, con los valores de cada Scroll
            poscolor.Text = 
                "[ Rojo = " + scroll_red.Value +
                " | Azul = " + scroll_blue.Value +
                " | Verde = " + scroll_green.Value +
                " |Alpha = " + scroll_alpha.Value + " ]";
            // Luego, si los valores han cambiado, cambio el color del panel asi como del poscolor.
            panel.BackColor = Color.FromArgb(scroll_alpha.Value,scroll_red.Value,scroll_green.Value,scroll_blue.Value);
            poscolor.ForeColor = Color.FromArgb(scroll_red.Value, scroll_green.Value, scroll_blue.Value);
        }
    }
}
