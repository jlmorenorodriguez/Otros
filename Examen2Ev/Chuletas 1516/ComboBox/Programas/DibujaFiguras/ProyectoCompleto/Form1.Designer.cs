namespace ProyectoCompleto
{
    partial class Form1
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
            this.cbOpcionesDibujo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbOpcionesDibujo
            // 
            this.cbOpcionesDibujo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOpcionesDibujo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOpcionesDibujo.FormattingEnabled = true;
            this.cbOpcionesDibujo.Items.AddRange(new object[] {
            "Círculo",
            "Cuadrado",
            "Elipse",
            "Cuña",
            "Círculo Relleno",
            "Cuadrado Relleno",
            "Elipse Rellena",
            "Cuña Rellena"});
            this.cbOpcionesDibujo.Location = new System.Drawing.Point(72, 34);
            this.cbOpcionesDibujo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbOpcionesDibujo.Name = "cbOpcionesDibujo";
            this.cbOpcionesDibujo.Size = new System.Drawing.Size(160, 28);
            this.cbOpcionesDibujo.TabIndex = 0;
            this.cbOpcionesDibujo.SelectedIndexChanged += new System.EventHandler(this.cbOpcionesDibujo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elija figura a dibujar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOpcionesDibujo);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOpcionesDibujo;
        private System.Windows.Forms.Label label1;
    }
}

