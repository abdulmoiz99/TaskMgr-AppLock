using System;
using Microsoft.VisualBasic.Devices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace OOP_Project
{
    public partial class Frm_Performance : Form
    {
        public Frm_Performance()
        {
            InitializeComponent();
            getDrive();
        }

        //Disk Management
        private void getDrive()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string item in drives)
            {
                Disk_comboBox.Items.Add(item.ToString());
            }
        }

     
        private void UpdateDiskInfo()
        {
            foreach (var series in Disk_chart.Series)
            {
                series.Points.Clear();
            }
            string getInfo = Disk_comboBox.SelectedItem.ToString();
            DriveInfo driveInfo = new DriveInfo(getInfo);
            string driveReady = driveInfo.IsReady.ToString();
            if (driveReady == "True")
            {
                string availableDriveSpace = driveInfo.AvailableFreeSpace.ToString();
                string totalDriveSpace = driveInfo.TotalSize.ToString();
                string driveType = driveInfo.DriveType.ToString();
                string usedDriveSpace = (driveInfo.TotalSize - driveInfo.AvailableFreeSpace).ToString();
                string driveFormat = driveInfo.DriveFormat.ToString();
                Disk_chart.Series["DiskUsage"].Points.AddXY("Free Space", availableDriveSpace);
                Disk_chart.Series["DiskUsage"].Points.AddXY("Used Space", usedDriveSpace);
                Drive_Ready_label.Text = "Drive Ready:      " + driveReady;
                Drive_Type_label.Text = "Drive Type:       " + driveType;
                Drive_Format_label.Text = "Drive Format:     " + driveFormat;
                Total_Space_label.Text = "Total Space:      " + (Convert.ToInt32(driveInfo.TotalSize * .000000001f)) + " GB";
                Used_Space_label.Text = "Used Space:       " + (Convert.ToInt32((driveInfo.TotalSize - driveInfo.AvailableFreeSpace) * .000000001f)) + " GB";
                Free_Space_label.Text = "Free Space:       " + (Convert.ToInt32(driveInfo.AvailableFreeSpace * .000000001f))+ " GB";
            }
            else
            {
                Drive_Ready_label.Text = "Drive Ready:      False";
                Drive_Type_label.Text = "Drive Type:       N/A";
                Drive_Format_label.Text = "Drive Format:     N/A";
                Total_Space_label.Text = "Total Space:      N/A";
                Used_Space_label.Text = "Used Space:       N/A";
                Free_Space_label.Text = "Free Space:       N/A";
            }
        }

        private void Frm_Performance_Load(object sender, EventArgs e)
        {
            //Disk
            Disk_comboBox.SelectedIndex = 0;

            //Ram
            float totalRam = myComputerInfo.TotalPhysicalMemory * 0.000001f;
            Total_RAM_label.Text = "Total RAM:     " + (Convert.ToUInt32(totalRam)).ToString() + " MB";

            //Cpu
            ManagementObjectSearcher mosProcessor = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject moProcessor in mosProcessor.Get())
            {
                if (moProcessor["NumberOfCores"] != null)
                    NoOfCore_label.Text = "Number of Cores: " + moProcessor["NumberOfCores"].ToString();
                if (moProcessor["name"] != null)
                    CPU_Name_label.Text = "Name: " + moProcessor["name"].ToString();
                if (moProcessor["manufacturer"] != null)
                    Manufacturer_label.Text = "Manufacturer: " + moProcessor["manufacturer"].ToString();
            }

            timer1_Tick(sender,e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetRamInfo();
            GetCPUInfo();
            lisV_Apps.Items.Clear();
            // stats1 Stats = new stats1();
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
     
        //RAM
        protected PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        ComputerInfo myComputerInfo = new ComputerInfo();

        public string getAvailableRAM()
        {
            return ramCounter.NextValue().ToString() + "Mb";
        }

        public void GetRamInfo()
        {
            float availableRam = ramCounter.NextValue();
            float totalRam = myComputerInfo.TotalPhysicalMemory * 0.000001f;
            float usedRam = totalRam - availableRam;
            float percentage = usedRam * 100 / totalRam;
            RAM_progressBar.Value = (int)percentage;
            RAM_Percentage_label.Text = ((int)percentage).ToString() + "%";
            Used_RAM_label.Text = "Used RAM:     " + usedRam + " MB";
            Free_RAM_label.Text = "Free RAM:      " + availableRam + " MB";
        }

        //CPU
        protected PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public string getCurrentCpuUsage()
        {
            return cpuCounter.NextValue() + "%";
        }

        public void GetCPUInfo()
        {
            CPU_progressBar.Value = (int)cpuCounter.NextValue();
            CPU_Percentage_label.Text = CPU_progressBar.Value.ToString() + "%";
        }

        private void Disk_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateDiskInfo();
        }
    }
}
