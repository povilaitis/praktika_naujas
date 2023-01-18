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
    public partial class Administratorius : Form
    {
        public Administratorius()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Destytojas_Click(object sender, EventArgs e)
        {
            Destytojas destytojas = new Destytojas();
            destytojas.Show();
        }

        private void Studentas_Click(object sender, EventArgs e)
        {
            Visi_studentai all = new Visi_studentai();
            all.Show();
        }

        private void Dalykas_Click(object sender, EventArgs e)
        {
            Dalykai dalykai = new Dalykai();
            dalykai.Show();
        }

        private void Grupe_Click(object sender, EventArgs e)
        {
            Grupe grupe = new Grupe();
            grupe.Show();
        }

        private void Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
