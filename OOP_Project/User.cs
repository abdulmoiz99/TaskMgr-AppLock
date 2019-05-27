using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    class User:AppObject
    {
        Sql SQL = new Sql();
        private string name;
        private string email;
        private string password;
        private string cnfrmPassword;
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string CnfrmPassword
        {
            get { return cnfrmPassword; }
            set { cnfrmPassword = value; }
        }
        public User()
        {

        }
        public User(String name, string email, string password, string cnfrmPassword)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.CnfrmPassword = cnfrmPassword;
            if (matchPassword(password, cnfrmPassword) ==true)
            {
                if (CheckInList(name)==false)
                {

                SQL.con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO userinfo (UIN_username  ,UIN_email     ,  UIN_password   ,      UIN_CPassword    )
                                                        VALUES ('" + name + "'  , '" + email + "'  ,'" + password + "','" + cnfrmPassword + "')", SQL.con);
                cmd.ExecuteNonQuery();
                SQL.con.Close();
                }
            }
           
        } 
        private void createUser(string name)
        {
           
        }
        private bool matchPassword(string password, string cnfrmPassword)
        {
            if (string.Compare(password, cnfrmPassword) == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Password does not match");
                return false;
            }
        }
        public override bool CheckInList(string Name)
        {
            string CompareDateFromStats = "";
            try
            {
                SQL.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM userinfo  WHERE UIN_username = '" + name + "' ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END", SQL.con);
                CompareDateFromStats = cmd.ExecuteScalar().ToString();
                SQL.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (string.Compare("True", CompareDateFromStats) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
        public bool checkPassword(string name, string password)
        {
            string oPassword = "";
            try
            {
                SQL.con.Open();
                SqlCommand cmd = new SqlCommand("Select UIN_password from userinfo where UIN_username='" + name + "'", SQL.con);
                oPassword = cmd.ExecuteScalar().ToString();
                SQL.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (string.Compare(password, oPassword) == 0)
            {
                Sql.userName = name;
                return true;
            }
            else
            {
                return false;
            }

        }
        public void UpdatePassword(string newPassword)
        {
            try
            {
                SQL.con.Open();
                SqlCommand cmd = new SqlCommand("update UserInfo set UIN_Password='" + newPassword + "'where UIN_Username='" + Sql.userName + "'", SQL.con);
                cmd.ExecuteNonQuery();
                SQL.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override int getCount()
        {
            SQL.con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM UserInfo where L_user='" + Sql.userName + "'", SQL.con);
            string count1 = cmd1.ExecuteScalar().ToString();
            SQL.con.Close();
            int count = int.Parse(count1);
            return count;
        }
    }

}
