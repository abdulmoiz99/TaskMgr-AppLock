﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    abstract class AppObject
    {
        private string name;// appname or username 
        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
        public abstract int getCount();
        public virtual string getAppName(int id)
        {
            return Name;
        }
        public virtual void setRecord(String Name)
        {
            // INSERT INTO TABLE
        }
        public virtual void setRecord(String Name, int time)
        {
            // INSERT INTO TABLE
        }
        public virtual bool CheckInList(String Name)
        {
            // check Whether the app or user is in record or not
            return false;
        }
        protected void KillApp(String Name)
        {
            foreach (Process proc in Process.GetProcessesByName(Name))
            {
                try
                {
                    proc.Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "");
                }
            }
        }
        // SQL setting and connection setup
        public static SqlConnection con = new SqlConnection(ReadCS());
        public static string userName = string.Empty;
        public static string ReadCS()
        {
            using (var streamReader = File.OpenText("SqlSettings.dat"))
            {
                var lines = "";
                try
                {
                    lines = streamReader.ReadToEnd();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "App Object");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "User");
                }
                return lines;
            }
        }
    }
}