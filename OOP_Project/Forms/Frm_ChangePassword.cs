using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project.Forms
{
    public partial class Frm_ChangePassword : Form
    {
        User User = new User();
        public Frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Dashboard NEW = new Frm_Dashboard();
            NEW.ShowDialog();
            this.Close();
        }

        private void Frm_ChangePassword_Load(object sender, EventArgs e)
        {
            lab_user.Text = AppObject.UserName;
            txt_OldPassword.Focus();
            
        }
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            if (User.checkPassword(AppObject.UserName,txt_OldPassword.Text)==true)
            {
                if (txt_newPassword.Text!=null)
                {
                    User.UpdatePassword(txt_newPassword.Text);
                    MessageBox.Show("Password Updated Successfully");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password","Password",  MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_OldPassword_Enter(object sender, EventArgs e)
        {
            txt_OldPassword.PasswordChar = '●';
        }

        private void txt_newPassword_TextChanged(object sender, EventArgs e)
        {
            txt_newPassword.PasswordChar = '●';
        }
    }
}
