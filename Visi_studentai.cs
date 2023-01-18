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
    public partial class Visi_studentai : Form
    {
        Studentas studentas;
        public Visi_studentai()
        {
            InitializeComponent();
            studentas = new Studentas(this);
        }
        public void Display()
        {
            StudentoDB.DisplayAndSearch("SELECT ID, Vardas, Pavarde FROM studentas", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) 
            {
                studentas.Clear();
                studentas.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                studentas.vardas = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                studentas.pavarde = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                studentas.UpdateInfo();
                studentas.ShowDialog();
                return;

            }


            if (e.ColumnIndex == 6) 
            {
                if (MessageBox.Show("Ar tikrai norite pašalinti studentą?", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    StudentoDB.DeleteStudent(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                    Display();
                }
                return;

            }
        }

        private void Visi_studentai_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void Visi_studentai_Load(object sender, EventArgs e)
        {

        }

        private void prideti_Click(object sender, EventArgs e)
        {

            studentas.Clear();
            studentas.ShowDialog();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            StudentoDB.DisplayAndSearch("SELECT ID, Vardas, Pavarde FROM student WHERE Vardas LIKE '%" + search.Text + "%'", dataGridView1);
        }
    }
}
