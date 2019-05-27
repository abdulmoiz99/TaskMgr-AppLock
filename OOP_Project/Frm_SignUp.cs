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
    public partial class Frm_SignUp : Form
    {
        public Frm_SignUp()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            User New = new User();
            if (New.CheckInList(txt_userName.Text) == false)
            {
                User NEW = new User(txt_userName.Text, txt_Email.Text, txt_password.Text, txt_confirmPassword.Text);
                MessageBox.Show("User Created Succesfully");
                this.Hide();
                Frm_Login NEW1 = new Frm_Login();
                NEW1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("UserName Already Taken", "Create Account");
            }
        }

        private void Frm_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login NEW = new Frm_Login();
            NEW.ShowDialog();
            this.Close();
        }
    }
}
