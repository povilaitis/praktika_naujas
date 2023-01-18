namespace Praktika
{
    partial class Grupe
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
            this.Išeiti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Išeiti
            // 
            this.Išeiti.Location = new System.Drawing.Point(597, 379);
            this.Išeiti.Name = "Išeiti";
            this.Išeiti.Size = new System.Drawing.Size(142, 43);
            this.Išeiti.TabIndex = 0;
            this.Išeiti.Text = "Išeiti";
            this.Išeiti.UseVisualStyleBackColor = true;
            this.Išeiti.Click += new System.EventHandler(this.Išeiti_Click);
            // 
            // Grupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Išeiti);
            this.Name = "Grupe";
            this.Text = "Grupe";
            this.Load += new System.EventHandler(this.Grupe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Išeiti;
    }
}