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
            lab_TRam.Text = HardwareInfo.GetPhysicalMemory() + " MB";
            lab_ARam.Text = HardwareInfo.GetAvailableRAM().ToString() + " MB";
            lab_URam.Text = HardwareInfo.GetUsedRAM().ToString() + " MB";
        }
    }
}
