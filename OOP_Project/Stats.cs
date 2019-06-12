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
        public Stats()
        {

        }
        public Stats(string appName)
        {
            base.Name = appName;
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
            base.Name = appName;
            t.Interval = 2000; // For accuracy
            t.Tick += new EventHandler(Stats_Timer);
            t.Start();
        }
        private void Stats_Timer(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Name).Length > 0)
            {
                try
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE stats SET stats_time = stats_time + 1 WHERE stats_AppName= '" + Name + "' AND stats_Date='" + DateTime.Now.ToShortDateString() + "'", con);
                    cmd.ExecuteNonQuery();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Stats");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Stats");
                }
            }
        }
        public override void setRecord(string Name)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO stats (Stats_AppName  , Stats_Time     ,  Stats_Date                              ,Stats_Day                       ,Stats_Month)
                                                            VALUES ('" + Name + "',      '0'  ,'" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.DayOfWeek + "','" + currentMonth() + "')", con);
                cmd.ExecuteNonQuery();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Stats");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stats");
            }
            startStats(Name);
        }
        public override bool CheckInList(string Name)
        {
            string CompareDateFromStats = "";
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM stats  WHERE stats_date = '" + DateTime.Now.ToShortDateString() + "' AND stats_appName='" + Name + "') THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END", con);
                CompareDateFromStats = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message, "Stats");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Stats");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stats"); ;
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
        public static string currentMonth()
        {
            int MonthNum = System.DateTime.Now.Month;
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(MonthNum);
            return monthName;
        }
        public int getStatsToday(string procName)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_Appname='" + procName + "' AND  stats_date='" + DateTime.Now.ToShortDateString() + "'", con);
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
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_Appname='" + procName + "'stats_day='" + Day + "' AND  stats_MONTH='" + currentMonth() + "'", con);
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
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_AppName='" + AppName + "'AND stats_Month='" + currentMonth() + "'", con);


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
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_appname='OOP_Project' AND stats_date='" + DateTime.Now.ToShortDateString() + "' ", con);
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
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT SUM(STATS_time) FROM Stats WHERE stats_appname='OOP_Project' AND stats_Month='" + currentMonth() + "' ", con);
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
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(stats_appname) FROM stats WHERE stats_date='" + DateTime.Now.ToShortDateString() + "'", con);
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
            int count = 0;
            string count1 = "0";
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Stats ", con);
                count1 = cmd1.ExecuteScalar().ToString();
                con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Stats");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message, "Stats");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stats");
            }
            count = int.Parse(count1);
            return count;
        }
    }

}
