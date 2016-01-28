namespace CambiaFuentes
{
    partial class Cambiafuentes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.frase = new System.Windows.Forms.Label();
            this.tamanyo_trackBar = new System.Windows.Forms.TrackBar();
            this.fuente_trackBar = new System.Windows.Forms.TrackBar();
            this.fuente = new System.Windows.Forms.Label();
            this.tamanyo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tamanyo_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuente_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tamanyo_trackBar);
            this.panel1.Controls.Add(this.fuente_trackBar);
            this.panel1.Controls.Add(this.fuente);
            this.panel1.Controls.Add(this.tamanyo);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 283);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.frase);
            this.panel2.Location = new System.Drawing.Point(13, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 150);
            this.panel2.TabIndex = 5;
            // 
            // frase
            // 
            this.frase.AutoSize = true;
            this.frase.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frase.Location = new System.Drawing.Point(49, 63);
            this.frase.Name = "frase";
            this.frase.Size = new System.Drawing.Size(324, 22);
            this.frase.TabIndex = 2;
            this.frase.Text = "Ejemplo sobre el uso de TrackBar";
            // 
            // tamanyo_trackBar
            // 
            this.tamanyo_trackBar.AllowDrop = true;
            this.tamanyo_trackBar.Location = new System.Drawing.Point(439, 61);
            this.tamanyo_trackBar.Maximum = 34;
            this.tamanyo_trackBar.Minimum = 12;
            this.tamanyo_trackBar.Name = "tamanyo_trackBar";
            this.tamanyo_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tamanyo_trackBar.Size = new System.Drawing.Size(45, 172);
            this.tamanyo_trackBar.SmallChange = 5;
            this.tamanyo_trackBar.TabIndex = 4;
            this.tamanyo_trackBar.TickFrequency = 2;
            this.tamanyo_trackBar.Value = 12;
            this.tamanyo_trackBar.Scroll += new System.EventHandler(this.tamanyo_Scroll);
            // 
            // fuente_trackBar
            // 
            this.fuente_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fuente_trackBar.LargeChange = 1;
            this.fuente_trackBar.Location = new System.Drawing.Point(77, 205);
            this.fuente_trackBar.Maximum = 9;
            this.fuente_trackBar.Name = "fuente_trackBar";
            this.fuente_trackBar.Size = new System.Drawing.Size(356, 45);
            this.fuente_trackBar.TabIndex = 3;
            this.fuente_trackBar.Value = 5;
            this.fuente_trackBar.Scroll += new System.EventHandler(this.fuente_Scroll);
            // 
            // fuente
            // 
            this.fuente.AutoSize = true;
            this.fuente.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuente.Location = new System.Drawing.Point(12, 214);
            this.fuente.Name = "fuente";
            this.fuente.Size = new System.Drawing.Size(59, 19);
            this.fuente.TabIndex = 1;
            this.fuente.Text = "Fuente";
            // 
            // tamanyo
            // 
            this.tamanyo.AutoSize = true;
            this.tamanyo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanyo.Location = new System.Drawing.Point(416, 39);
            this.tamanyo.Name = "tamanyo";
            this.tamanyo.Size = new System.Drawing.Size(68, 19);
            this.tamanyo.TabIndex = 0;
            this.tamanyo.Text = "Tamaño";
            // 
            // Cambiafuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(570, 279);
            this.Controls.Add(this.panel1);
            this.Name = "Cambiafuentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Fuentes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tamanyo_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuente_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tamanyo_trackBar;
        private System.Windows.Forms.TrackBar fuente_trackBar;
        private System.Windows.Forms.Label frase;
        private System.Windows.Forms.Label fuente;
        private System.Windows.Forms.Label tamanyo;
        private System.Windows.Forms.Panel panel2;
    }
}

