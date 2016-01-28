using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambiaFuentes
{
    public partial class Cambiafuentes : Form
    {

        

        public Cambiafuentes()
        {
            InitializeComponent();
        }

        private void fuente_Scroll(object sender, EventArgs e)
        {
            int valor_fuente = ((TrackBar)sender).Value;
            switch (valor_fuente)
            {
                case 0:
                    {

                       
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        
                        break;
                    }
                case 1:
                    {
                        frase.Font = new Font("Colibri", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 2:
                    {
                        frase.Font = new Font("Times New Roman", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 3:
                    {
                        frase.Font = new Font("Tahoma", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 4:
                    {
                        frase.Font = new Font("Comic Sans", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 5:
                    {
                        frase.Font = new Font("Arial", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 6:
                    {
                        frase.Font = new Font("Verdana", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 7:
                    {
                        frase.Font = new Font("Yu Mincho", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 8:
                    {
                        frase.Font = new Font("Enconding", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 9:
                    {
                        frase.Font = new Font("Segoe Script", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }



            }
        }

        private void tamanyo_Scroll(object sender, EventArgs e)
        {
            int valor_fuente = ((TrackBar)sender).Value;
            switch (valor_fuente)
            {
                case 12:
                    {
                        frase.Font = new Font("Courier New",tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 13:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 14:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 15:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                case 16:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                     case 17:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                        case 18:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                         case 19:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                         case 20:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                         case 21:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                         case 22:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;

                    }
                         case 23:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                         case 24:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
                         case 25:
                    {
                        frase.Font = new Font("Courier New", tamanyo_trackBar.Value, FontStyle.Bold);
                        break;
                    }
            }
        }
    }
}