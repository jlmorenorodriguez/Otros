namespace Exposicion_ComboBox
{
    partial class FormTareas
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
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnadirQuitar = new System.Windows.Forms.Button();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHorario
            // 
            this.cbHorario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbHorario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHorario.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHorario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(17, 6);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbHorario.Size = new System.Drawing.Size(391, 29);
            this.cbHorario.TabIndex = 0;
            this.cbHorario.SelectedIndexChanged += new System.EventHandler(this.cbHorario_SelectedIndexChanged);
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(17, 41);
            this.txtTarea.Multiline = true;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(391, 68);
            this.txtTarea.TabIndex = 1;
            this.txtTarea.TextChanged += new System.EventHandler(this.txtTarea_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbHorario);
            this.panel1.Controls.Add(this.txtTarea);
            this.panel1.Controls.Add(this.btnAnadirQuitar);
            this.panel1.Controls.Add(this.btnAnyadir);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 213);
            this.panel1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(132, 178);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Ordenar Asignaturas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "AÑADIR TODO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnadirQuitar
            // 
            this.btnAnadirQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirQuitar.Location = new System.Drawing.Point(17, 116);
            this.btnAnadirQuitar.Name = "btnAnadirQuitar";
            this.btnAnadirQuitar.Size = new System.Drawing.Size(192, 27);
            this.btnAnadirQuitar.TabIndex = 5;
            this.btnAnadirQuitar.Text = "Añadir/Quitar Materias";
            this.btnAnadirQuitar.UseVisualStyleBackColor = true;
            this.btnAnadirQuitar.Click += new System.EventHandler(this.btnAnadirQuitar_Click);
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnyadir.Location = new System.Drawing.Point(215, 116);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(193, 27);
            this.btnAnyadir.TabIndex = 4;
            this.btnAnyadir.Text = "Añadir Registro";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Wheat;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Miriam", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(144, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Gestor de Tareas";
            // 
            // FormTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 278);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormTareas";
            this.Text = "Lista de Tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Button btnAnadirQuitar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

