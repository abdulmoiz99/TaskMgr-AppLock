using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Project.Classes;

namespace OOP_Project
{
    class Focus : AppObject// : Lock  kill app in restric use 
    {
        Timer t = new Timer();
        int time;
        public int Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
        public Focus()
        {
        }
        public Focus(string procName)
        {
            base.Name = procName;
            StartTimer(procName);
        }
        public Focus(String procName, int time)
        {
            base.Name = procName;
            this.Time = time;
            setRecord(procName, time);
            StartTimer(procName);
        }
        private void StartTimer(string procName)
        {
            base.Name = procName;
            t.Interval = 1000;
            t.Tick += new EventHandler(Update_Timer);
            t.Start();
        }
        private void Update_Timer(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Name).Length > 0)
            {
                if (CheckInList(Name) == true)
                {
                    if (TimerEqual(Name) == false)
                    {
                        if (AppObject.Con.State == ConnectionState.Open)
                        {
                            Con.Close();
                        }
                        SQL.NonScalarQuery("UPDATE Focus SET F_CountLive = F_CountLive + 1 WHERE F_Name = '" + Name + "'");
                    }
                    else
                    {
                        RestricUse(Name);
                        MessageBox.Show(Name + " is restricted", "Daily Limit Exceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (CheckInList(Name) == false)
            {
                UpdateDate(Name);
            }
        }
        public override bool CheckInList(string name)//check date
        {
            string date = "";
            DateTime StartDate, EndDate;
            int differenceInDays = -1;
            if (getCount() > 0)
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                date = SQL.ScalarQuery("select F_date from Focus where F_name='" + name + "'");
                StartDate = Convert.ToDateTime(date);
                EndDate = System.DateTime.Now;
                TimeSpan ts = EndDate.Date - StartDate.Date;
                differenceInDays = ts.Days;  // This is in int 
            }
            if (differenceInDays == 0)
            {
                return true;
            }
            else
            {
                ResetTimer(name);
                return false;
            }
        }
        private void UpdateDate(String procName)
        {
            SQL.NonScalarQuery("Update Focus set F_date='" + DateTime.Now.ToShortDateString() + "' where f_Name='" + procName + "'");
        }
        private bool TimerEqual(String procName)
        {
            string countLive;
            string countTime;
            countLive = SQL.ScalarQuery("select F_CountLive from Focus where F_name='" + procName + "'");
            countTime = SQL.ScalarQuery("select F_CountTimer from Focus where F_name='" + procName + "'");
            if (string.Compare(countLive, countTime) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RestricUse(String procName)
        {
            if (CheckInList(procName) == true)
            {
                KillApp(procName);
            }
        }

        private void ResetTimer(string procName)

        {
            SQL.NonScalarQuery("Update Focus set F_Countlive= 0 where f_Name='" + procName + "'");
        }
        public override void setRecord(string Name, int time)
        {
            SQL.NonScalarQuery(@"insert into Focus (F_Name        ,F_CountLive,   F_CountTimer   ,F_user                   ,F_Date)
                                                              values('" + Name + "',    0,          " + time + ",   '" + AppObject.UserName + "','" + DateTime.Now.ToShortDateString() + "')");
        }
        public override int getCount()
        {
            int count = 0;
            string count1 = "0";
            count1 = SQL.ScalarQuery("SELECT COUNT(*) FROM Focus;");
            count = int.Parse(count1);
            return count;
        }

        public override string getAppName(int id)
        {
            string Name = "";
            Name = SQL.ScalarQuery("SELECT F_Name from focus where F_id =" + id + "");
            return Name;
        }
    }
}
