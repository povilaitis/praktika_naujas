namespace Praktika
{
    partial class Administratorius
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
            this.Destytojas = new System.Windows.Forms.Button();
            this.Studentas = new System.Windows.Forms.Button();
            this.Dalykas = new System.Windows.Forms.Button();
            this.Grupe = new System.Windows.Forms.Button();
            this.Atsijungti = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Destytojas
            // 
            this.Destytojas.Location = new System.Drawing.Point(32, 118);
            this.Destytojas.Name = "Destytojas";
            this.Destytojas.Size = new System.Drawing.Size(136, 54);
            this.Destytojas.TabIndex = 0;
            this.Destytojas.Text = "Destytojas";
            this.Destytojas.UseVisualStyleBackColor = true;
            this.Destytojas.Click += new System.EventHandler(this.Destytojas_Click);
            // 
            // Studentas
            // 
            this.Studentas.Location = new System.Drawing.Point(32, 200);
            this.Studentas.Name = "Studentas";
            this.Studentas.Size = new System.Drawing.Size(136, 49);
            this.Studentas.TabIndex = 1;
            this.Studentas.Text = "Studentas";
            this.Studentas.UseVisualStyleBackColor = true;
            this.Studentas.Click += new System.EventHandler(this.Studentas_Click);
            // 
            // Dalykas
            // 
            this.Dalykas.Location = new System.Drawing.Point(32, 274);
            this.Dalykas.Name = "Dalykas";
            this.Dalykas.Size = new System.Drawing.Size(136, 49);
            this.Dalykas.TabIndex = 1;
            this.Dalykas.Text = "Dalykas";
            this.Dalykas.UseVisualStyleBackColor = true;
            this.Dalykas.Click += new System.EventHandler(this.Dalykas_Click);
            // 
            // Grupe
            // 
            this.Grupe.Location = new System.Drawing.Point(32, 358);
            this.Grupe.Name = "Grupe";
            this.Grupe.Size = new System.Drawing.Size(136, 49);
            this.Grupe.TabIndex = 1;
            this.Grupe.Text = "Grupe";
            this.Grupe.UseVisualStyleBackColor = true;
            this.Grupe.Click += new System.EventHandler(this.Grupe_Click);
            // 
            // Atsijungti
            // 
            this.Atsijungti.BackColor = System.Drawing.Color.Red;
            this.Atsijungti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atsijungti.Location = new System.Drawing.Point(397, 7);
            this.Atsijungti.Name = "Atsijungti";
            this.Atsijungti.Size = new System.Drawing.Size(136, 49);
            this.Atsijungti.TabIndex = 1;
            this.Atsijungti.Text = "Atsijungti";
            this.Atsijungti.UseVisualStyleBackColor = false;
            this.Atsijungti.Click += new System.EventHandler(this.Atsijungti_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 92);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.Atsijungti);
            this.panel2.Location = new System.Drawing.Point(5, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 63);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(203, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 327);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "*Dalykas - prideti nauja dalyka";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Grupe - sukurti nuaja grupe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Studentas - prideti nauja studenta.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Destytojas - prideti nauja destytoja. ";
            // 
            // Administratorius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grupe);
            this.Controls.Add(this.Dalykas);
            this.Controls.Add(this.Studentas);
            this.Controls.Add(this.Destytojas);
            this.Name = "Administratorius";
            this.Text = "Administratorius";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Destytojas;
        private System.Windows.Forms.Button Studentas;
        private System.Windows.Forms.Button Dalykas;
        private System.Windows.Forms.Button Grupe;
        private System.Windows.Forms.Button Atsijungti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}