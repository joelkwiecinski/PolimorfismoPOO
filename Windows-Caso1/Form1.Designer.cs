namespace Windows_Caso1
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
            this.btnAfinarPiano = new System.Windows.Forms.Button();
            this.btnAfinarGuitarra = new System.Windows.Forms.Button();
            this.btnAfinarViolin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfinarPiano
            // 
            this.btnAfinarPiano.Location = new System.Drawing.Point(169, 302);
            this.btnAfinarPiano.Name = "btnAfinarPiano";
            this.btnAfinarPiano.Size = new System.Drawing.Size(453, 98);
            this.btnAfinarPiano.TabIndex = 5;
            this.btnAfinarPiano.Text = "Afinar piano";
            this.btnAfinarPiano.UseVisualStyleBackColor = true;
            this.btnAfinarPiano.Click += new System.EventHandler(this.btnAfinarPiano_Click);
            // 
            // btnAfinarGuitarra
            // 
            this.btnAfinarGuitarra.Location = new System.Drawing.Point(169, 198);
            this.btnAfinarGuitarra.Name = "btnAfinarGuitarra";
            this.btnAfinarGuitarra.Size = new System.Drawing.Size(453, 98);
            this.btnAfinarGuitarra.TabIndex = 4;
            this.btnAfinarGuitarra.Text = "Afinar guitarra";
            this.btnAfinarGuitarra.UseVisualStyleBackColor = true;
            this.btnAfinarGuitarra.Click += new System.EventHandler(this.btnAfinarGuitarra_Click);
            // 
            // btnAfinarViolin
            // 
            this.btnAfinarViolin.Location = new System.Drawing.Point(169, 94);
            this.btnAfinarViolin.Name = "btnAfinarViolin";
            this.btnAfinarViolin.Size = new System.Drawing.Size(453, 98);
            this.btnAfinarViolin.TabIndex = 3;
            this.btnAfinarViolin.Text = "Afinar violin";
            this.btnAfinarViolin.UseVisualStyleBackColor = true;
            this.btnAfinarViolin.Click += new System.EventHandler(this.btnAfinarViolin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 495);
            this.Controls.Add(this.btnAfinarPiano);
            this.Controls.Add(this.btnAfinarGuitarra);
            this.Controls.Add(this.btnAfinarViolin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfinarPiano;
        private System.Windows.Forms.Button btnAfinarGuitarra;
        private System.Windows.Forms.Button btnAfinarViolin;
    }
}

