namespace Praktika
{
    partial class Studento_dalykai
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
            this.Duoti_studentui_dalykai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Duoti_studentui_dalykai
            // 
            this.Duoti_studentui_dalykai.Location = new System.Drawing.Point(553, 356);
            this.Duoti_studentui_dalykai.Name = "Duoti_studentui_dalykai";
            this.Duoti_studentui_dalykai.Size = new System.Drawing.Size(170, 54);
            this.Duoti_studentui_dalykai.TabIndex = 0;
            this.Duoti_studentui_dalykai.Text = "Duoti studentui dalykai";
            this.Duoti_studentui_dalykai.UseVisualStyleBackColor = true;
            // 
            // Studento_dalykai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Duoti_studentui_dalykai);
            this.Name = "Studento_dalykai";
            this.Text = "Studento_dalykai";
            this.Load += new System.EventHandler(this.Studento_dalykai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Duoti_studentui_dalykai;
    }
}