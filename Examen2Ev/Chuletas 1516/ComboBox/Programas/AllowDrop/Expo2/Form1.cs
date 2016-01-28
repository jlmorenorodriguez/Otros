using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void comboBox2_DragDrop(object sender, DragEventArgs e)
        {
           string [] archivos = (string []) e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string archivo in archivos)
                comboBox2.Items.Add(archivo);
            
        }
    }
}
