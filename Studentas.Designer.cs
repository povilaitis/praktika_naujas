namespace Praktika
{
    partial class Studentas
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
            this.Atsijungti = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pavarde = new System.Windows.Forms.TextBox();
            this.Vardas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.išsaugoti = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Atsijungti
            // 
            this.Atsijungti.Location = new System.Drawing.Point(74, 388);
            this.Atsijungti.Name = "Atsijungti";
            this.Atsijungti.Size = new System.Drawing.Size(157, 41);
            this.Atsijungti.TabIndex = 0;
            this.Atsijungti.Text = "Atsijungti";
            this.Atsijungti.UseVisualStyleBackColor = true;
            this.Atsijungti.Click += new System.EventHandler(this.Atsijungti_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.išsaugoti);
            this.panel1.Controls.Add(this.Pavarde);
            this.panel1.Controls.Add(this.Vardas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 350);
            this.panel1.TabIndex = 2;
            // 
            // Pavarde
            // 
            this.Pavarde.Location = new System.Drawing.Point(39, 198);
            this.Pavarde.Name = "Pavarde";
            this.Pavarde.Size = new System.Drawing.Size(173, 22);
            this.Pavarde.TabIndex = 3;
            // 
            // Vardas
            // 
            this.Vardas.Location = new System.Drawing.Point(39, 74);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(173, 22);
            this.Vardas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Studento pavarde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studento vardas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Priskirti studentui dalyka";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // išsaugoti
            // 
            this.išsaugoti.Location = new System.Drawing.Point(114, 283);
            this.išsaugoti.Name = "išsaugoti";
            this.išsaugoti.Size = new System.Drawing.Size(176, 39);
            this.išsaugoti.TabIndex = 3;
            this.išsaugoti.Text = "Išsaugoti";
            this.išsaugoti.UseVisualStyleBackColor = true;
            this.išsaugoti.Click += new System.EventHandler(this.išsaugoti_Click);
            // 
            // Studentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Atsijungti);
            this.Name = "Studentas";
            this.Text = "Studentas";
            this.Load += new System.EventHandler(this.Studentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Atsijungti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Pavarde;
        private System.Windows.Forms.TextBox Vardas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button išsaugoti;
    }
}