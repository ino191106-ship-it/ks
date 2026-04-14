using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuongtrinhquanlykhachsan.All_thông_tin
{
    public partial class Useraddroom : UserControl
    {
        function fn = new function();
        string query;
        public Useraddroom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Useraddroom_Load(object sender, EventArgs e)
        {
            query = "select * from room";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            if (txtroom.Text != "" && txtroomtype.Text != "" && txtbed.Text != "" && txtprice.Text != "")
            {
                string roomno = txtroom.Text;
                string roomtype = txtroomtype.Text;
                string bed = txtbed.Text;
                Int64 price = Int64.Parse(txtprice.Text);
                query = "insert into room (roomNo,roomType,bed,price) values('" + roomno + "','" + roomtype + "','" + bed + "'," + price + ")";
                fn.SetData(query, "Thêm phòng thành công");
                Useraddroom_Load(this, null);
                clearAll();
            }

        }
        public void clearAll()
        {
            txtroom.Clear();
            txtroomtype.SelectedIndex = -1;
            txtbed.SelectedIndex = -1;
            txtprice.Clear();
        }
    }
}