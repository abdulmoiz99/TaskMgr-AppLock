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
        string name =string.Empty;
        public Frm_Password(string ProcName)
        {
            InitializeComponent();
            name = ProcName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = name;
            Lock NEW = new Lock(name, txt_Password.Text.ToString());
            this.Close();
        }

        private void Frm_Password_Load(object sender, EventArgs e)
        {
            label1.Text = name;
            txt_Password.Focus();
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '●';
        }
    }
}
