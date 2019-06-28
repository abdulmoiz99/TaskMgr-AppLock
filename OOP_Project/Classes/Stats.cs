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
using OOP_Project.Classes;
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
                SQL.NonScalarQuery("UPDATE stats SET stats_time = stats_time + 1 WHERE stats_AppName = '" + Name + "' AND stats_Date = '" + DateTime.Now.ToShortDateString() + "'");
            }
        }
        public override void setRecord(string Name)
        {
            SQL.NonScalarQuery(@"INSERT INTO stats (Stats_AppName  , Stats_Time     ,  Stats_Date                              ,Stats_Day                       ,Stats_Month)
                                                            VALUES ('" + Name + "',      '0'  ,'" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.DayOfWeek + "','" + currentMonth() + "')");
            startStats(Name);
        }
        public override bool CheckInList(string Name)
        {
            string CompareDateFromStats = "";
            CompareDateFromStats = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM stats  WHERE stats_date = '" + DateTime.Now.ToShortDateString() + "' AND stats_appName='" + Name + "') THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
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
            String Stats;
            Stats = SQL.ScalarQuery("SELECT SUM(STATS_time) FROM Stats WHERE stats_Appname='" + procName + "' AND  stats_date='" + DateTime.Now.ToShortDateString() + "'");
            if (Stats != "")
            {
                return int.Parse(Stats);

            }
            else
            {
                return 0;
            }
        }
        public int getStatsByDay(string procName, string Day)
        {
            string stats = "";
            stats = SQL.ScalarQuery("SELECT SUM(STATS_time) FROM Stats WHERE stats_Appname='" + procName + "' AND stats_day='"+Day+"' AND  stats_MONTH='" + currentMonth() + "'");
            if (stats != "")
            {
                return int.Parse(stats);

            }
            else
            {
                return 0;
            }
        }
        public int getStatsbyCurrentMonth(String AppName)
        {
            string stats = "";
            stats = SQL.ScalarQuery("SELECT SUM(STATS_time) FROM Stats WHERE stats_AppName='" + AppName + "'AND stats_Month='" + currentMonth() + "'");
            if (stats != "")
            {
                return int.Parse(stats);

            }
            else
            {
                return 0;
            }
        }
        public int getScreenTimeToday()
        {
            string stats = "";
            stats = SQL.ScalarQuery("SELECT SUM(STATS_time) FROM Stats WHERE stats_appname='OOP_Project' AND stats_date='" + DateTime.Now.ToShortDateString() + "' ");
            if (stats != "")
            {
                return int.Parse(stats);

            }
            else
            {
                return 0;
            }
        }
        public int getScreenTimeMonth()
        {
            string stats = "";
            stats = SQL.ScalarQuery("SELECT SUM(STATS_time) FROM Stats WHERE stats_appname='OOP_Project' AND stats_Month='" + currentMonth() + "' ");
            if (stats != "")
            {
                return int.Parse(stats);

            }
            else
            {
                return 0;
            }
        }
        public int getAppconutToday()
        {
            string stats = "";
            stats = SQL.ScalarQuery("SELECT COUNT(stats_appname) FROM stats WHERE stats_date='" + DateTime.Now.ToShortDateString() + "'");
            if (stats != "")
            {
                return int.Parse(stats);

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
            count1 = SQL.ScalarQuery("SELECT COUNT(*) FROM Stats ");
            count = int.Parse(count1);
            return count;
        }
    }

}
