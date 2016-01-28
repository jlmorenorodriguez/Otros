using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquilar
{
    public partial class Listaalquiler : Form
    {

        List<Producto> lista_productos = new List<Producto>();

        public Listaalquiler()
        {
            InitializeComponent();
            lista_productos = Producto.rellenarlista();
            Producto_scrollbar.Maximum = lista_productos.Count() - 1;
        }

        private void muestraproducto_Scroll(object sender, ScrollEventArgs e)
        {
                id_textbox.Text = Convert.ToString(Convert.ToString(lista_productos[Producto_scrollbar.Value].Id));
                nombre_textbox.Text = (lista_productos[Producto_scrollbar.Value].Nombre);
                genero_textbox.Text = (lista_productos[Producto_scrollbar.Value].Genero);
                descripcion_textbox.Text = lista_productos[Producto_scrollbar.Value].Descripcion;
                if (lista_productos[Producto_scrollbar.Value].Estado_alquiler == true) {

                    alquiler_textbox.Text = "SÍ";
                }
                else
                {
                    if (Producto_scrollbar.Value == 0)
                    {
                        alquiler_textbox.Text = "";
                    }
                    else
                    {
                        alquiler_textbox.Text = "NO";
                    }
                    }
            
            


                   
                      
        }

      

       
    }
}
