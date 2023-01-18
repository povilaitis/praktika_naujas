using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Studentas : Form
    {
        private readonly Visi_studentai _parent;
        public string id, vardas, pavarde;
        public Studentas(Visi_studentai parent)
        {
            InitializeComponent();
            _parent = parent;
            
        }
       

        public void UpdateInfo()
        {
            išsaugoti.Text = "Atnaujinti";
            Vardas.Text = vardas;
            Pavarde.Text = pavarde;
        }
      
        public void Clear()
        {
            Vardas.Text = Pavarde.Text = string.Empty;
        }

        private void perzvelgti_Click(object sender, EventArgs e)
        {
            Visi_studentai all = new Visi_studentai();
            all.Show();
        }

        private void Studentas_Load(object sender, EventArgs e)
        {

        }

        private void išsaugoti_Click(object sender, EventArgs e)
        {
            if (Vardas.Text.Trim().Length < 3)
            {
                MessageBox.Show("Studento vardas netinkamas");
                return;
            }
            if (Pavarde.Text.Trim().Length < 1)
            {
                MessageBox.Show("Studento pavarde netinkama");
                return;
            }
            if (išsaugoti.Text == "Išsaugoti")
            {
                Student std = new Student(Vardas.Text.Trim(), Pavarde.Text.Trim());
               
                StudentoDB.PridetVartot_stud(std.Vardas, std.Pavarde);
                StudentoDB.PridetiStud(std.Vardas, std.Pavarde);
                Clear();
            }

            if (išsaugoti.Text == "Atnaujinti")
            {
                Student std = new Student(Vardas.Text.Trim(), Pavarde.Text.Trim());
               
            }
            
        }

      

      
        private void Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
