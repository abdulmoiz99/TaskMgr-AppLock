using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace OOP_Project
{
    class Lock : AppObject
    {
        string password;
        Timer t = new Timer();
        public Lock()
        {
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public Lock(String procName)
        {
            base.Name = procName;
            lockApp(Name);
            CheckLockStatus(Name);
        }
        public Lock(string procName, string Password)
        {
            this.Password = Password;
            base.Name = procName;
            User User = new User();
            if (User.checkPassword(Sql.userName, Password) == true)
            {
                Startapp(Name);
                Unlock(Name);
                t.Interval = 1000;
                t.Tick += new EventHandler(GiveAccess_Timer);
                t.Start();
            }
            else KillApp(Name);
        }
        private void GiveAccess_Timer(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Name).Length > 0)
            {
            }
            else
            {
                lockApp(Name);
            }
        }
        public void Unlock(string ProcName)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Lock SET L_Locked =  0 WHERE L_Name = '" + ProcName + "' AND L_User='" + Sql.userName + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lockApp(String procName)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Lock SET L_Locked = 1 WHERE L_Name = '" + procName + "' AND L_User='" + Sql.userName + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CheckLockStatus(String procName)
        {
            base.Name = procName;
            t.Interval = 1000;
            t.Tick += new EventHandler(CheckLockStatus_Timer);
            t.Start();
        }
        private void CheckLockStatus_Timer(object sender, EventArgs e)
        {
            string Lock;
            try
            {
                if (CheckInList(Name) == true)
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select L_locked from Lock where L_Name='" + Name + "' AND L_user ='" + Sql.userName + "'", con);
                    Lock = cmd.ExecuteScalar().ToString();
                    con.Close();
                    if (string.Compare("True", Lock) == 0)
                    {
                        foreach (Process proc in Process.GetProcessesByName(Name))
                        {
                            KillApp(Name);
                            if (Process.GetProcessesByName(Name).Length > 0)
                            {
                                bool key = IsAlreadyOpen(typeof(Frm_Password));
                                if (key == false)
                                {
                                    Frm_Password NEW = new Frm_Password(Name);
                                    NEW.Show();
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lock");
            }
        }
        public override bool CheckInList(string Name)
        {
            string Check = "";
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("	SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM Lock  WHERE L_Name = '" + Name + "' and L_User='" + Sql.userName + "') THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END", con);
                Check = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lock");
            }
            if (string.Compare("True", Check) == 0)
            {
                return true;
            }
            else return false;
        }
        public void Startapp(String ProcName)
        {
            try
            {
                Process firstProc = new Process();
                firstProc.StartInfo.FileName = ProcName;
                firstProc.EnableRaisingEvents = true;
                firstProc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lock");
            }
        }
        public bool CheckAppLock(String ProcName)
        {
            String Lock = "";
            if (getCount() > 0)
            {
                try
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("Select L_locked from Lock where L_Name='" + ProcName + "' AND L_user ='" + Sql.userName + "'", con);
                    Lock = cmd1.ExecuteScalar().ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lock");
                }

            }
            if (string.Compare("True", Lock) == 0)
            {
                return true;
            }

            else return false;
        }
        private bool IsAlreadyOpen(Type formType)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == formType)
                {
                    f.BringToFront();
                    f.WindowState = FormWindowState.Normal;
                    f.BringToFront();
                    isOpen = true;
                }
            }
            return isOpen;
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
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Lock ", con);
                count1 = cmd1.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lock");
            }
            count = int.Parse(count1);
            return count;
        }
        public override string getAppName(int id)
        {
            string Name = "";
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT L_Name from Lock where L_id =" + id + " ", con);
                Name = cmd1.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lock");
            }
            return Name;
        }
        public override void setRecord(String Name)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Lock (L_Name        ,L_Locked  , L_User)
                                                         VALUES ('" + Name + "',0         ,'" + Sql.userName + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
