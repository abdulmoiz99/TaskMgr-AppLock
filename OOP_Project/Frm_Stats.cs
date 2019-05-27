using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Frm_Stats : Form
    {
        Stats STATS = new Stats();
        public Frm_Stats()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Stats_Load(object sender, EventArgs e)
        {
            btn_Daily_Click(sender, e);
            lab_ScreenTimeToday.Text = (STATS.getScreenTimeToday() / 60).ToString() + " mins today";
            lab_ScreenTimeMonth.Text = (STATS.getScreenTimeMonth() / 60).ToString() + " min this month";

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lisV_Apps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Daily_Click(object sender, EventArgs e)
        {
            // to setup chart   
            chart1.Series[0].Points.Clear();

            btn_Daily.BackColor = Color.AliceBlue;
            btn_Monthly.BackColor = Color.White;
            chart1.Series["Time"]["PieLabelStyle"] = "Disabled";
            Lock LOCK = new Lock();
            string Name = "";
            int count = LOCK.getCount();
            string[] arr = new string[2];
            int Time;
            lisV_Apps.Items.Clear();
            for (int i = 1; i <= count; i++)
            {
                Name = LOCK.getAppName(i);
                if (STATS.CheckInList(Name) == true)
                {

                    Time = STATS.getStatsToday(Name);
                    this.chart1.Series["Time"].Points.AddXY(Name, Time);
                    ListViewItem itm;
                    //add items to ListView
                    arr[0] = Name;
                    if (Time > 60)
                    {
                        arr[1] = (Time / 60).ToString() + " mins";
                    }
                    else arr[1] = (Time).ToString() + " sec";
                    itm = new ListViewItem(arr);
                    lisV_Apps.Items.Add(itm);
                }
            }

        }

        private void btn_Monthly_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            btn_Daily.BackColor = Color.White;
            btn_Monthly.BackColor = Color.AliceBlue; 



            // to setup chart 
            chart1.Series["Time"]["PieLabelStyle"] = "Disabled";
            Lock LOCK = new Lock();
            string Name = "";
            int count = LOCK.getCount();
            string[] arr = new string[2];
            int Time;
            lisV_Apps.Items.Clear();
            for (int i = 1; i <= count; i++)
            {
                Name = LOCK.getAppName(i);
                if (STATS.CheckInList(Name) == true)
                {
                    Time = STATS.getStatsbyCurrentMonth(Name);
                    if (Time > 60)
                    {
                        this.chart1.Series["Time"].Points.AddXY(Name, Time);
                        ListViewItem itm;
                        //add items to ListView
                        arr[0] = Name;
                        if (Time > 60)
                        {
                            arr[1] = (Time / 60).ToString() + " mins";
                        }
                        else arr[1] = (Time).ToString() + " sec";
                        itm = new ListViewItem(arr);
                        lisV_Apps.Items.Add(itm);
                    }
                }
            }

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
