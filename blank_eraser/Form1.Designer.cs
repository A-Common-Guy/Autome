namespace blank_eraser
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.eraser = new System.Windows.Forms.Button();
            this.tin = new System.Windows.Forms.TextBox();
            this.tout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eraser
            // 
            this.eraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraser.Location = new System.Drawing.Point(398, 12);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(390, 426);
            this.eraser.TabIndex = 0;
            this.eraser.Text = "ERASE";
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // tin
            // 
            this.tin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tin.Location = new System.Drawing.Point(12, 12);
            this.tin.Multiline = true;
            this.tin.Name = "tin";
            this.tin.Size = new System.Drawing.Size(369, 201);
            this.tin.TabIndex = 1;
            // 
            // tout
            // 
            this.tout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tout.Location = new System.Drawing.Point(12, 240);
            this.tout.Multiline = true;
            this.tout.Name = "tout";
            this.tout.Size = new System.Drawing.Size(369, 198);
            this.tout.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tout);
            this.Controls.Add(this.tin);
            this.Controls.Add(this.eraser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.TextBox tin;
        private System.Windows.Forms.TextBox tout;
    }
}

