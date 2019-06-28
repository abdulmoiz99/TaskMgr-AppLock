using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Project.Classes;

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
        public User(String name, string email, string password)
        {
            base.Name = name;
            this.Email = email;
            this.Password = password;
            this.CnfrmPassword = cnfrmPassword;
            if (matchPassword(password, cnfrmPassword) == true)
            {
                if (CheckInList(name) == false)
                {
                    SQL.NonScalarQuery(@"INSERT INTO userinfo (UIN_username  ,UIN_email     ,  UIN_password    )
                                                        VALUES                  ('" + Name + "'  , '" + Email + "'  ,'" + Password + "')");
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
            Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM userinfo  WHERE UIN_username = '" + name + "' ) THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
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
            oPassword = SQL.ScalarQuery("Select UIN_password from userinfo where UIN_username='" + name + "'");
            if (string.Compare(password, oPassword) == 0)
            {
                AppObject.UserName = name;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdatePassword(string newPassword)
        {
            SQL.NonScalarQuery("update UserInfo set UIN_Password='" + newPassword + "'where UIN_Username='" + AppObject.UserName + "'");
        }
        public override int getCount()
        {
            int count = 0;
            string count1 = "0";
            count1 = SQL.ScalarQuery("SELECT COUNT(*) FROM UserInfo where L_user='" + AppObject.UserName + "'");
            count = int.Parse(count1);
            return count;
        }
    }

}
