using System;
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
            lab_user.Text = AppObject.userName.ToUpper();
            try
            {
             //   CURRENTLY LOCKED APP
                if (AppObject.con.State == ConnectionState.Open)
                {
                    AppObject.con.Close();
                }
                AppObject.con.Open();
                SqlCommand cmd = new SqlCommand("select L_Name from Lock where L_locked=1", AppObject.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dgv_currentlyLocked.DataSource = ds;
                AppObject.con.Close();
                if (dgv_currentlyLocked.RowCount > 0)
                {
                    pnl_Lock.Visible = false;
                }
             //   FREQUENTLY USED APPS
                if (AppObject.con.State == ConnectionState.Open)
                {
                    AppObject.con.Close();
                }
                AppObject.con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT stats_appname FROM Stats where Stats_Time>(SELECT AVG(Stats_Time)FROM Stats WHERE Stats_Month='" + Stats.currentMonth() + "')", AppObject.con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable ds1 = new DataTable();
                da1.Fill(ds1);
                dgv_MostUsedApps.DataSource = ds1;
                AppObject.con.Close();
                if (dgv_MostUsedApps.RowCount > 0)
                {
                    pnl_FUsed.Visible = false;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Form INFO");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message, "Form INFO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form INFO");
            }
        }
    }
}
