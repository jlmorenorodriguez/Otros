using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_ColorDialog_FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            switch(lbModoAplique.Text)
            {
                case "SELECCIÓN":
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        rtbDocumento.SelectionColor = colorDialog.Color;
                        rtbTitulo.SelectionColor = colorDialog.Color;
                    }
                    break;

                case "TODO":
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        rtbDocumento.ForeColor = colorDialog.Color;
                        rtbTitulo.ForeColor = colorDialog.Color;
                    }
                    break;       
            }
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            switch (lbModoAplique.Text)
            {
                case "SELECCIÓN":
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                    {
                        //pruebas
                        ;

                        rtbDocumento.SelectionFont = fontDialog.Font;
                        rtbTitulo.SelectionFont = fontDialog.Font;
                    }
                    break;

                case "TODO":
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                    {
                        rtbDocumento.Font = fontDialog.Font;
                        rtbTitulo.Font = fontDialog.Font;
                    }
                    break;
            }           
        }

        private void btnEdtTitulo_Click(object sender, EventArgs e)
        {
            if (lbModoAplique.Text == "TODO")
                lbModoAplique.Text = "SELECCIÓN";
            else
                lbModoAplique.Text = "TODO";
        }

        private void colorDialog_HelpRequest(object sender, EventArgs e)
        {

        }

    }
}
