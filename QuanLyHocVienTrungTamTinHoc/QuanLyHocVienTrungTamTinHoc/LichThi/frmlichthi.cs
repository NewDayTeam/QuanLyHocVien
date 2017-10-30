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
    public partial class frmlichthi : Form
    {
        SqlConnection conn;
        public frmlichthi()
        {
            InitializeComponent();
            string s = @"Data Source=DESKTOP-0U8HQ4G\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;Integrated Security=True";
            conn = new SqlConnection(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string s = "select MaMonHoc from XEPLICHTHI  where MaMonHoc='" + cmb_monhoc.SelectedItem.ToString() + "'";
                SqlCommand com1 = new SqlCommand(s, conn);
                SqlDataReader rd1;
                rd1 = com1.ExecuteReader();
                if (rd1.HasRows == true)
                {
                    MessageBox.Show("Môn học này đã học trong khóa học khác");
                    return;

                }
                else
                {
                    rd1.Close();
                }
                string query = "set dateformat dmy insert into XEPLICHTHI(MaKhoaHoc,MaMonHoc,TenMonHoc,NGTHI,GIOTHI,DIADIEM) values ('" + (cmb_khoahoc.SelectedItem.ToString()) + "','" + (cmb_monhoc.SelectedItem.ToString()) + "',N'"+txt_tenmon.Text + "','" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text + "',N'"+this.txt_diadiem.Text+"')";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {


                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Đọc thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void levave_comboxbox(object sender, EventArgs e)
        {
            if (cmb_khoahoc.SelectedItem == null)
            {
                MessageBox.Show("Vùi lòng chọn khóa học");
                return;
            }


        }
        private void levave_comboxbox1(object sender, EventArgs e)
        {
            if (this.cmb_monhoc.SelectedItem == null)
            {
                MessageBox.Show("Vùi lòng chọn môn học ");
                return;
            }


        }
        private void frmlichthi_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                }
                string query1 = "select MaMonHoc from MON_HOC ";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataReader rd1;
                rd1 = cmd1.ExecuteReader();
                while (rd1.Read())
                {
                    string load1 = rd1["MaMonHoc"].ToString();
                    this.cmb_monhoc.Items.Add(load1);
                    


                }
                rd1.Close();
                string query = "select  MaKhoaHoc from KHOA_HOC ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string load = rd["MaKhoaHoc"].ToString();
                    cmb_khoahoc.Items.Add(load);



                }
                



                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tg = DateTime.Now;
            string[] tg1 = tg.ToString("dd/MM/yyyy").Split('/');
            int[] a = Array.ConvertAll(tg1,int.Parse);
            string[] tg2 = this.dateTimePicker1.Text.Split('/');
            int[] b = Array.ConvertAll(tg2, int.Parse);
            DateTime ngayhientai = new DateTime(a[2], a[1], a[0]);
            DateTime ngaythi = new DateTime(b[2], b[1], b[0]);
            if (ngayhientai>ngaythi)
            {
                MessageBox.Show("Vui lòng nhập ngày thi lớn hơn ngày hiện tại ");
                return;
            }
        }

        private void txt_tenmon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
            if (e.Handled == true)
            {

                MessageBox.Show("Vui lòng nhập kí tự từ A-Z");
                return;
            }

        }
    }
}
