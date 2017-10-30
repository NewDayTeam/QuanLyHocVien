using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlytrungtam
{
    public partial class frmthaydoi : Form
    {
        SqlConnection conn;
        public frmthaydoi()
        {
            string s = @"Data Source=DESKTOP-0U8HQ4G\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;Integrated Security=True";
            conn = new SqlConnection(s);
            InitializeComponent();
        }

        private void txt_passnew_TextChanged(object sender, EventArgs e)
        {
            //this.Hide();
            //frmmatkhau frmmatkhau = new frmmatkhau();
            //frmmatkhau.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            if (this.txt_passold.Text.Trim() != "" && this.txt_passnew.Text.Trim() != "" && this.txt_twopassnew.Text.Trim() != "")
            {
                string query = "update QUANLYTAIKHOAN SET PASSWORD='" + txt_passnew.Text.Trim() + "' where PASSWORD='" + txt_passold.Text.Trim() + "' ";
                //câu lệnh là không gian để lấy dữ liệu 
                conn.Open();
                SqlDataAdapter data = new SqlDataAdapter(query, conn);
                DataTable tbl = new DataTable();
                data.Fill(tbl);
                conn.Close();

                this.Close();
            }
            else
            {
                MessageBox.Show("Vùi lòng nhập đủ dữ liệu");
                return;


            }
        }

        private void frmthaydoi_Load(object sender, EventArgs e)
        {

        }

        private void frmthaydoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thongbao;
            thongbao=MessageBox.Show("BẠN CÓ MUỐN THOÁT", "CHÚ Ý",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (thongbao == DialogResult.No)
                e.Cancel = true;
        }
    }
}
