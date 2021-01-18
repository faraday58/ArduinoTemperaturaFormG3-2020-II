namespace ArduinoTemperaturaFormG3_2020_II
{
    partial class PruebaLED
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
            this.btnPrende = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrende
            // 
            this.btnPrende.Location = new System.Drawing.Point(142, 121);
            this.btnPrende.Name = "btnPrende";
            this.btnPrende.Size = new System.Drawing.Size(163, 134);
            this.btnPrende.TabIndex = 0;
            this.btnPrende.Text = "Prende";
            this.btnPrende.UseVisualStyleBackColor = true;
            this.btnPrende.Click += new System.EventHandler(this.btnPrende_Click);
            // 
            // PruebaLED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.btnPrende);
            this.Name = "PruebaLED";
            this.Text = "PruebaLED";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrende;
    }
}