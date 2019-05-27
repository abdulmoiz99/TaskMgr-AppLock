﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace OOP_Project
{
    class Lock : AppObject//: User
    {
        public Lock()
        {

        }
        Sql SQL = new Sql();
        string procName;
        string password;
        Timer t = new Timer();

        public string ProcName
        {
            get
            {
                return procName;
            }
            set
            {
                procName = value;
            }
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
            this.ProcName = procName;
            lockApp(procName);
            CheckLockStatus(procName);
        }
        public Lock(string procName, string Password)
        {
            this.Password = Password;
            this.ProcName = procName;
            User User = new User();
            if (User.checkPassword(Sql.userName, Password) == true)
            {
                Startapp(procName);
                Unlock(procName);
                t.Interval = 1000;
                t.Tick += new EventHandler(GiveAccess_Timer);
                t.Start();
            }
            else killApp(procName);
        }
        private void GiveAccess_Timer(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(ProcName).Length > 0)
            {
            }
            else
            {
                lockApp(ProcName);
            }
        }
        public void Unlock(string ProcName)
        {
            try
            {
                if (SQL.con.State == ConnectionState.Open)
                {
                    SQL.con.Close();
                }
                SQL.con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Lock SET L_Locked =  0 WHERE L_Name = '" + ProcName + "' AND L_User='" + Sql.userName + "'", SQL.con);
                cmd.ExecuteNonQuery();
                SQL.con.Close();
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
                if (SQL.con.State == ConnectionState.Open)
                {
                    SQL.con.Close();
                }
                SQL.con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Lock SET L_Locked = 1 WHERE L_Name = '" + procName + "' AND L_User='" + Sql.userName + "'", SQL.con);
                cmd.ExecuteNonQuery();
                SQL.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckLockStatus(String procName)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(CheckLockStatus_Timer);
            t.Start();
        }

        private void CheckLockStatus_Timer(object sender, EventArgs e)
        {
            string Lock;
            try
            {
                if (SQL.con.State == ConnectionState.Open)
                {
                    SQL.con.Close();
                }
                if (CheckAppList(procName) == true)
                {
                    SqlCommand cmd = new SqlCommand("Select L_locked from Lock where L_Name='" + ProcName + "' AND L_user ='" + Sql.userName + "'", SQL.con);
                    Lock = cmd.ExecuteScalar().ToString();
                    SQL.con.Close();
                    if (string.Compare("True", Lock) == 0)
                    {
                        foreach (Process proc in Process.GetProcessesByName(ProcName))
                        {
                            killApp(ProcName);
                            if (Process.GetProcessesByName(ProcName).Length > 0)
                            {
                                bool key = IsAlreadyOpen(typeof(Frm_Password));
                                if (key == false)
                                {
                                    Frm_Password NEW = new Frm_Password(ProcName);
                                    NEW.Show();
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool CheckAppList(String procName)
        {
            string Check = "";
            SQL.con.Open();
            SqlCommand cmd = new SqlCommand("	SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM Lock  WHERE L_Name = '" + procName + "' and L_User='" + Sql.userName + "') THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END", SQL.con);
            Check = cmd.ExecuteScalar().ToString();
            if (string.Compare("True", Check) == 0)
            {
                return true;
            }
            else return false;
        }
        public void killApp(string procName)
        {
            foreach (Process proc in Process.GetProcessesByName(procName))
            {
                try
                {
                    proc.Kill();
                }
                catch (Exception)
                {

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
                MessageBox.Show(ex.Message);
            }
        }
        public bool CheckAppLock(String ProcName)
        {
                String Lock = "";
            if (getCount() > 0)
            {
                SQL.con.Open();
                SqlCommand cmd1 = new SqlCommand("Select L_locked from Lock where L_Name='" + ProcName + "' AND L_user ='" + Sql.userName + "'", SQL.con);
               Lock = cmd1.ExecuteScalar().ToString();
                SQL.con.Close();

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
            SQL.con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Lock where L_user='"+Sql.userName+"'", SQL.con);
            string count1 = cmd1.ExecuteScalar().ToString();
            SQL.con.Close();
            int count = int.Parse(count1);
            return count;
        }

        public override string getAppName(int id)
        {
            string Name = "";
            try
            {
                if (SQL.con.State == ConnectionState.Open)
                {
                    SQL.con.Close();
                }
                SQL.con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT L_Name from Lock where L_id =" + id + " ", SQL.con);
                Name = cmd1.ExecuteScalar().ToString();
                SQL.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return Name;
        }
        public override void setRecord(String Name)
        {
            try
            {
                if (SQL.con.State == ConnectionState.Open)
                {
                    SQL.con.Close();
                }
                SQL.con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Lock (L_Name        ,L_Locked  , L_User)
                                                         VALUES ('" + Name + "',0         ,'" + Sql.userName + "')", SQL.con);
                cmd.ExecuteNonQuery();
                SQL.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
