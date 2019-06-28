using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Frm_Password : Form
    {
        readonly string  name ="a";
        public Frm_Password(string ProcName)
        {
            InitializeComponent();
            name = ProcName;
            label1.Text = ProcName;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           // label1.Text = name;
            Lock NEW = new Lock(name, txt_Password.Text.ToString());
            this.Close();
        }

        private void Frm_Passeword_Load(object sender, EventArgs e)
        {
            txt_Password.Focus();
            btn_Unlock.FlatStyle = FlatStyle.Flat;
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '●';
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
