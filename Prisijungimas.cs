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
    public partial class Prisijungimas : Form
    {
        public Prisijungimas()
        {
            InitializeComponent();
            DBHelper.EstablishConnection();
        }



        private void Išeiti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prisijungimas_Load(object sender, EventArgs e)
        {

        }

        private void Prisijungti_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            Users aUser = UsersDA.RetrieveUser(username);
            if (aUser.Password.Equals(password))
            {
                if (aUser.Type.Equals("admin"))
                {
                    MessageBox.Show("Login Success");
                    Administratorius a = new Administratorius();
                    a.Show();
                }
                else if (aUser.Type.Equals("destytojas"))
                {

                    MessageBox.Show("Login Success");
                    Studentas d = new Studentas(null);
                    d.Show();

                }
                else if (aUser.Type.Equals("studentas"))
                {

                    MessageBox.Show("Login Success");
                    Studento_pazymiai s = new Studento_pazymiai();
                    s.Show();

                }
            }
            else
            {
                MessageBox.Show("Login Failed. Please try again");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Prisijungimas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
