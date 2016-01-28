namespace W_ColorDialog_FontDialog
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
            this.rtbDocumento = new System.Windows.Forms.RichTextBox();
            this.btnEdtTitulo = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFuente = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.lbModoAplique = new System.Windows.Forms.Label();
            this.rtbTitulo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbDocumento
            // 
            this.rtbDocumento.Location = new System.Drawing.Point(47, 100);
            this.rtbDocumento.Name = "rtbDocumento";
            this.rtbDocumento.Size = new System.Drawing.Size(490, 542);
            this.rtbDocumento.TabIndex = 0;
            this.rtbDocumento.Text = "";
            // 
            // btnEdtTitulo
            // 
            this.btnEdtTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.btnEdtTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdtTitulo.Location = new System.Drawing.Point(571, 177);
            this.btnEdtTitulo.Name = "btnEdtTitulo";
            this.btnEdtTitulo.Size = new System.Drawing.Size(327, 45);
            this.btnEdtTitulo.TabIndex = 1;
            this.btnEdtTitulo.Text = "MODO APLICACIÓN";
            this.btnEdtTitulo.UseVisualStyleBackColor = false;
            this.btnEdtTitulo.Click += new System.EventHandler(this.btnEdtTitulo_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.DarkGray;
            this.btnColor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(571, 474);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(327, 45);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "FORMATO COLOR";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFuente
            // 
            this.btnFuente.BackColor = System.Drawing.Color.DarkGray;
            this.btnFuente.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuente.Location = new System.Drawing.Point(571, 552);
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(327, 45);
            this.btnFuente.TabIndex = 4;
            this.btnFuente.Text = "FORMATO FUENTE";
            this.btnFuente.UseVisualStyleBackColor = false;
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorDialog.FullOpen = true;
            this.colorDialog.ShowHelp = true;
            this.colorDialog.SolidColorOnly = true;
            this.colorDialog.HelpRequest += new System.EventHandler(this.colorDialog_HelpRequest);
            // 
            // fontDialog
            // 
            this.fontDialog.FixedPitchOnly = true;
            this.fontDialog.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontDialog.ShowApply = true;
            // 
            // lbModoAplique
            // 
            this.lbModoAplique.AutoSize = true;
            this.lbModoAplique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbModoAplique.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModoAplique.Location = new System.Drawing.Point(577, 239);
            this.lbModoAplique.Name = "lbModoAplique";
            this.lbModoAplique.Size = new System.Drawing.Size(106, 36);
            this.lbModoAplique.TabIndex = 6;
            this.lbModoAplique.Text = "TODO";
            // 
            // rtbTitulo
            // 
            this.rtbTitulo.BackColor = System.Drawing.Color.White;
            this.rtbTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTitulo.Location = new System.Drawing.Point(47, 43);
            this.rtbTitulo.Name = "rtbTitulo";
            this.rtbTitulo.Size = new System.Drawing.Size(490, 51);
            this.rtbTitulo.TabIndex = 7;
            this.rtbTitulo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(928, 687);
            this.Controls.Add(this.rtbTitulo);
            this.Controls.Add(this.lbModoAplique);
            this.Controls.Add(this.btnFuente);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnEdtTitulo);
            this.Controls.Add(this.rtbDocumento);
            this.MaximumSize = new System.Drawing.Size(944, 800);
            this.MinimumSize = new System.Drawing.Size(944, 726);
            this.Name = "Form1";
            this.Text = "W_ColorDialog_FontDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDocumento;
        private System.Windows.Forms.Button btnEdtTitulo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label lbModoAplique;
        private System.Windows.Forms.RichTextBox rtbTitulo;
    }
}

