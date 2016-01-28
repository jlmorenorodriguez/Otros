using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            
            
        
            /* Accelerations*/
           InitializeAcceleratedUpDown();
           
            

            
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos del Alumno: " + "\nNombre: " + textBox1.Text + "\nSemestre: " + nUd3.Value + "\nPromedio: " + nUd2.Value + "\nEdad: " + nUd1.Value);
        }
    
        
        
        //Acelerations
        private void InitializeAcceleratedUpDown()
        {


            nUd2.Maximum = 400000;
            nUd2.Minimum = -400000;

            /* Añadir aceleradores al control*/
            
            //si lo dejas 2 segundos presionado, incrementa de 100 en 100.
            nUd2.Accelerations.Add(new NumericUpDownAcceleration(2, 100));
            //si lo dejas 5 segundos persionado, incrementa de 1.000 en 1.000.
            nUd2.Accelerations.Add(new NumericUpDownAcceleration(5, 1000));
            //si lo dejas 8 segundos presionado, incrementa de 5.000 en 5.000.
            nUd2.Accelerations.Add(new NumericUpDownAcceleration(8, 5000));

            
        }


        //DecimalPlaces
       private void chbDecimales_Click(object sender, EventArgs e)
        {
/* Si DecimalPlaces es mayor que 0 , que lo ajuste a 0 y redondeé el
valor actual; de lo contrario ,que establezca DecimalPlaces a 2 y que cambie el
 Increment a 0,25 . */
            if (nUd1.DecimalPlaces > 0)
            {
                nUd1.DecimalPlaces = 0;
                nUd1.Value = Decimal.Round(nUd1.Value, 0);
                nUd1.Increment = 1;
                chbDecimales.Text = "Decimales";
                
            }
            else
            {
                nUd1.DecimalPlaces = 2;
                nUd1.Increment = 0.25M;
                chbDecimales.Text = "Redondear";
            }
       }

        //Hexadecimal  
         private void chbHexadecimales_Click(object sender, EventArgs e)
        {
          /* Si Hexadecimal es true, ponlo false; 
     si no, ponlo true. */
            if (nUd3.Hexadecimal)
            {
                nUd3.Hexadecimal = false;
            }
            else
            {
                nUd3.Hexadecimal = true;
            }
        }

        

        //ThousandSeparator
         private void chkThousand_Click(object sender, EventArgs e)
         {
             /*Si ThousandsSeparator está true, ponlo false; 
      si no, ponlo true. */
             if (nUd2.ThousandsSeparator)
             {
                 nUd2.ThousandsSeparator = false;
             }
             else
             {
                 nUd2.ThousandsSeparator = true;
             }
         }

      
        //UpButton
         private void btnIncrementar_Click(object sender, EventArgs e)
         {
             nUd1.UpButton();
             nUd2.UpButton();
             nUd3.UpButton();
         }

        //DownButton
         private void btnDecrementar_Click(object sender, EventArgs e)
         {
             nUd1.DownButton();
             nUd2.DownButton();
             nUd3.DownButton();
         }

      
       
        

     
    }
        


        
        }

      
       
    


