using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Praktika
{
    public static class StudentoDB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=root;database=projektas";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }
    

        public static void PridetiStud(string vardas, string pavarde)
        {
            MySqlCommand cmd = null;
    

            string sql = "INSERT INTO `projektas`.`studentas` (`naudotojo_ID`, `grupes_ID`, `Vardas`, `Pavarde`) VALUES ((select naudotojo_ID from prisijungimas where vardas='"+vardas+"), '1', '"+vardas+"', '"+pavarde+"');";

            cmd = DBHelper.Sql(sql);

          
            
        }

        public static void PridetVartot_stud(string vardas, string pavarde)
        {
            MySqlCommand cmd = null;
            string type = "studentas";

            string sql = "INSERT INTO `projektas`.`prisijungimas` (`vardas`, `pavarde`, `Naudotojo_role`) VALUES ('"+vardas+"', '"+pavarde+"', '"+type+"');";
            cmd = DBHelper.Sql(sql);

           
        }

    
        public static void DeleteStudent(string id)
        {
            string sql = "DELETE FROM student WHERE ID = @StudentID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Studentas pasalintas", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Studentas nepasalintas \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
