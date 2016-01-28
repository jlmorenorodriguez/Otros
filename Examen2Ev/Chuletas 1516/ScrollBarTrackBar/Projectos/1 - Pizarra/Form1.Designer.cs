namespace ScrollBar
{
    partial class Pizarra
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
            this.panel = new System.Windows.Forms.Panel();
            this.scroll_alpha = new System.Windows.Forms.HScrollBar();
            this.scroll_red = new System.Windows.Forms.HScrollBar();
            this.scroll_blue = new System.Windows.Forms.VScrollBar();
            this.scroll_green = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.poscolor = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de Colores [Hex]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Controls.Add(this.scroll_alpha);
            this.panel.Controls.Add(this.scroll_red);
            this.panel.Controls.Add(this.scroll_blue);
            this.panel.Controls.Add(this.scroll_green);
            this.panel.Location = new System.Drawing.Point(80, 150);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(434, 303);
            this.panel.TabIndex = 1;
            // 
            // scroll_alpha
            // 
            this.scroll_alpha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scroll_alpha.LargeChange = 1;
            this.scroll_alpha.Location = new System.Drawing.Point(0, 285);
            this.scroll_alpha.Maximum = 255;
            this.scroll_alpha.Name = "scroll_alpha";
            this.scroll_alpha.Size = new System.Drawing.Size(434, 18);
            this.scroll_alpha.TabIndex = 3;
            this.scroll_alpha.TabStop = true;
            this.scroll_alpha.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CambiaColor);
            // 
            // scroll_red
            // 
            this.scroll_red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scroll_red.LargeChange = 1;
            this.scroll_red.Location = new System.Drawing.Point(0, 0);
            this.scroll_red.Maximum = 255;
            this.scroll_red.Name = "scroll_red";
            this.scroll_red.Size = new System.Drawing.Size(434, 18);
            this.scroll_red.TabIndex = 9;
            this.scroll_red.TabStop = true;
            this.scroll_red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CambiaColor);
            // 
            // scroll_blue
            // 
            this.scroll_blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scroll_blue.LargeChange = 1;
            this.scroll_blue.Location = new System.Drawing.Point(417, 0);
            this.scroll_blue.Maximum = 255;
            this.scroll_blue.Name = "scroll_blue";
            this.scroll_blue.Size = new System.Drawing.Size(17, 303);
            this.scroll_blue.TabIndex = 6;
            this.scroll_blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CambiaColor);
            // 
            // scroll_green
            // 
            this.scroll_green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scroll_green.LargeChange = 1;
            this.scroll_green.Location = new System.Drawing.Point(0, 0);
            this.scroll_green.Maximum = 255;
            this.scroll_green.Name = "scroll_green";
            this.scroll_green.Size = new System.Drawing.Size(17, 303);
            this.scroll_green.TabIndex = 5;
            this.scroll_green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CambiaColor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(271, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(8, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(271, 475);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alpha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(525, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Blue";
            // 
            // poscolor
            // 
            this.poscolor.AutoSize = true;
            this.poscolor.BackColor = System.Drawing.Color.Transparent;
            this.poscolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.poscolor.ForeColor = System.Drawing.Color.Black;
            this.poscolor.Location = new System.Drawing.Point(76, 78);
            this.poscolor.Name = "poscolor";
            this.poscolor.Size = new System.Drawing.Size(127, 20);
            this.poscolor.TabIndex = 8;
            this.poscolor.Text = "Valor del Color";
            // 
            // Pizarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(585, 548);
            this.Controls.Add(this.poscolor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Pizarra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pizarra";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.VScrollBar scroll_blue;
        private System.Windows.Forms.VScrollBar scroll_green;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label poscolor;
        private System.Windows.Forms.HScrollBar scroll_alpha;
        private System.Windows.Forms.HScrollBar scroll_red;



    }
}

