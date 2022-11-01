namespace Windows_Caso2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMoverPeon = new System.Windows.Forms.Button();
            this.btnMoverCaballo = new System.Windows.Forms.Button();
            this.btnMoverTorre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoverPeon
            // 
            this.btnMoverPeon.Location = new System.Drawing.Point(95, 36);
            this.btnMoverPeon.Name = "btnMoverPeon";
            this.btnMoverPeon.Size = new System.Drawing.Size(209, 56);
            this.btnMoverPeon.TabIndex = 0;
            this.btnMoverPeon.Text = "Mover peón";
            this.btnMoverPeon.UseVisualStyleBackColor = true;
            this.btnMoverPeon.Click += new System.EventHandler(this.btnMoverPeon_Click);
            // 
            // btnMoverCaballo
            // 
            this.btnMoverCaballo.Location = new System.Drawing.Point(95, 98);
            this.btnMoverCaballo.Name = "btnMoverCaballo";
            this.btnMoverCaballo.Size = new System.Drawing.Size(209, 56);
            this.btnMoverCaballo.TabIndex = 1;
            this.btnMoverCaballo.Text = "Mover caballo";
            this.btnMoverCaballo.UseVisualStyleBackColor = true;
            this.btnMoverCaballo.Click += new System.EventHandler(this.btnMoverCaballo_Click);
            // 
            // btnMoverTorre
            // 
            this.btnMoverTorre.Location = new System.Drawing.Point(95, 160);
            this.btnMoverTorre.Name = "btnMoverTorre";
            this.btnMoverTorre.Size = new System.Drawing.Size(209, 56);
            this.btnMoverTorre.TabIndex = 2;
            this.btnMoverTorre.Text = "Mover torre";
            this.btnMoverTorre.UseVisualStyleBackColor = true;
            this.btnMoverTorre.Click += new System.EventHandler(this.btnMoverTorre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 252);
            this.Controls.Add(this.btnMoverTorre);
            this.Controls.Add(this.btnMoverCaballo);
            this.Controls.Add(this.btnMoverPeon);
            this.Name = "Form1";
            this.Text = "Ajedrez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoverPeon;
        private System.Windows.Forms.Button btnMoverCaballo;
        private System.Windows.Forms.Button btnMoverTorre;
    }
}

