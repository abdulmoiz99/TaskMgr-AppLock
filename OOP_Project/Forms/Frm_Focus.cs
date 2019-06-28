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
    public partial class Frm_Focus : Form
    {

        int time;
        public Frm_Focus()
        {
            InitializeComponent();
        }

        private void Frm_Focus_Activated(object sender, EventArgs e)
        {
            FormSetup.fillDgv(dgv_MostUsedApps, "SELECT DISTINCT stats_appname FROM Stats where Stats_Time>(SELECT AVG(Stats_Time)FROM Stats WHERE Stats_Month='" + Stats.currentMonth().ToString() + "');");
        }
        private void Frm_Focus_Load(object sender, EventArgs e)
        {
            txt_timer.BorderStyle = BorderStyle.None;
            txt_timer.Text = "00";
        }

        private void btn_Restric_Click(object sender, EventArgs e)
        {
            time = int.Parse(txt_timer.Text);
            if (rdo_min.Checked == true)
            {
                time = time * 60;
            }
            else if (rdo_hour.Checked == true)
            {
                time = time * 60 * 60;
            }

            if (lab_appName.Text != "App Name")
            {
                DialogResult YesOrNo = MessageBox.Show("Are You Sure To Restric " + lab_appName.Text + " For " + time + " Seconds Daily", "Focus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (YesOrNo == DialogResult.Yes)
                {
                    Focus NEW = new Focus(lab_appName.Text, time);
                    txt_timer.Text = "00";
                }
            }
            if (lab_appName.Text == "App Name")
            {
                MessageBox.Show("Please Select An App First", "Focus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_MostUsedApps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lab_appName.Text = "App Name";
                int index = e.RowIndex;
                DataGridViewRow selectedrow = dgv_MostUsedApps.Rows[index];
                lab_appName.Text = selectedrow.Cells[0].Value.ToString();
                if (lab_appName.Text != "App Name")
                {
                    chart.Series[0].Points.Clear();
                    Stats New = new Stats();
                    panel1.Visible = false;
                    chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
                    chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
                    chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                    for (int i = 0; i < 7; i++) { this.chart.Series["Time"].Points.AddXY(Days[i], (New.getStatsByDay(lab_appName.Text, Days[i]))/60); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            time++;
            txt_timer.Text = time.ToString();
        }
        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                txt_timer.Text = time.ToString();
            }
        }
    }
}
