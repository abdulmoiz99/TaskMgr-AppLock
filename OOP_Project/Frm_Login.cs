using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
       
        private void btn_signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_SignUp NEW = new Frm_SignUp();
            NEW.ShowDialog();
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {

            User User = new User();

            if (User.CheckInList(txt_UserName.Text) == true)
            {
                if (User.checkPassword(txt_UserName.Text, txt_Password.Text) == true)
                {
                    Sql.userName = txt_UserName.Text;
                    this.Hide();
                    Frm_Dashboard NEW1 = new Frm_Dashboard();
                    NEW1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
            }
            else
            {
                MessageBox.Show("Username Doesn't Exist", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
           txt_UserName.Focus();
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            
           txt_Password.PasswordChar = '●';
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
