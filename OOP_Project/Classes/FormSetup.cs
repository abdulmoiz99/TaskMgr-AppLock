using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    sealed class FormSetup
    {
        public  void load_form(Form form_name, string form_title)//, string type)
        {
            string fname;
            try
            {
                fname = form_title;
                {
                    var withBlock = form_name;
                    withBlock.MdiParent = this;
                    // ChartControl1.Visible = False
                    // .MinimizeBox = False
                    // .MaximizeBox = False
                    withBlock.Dock = DockStyle.Fill;
                    withBlock.WindowState = FormWindowState.Maximized;
                    withBlock.Show();
                    withBlock.WindowState = FormWindowState.Maximized;
                    form_name.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void fillCombo(ComboBox combo, String TableName, String DisplayMember, String ValueMember, String Condition,String Key)//, List<T> Models, string Name, string Value)
        {
            try
            {
                if (AppObject.Con.State == ConnectionState.Open)
                {
                    AppObject.Con.Close();
                }
                AppObject.Con.Open();
                DataTable tb1 = new DataTable();
                SqlCommand cmd1 = new SqlCommand("select " + ValueMember + " , " + DisplayMember + " from " + TableName + " where " + Condition + " AND "+Key+"_User='" + AppObject.UserName + "'", AppObject.Con);
                SqlDataReader d1;
                d1 = cmd1.ExecuteReader();
                tb1.Load(d1);
                combo.DisplayMember = DisplayMember;
                combo.ValueMember = ValueMember;
                combo.DataSource = tb1;
                AppObject.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void fillDgv(DataGridView DataGridView,String Query)
        {
            try
            {
                if (AppObject.Con.State == ConnectionState.Open)
                {
                    AppObject.Con.Close();
                }
                AppObject.Con.Open();
                SqlCommand cmd2 = new SqlCommand(Query, AppObject.Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable ds = new DataTable();
                da.Fill(ds);
                DataGridView.DataSource = ds;
                AppObject.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "AppLock");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "AppLock");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AppLock");
            }
        }

        public static implicit operator Form(FormSetup v)
        {
            throw new NotImplementedException();
        }
    }
}
        //public void load_form(Form form_name, string form_title, string type)
        //{
        //    // if type f then form and if type r then report
        //    string fname;
        //    try
        //    {
        //        fname = form_title;
        //        // If Not CheckPermision(CInt(user_roleid), fname, "Access", type) Then
        //        // MessageBox.Show("ACCESS DENIED!  Please contact to system administrator..", "System Error", MessageBoxButtons.OK)
        //        // Exit Sub
        //        // End If
        //        // With...
        //        form_name.BringToFront();
        //        //   DockStyle.Fill.WindowState = FormWindowState.Maximized;
        //        // this.Dock = FormWindowState.Maximized;
        //        form_name.MdiParent = this;// FormWindowState.Maximized;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
