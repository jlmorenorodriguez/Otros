using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exposicion_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creo el autocompletado con una tabla de nombres
            AutoCompleteStringCollection nombres = new AutoCompleteStringCollection();
            nombres.AddRange(new string[] { "Dani", "Pablo", "Manuel", "Miguel", "Jesus", "Julio", "Jose Luis", "Samuel", "Alvaro", "Mancilla", "Quini", "Jorge", "David", "Piniella", "Jaime", "Juan" });
            // Cambio las propiedades del text box necesarias para poder usar el autocompletado
             tb1.AutoCompleteCustomSource = nombres;
             tb1.AutoCompleteMode =AutoCompleteMode.SuggestAppend;
             tb1.AutoCompleteSource = AutoCompleteSource.CustomSource;

             tb2.PasswordChar = '*';
             tb2.TextAlign = HorizontalAlignment.Center;

             tb3.CharacterCasing = CharacterCasing.Upper;
             tb3.Multiline = true;
             tb3.ScrollBars = ScrollBars.Both;

             tb3.Paste("Hola");
             txtEvento.Text ="TextAlignChanged";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbPaste2.Paste(txbPaste.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEvento.TextAlign = HorizontalAlignment.Right;
        }

        private void txtEvento_TextAlignChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ahora estas usando el evento TextAlignChanged");
        }
    }
}
