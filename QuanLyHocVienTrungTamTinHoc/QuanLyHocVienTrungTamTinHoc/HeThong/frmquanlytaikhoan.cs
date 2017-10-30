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
    public partial class frmquanlytaikhoan : Form
    {
        SqlConnection conn;
        public frmquanlytaikhoan()
        {
            InitializeComponent();
            //string s = @"Data Source=DESKTOP-0U8HQ4G\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;Integrated Security=True";
            //conn = new SqlConnection(s);
            conn = new SqlConnection(ConnectionString.connectionString);
            fillcmb();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmquanlytaikhoan_Load(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
        }

        private void btn_capnhap_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "select * from QUANLYTAIKHOAN";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read;
            read = cmd.ExecuteReader();
            lst_DSTK.Items.Clear();
            while (read.Read())
            {
                ListViewItem itmem = new ListViewItem(read["Username"].ToString());
                //itmem.SubItems.Add(read["PASSWORD"].ToString());
                itmem.SubItems.Add(read["Chucvu"].ToString());
                this.lst_DSTK.Items.Add(itmem);


            }


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            //this.btn_capnhap.Enabled = true;
        }
        void fillcmb()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "select Chucvu from QUANLYTAIKHOAN";

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {

                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                //lst_DSTK.Items.Clear();
                while (rd.Read())
                {
                    string nameacount = rd["Chucvu"].ToString();
                    this.cmb_chucvu.Items.Add(nameacount);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }
   


        private void button1_Click(object sender, EventArgs e)
        {
          



                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();

                    }



                    string s = "select Username from QUANLYTAIKHOAN where Username='" + txt_taikhoan.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(s, conn);
                    SqlDataReader rd1;
                    rd1 = cmd1.ExecuteReader();
                    if (rd1.HasRows == true)
                    {
                        MessageBox.Show("Username đã tồn tại ");
                        return;

                    }
                    else
                    {
                        rd1.Close();

                    }
                    if (!string.IsNullOrEmpty(txt_taikhoan.Text) && !string.IsNullOrEmpty(txt_matkhau.Text) && !string.IsNullOrEmpty(txt_chucvu.Text))
                    {
                        string query = "insert into QUANLYTAIKHOAN (Username,PASSWORD,Chucvu) values (N'" + txt_taikhoan.Text + "','" + txt_matkhau.Text + "',N'" + txt_chucvu.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader rd;
                        rd = cmd.ExecuteReader();
                       // lst_DSTK.Items.Clear();

                        while (rd.Read())
                        {

                            ListViewItem itmemss = new ListViewItem();
                            itmemss.Text = rd["Username"].ToString();
                          //  itmemss.SubItems.Add(rd["PASSWORD"].ToString());
                            itmemss.SubItems.Add(rd["Chucvu"].ToString());
                            lst_DSTK.Items.Add(itmemss);


                        }
                        if (conn.State == ConnectionState.Open)
                        {

                            conn.Close();
                        }
                        MessageBox.Show("Thành công");
                       // lst_DSTK.Items.Clear();



                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu rỗng");
                        return;

                    }
                     



                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                
                txt_taikhoan.Text = "";
                txt_matkhau.Text = "";
                txt_chucvu.Text = "";
            
        }
       
        private void lst_DSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexx = lst_DSTK.SelectedIndices;
            foreach (int indes in indexx)
            {
                txt_taikhoan.Text = lst_DSTK.Items[indes].Text;
                //txt_matkhau.Text = lst_DSTK.Items[indes].SubItems[1].Text;
                cmb_chucvu.SelectedItem = lst_DSTK.Items[indes].SubItems[1].Text;

            }
        }
 

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                }
                if(lst_DSTK.FocusedItem !=null && lst_DSTK.FocusedItem.Index >=0)
                {

                    if (lst_DSTK.SelectedItems != null)
                    {
                        ListViewItem itmes = lst_DSTK.FocusedItem;
                        string query = "update QUANLYTAIKHOAN set Username=N'" + txt_taikhoan.Text + "' where Username='" + itmes.Text + "'";
                        SqlDataAdapter data = new SqlDataAdapter(query, conn);
                        DataTable table = new DataTable();
                        data.Fill(table);
                        

                      

                        

                    }
                }
                if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();

                    }
                     MessageBox.Show("Thành công");
            
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


                
                     
            
            
      
        
    }

               

           

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            ////try
            ////{
            ////    if (conn.State == ConnectionState.Closed)
            ////    {
            ////        conn.Open();

            ////    }

                    
            ////        string query = "delete from QUANLYTAIKHOAN where Username=N'"+txt_taikhoan.Text+ "'";
            ////        SqlCommand cmd = new SqlCommand(query, conn);
            ////        SqlDataReader rd;
            ////        rd = cmd.ExecuteReader();
            ////       // lst_DSTK.Items.Clear();
            ////        while (rd.Read())
            ////        {
            ////            ListViewItem item1 = this.lst_DSTK.FocusedItem;
            ////            this.lst_DSTK.Items.Remove(item1);

            ////        }



            ////    if (conn.State == ConnectionState.Open)
            ////    {
            ////        conn.Close();

            ////    }
            ////    MessageBox.Show("Xóa thành công");
              
                
            ////}
            ////catch (Exception ex)
            ////{
            ////    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ////}
            //this.txt_taikhoan.Text = "";
            //this.txt_matkhau.Text = "";
            //this.cmb_chucvu.Text = "";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "ADMIN" && textBox2.Text == "123")
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();

                    }


                    string query = "delete from QUANLYTAIKHOAN where Username=N'" + txt_taikhoan.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    // lst_DSTK.Items.Clear();
                    while (rd.Read())
                    {
                        ListViewItem item1 = this.lst_DSTK.FocusedItem;
                        this.lst_DSTK.Items.Remove(item1);

                    }



                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();

                    }
                    MessageBox.Show("Xóa thành công");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                this.txt_taikhoan.Text = "";
                this.txt_matkhau.Text = "";
                this.cmb_chucvu.Text = "";
               


            }
            else
            {

                MessageBox.Show("Bạn không phải là ADMIN, xóa không thành công");

            }
            textBox1.Text = "";
            textBox2.Text = "";

        }

       

      

      
    }
}
