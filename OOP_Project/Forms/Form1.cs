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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Dashboard New = new Frm_Dashboard();
           // Frm_Login New = new Frm_Login();
            New.ShowDialog();
            this.Close();
            //Frm_Login New = new Frm_Login();
            //New.Show();
        }
    }
}
