namespace Elipses
{
    partial class FormDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbCabecera = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dSElipses = new Elipses.DSElipses();
            this.elipsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elipsesTableAdapter = new Elipses.DSElipsesTableAdapters.ElipsesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSElipses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipsesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(697, 396);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(265, 43);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbCabecera
            // 
            this.lbCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCabecera.Location = new System.Drawing.Point(45, 38);
            this.lbCabecera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCabecera.Name = "lbCabecera";
            this.lbCabecera.Size = new System.Drawing.Size(428, 28);
            this.lbCabecera.TabIndex = 26;
            // 
            // dgv
            // 
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dgv.Location = new System.Drawing.Point(45, 82);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(915, 306);
            this.dgv.TabIndex = 27;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.HeaderText = "Edit";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "►";
            this.Editar.ToolTipText = "►";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 40;
            // 
            // dSElipses
            // 
            this.dSElipses.DataSetName = "DSElipses";
            this.dSElipses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elipsesBindingSource
            // 
            this.elipsesBindingSource.DataMember = "Elipses";
            this.elipsesBindingSource.DataSource = this.dSElipses;
            // 
            // elipsesTableAdapter
            // 
            this.elipsesTableAdapter.ClearBeforeFill = true;
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1001, 455);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbCabecera);
            this.Controls.Add(this.btnCancelar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDatos";
            this.Text = "FormDatos";
            this.Load += new System.EventHandler(this.FormDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSElipses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipsesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbCabecera;
        private System.Windows.Forms.DataGridView dgv;
        private Elipses.DSElipses dSElipses;
        private System.Windows.Forms.BindingSource elipsesBindingSource;
        private Elipses.DSElipsesTableAdapters.ElipsesTableAdapter elipsesTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}