using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using OOP_Project.Classes;

namespace OOP_Project
{
    class Lock: AppObject
    {
        string password;
        Timer t = new Timer();
        public string Password
        {
            get
            { return password; }
            set
            { password = value; }
        }
        public Lock()
        {
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
            if (User.checkPassword(AppObject.UserName, Password) == true)
            {
                Startapp(Name);
                Unlock(Name);
                t.Interval = 1000;
                t.Tick += new EventHandler(GiveAccess_Timer);
                t.Start();
            }
            else
            {
                KillApp(Name);
            }
        }
        private void GiveAccess_Timer(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Name).Length > 0)
            {
            }
            else
            {
                lockApp(Name); t.Stop();            }
        }
        public void Unlock(string ProcName)
        {
            SQL.NonScalarQuery("UPDATE Lock SET L_Locked = 0 WHERE L_Name = '" + ProcName + "' AND L_User = '" + AppObject.UserName + "'");

        }
        private void lockApp(String procName)
        {
            //}
            SQL.NonScalarQuery("UPDATE Lock SET L_Locked = 1 WHERE L_Name = '" + procName + "' AND L_User='" + AppObject.UserName + "'");
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
            if (CheckInList(Name) == true)
            {
                Lock = SQL.ScalarQuery("Select L_locked from Lock where L_Name='" + Name + "' AND L_user ='" + AppObject.UserName + "'");
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
                Lock = SQL.ScalarQuery("Select L_locked from Lock where L_Name='" + ProcName + "' AND L_user ='" + AppObject.UserName + "'");
            }
            if (string.Compare("True", Lock) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        public override bool CheckInList(string Name)
        {
            string Check = "";
            Check = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM Lock  WHERE L_Name = '" + Name + "' and L_User='" + AppObject.UserName + "') THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");//cmd.ExecuteScalar().ToString();
            if (string.Compare("True", Check) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int getCount()
        {
            int count = 0;
            string count1 = "0";
            count1 = SQL.ScalarQuery("SELECT COUNT(*) FROM Lock where L_User='"+AppObject.UserName+"'");
            count = int.Parse(count1);
            return count;
        }
        public override string getAppName(int id)
        {
            string Name = "";
            Name = SQL.ScalarQuery("SELECT L_Name from Lock where L_id =" + id + " ANd  L_User='" + AppObject.UserName + "'");
            return Name;
        }
        public override void setRecord(String Name)
        {

            SQL.NonScalarQuery(@"INSERT INTO Lock (L_Name        ,L_Locked  ,              L_User        )
                                                         VALUES ('" + Name + "',          0  ,'" + AppObject.UserName + "')");
        }
    }
}
