namespace Elipses
{
    partial class FormDibujo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.tracX = new System.Windows.Forms.TrackBar();
            this.tracY = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnIgualaEjes = new System.Windows.Forms.Button();
            this.lbX = new System.Windows.Forms.Label();
            this.chbRellenar = new System.Windows.Forms.CheckBox();
            this.rbElipse = new System.Windows.Forms.RadioButton();
            this.rbRectang = new System.Windows.Forms.RadioButton();
            this.nudEjeY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrosor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizaEjeX = new System.Windows.Forms.Button();
            this.txbLong = new System.Windows.Forms.TextBox();
            this.lbLong = new System.Windows.Forms.Label();
            this.tracEjeX = new System.Windows.Forms.TrackBar();
            this.btnActualizaXY = new System.Windows.Forms.Button();
            this.txbY = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.txbX = new System.Windows.Forms.TextBox();
            this.btnMostrarBD = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tracX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracY)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEjeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracEjeX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.Color.White;
            this.panelDibujo.Location = new System.Drawing.Point(60, 20);
            this.panelDibujo.Margin = new System.Windows.Forms.Padding(4);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(600, 554);
            this.panelDibujo.TabIndex = 0;
            // 
            // tracX
            // 
            this.tracX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tracX.Location = new System.Drawing.Point(45, 574);
            this.tracX.Margin = new System.Windows.Forms.Padding(4);
            this.tracX.Maximum = 450;
            this.tracX.Name = "tracX";
            this.tracX.Size = new System.Drawing.Size(624, 56);
            this.tracX.TabIndex = 1;
            // 
            // tracY
            // 
            this.tracY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tracY.Location = new System.Drawing.Point(13, 11);
            this.tracY.Margin = new System.Windows.Forms.Padding(4);
            this.tracY.Maximum = 450;
            this.tracY.Name = "tracY";
            this.tracY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tracY.Size = new System.Drawing.Size(56, 576);
            this.tracY.TabIndex = 2;
            this.tracY.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 586);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 43);
            this.label3.TabIndex = 10;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(33, 418);
            this.btnDibujar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(265, 55);
            this.btnDibujar.TabIndex = 19;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbNombre);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnIgualaEjes);
            this.groupBox1.Controls.Add(this.lbX);
            this.groupBox1.Controls.Add(this.btnDibujar);
            this.groupBox1.Controls.Add(this.chbRellenar);
            this.groupBox1.Controls.Add(this.rbElipse);
            this.groupBox1.Controls.Add(this.rbRectang);
            this.groupBox1.Controls.Add(this.nudEjeY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbGrosor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnActualizaEjeX);
            this.groupBox1.Controls.Add(this.txbLong);
            this.groupBox1.Controls.Add(this.lbLong);
            this.groupBox1.Controls.Add(this.tracEjeX);
            this.groupBox1.Controls.Add(this.btnActualizaXY);
            this.groupBox1.Controls.Add(this.txbY);
            this.groupBox1.Controls.Add(this.lbY);
            this.groupBox1.Controls.Add(this.txbX);
            this.groupBox1.Location = new System.Drawing.Point(691, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(449, 490);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades de la Elipse ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.ForeColor = System.Drawing.Color.White;
            this.txbNombre.Location = new System.Drawing.Point(57, 43);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(313, 35);
            this.txbNombre.TabIndex = 43;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(311, 418);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 55);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnIgualaEjes
            // 
            this.btnIgualaEjes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgualaEjes.Location = new System.Drawing.Point(316, 278);
            this.btnIgualaEjes.Margin = new System.Windows.Forms.Padding(4);
            this.btnIgualaEjes.Name = "btnIgualaEjes";
            this.btnIgualaEjes.Size = new System.Drawing.Size(107, 28);
            this.btnIgualaEjes.TabIndex = 39;
            this.btnIgualaEjes.Text = "ejeY=ejeX";
            this.btnIgualaEjes.UseVisualStyleBackColor = true;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.ForeColor = System.Drawing.Color.White;
            this.lbX.Location = new System.Drawing.Point(60, 111);
            this.lbX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(27, 25);
            this.lbX.TabIndex = 19;
            this.lbX.Text = "X";
            // 
            // chbRellenar
            // 
            this.chbRellenar.AutoSize = true;
            this.chbRellenar.BackColor = System.Drawing.Color.Maroon;
            this.chbRellenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRellenar.ForeColor = System.Drawing.Color.White;
            this.chbRellenar.Location = new System.Drawing.Point(292, 353);
            this.chbRellenar.Margin = new System.Windows.Forms.Padding(4);
            this.chbRellenar.Name = "chbRellenar";
            this.chbRellenar.Size = new System.Drawing.Size(113, 29);
            this.chbRellenar.TabIndex = 38;
            this.chbRellenar.Text = "Rellenar";
            this.chbRellenar.UseVisualStyleBackColor = false;
            // 
            // rbElipse
            // 
            this.rbElipse.AutoSize = true;
            this.rbElipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbElipse.Checked = true;
            this.rbElipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbElipse.ForeColor = System.Drawing.Color.White;
            this.rbElipse.Location = new System.Drawing.Point(261, 132);
            this.rbElipse.Margin = new System.Windows.Forms.Padding(4);
            this.rbElipse.Name = "rbElipse";
            this.rbElipse.Size = new System.Drawing.Size(86, 29);
            this.rbElipse.TabIndex = 37;
            this.rbElipse.TabStop = true;
            this.rbElipse.Text = "Elipse";
            this.rbElipse.UseVisualStyleBackColor = false;
            // 
            // rbRectang
            // 
            this.rbRectang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbRectang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRectang.ForeColor = System.Drawing.Color.White;
            this.rbRectang.Location = new System.Drawing.Point(261, 170);
            this.rbRectang.Margin = new System.Windows.Forms.Padding(4);
            this.rbRectang.Name = "rbRectang";
            this.rbRectang.Size = new System.Drawing.Size(147, 31);
            this.rbRectang.TabIndex = 36;
            this.rbRectang.Text = "Rectángulo";
            this.rbRectang.UseVisualStyleBackColor = false;
            // 
            // nudEjeY
            // 
            this.nudEjeY.BackColor = System.Drawing.Color.Blue;
            this.nudEjeY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudEjeY.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.nudEjeY.ForeColor = System.Drawing.Color.White;
            this.nudEjeY.Location = new System.Drawing.Point(319, 246);
            this.nudEjeY.Margin = new System.Windows.Forms.Padding(4);
            this.nudEjeY.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.nudEjeY.Name = "nudEjeY";
            this.nudEjeY.Size = new System.Drawing.Size(100, 31);
            this.nudEjeY.TabIndex = 24;
            this.nudEjeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEjeY.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Coords. Centro";
            // 
            // lbColor
            // 
            this.lbColor.BackColor = System.Drawing.Color.Black;
            this.lbColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lbColor.ForeColor = System.Drawing.Color.White;
            this.lbColor.Location = new System.Drawing.Point(155, 331);
            this.lbColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(124, 69);
            this.lbColor.TabIndex = 33;
            this.lbColor.Text = "Color";
            this.lbColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbColor.Click += new System.EventHandler(this.lbColor_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "Grosor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGrosor
            // 
            this.cbGrosor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrosor.FormattingEnabled = true;
            this.cbGrosor.Location = new System.Drawing.Point(33, 363);
            this.cbGrosor.Margin = new System.Windows.Forms.Padding(4);
            this.cbGrosor.Name = "cbGrosor";
            this.cbGrosor.Size = new System.Drawing.Size(92, 36);
            this.cbGrosor.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Eje Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizaEjeX
            // 
            this.btnActualizaEjeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaEjeX.Location = new System.Drawing.Point(33, 220);
            this.btnActualizaEjeX.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizaEjeX.Name = "btnActualizaEjeX";
            this.btnActualizaEjeX.Size = new System.Drawing.Size(147, 28);
            this.btnActualizaEjeX.TabIndex = 28;
            this.btnActualizaEjeX.Text = "Actualiza EjeX";
            this.btnActualizaEjeX.UseVisualStyleBackColor = true;
            // 
            // txbLong
            // 
            this.txbLong.BackColor = System.Drawing.Color.Blue;
            this.txbLong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLong.ForeColor = System.Drawing.Color.White;
            this.txbLong.Location = new System.Drawing.Point(233, 220);
            this.txbLong.Margin = new System.Windows.Forms.Padding(4);
            this.txbLong.MaxLength = 4;
            this.txbLong.Name = "txbLong";
            this.txbLong.Size = new System.Drawing.Size(65, 28);
            this.txbLong.TabIndex = 27;
            this.txbLong.Text = "200";
            this.txbLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLong
            // 
            this.lbLong.BackColor = System.Drawing.Color.Blue;
            this.lbLong.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLong.ForeColor = System.Drawing.Color.White;
            this.lbLong.Location = new System.Drawing.Point(177, 220);
            this.lbLong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLong.Name = "lbLong";
            this.lbLong.Size = new System.Drawing.Size(59, 27);
            this.lbLong.TabIndex = 26;
            this.lbLong.Text = "Eje X";
            this.lbLong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tracEjeX
            // 
            this.tracEjeX.BackColor = System.Drawing.Color.Blue;
            this.tracEjeX.Location = new System.Drawing.Point(33, 256);
            this.tracEjeX.Margin = new System.Windows.Forms.Padding(4);
            this.tracEjeX.Maximum = 450;
            this.tracEjeX.Name = "tracEjeX";
            this.tracEjeX.Size = new System.Drawing.Size(265, 56);
            this.tracEjeX.TabIndex = 25;
            // 
            // btnActualizaXY
            // 
            this.btnActualizaXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaXY.Location = new System.Drawing.Point(36, 170);
            this.btnActualizaXY.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizaXY.Name = "btnActualizaXY";
            this.btnActualizaXY.Size = new System.Drawing.Size(177, 33);
            this.btnActualizaXY.TabIndex = 23;
            this.btnActualizaXY.Text = "Actualiza  (X, Y)";
            this.btnActualizaXY.UseVisualStyleBackColor = true;
            // 
            // txbY
            // 
            this.txbY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbY.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbY.ForeColor = System.Drawing.Color.White;
            this.txbY.Location = new System.Drawing.Point(137, 132);
            this.txbY.Margin = new System.Windows.Forms.Padding(4);
            this.txbY.MaxLength = 4;
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(75, 35);
            this.txbY.TabIndex = 22;
            this.txbY.Text = "200";
            this.txbY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbY.TextChanged += new System.EventHandler(this.txbY_TextChanged);
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY.ForeColor = System.Drawing.Color.White;
            this.lbY.Location = new System.Drawing.Point(155, 111);
            this.lbY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(26, 25);
            this.lbY.TabIndex = 21;
            this.lbY.Text = "Y";
            // 
            // txbX
            // 
            this.txbX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbX.ForeColor = System.Drawing.Color.White;
            this.txbX.Location = new System.Drawing.Point(37, 132);
            this.txbX.Margin = new System.Windows.Forms.Padding(4);
            this.txbX.MaxLength = 4;
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(75, 35);
            this.txbX.TabIndex = 20;
            this.txbX.Text = "200";
            this.txbX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbX.TextChanged += new System.EventHandler(this.txbX_TextChanged);
            // 
            // btnMostrarBD
            // 
            this.btnMostrarBD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarBD.Location = new System.Drawing.Point(691, 517);
            this.btnMostrarBD.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarBD.Name = "btnMostrarBD";
            this.btnMostrarBD.Size = new System.Drawing.Size(449, 49);
            this.btnMostrarBD.TabIndex = 27;
            this.btnMostrarBD.Text = "Mostrar Figuras Guardadas";
            this.btnMostrarBD.UseVisualStyleBackColor = true;
            this.btnMostrarBD.Click += new System.EventHandler(this.btnMostrarBD_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(691, 572);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(449, 49);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar la Figura Actual";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormDibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1163, 655);
            this.Controls.Add(this.btnMostrarBD);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tracX);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.tracY);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDibujo";
            this.Text = "Dibujo de Elipses y REctángulos";
            ((System.ComponentModel.ISupportInitialize)(this.tracX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEjeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracEjeX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.TrackBar tracX;
        private System.Windows.Forms.TrackBar tracY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGrosor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizaEjeX;
        private System.Windows.Forms.TextBox txbLong;
        private System.Windows.Forms.Label lbLong;
        private System.Windows.Forms.TrackBar tracEjeX;
        private System.Windows.Forms.NumericUpDown nudEjeY;
        private System.Windows.Forms.Button btnActualizaXY;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRectang;
        private System.Windows.Forms.RadioButton rbElipse;
        private System.Windows.Forms.CheckBox chbRellenar;
        private System.Windows.Forms.Button btnIgualaEjes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnMostrarBD;
        private System.Windows.Forms.Button btnGuardar;

    }
}

