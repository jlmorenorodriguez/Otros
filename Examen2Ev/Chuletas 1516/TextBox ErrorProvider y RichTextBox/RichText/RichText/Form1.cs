using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editor.Clear();
        }

        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {            
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            Open.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir Archivo";
            Open.ShowDialog(this);
            try
            {                
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                editor.Text = myStreamReader.ReadToEnd();

            }
            catch (Exception) { }
        }

        private void guardarComoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|All files(*.*)|*.*";
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog(this);
            try
            {
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(editor.Text);
                myStreamWriter.Flush();

            }
            catch (Exception) { }

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void atrasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editor.Undo();
        }

        private void adelanteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editor.Redo();
        }

        private void copiarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editor.Copy();
        }

        private void pegarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editor.Paste();
        }

        private void cortarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editor.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editor.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            editor.Clear();
        }

        private void fuenteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = editor.Font;
            if (font.ShowDialog() == DialogResult.OK)
            {
                editor.Font = font.Font;
            }
        }

        private void colorDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                editor.ForeColor = color.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
             ColorDialog fondo = new ColorDialog();
             if (fondo.ShowDialog() == DialogResult.OK)
            {
                editor.BackColor = fondo.Color;
            }
        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editor.SelectionFont != null)
            {
                System.Drawing.Font currentFont = editor.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                newFontStyle = FontStyle.Regular;


                editor.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editor.SelectionFont != null)
            {
                System.Drawing.Font currentFont = editor.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                newFontStyle = FontStyle.Bold;


                editor.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

      
    }
}
