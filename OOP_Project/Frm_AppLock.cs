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

namespace OOP_Project
{
    public partial class Frm_AppLock : Form
    {
        Sql SQL = new Sql();
        public Frm_AppLock()
        {
            InitializeComponent();
        }

        private void Frm_AppLock_Load(object sender, EventArgs e)
        {

        }

        private void Frm_AppLock_Activated(object sender, EventArgs e)
        { // lock
            SQL.con.Open();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("select L_id,L_Name from Lock  where L_locked=0 AND L_User='" + Sql.userName + "'", SQL.con);
            SqlDataReader d;
            d = cmd.ExecuteReader();
            tb.Load(d);
            cmb_newLock.DisplayMember = "L_Name";
            cmb_newLock.ValueMember = "L_id";
            cmb_newLock.DataSource = tb;
            SQL.con.Close();

            // unlock
            SQL.con.Open();
            DataTable tb1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand("select L_id,L_Name from Lock where L_locked=1 AND L_User='" + Sql.userName + "'", SQL.con);
            SqlDataReader d1;
            d1 = cmd1.ExecuteReader();
            tb1.Load(d1);
            cmb_newUnlock.DisplayMember = "L_Name";
            cmb_newUnlock.ValueMember = "L_id";
            cmb_newUnlock.DataSource = tb1;
            SQL.con.Close();

            //datagrid view
            try
            {
                SQL.con.Open();
                SqlCommand cmd2 = new SqlCommand("select L_name from Lock where L_locked=1", SQL.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dgv_currentlyLocked.DataSource = ds;
                SQL.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dgv_currentlyLocked.RowCount > 0)
            {
                pnl_applock.Visible = false;
            }
        }

        private void btn_inLock_Click(object sender, EventArgs e)
        {
            Lock New = new Lock();
            MessageBox.Show(cmb_newUnlock.Text.ToString());
            New.Unlock(cmb_newUnlock.Text.ToString());
            //
            Frm_AppLock_Activated(sender, e);

        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = MessageBox.Show("Are You Sure To Lock " + cmb_newLock.Text + " ", "Lock", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (YesOrNo == DialogResult.Yes)
            {
                try
                {
                    Lock App = new Lock(cmb_newLock.Text.ToString());
                    Frm_AppLock_Activated(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
              
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}