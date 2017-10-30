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
    public partial class frmmatkhau : Form
    {
        SqlConnection con;
        public frmmatkhau() 
        {
            string s = @"Data Source=DESKTOP-0U8HQ4G\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;Integrated Security=True";
             con = new SqlConnection(s);
            InitializeComponent();
        }

        private void frmmatkhau_Load(object sender, EventArgs e)
        {


        }


        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(txt_username.Text)) && !(string.IsNullOrEmpty(txt_password.Text)))
                this.btn_login.Enabled = true;

                
      
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
            if (e.Handled == true)
            {
                MessageBox.Show("Vui lòng nhập kí tự từ A-Z");
                return;

            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (this.txt_username.Text.Trim().Length == 0)
            {
                this.lbl_notice.Visible = true;
                this.lbl_notice.Text = "Trường này không được bỏ trống";
                this.lbl_notice.ForeColor = Color.Red;
            }
            else
            {

                this.lbl_notice.Visible = false;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string query = "select * from QUANLYTAIKHOAN WHERE Username='" + txt_username.Text.Trim() + "' and PASSWORD='" + txt_password.Text.Trim() + "'";
            SqlDataAdapter data = new SqlDataAdapter(query, con);
            DataTable tbl = new DataTable();
            data.Fill(tbl);
            if (tbl.Rows.Count == 1)
            {
                this.Hide();
                frmhethong frmhethong = new frmhethong();
                frmhethong.ShowDialog();
                this.Show();

                

            }
            else
            {

                MessageBox.Show("PLEASE CHECK USERNAME AND PASSWORD ");
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
        }
        
    }
}
