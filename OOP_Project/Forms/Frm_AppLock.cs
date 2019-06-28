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
    public partial class Frm_AppLock : Form
    {

        public Frm_AppLock()
        {
            InitializeComponent();
        }
        private void Frm_AppLock_Activated(object sender, EventArgs e)
        {
            // lock 
            FormSetup.fillCombo(cmb_newLock, "Lock", "L_Name", "L_id", "L_locked=0", "L");
            //Unlock
            FormSetup.fillCombo(cmb_newUnlock, "Lock", "L_Name", "L_id", "L_locked=1", "L");
            //datagrid view 
            FormSetup.fillDgv(dgv_currentlyLocked, "select L_name from Lock where L_locked=1");
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
                }

            }
        }
    }
}
