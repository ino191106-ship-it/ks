using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuongtrinhquanlykhachsan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "ta" && txtpassword.Text == "123")
            {

                labelerror.Visible = false;
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }else
            {
                labelerror.Visible = true;
                txtpassword.Clear();



            }

        }
    } 
}
