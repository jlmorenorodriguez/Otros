namespace InterfazUsuario
{
    partial class IUAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControles = new System.Windows.Forms.Panel();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.cbGrupos = new System.Windows.Forms.ComboBox();
            this.btnGestGrupos = new System.Windows.Forms.Button();
            this.lbCabecera = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelControles.Controls.Add(this.btnGuardarCambios);
            this.panelControles.Controls.Add(this.label1);
            this.panelControles.Controls.Add(this.btnAnadir);
            this.panelControles.Controls.Add(this.cbGrupos);
            this.panelControles.Location = new System.Drawing.Point(44, 433);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(924, 74);
            this.panelControles.TabIndex = 29;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Enabled = false;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(681, 23);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(188, 33);
            this.btnGuardarCambios.TabIndex = 25;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Grupo Seleccionado";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(16, 13);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(188, 33);
            this.btnAnadir.TabIndex = 21;
            this.btnAnadir.Text = "Añadir Alumno";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // cbGrupos
            // 
            this.cbGrupos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupos.Location = new System.Drawing.Point(246, 26);
            this.cbGrupos.Name = "cbGrupos";
            this.cbGrupos.Size = new System.Drawing.Size(284, 30);
            this.cbGrupos.TabIndex = 12;
            this.cbGrupos.SelectedIndexChanged += new System.EventHandler(this.cbGrupos_SelectedIndexChanged);
            // 
            // btnGestGrupos
            // 
            this.btnGestGrupos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestGrupos.Location = new System.Drawing.Point(780, 31);
            this.btnGestGrupos.Name = "btnGestGrupos";
            this.btnGestGrupos.Size = new System.Drawing.Size(188, 33);
            this.btnGestGrupos.TabIndex = 24;
            this.btnGestGrupos.Text = "Gestionar Grupos";
            this.btnGestGrupos.UseVisualStyleBackColor = true;
            // 
            // lbCabecera
            // 
            this.lbCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCabecera.Location = new System.Drawing.Point(40, 44);
            this.lbCabecera.Name = "lbCabecera";
            this.lbCabecera.Size = new System.Drawing.Size(520, 23);
            this.lbCabecera.TabIndex = 28;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(42, 70);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(926, 342);
            this.dgv.TabIndex = 27;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.HeaderText = "Edit";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "►";
            this.Editar.ToolTipText = "Editar Registro";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 40;
            // 
            // IUAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 551);
            this.Controls.Add(this.btnGestGrupos);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.lbCabecera);
            this.Controls.Add(this.dgv);
            this.Name = "IUAlumno";
            this.Text = "Alumnos de Formación Profesional";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IUAlumno_FormClosing);
            this.Load += new System.EventHandler(this.IUAlumno_Load);
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnGestGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.ComboBox cbGrupos;
        private System.Windows.Forms.Label lbCabecera;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}

