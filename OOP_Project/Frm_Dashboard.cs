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
    public partial class Frm_Dashboard : Form
    {
        Timer t = new Timer();
        public Frm_Dashboard()
        {
            InitializeComponent();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Lock_Click(object sender, EventArgs e)
        {
            PanelFloat.Height = btn_Lock.Height;
            PanelFloat.Top = btn_Lock.Top;
            Frm_AppLock NEW = new Frm_AppLock();
            NEW.MdiParent = this;
            NEW.Dock = DockStyle.Fill;
            NEW.Show();
        }
        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
           
            // ======To Start Focus=======
            var NEW = new Focus();
            int AppCount = NEW.getCount();
            if (AppCount > 0)
            {
                Focus[] F = new Focus[AppCount+1];
                for (int i = 1; i <= AppCount; i++)
                {
                    F[i] = new Focus(NEW.getAppName(i));
                }
            }
             //=============To start Lock===
            var NEW1 = new Lock();
            int appCountLock = NEW1.getCount();
            if (appCountLock > 0)
            {
                string Name;

                Lock[] L = new Lock[appCountLock + 1];
                for (int i = 1; i <= appCountLock; i++)
                {
                    Name = NEW1.getAppName(i);
                    if (NEW1.CheckAppLock(Name) == true)
                    {
                        L[i] = new Lock(Name);
                    }
                }

            }
            // to start stats
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    var STATS = new Stats(p.ProcessName);
                }
            }
            // for new record in stats
            t.Interval = 2000; // For accuracy
            t.Tick += new EventHandler(Stats_Timer);
            t.Start();
            // Blank form load
            btn_DashBoard_Click(sender, e);

        }
        private void Stats_Timer(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    Stats STATS = new Stats();
                    Lock LOCK = new Lock();
                    if (STATS.CheckApp(p.ProcessName) == false)
                    {
                        Stats NEW = new Stats(p.ProcessName);
                    }
                    if (LOCK.CheckAppList(p.ProcessName)==false)
                    {
                        LOCK.setRecord(p.ProcessName);
                    }

                }
            }
        }
        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            PanelFloat.Height = btn_DashBoard.Height;
            PanelFloat.Top = btn_DashBoard.Top;

            Frm_Info NEW = new Frm_Info();
            NEW.MdiParent = this;
            NEW.Dock = DockStyle.Fill;
            NEW.Show();
        }
        private void btn_Active_Click(object sender, EventArgs e)
        {
            PanelFloat.Height = btn_Active.Height;
            PanelFloat.Top = btn_Active.Top;
            Frm_Performance NEW = new Frm_Performance();
            NEW.MdiParent = this;
            NEW.Dock = DockStyle.Fill;
            NEW.Show();
        }

        private void btn_focus_Click(object sender, EventArgs e)
        {
            PanelFloat.Height = btn_focus.Height;
            PanelFloat.Top = btn_focus.Top;
            Frm_Focus NEW = new Frm_Focus();
            NEW.MdiParent = this;
            NEW.Dock = DockStyle.Fill;
            NEW.Show();
        }

        private void btn_AppUsage_Click(object sender, EventArgs e)
        {
            PanelFloat.Height = btn_AppUsage.Height;
            PanelFloat.Top = btn_AppUsage.Top;
            Frm_Stats NEW = new Frm_Stats();
            NEW.MdiParent = this;
            NEW.Dock = DockStyle.Fill;
            NEW.Show();

        }

        private void btn_AppLaunch_Click(object sender, EventArgs e)
        {
        }

        private void Panel_SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_systemInfo_Click(object sender, EventArgs e)
        {
            PanelFloat.Height = btn_systemInfo.Height;
            PanelFloat.Top = btn_systemInfo.Top;
            Frm_SystemInfo NEW = new Frm_SystemInfo();
            NEW.MdiParent = this;
            NEW.Dock = DockStyle.Fill;
            NEW.Show();
        }

        private void btn_Minimizesd_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
        private void Toppannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Dashboard_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login LOGIN = new Frm_Login();
            LOGIN.ShowDialog();
            this.Close();
        }
    }
}
