namespace cbOtrosMetodos
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
            this.cbcomunidades = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbcomunidades
            // 
            this.cbcomunidades.DropDownHeight = 80;
            this.cbcomunidades.FormattingEnabled = true;
            this.cbcomunidades.IntegralHeight = false;
            this.cbcomunidades.Items.AddRange(new object[] {
            "Andalucía",
            "Aragón",
            "Asturias",
            "Baleares",
            "Canarias",
            "Cantabria",
            "Castilla y León",
            "Castilla - La Mancha",
            "Cataluña",
            "Comunidad Valenciana",
            "Extremadura",
            "Galicia",
            "Comunidad de Madrid",
            "Región de Murcia",
            "C. Foral de Navarra",
            "País Vasco",
            "La Rioja",
            "Ceuta",
            "Melilla"});
            this.cbcomunidades.Location = new System.Drawing.Point(24, 30);
            this.cbcomunidades.Name = "cbcomunidades";
            this.cbcomunidades.Size = new System.Drawing.Size(231, 21);
            this.cbcomunidades.TabIndex = 0;
            this.cbcomunidades.SelectedIndexChanged += new System.EventHandler(this.cbcomunidades_SelectedIndexChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(24, 57);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(111, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "FindString";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "FindStringExact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cbcomunidades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbcomunidades;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button button1;
    }
}

