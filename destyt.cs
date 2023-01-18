using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Drawing;

namespace Praktika
{
    public class Teacher
    {
        private string name;
        private string lname;

        public Teacher() { }

        public Teacher(string name, string lname)
        {
            Name = name;
            Lname = lname;

        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Lname
        {
            get { return lname; }
            set { lname = value; }
        }


        public void create(string teach_name, string teach_lname, string extra)
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `projektas`.`destytojas` (`naudotojo_ID`,`vardas`,`pavarde`) VALUES((SELECT naudotojo_ID FROM prisijungimas WHERE vardas = '" + teach_name + "'), '" + teach_name + "', '" + teach_lname + "');";

            cmd = DBHelper.Sql(query);
        }   

        public void user_create(string name, string lname, string type)
        {
            MySqlCommand cmd = null;
            string query = "INSERT INTO `projektas`.`prisijungimas` (`vardas`, `pavarde`, `Naudotojo_role`) VALUES ('" + name + "', '" + lname + "', '" + type + "');";
            cmd = DBHelper.Sql(query);


        }
    }
   }
