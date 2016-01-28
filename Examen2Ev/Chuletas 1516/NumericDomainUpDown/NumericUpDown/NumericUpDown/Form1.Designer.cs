namespace NumericUpDown
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nUd1 = new System.Windows.Forms.NumericUpDown();
            this.nUd2 = new System.Windows.Forms.NumericUpDown();
            this.nUd3 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chbDecimales = new System.Windows.Forms.CheckBox();
            this.chbHexadecimal = new System.Windows.Forms.CheckBox();
            this.chkThousand = new System.Windows.Forms.CheckBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.btnDecrementar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Promedio";
            // 
            // nUd1
            // 
            this.nUd1.Location = new System.Drawing.Point(272, 291);
            this.nUd1.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nUd1.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.nUd1.Name = "nUd1";
            this.nUd1.Size = new System.Drawing.Size(75, 29);
            this.nUd1.TabIndex = 5;
            this.nUd1.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // nUd2
            // 
            this.nUd2.DecimalPlaces = 2;
            this.nUd2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nUd2.Location = new System.Drawing.Point(196, 235);
            this.nUd2.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nUd2.Name = "nUd2";
            this.nUd2.Size = new System.Drawing.Size(151, 29);
            this.nUd2.TabIndex = 6;
            this.nUd2.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // nUd3
            // 
            this.nUd3.Location = new System.Drawing.Point(272, 189);
            this.nUd3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nUd3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUd3.Name = "nUd3";
            this.nUd3.Size = new System.Drawing.Size(75, 29);
            this.nUd3.TabIndex = 7;
            this.nUd3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(111, 368);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 31);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chbDecimales
            // 
            this.chbDecimales.AutoSize = true;
            this.chbDecimales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDecimales.Location = new System.Drawing.Point(353, 292);
            this.chbDecimales.Name = "chbDecimales";
            this.chbDecimales.Size = new System.Drawing.Size(88, 20);
            this.chbDecimales.TabIndex = 10;
            this.chbDecimales.Text = "Decimales";
            this.chbDecimales.UseVisualStyleBackColor = true;
            this.chbDecimales.Click += new System.EventHandler(this.chbDecimales_Click);
            // 
            // chbHexadecimal
            // 
            this.chbHexadecimal.AutoSize = true;
            this.chbHexadecimal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHexadecimal.Location = new System.Drawing.Point(353, 192);
            this.chbHexadecimal.Name = "chbHexadecimal";
            this.chbHexadecimal.Size = new System.Drawing.Size(116, 20);
            this.chbHexadecimal.TabIndex = 11;
            this.chbHexadecimal.Text = "Hexadecimales";
            this.chbHexadecimal.UseVisualStyleBackColor = true;
            this.chbHexadecimal.Click += new System.EventHandler(this.chbHexadecimales_Click);
            // 
            // chkThousand
            // 
            this.chkThousand.AutoSize = true;
            this.chkThousand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThousand.Location = new System.Drawing.Point(353, 237);
            this.chkThousand.Name = "chkThousand";
            this.chkThousand.Size = new System.Drawing.Size(61, 20);
            this.chkThousand.TabIndex = 12;
            this.chkThousand.Text = "Punto";
            this.chkThousand.UseVisualStyleBackColor = true;
            this.chkThousand.Click += new System.EventHandler(this.chkThousand_Click);
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementar.Location = new System.Drawing.Point(295, 375);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(119, 23);
            this.btnIncrementar.TabIndex = 13;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // btnDecrementar
            // 
            this.btnDecrementar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrementar.Location = new System.Drawing.Point(295, 404);
            this.btnDecrementar.Name = "btnDecrementar";
            this.btnDecrementar.Size = new System.Drawing.Size(119, 23);
            this.btnDecrementar.TabIndex = 14;
            this.btnDecrementar.Text = "Decrementar";
            this.btnDecrementar.UseVisualStyleBackColor = true;
            this.btnDecrementar.Click += new System.EventHandler(this.btnDecrementar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 464);
            this.Controls.Add(this.btnDecrementar);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.chkThousand);
            this.Controls.Add(this.chbHexadecimal);
            this.Controls.Add(this.chbDecimales);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nUd3);
            this.Controls.Add(this.nUd2);
            this.Controls.Add(this.nUd1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUd3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUd1;
        private System.Windows.Forms.NumericUpDown nUd2;
        private System.Windows.Forms.NumericUpDown nUd3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chbDecimales;
        private System.Windows.Forms.CheckBox chbHexadecimal;
        private System.Windows.Forms.CheckBox chkThousand;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.Button btnDecrementar;

    }
}

