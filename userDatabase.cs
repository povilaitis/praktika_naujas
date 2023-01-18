using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika.Properties;
using MySql.Data.MySqlClient;
using System.Data;

namespace Praktika
{
    public static class UsersDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static Users RetrieveUser(string username)
        {
            string query = "SELECT * FROM projektas.prisijungimas where vardas = (@username) limit 1";
            cmd = DBHelper.RunQuery(query, username);
            Users aUser = null;
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string uName = dr["vardas"].ToString();
                    string password = dr["pavarde"].ToString();
                    string type = dr["Naudotojo_role"].ToString();
                    aUser = new Users(uName, password, type);
                }
            }
            return aUser;
        }
    }
}
