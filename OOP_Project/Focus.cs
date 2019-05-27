using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    class Focus : AppObject// : Lock  kill app in restric use 
    {
        Sql SQL = new Sql();
        Timer t = new Timer();
        string procName;
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

        public string ProcName1
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

        public string AppName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Focus()
        {
        }
        public Focus(string procName)
        {
            this.ProcName1 = procName;
            StartTimer(procName);
        }
        public Focus(String procName, int time)
        {
            this.ProcName1 = procName;
            this.Time = time;
            setRecord(procName, time);
            StartTimer(procName);
        }
        private void SetFocus(String procName, int time)
        {
            try
            {

                SQL.con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Focus (F_Name,F_CountLive,F_CountTimer,F_Date) values('" + procName + "',0," + time + ",'" + DateTime.Now.ToShortDateString() + "')", SQL.con);
                cmd1.ExecuteNonQuery();
                SQL.con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void StartTimer(string procName)
        {
            this.ProcName1 = procName;
            t.Interval = 1000;
            t.Tick += new EventHandler(Update_Timer);
            t.Start();
        }
        private void Update_Timer(object sender, EventArgs e)
        {


            if (Process.GetProcessesByName(ProcName1).Length > 0)
            {
                if (CheckInList(ProcName1) == true)
                {
                    if (TimerEqual(ProcName1) == false)
                    {
                        if (SQL.con.State == ConnectionState.Open)
                        {
                            SQL.con.Close();
                        }
                        SQL.con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Focus SET F_CountLive = F_CountLive + 1 WHERE F_Name = '" + ProcName1 + "'", SQL.con);
                        cmd.ExecuteNonQuery();
                        SQL.con.Close();
                    }

                    else
                    {
                        RestricUse(ProcName1);
                        MessageBox.Show(ProcName1 + " is restricted");
                    }
                }
            }
            if (CheckInList(ProcName1) == false)
            {
                UpdateDate(ProcName1);

            }

        }
        public override bool CheckInList(string Name)// checkdate
        {
            string date = "";
            DateTime StartDate, EndDate;
            int differenceInDays = -1;
            if (getCount() > 0)
            {

                if (SQL.con.State == ConnectionState.Open)
                {
                    SQL.con.Close();
                }
                try
                {
                    SQL.con.Open();
                    SqlCommand cmd = new SqlCommand("select F_date from Focus where F_name='" + Name + "'", SQL.con);
                    date = cmd.ExecuteScalar().ToString();
                    SQL.con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Focus CheckDate");
                }
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
                ResetTimer(procName);
                return false;
            }

        }

        private void UpdateDate(String procName)
        {
            SQL.con.Open();
            SqlCommand cmd = new SqlCommand("Update Focus set F_date='" + DateTime.Now.ToShortDateString() + "' where f_Name='" + procName + "'", SQL.con);
            cmd.ExecuteNonQuery();
            SQL.con.Close();
        }
        private bool TimerEqual(String procName)
        {
            string countLive;
            string countTime;

            SQL.con.Open();
            SqlCommand cmd = new SqlCommand("select F_CountLive from Focus where F_name='" + procName + "'", SQL.con);
            countLive = cmd.ExecuteScalar().ToString();
            SqlCommand cmd1 = new SqlCommand("select F_CountTimer from Focus where F_name='" + procName + "'", SQL.con);
            countTime = cmd1.ExecuteScalar().ToString();
            SQL.con.Close();
            if (string.Compare(countLive, countTime) == 0)
            {
                return true;
            }
            else return false;
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
            SQL.con.Open();
            SqlCommand cmd = new SqlCommand("Update Focus set F_Countlive= 0 where f_Name='" + procName + "'", SQL.con);
            cmd.ExecuteNonQuery();
            SQL.con.Close();
        }


        public override void setRecord(string Name, int time)
        {
            try
            {

                SQL.con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Focus (F_Name,F_CountLive,F_CountTimer,F_Date) values('" + Name + "',0," + time + ",'" + DateTime.Now.ToShortDateString() + "')", SQL.con);
                cmd1.ExecuteNonQuery();
                SQL.con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public override int getCount()
        {
            if (SQL.con.State == ConnectionState.Open)
            {
                SQL.con.Close();
            }
            SQL.con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Focus;", SQL.con);
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
                SQL.con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT F_Name from focus where F_id =" + id + "", SQL.con);
                Name = cmd1.ExecuteScalar().ToString();
                SQL.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Name;
        }
    }
}
