using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Frm_Performance : Form
    {
        public Frm_Performance()
        {
            InitializeComponent();
        }

        private void Frm_Performance_Load(object sender, EventArgs e)
        {
            //double TotalRam = double.Parse(HardwareInfo.GetPhysicalMemory());
            //PerformanceCounter availableBytes = new PerformanceCounter("Memory", "Available Bytes", true);
            //double AvailableRam = availableBytes.RawValue / 1024 / 1024; // Mb 
            //availableBytes.Close();
            //double UsedRam = TotalRam - AvailableRam;

            //this.chart1.Series["TotalRam"].Points.AddXY("Available", AvailableRam);
            //this.chart1.Series["TotalRam"].Points.AddXY("Used", UsedRam); 
            timer1_Tick(sender,e);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lisV_Apps.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    string[] arr = new string[2];
                    ListViewItem itm;
                    //add items to ListView
                    arr[0] = p.MainWindowTitle;
                    arr[1] = p.ProcessName;
                    itm = new ListViewItem(arr);
                    lisV_Apps.Items.Add(itm);
                }
            }

            lisV_Process.Items.Clear();
            Process[] processlist = Process.GetProcesses();
            foreach (Process p in processlist)
            {
                string[] arr = new string[2];
                ListViewItem itm;
                arr[0] = p.ProcessName;
                arr[1] = (p.PagedMemorySize64 / 1024 / 1024).ToString() + " MB";
                if (arr[0] != "0")
                {

                }
                itm = new ListViewItem(arr);
                lisV_Process.Items.Add(itm);
            }
        }
        private void Frm_Performance_Activated(object sender, EventArgs e)
        {
        }
        private void chart2_Click(object sender, EventArgs e)
        {
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
        }
        private void lisV_Apps_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_endTask_Click(object sender, EventArgs e)
        {

        }
    }
}
