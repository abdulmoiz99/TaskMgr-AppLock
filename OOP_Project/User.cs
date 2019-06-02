using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    class User : AppObject
    {
        private string email;
        private string password;
        private string cnfrmPassword;
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
            base.Name = name;
            this.Email = email;
            this.Password = password;
            this.CnfrmPassword = cnfrmPassword;
            if (matchPassword(password, cnfrmPassword) == true)
            {
                if (CheckInList(name) == false)
                {
                    try
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO userinfo (UIN_username  ,UIN_email     ,  UIN_password   ,      UIN_CPassword    )
                                                        VALUES                  ('" + Name + "'  , '" + Email + "'  ,'" + Password + "','" + CnfrmPassword + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL " + ex.Message, "User");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "User");
                    }
                }
            }
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
        public override bool CheckInList(string name)
        {
            string Compare = "";
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM userinfo  WHERE UIN_username = '" + name + "' ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END", con);
                Compare = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"User");
            }
            if (string.Compare("True", Compare) == 0)
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
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("Select UIN_password from userinfo where UIN_username='" + name + "'", con);
                oPassword = cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"User");
            }
            if (string.Compare(password, oPassword) == 0)
            {
                AppObject.userName = name;
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
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("update UserInfo set UIN_Password='" + newPassword + "'where UIN_Username='" + AppObject.userName + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"User");
            }
        }

        public override int getCount()
        {
            int count = 0;
            string count1 = "0";
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM UserInfo where L_user='" + AppObject.userName + "'", con);
                count1 = cmd1.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"User");
            }
            count = int.Parse(count1);
            return count;
        }
    }

}
