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
    public partial class Frm_Active : Form
    {
        public Frm_Active()
        {
            InitializeComponent();
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
                    arr[0] = p.ProcessName;
                    arr[1] = p.MainWindowTitle;
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

        private void Frm_Active_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void lisV_Apps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lisV_Apps.SelectedItems.Count > 0)
            {
                ListViewItem item = lisV_Apps.SelectedItems[0];
                txt_activeTask.Text = item.SubItems[0].Text;
            }
        }

        private void btn_endTask_Click_1(object sender, EventArgs e)
        {
            if (txt_activeTask.Text != string.Empty)
            {
                foreach (Process proc in Process.GetProcessesByName(txt_activeTask.Text))
                {
                    try
                    {
                        proc.Kill();
                        txt_activeTask.Text = "";
                        timer1_Tick(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "");
                    }
                }
            }
        }
    }
}
