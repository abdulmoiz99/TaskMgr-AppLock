using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OOP_Project
{
    class Stats : AppObject
    {
        Timer t = new Timer();
        Sql SQL = new Sql();

        private string appName;

        public string AppName
        {
            get { return appName; }
            set { appName = value; }
        }
        public Stats()
        {

        }
        public Stats(string appName)
        {
            this.AppName = appName;
            if (CheckInList(appName) == true)
            {
                startStats(appName);
            }
            if (CheckInList(appName) == false)
            {
                setRecord(appName);
                startStats(appName);
            }
        }
        public void startStats(string appName)
        {
            this.AppName = appName;
            t.Interval = 2000; // For accuracy
            t.Tick += new EventHandler(Stats_Timer);
            t.Start();
        }
        private void Stats_Timer(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(AppName).Length > 0)
            {
                try
                {

                    if (SQL.con.State == ConnectionState.Open)
                    {
                        SQL.con.Close();
                    }
                    SQL.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE stats SET stats_time = stats_time + 1 WHERE stats_AppName= '" + AppName + "' AND stats_Date='" + DateTime.Now.ToShortDateString() + "'", SQL.con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public override void setRecord(string Name)
        {
            try
            {
                if (SQL.con.State == ConnectionState.Open)
                {
                    SQL.con.Close();
                }
                SQL.con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO stats (Stats_AppName  , Stats_Time     ,  Stats_Date                              ,Stats_Day                       ,Stats_Month)
                                                            VALUES ('" + Name + "',      '0'  ,'" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.DayOfWeek + "','" + currentMonth() + "')", SQL.con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            startStats(appName);
        }
        public override bool CheckInList(string Name)
        {
            string CompareDateFromStats = "";
            try
            {
                if (SQL.con.State == ConnectionState.Open)
                {
                    SQL.con.Close();
                }
                SQL.con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM stats  WHERE stats_date = '" + DateTime.Now.ToShortDateString() + "' AND stats_appName='" + appName + "') THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END", SQL.con);
                CompareDateFromStats = cmd.ExecuteScalar().ToString();
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
        public string currentMonth()
        {
            int MonthNum = System.DateTime.Now.Month;
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(MonthNum);
            return monthName;
        }
        public int getStatsToday(string procName)
        {
            if (SQL.con.State == ConnectionState.Open)
            {
                SQL.con.Close();
            }
            SQL.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_Appname='" + procName + "' AND  stats_date='" + DateTime.Now.ToShortDateString() + "'", SQL.con);
            cmd.ExecuteScalar().ToString();
            if (cmd.ExecuteScalar().ToString() != "")
            {
                return int.Parse(cmd.ExecuteScalar().ToString());

            }
            else
            {
                return 0;
            }
        }
        public int getStatsByDay(string procName, string Day)
        {
            if (SQL.con.State == ConnectionState.Open)
            {
                SQL.con.Close();
            }
            SQL.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_Appname='" + procName + "'stats_day='" + Day + "' AND  stats_MONTH='" + currentMonth() + "'", SQL.con);
            cmd.ExecuteScalar().ToString();
            if (cmd.ExecuteScalar().ToString() != "")
            {
                return int.Parse(cmd.ExecuteScalar().ToString());

            }
            else
            {
                return 0;
            }
        }
        public int getStatsbyCurrentMonth(String AppName)
        {
            if (SQL.con.State == ConnectionState.Open)
            {
                SQL.con.Close();
            }
            SQL.con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_AppName='" + AppName + "'AND stats_Month='" + currentMonth() + "'", SQL.con);


            if (cmd1.ExecuteScalar().ToString() != "")
            {
                return int.Parse(cmd1.ExecuteScalar().ToString());
            }
            else
            {
                return 0;
            }

        }
        public int getScreenTimeToday()
        {
            if (SQL.con.State == ConnectionState.Open)
            {
                SQL.con.Close();
            }
            SQL.con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_appname='devenv' AND stats_date='" + DateTime.Now.ToShortDateString() + "' ", SQL.con);
            if (cmd1.ExecuteScalar().ToString() != "")
            {
                return int.Parse(cmd1.ExecuteScalar().ToString());
            }

            else
            {
                return 0;
            }



        }
        public int getScreenTimeMonth()
        {
            if (SQL.con.State == ConnectionState.Open)
            {
                SQL.con.Close();
            }
            SQL.con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_appname='devenv' AND stats_Month='" + currentMonth() + "' ", SQL.con);
            if (cmd1.ExecuteScalar().ToString() != "")
            {
                return int.Parse(cmd1.ExecuteScalar().ToString());
            }
            else
            {
                return 0;
            }


        }
        public int getAppConutToday()
        {
            if (SQL.con.State == ConnectionState.Open)
            {
                SQL.con.Close();
            }
            SQL.con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(stats_appname) FROM stats WHERE stats_date='" + DateTime.Now.ToShortDateString() + "'", SQL.con);
            if (cmd1.ExecuteScalar().ToString() != "")
            {
                return int.Parse(cmd1.ExecuteScalar().ToString());
            }

            else
            {
                return 0;
            }
        }

        public override int getCount()
        {
            SQL.con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Stats ", SQL.con);
            string count1 = cmd1.ExecuteScalar().ToString();
            SQL.con.Close();
            int count = int.Parse(count1);
            return count;
        }
    }

}
