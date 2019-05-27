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
        Sql SQL = new Sql();
        public Frm_Info()
        {
            InitializeComponent();
        }

        private void Frm_Info_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Info_Activated(object sender, EventArgs e)
        {
            lab_user.Text = Sql.userName.ToUpper();
            try
            {
                // CURRENTLY LOCKED APP 
                SQL.con.Open();
                SqlCommand cmd = new SqlCommand("select L_Name from Lock where L_locked=1", SQL.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dgv_currentlyLocked.DataSource = ds;
                SQL.con.Close();
                if (dgv_currentlyLocked.RowCount > 0)
                {
                    pnl_Lock.Visible = false;
                }
                // FREQUENTLY USED APPS  
                Stats Stats = new Stats();
                SQL.con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT stats_appname FROM Stats where Stats_Time>(SELECT AVG(Stats_Time)FROM Stats WHERE Stats_Month='" + Stats.currentMonth() +"')", SQL.con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable ds1 = new DataTable();
                da1.Fill(ds1);
                dgv_MostUsedApps.DataSource = ds1;
                SQL.con.Close();
                if (dgv_MostUsedApps.RowCount>0)
                {
                   pnl_FUsed.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lab_user_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_lock_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
