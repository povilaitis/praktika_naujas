using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktika
{
    public partial class Destytojas : Form
    {
        public Destytojas()
        {
            InitializeComponent();
            DBHelper.EstablishConnection();
        }



        private void Atsijungti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Destytojas_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void Itraukti_Click(object sender, EventArgs e)
        {
            string name = Vardas.Text.ToString();
            string pavard = Pavarde.Text.ToString();

            Teacher dest = new Teacher(name, pavard);

            dest.user_create(dest.Name, dest.Lname, "destytojas");
            dest.create(dest.Name, dest.Lname, null);

        }

        void fill()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT * FROM projektas.destytojas;";

            cmd = DBHelper.Sql(query);

            dt = new DataTable();
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
