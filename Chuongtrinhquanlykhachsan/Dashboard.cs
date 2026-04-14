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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            useraddroom1.Visible = false;
            btnaddroom.PerformClick();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            psnelmoving.Left = btnaddroom.Left + 50;
            useraddroom1.Visible = true;
            useraddroom1.BringToFront();

        }

        private void useraddroom1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void useraddroom1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
