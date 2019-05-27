﻿using System;
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
    public partial class Frm_SystemInfo : Form
    {
        public Frm_SystemInfo()
        {
            InitializeComponent();
        }

        private void Frm_SystemInfo_Load(object sender, EventArgs e)
        {
            lab_userName.Text = HardwareInfo.GetAccountName();
            lab_manufacturer.Text = HardwareInfo.GetBIOSmaker();
            lab_deviceName.Text = HardwareInfo.GetComputerName();
            lab_GPU.Text = HardwareInfo.GetCPUManufacturer();
            lab_clockSpeed.Text = HardwareInfo.GetCpuSpeedInGHz().ToString();
            lab_ramSlot.Text = HardwareInfo.GetNoRamSlots();
            lab_windoesSpec.Text = HardwareInfo.GetOSInformation();
            lab_proccesor.Text = HardwareInfo.GetProcessorInformation();
            lab_macAddress.Text = HardwareInfo.GetMACAddress();





            // RAM            
            double TotalRam = double.Parse(HardwareInfo.GetPhysicalMemory());
            PerformanceCounter availableBytes = new PerformanceCounter("Memory", "Available Bytes", true);
            double AvailableRam = availableBytes.RawValue / 1024 / 1024; // Mb 
            availableBytes.Close();
            double UsedRam = TotalRam - AvailableRam;
            lab_TRam.Text = TotalRam.ToString() + " MB";
            lab_ARam.Text = AvailableRam.ToString() + " MB";
            lab_URam.Text = UsedRam.ToString() + " MB";

            //this.chart1.Series["TotalRam"].Points.AddXY("Available", AvailableRam);
            //this.chart1.Series["TotalRam"].Points.AddXY("Used", UsedRam);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void lab_proccesor_Click(object sender, EventArgs e)
        {

        }

        private void lab_macAddress_Click(object sender, EventArgs e)
        {

        }

        private void lab_GPU_Click(object sender, EventArgs e)
        {

        }

        private void lab_manufacturer_Click(object sender, EventArgs e)
        {

        }

        private void lab_clockSpeed_Click(object sender, EventArgs e)
        {

        }
    }
}