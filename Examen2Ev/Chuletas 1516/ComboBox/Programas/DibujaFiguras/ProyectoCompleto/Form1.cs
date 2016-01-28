using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompleto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ResizeRedraw = true;
        }

        private void cbOpcionesDibujo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics grafico = base.CreateGraphics();
            Pen boli = new Pen(Color.Blue);

            Brush pincel = new SolidBrush(Color.Crimson);

            grafico.Clear(Color.White);

            switch (cbOpcionesDibujo.SelectedIndex)
            {
                case 0: //Circulo
                    grafico.DrawEllipse(boli, 50, 100, 150, 150);

                    break;

                case 1: // Cuadrado
                    grafico.DrawRectangle(boli, 50, 100, 150, 150);
                    break;
                
                case 2: // Elipse
                    grafico.DrawEllipse(boli, 50, 100, 150, 115);
                    break;

                case 3: // Cuña
                    grafico.DrawPie(boli, 50, 100, 140, 140, 0, 45);
                    break;
                case 4: // circulo relleno
                    grafico.FillEllipse(pincel, 50, 100, 150, 150);
                    break;
                case 5: // Cuadrado relleno
                    grafico.FillRectangle(pincel, 50, 100, 150, 150);
                    break;
                case 6: //Rellenar elipse
                    grafico.FillEllipse(pincel, 50, 100, 230, 140);
                    break;
                case 7: // Rellenar cuña
                    grafico.FillPie(pincel, 50, 100, 150, 150, 0, 45);
                    break;


            }


        }
    }
}
