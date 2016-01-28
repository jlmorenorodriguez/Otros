namespace CheckListBox
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
            this.checkedListBoxEquipos = new System.Windows.Forms.CheckedListBox();
            this.listBoxEquipos = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txbAñadirEquipo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxEquipos
            // 
            this.checkedListBoxEquipos.CheckOnClick = true;
            this.checkedListBoxEquipos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkedListBoxEquipos.FormattingEnabled = true;
            this.checkedListBoxEquipos.Location = new System.Drawing.Point(58, 90);
            this.checkedListBoxEquipos.Name = "checkedListBoxEquipos";
            this.checkedListBoxEquipos.ScrollAlwaysVisible = true;
            this.checkedListBoxEquipos.Size = new System.Drawing.Size(300, 193);
            this.checkedListBoxEquipos.TabIndex = 0;
            // 
            // listBoxEquipos
            // 
            this.listBoxEquipos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.listBoxEquipos.FormattingEnabled = true;
            this.listBoxEquipos.ItemHeight = 24;
            this.listBoxEquipos.Location = new System.Drawing.Point(522, 24);
            this.listBoxEquipos.Name = "listBoxEquipos";
            this.listBoxEquipos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxEquipos.Size = new System.Drawing.Size(181, 316);
            this.listBoxEquipos.Sorted = true;
            this.listBoxEquipos.TabIndex = 1;
            // 
            // btnAñadir
            // 
            this.btnAñadir.AutoSize = true;
            this.btnAñadir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(58, 306);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(86, 34);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txbAñadirEquipo
            // 
            this.txbAñadirEquipo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.txbAñadirEquipo.Location = new System.Drawing.Point(58, 12);
            this.txbAñadirEquipo.Name = "txbAñadirEquipo";
            this.txbAñadirEquipo.Size = new System.Drawing.Size(227, 32);
            this.txbAñadirEquipo.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(150, 306);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 34);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clasificacion:";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.AutoSize = true;
            this.btnOrdenar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(256, 306);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(102, 34);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.AutoSize = true;
            this.btnIzquierda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.Location = new System.Drawing.Point(387, 143);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(102, 34);
            this.btnIzquierda.TabIndex = 7;
            this.btnIzquierda.Text = "<<<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.AutoSize = true;
            this.btnDerecha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.Location = new System.Drawing.Point(387, 195);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(102, 34);
            this.btnDerecha.TabIndex = 8;
            this.btnDerecha.Text = ">>>";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 352);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txbAñadirEquipo);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.listBoxEquipos);
            this.Controls.Add(this.checkedListBoxEquipos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxEquipos;
        private System.Windows.Forms.ListBox listBoxEquipos;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox txbAñadirEquipo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
    }
}

