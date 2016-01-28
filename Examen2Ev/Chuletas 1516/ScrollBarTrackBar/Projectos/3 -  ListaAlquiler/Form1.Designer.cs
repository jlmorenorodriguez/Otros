namespace Alquilar
{
    partial class Listaalquiler
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
            this.ficha = new System.Windows.Forms.GroupBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.descripcion_textbox = new System.Windows.Forms.RichTextBox();
            this.descripcion_label = new System.Windows.Forms.Label();
            this.alquiler_textbox = new System.Windows.Forms.TextBox();
            this.genero_textbox = new System.Windows.Forms.TextBox();
            this.nombre_textbox = new System.Windows.Forms.TextBox();
            this.alquiler_label = new System.Windows.Forms.Label();
            this.genero_label = new System.Windows.Forms.Label();
            this.nombre_label = new System.Windows.Forms.Label();
            this.Producto_scrollbar = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ficha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ficha
            // 
            this.ficha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ficha.Controls.Add(this.id_textbox);
            this.ficha.Controls.Add(this.id_label);
            this.ficha.Controls.Add(this.descripcion_textbox);
            this.ficha.Controls.Add(this.descripcion_label);
            this.ficha.Controls.Add(this.alquiler_textbox);
            this.ficha.Controls.Add(this.genero_textbox);
            this.ficha.Controls.Add(this.nombre_textbox);
            this.ficha.Controls.Add(this.alquiler_label);
            this.ficha.Controls.Add(this.genero_label);
            this.ficha.Controls.Add(this.nombre_label);
            this.ficha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ficha.Location = new System.Drawing.Point(0, 34);
            this.ficha.Name = "ficha";
            this.ficha.Size = new System.Drawing.Size(502, 366);
            this.ficha.TabIndex = 0;
            this.ficha.TabStop = false;
            this.ficha.Text = "FICHA";
            // 
            // id_textbox
            // 
            this.id_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.id_textbox.Location = new System.Drawing.Point(72, 38);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.ReadOnly = true;
            this.id_textbox.Size = new System.Drawing.Size(35, 26);
            this.id_textbox.TabIndex = 9;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(43, 38);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 18);
            this.id_label.TabIndex = 8;
            this.id_label.Text = "ID";
            // 
            // descripcion_textbox
            // 
            this.descripcion_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.descripcion_textbox.Location = new System.Drawing.Point(46, 198);
            this.descripcion_textbox.Name = "descripcion_textbox";
            this.descripcion_textbox.ReadOnly = true;
            this.descripcion_textbox.Size = new System.Drawing.Size(391, 109);
            this.descripcion_textbox.TabIndex = 7;
            this.descripcion_textbox.Text = "";
            // 
            // descripcion_label
            // 
            this.descripcion_label.AutoSize = true;
            this.descripcion_label.Location = new System.Drawing.Point(43, 177);
            this.descripcion_label.Name = "descripcion_label";
            this.descripcion_label.Size = new System.Drawing.Size(92, 18);
            this.descripcion_label.TabIndex = 6;
            this.descripcion_label.Text = "Descripción";
            // 
            // alquiler_textbox
            // 
            this.alquiler_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.alquiler_textbox.Location = new System.Drawing.Point(203, 125);
            this.alquiler_textbox.Name = "alquiler_textbox";
            this.alquiler_textbox.ReadOnly = true;
            this.alquiler_textbox.Size = new System.Drawing.Size(61, 26);
            this.alquiler_textbox.TabIndex = 5;
            // 
            // genero_textbox
            // 
            this.genero_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.genero_textbox.Location = new System.Drawing.Point(203, 82);
            this.genero_textbox.Name = "genero_textbox";
            this.genero_textbox.ReadOnly = true;
            this.genero_textbox.Size = new System.Drawing.Size(277, 26);
            this.genero_textbox.TabIndex = 4;
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.BackColor = System.Drawing.Color.PapayaWhip;
            this.nombre_textbox.Location = new System.Drawing.Point(203, 35);
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.ReadOnly = true;
            this.nombre_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.nombre_textbox.Size = new System.Drawing.Size(277, 26);
            this.nombre_textbox.TabIndex = 3;
            // 
            // alquiler_label
            // 
            this.alquiler_label.AutoSize = true;
            this.alquiler_label.Location = new System.Drawing.Point(137, 125);
            this.alquiler_label.Name = "alquiler_label";
            this.alquiler_label.Size = new System.Drawing.Size(60, 18);
            this.alquiler_label.TabIndex = 2;
            this.alquiler_label.Text = "Alquiler";
            // 
            // genero_label
            // 
            this.genero_label.AutoSize = true;
            this.genero_label.Location = new System.Drawing.Point(137, 85);
            this.genero_label.Name = "genero_label";
            this.genero_label.Size = new System.Drawing.Size(60, 18);
            this.genero_label.TabIndex = 1;
            this.genero_label.Text = "Género";
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Location = new System.Drawing.Point(133, 41);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(64, 18);
            this.nombre_label.TabIndex = 0;
            this.nombre_label.Text = "Nombre";
            // 
            // Producto_scrollbar
            // 
            this.Producto_scrollbar.LargeChange = 1;
            this.Producto_scrollbar.Location = new System.Drawing.Point(494, 34);
            this.Producto_scrollbar.Maximum = 9;
            this.Producto_scrollbar.Name = "Producto_scrollbar";
            this.Producto_scrollbar.Size = new System.Drawing.Size(20, 366);
            this.Producto_scrollbar.TabIndex = 1;
            this.Producto_scrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.muestraproducto_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Producto_scrollbar);
            this.panel1.Controls.Add(this.ficha);
            this.panel1.Location = new System.Drawing.Point(33, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 400);
            this.panel1.TabIndex = 0;
            // 
            // Listaalquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 426);
            this.Controls.Add(this.panel1);
            this.Name = "Listaalquiler";
            this.Text = "Lista Alquiler";
            this.ficha.ResumeLayout(false);
            this.ficha.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ficha;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.RichTextBox descripcion_textbox;
        private System.Windows.Forms.Label descripcion_label;
        private System.Windows.Forms.TextBox alquiler_textbox;
        private System.Windows.Forms.TextBox genero_textbox;
        private System.Windows.Forms.TextBox nombre_textbox;
        private System.Windows.Forms.Label alquiler_label;
        private System.Windows.Forms.Label genero_label;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.VScrollBar Producto_scrollbar;
        private System.Windows.Forms.Panel panel1;

    }
}

