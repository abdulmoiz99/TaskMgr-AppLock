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
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Focus SET F_CountLive = F_CountLive + 1 WHERE F_Name = '" + Name + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    else
                    {
                        RestricUse(Name);
                        MessageBox.Show(Name + " is restricted");
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

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select F_date from Focus where F_name='" + name + "'", con);
                    date = cmd.ExecuteScalar().ToString();
                    con.Close();

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
                ResetTimer(name);
                return false;
            }

        }
        private void UpdateDate(String procName)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Focus set F_date='" + DateTime.Now.ToShortDateString() + "' where f_Name='" + procName + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Focus");
            }
        }
        private bool TimerEqual(String procName)
        {
            string countLive;
            string countTime;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("select F_CountLive from Focus where F_name='" + procName + "'", con);
            countLive = cmd.ExecuteScalar().ToString();
            SqlCommand cmd1 = new SqlCommand("select F_CountTimer from Focus where F_name='" + procName + "'", con);
            countTime = cmd1.ExecuteScalar().ToString();
            con.Close();
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
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Focus set F_Countlive= 0 where f_Name='" + procName + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Focus");
            }
        }
        public override void setRecord(string Name, int time)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Focus (F_Name,F_CountLive,F_CountTimer,F_Date) values('" + Name + "',0," + time + ",'" + DateTime.Now.ToShortDateString() + "')", con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Focus");
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
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Focus;", con);
                count1 = cmd1.ExecuteScalar().ToString();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Focus");
            }
            count = int.Parse(count1);
            return count;
        }

        public override string getAppName(int id)
        {
            string Name = "";
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT F_Name from focus where F_id =" + id + "", con);
                Name = cmd1.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Name;
        }
    }
}
