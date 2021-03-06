﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Project.Forms;

namespace OOP_Project
{
    public partial class Frm_Info : Form
    {

        public Frm_Info()
        {
            InitializeComponent();
        }
        private void Frm_Info_Activated(object sender, EventArgs e)
        {
            
        }

        private void Frm_Info_Load(object sender, EventArgs e)
        {
            lab_user.Text = AppObject.UserName.ToUpper();
             //   CURRENTLY LOCKED APP
            FormSetup.fillDgv(dgv_currentlyLocked, "select L_Name from Lock where L_locked=1 and L_User='"+AppObject.UserName+"'");
            if (dgv_currentlyLocked.RowCount > 0)
            {
                pnl_Lock.Visible = false;
            }
            //   FREQUENTLY USED APPS
            FormSetup.fillDgv(dgv_MostUsedApps, "SELECT DISTINCT stats_appname FROM Stats where Stats_Time>(SELECT AVG(Stats_Time)FROM Stats WHERE Stats_Month='" + Stats.currentMonth() + "')");
            if (dgv_MostUsedApps.RowCount > 0)
            {
                pnl_FUsed.Visible = false;
            }
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            //this.Hide();
          //  Frm_Dashboard.ActiveForm.Disposed += new EventHandler(Frm_Dashboard.Close);
            Frm_ChangePassword NEW = new Frm_ChangePassword();
            NEW.ShowDialog();
           // this.Close();
        }
    }
}
