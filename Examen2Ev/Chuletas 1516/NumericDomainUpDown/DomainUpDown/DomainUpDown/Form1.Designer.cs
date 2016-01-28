namespace DomainUpDown
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
            this.dUd1 = new System.Windows.Forms.DomainUpDown();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.txbAnadir = new System.Windows.Forms.TextBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.chbOrdenar = new System.Windows.Forms.CheckBox();
            this.chbEnvolver = new System.Windows.Forms.CheckBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dUd1
            // 
            this.dUd1.Location = new System.Drawing.Point(141, 144);
            this.dUd1.Name = "dUd1";
            this.dUd1.Size = new System.Drawing.Size(158, 29);
            this.dUd1.TabIndex = 0;
            this.dUd1.Text = "opcion";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(187, 205);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 35);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 23;
            this.lb1.Location = new System.Drawing.Point(393, 41);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(120, 372);
            this.lb1.TabIndex = 2;
            // 
            // txbAnadir
            // 
            this.txbAnadir.Location = new System.Drawing.Point(88, 380);
            this.txbAnadir.Name = "txbAnadir";
            this.txbAnadir.Size = new System.Drawing.Size(100, 29);
            this.txbAnadir.TabIndex = 3;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(211, 380);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(173, 37);
            this.btnAnadir.TabIndex = 4;
            this.btnAnadir.Text = "Añadir al Domain";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // chbOrdenar
            // 
            this.chbOrdenar.AutoSize = true;
            this.chbOrdenar.Location = new System.Drawing.Point(141, 41);
            this.chbOrdenar.Name = "chbOrdenar";
            this.chbOrdenar.Size = new System.Drawing.Size(74, 27);
            this.chbOrdenar.TabIndex = 5;
            this.chbOrdenar.Text = "Sorted";
            this.chbOrdenar.UseVisualStyleBackColor = true;
            this.chbOrdenar.CheckedChanged += new System.EventHandler(this.chbOrdenar_CheckedChanged);
            // 
            // chbEnvolver
            // 
            this.chbEnvolver.AutoSize = true;
            this.chbEnvolver.Location = new System.Drawing.Point(242, 41);
            this.chbEnvolver.Name = "chbEnvolver";
            this.chbEnvolver.Size = new System.Drawing.Size(67, 27);
            this.chbEnvolver.TabIndex = 6;
            this.chbEnvolver.Text = "Wrap";
            this.chbEnvolver.UseVisualStyleBackColor = true;
            this.chbEnvolver.CheckedChanged += new System.EventHandler(this.chbEnvolver_CheckedChanged);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 23;
            this.lb2.Location = new System.Drawing.Point(549, 41);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(120, 372);
            this.lb2.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(496, 443);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 39);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 651);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.chbEnvolver);
            this.Controls.Add(this.chbOrdenar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.txbAnadir);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.dUd1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dUd1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.TextBox txbAnadir;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.CheckBox chbOrdenar;
        private System.Windows.Forms.CheckBox chbEnvolver;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btnLimpiar;

    }
}

