//Alumno:
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Elipses
{
    public partial class FormDibujo : Form
    {
        // Yo usé estas constantes y variables globales. Borra las que no te interesen (o todas)
        const int XYMAX = 450, LONMAX = 450, ANGUMAX = 180;

        int cX = 100, cY = 100, ejeX = 100, ejeY = 100;
        float grosor = 2;
        Color color = Color.FromArgb(0, 0, 0);
        bool okX = true, okY = true, okejeX = true;
        Graphics pizarra;

        DSElipses.ElipsesRow filaDS = null;
        FormDatos formElipses = new FormDatos();
        public FormDibujo()
        {
            InitializeComponent();
            float num = 0.5f;
            while (num < 5f)
            {
                num += 0.5f;
                cbGrosor.Items.Add(num);
            }
            cbGrosor.SelectedItem = 2.5f;
        }

        private void btnMostrarBD_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == formElipses.ShowDialog())
            {
                filaDS = formElipses.FilaDS;
                txbNombre.Text = filaDS.nombre;
                tracX.Value = Convert.ToInt32(filaDS.Xcentro);
                txbX.Text = tracX.Value.ToString();
                tracY.Value = Convert.ToInt32(filaDS.Ycentro);
                txbY.Text = tracY.Value.ToString();
                tracEjeX.Value = Convert.ToInt32(filaDS.ejeX);
                txbLong.Text = tracEjeX.Value.ToString();
                nudEjeY.Value = Convert.ToInt32(filaDS.ejeY);
                cbGrosor.Text = " " + (0.1 * (double)Convert.ToInt32(filaDS.Grosor)).ToString();
                color = Color.FromArgb(Convert.ToInt32(filaDS.ColorR), Convert.ToInt32(filaDS.ColorG), Convert.ToInt32(filaDS.ColorB));
                lbColor.BackColor = color;
                rbElipse.Checked = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (CompruebaActualiza())
            {
                string text = txbNombre.Text.Trim();
                if (text.Length < 1)
                {
                    MessageBox.Show("Debes asignarle un nombre a esta configuración", "Error en los Datos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    filaDS = formElipses.BuscaPorNombre(text);
                    if (filaDS == null)
                    {
                        filaDS = formElipses.FilaVacia;
                        filaDS.nombre = txbNombre.Text;
                        filaDS.Xcentro = tracX.Value;
                        filaDS.Ycentro = tracY.Value;
                        filaDS.ejeX = tracEjeX.Value;
                        filaDS.ejeY = (int)nudEjeY.Value;
                        filaDS.Grosor = Convert.ToInt32(10f * grosor);
                        filaDS.ColorR = (int)color.R;
                        filaDS.ColorG = (int)color.G;
                        filaDS.ColorB = (int)color.B;
                        try
                        {
                            formElipses.AddRegistro(filaDS);
                            MessageBox.Show("Configuración guardada con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch
                        {
                            MessageBox.Show("Error al guardar la configuración", "Error en los Datos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else if (DialogResult.Yes == MessageBox.Show("Ya existe una figura con este nombre\n ¿Quieres sobreescribirla?", "Ya existe esta figura", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    {
                        filaDS.Xcentro = tracX.Value;
                        filaDS.Ycentro = tracY.Value;
                        filaDS.ejeX = tracEjeX.Value;
                        filaDS.ejeY = (int)nudEjeY.Value;
                        filaDS.Grosor = Convert.ToInt32(10f * grosor);
                        filaDS.ColorR = (int)color.R;
                        filaDS.ColorG = (int)color.G;
                        filaDS.ColorB = (int)color.B;
                        try
                        {
                            formElipses.ModificaRegistro(filaDS);
                            MessageBox.Show("Se han realizado los cambios con éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch
                        {
                            MessageBox.Show("Error al guardar la configuración", "Error en los Datos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
            }
        }
        private bool CompruebaActualiza()
        {
            bool result;
            if (!okX || !okY || !okejeX)
            {
                MessageBox.Show("Las coordenadas o longitud no son coherentes con sus cursores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                result = false;
            }
            else
            {
                color = lbColor.BackColor;
                grosor = (float)Convert.ToDouble(cbGrosor.Text);
                ejeX = Convert.ToInt32(txbLong.Text);
                ejeY = Convert.ToInt32(nudEjeY.Value);
                cX = Convert.ToInt32(txbX.Text);
                cY = Convert.ToInt32(txbY.Text);
                result = true;
            }
            return result;
        }

        private void lbColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            color = colorDialog.Color;
        }

        private void txbX_TextChanged(object sender, EventArgs e)
        {
            okX = (txbX.Text == tracX.Value.ToString());
            if (okX)
            {
                txbX.BackColor = Color.FromArgb(192, 0, 0);
            }
            else
            {
                txbX.BackColor = Color.FromArgb(255, 192, 128);
            }
        }

        private void txbY_TextChanged(object sender, EventArgs e)
        {
            okY = (txbY.Text == tracY.Value.ToString());
            if (okY)
            {
                txbY.BackColor = Color.FromArgb(192, 0, 0);
            }
            else
            {
                txbY.BackColor = Color.FromArgb(255, 192, 128);
            }
        }
    }
}
