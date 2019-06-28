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
                Free_Space_label.Text = "Free Space:       " + (Convert.ToInt32(driveInfo.AvailableFreeSpace * .000000001f)) + " GB";
            }
            else
            {
                Drive_Ready_label.Text =    "Drive Ready    :   False";
                Drive_Type_label.Text  =    "Drive Type     :   N/A";
                Drive_Format_label.Text =   "Drive Format   :   N/A";
                Total_Space_label.Text =    "Total Space    :   N/A";
                Used_Space_label.Text =     "Used Space     :   N/A";
                Free_Space_label.Text =     "Free Space     :   N/A";
            }
        }
        private void Frm_Performance_Load(object sender, EventArgs e)
        {
            //Disk
            Disk_comboBox.SelectedIndex = 0;

            //Ram
            Total_RAM_label.Text = "Total RAM:     " + HardwareInfo.GetPhysicalMemory() + " MB";

            //Cpu
            CPU_Name_label.Text = "Name: " + HardwareInfo.GetProcessorInformation();
            Manufacturer_label.Text = "Manufacturer: " + HardwareInfo.GetBIOSmaker();
            NoOfCore_label.Text = "Number of Cores: " + HardwareInfo.GetNoOfCPUCores();

            timer1_Tick(sender, e);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetRamInfo();
            GetCPUInfo();
        }
        public void GetRamInfo()
        {
            double percentage = HardwareInfo.GetUsedRAM() * 100 / double.Parse(HardwareInfo.GetPhysicalMemory());
            RAM_progressBar.Value = (int)percentage;
            RAM_Percentage_label.Text = ((int)percentage).ToString() + "%";
            Used_RAM_label.Text = "Used RAM:      " + HardwareInfo.GetUsedRAM().ToString() + " MB";
            Free_RAM_label.Text = "Free RAM:      " + HardwareInfo.GetAvailableRAM().ToString() + " MB";
        }
        //CPU
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
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
