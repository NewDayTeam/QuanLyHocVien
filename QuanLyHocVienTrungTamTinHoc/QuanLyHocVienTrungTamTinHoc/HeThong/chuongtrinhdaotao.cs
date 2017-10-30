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
    public partial class chuongtrinhdaotao : Form
    {
        SqlConnection conet;
        public chuongtrinhdaotao()
        {
            InitializeComponent();
            string s = @"Data Source=DESKTOP-0U8HQ4G\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;Integrated Security=True";
            conet = new SqlConnection(s);
        }

        private void chuongtrinhdaotao_Load(object sender, EventArgs e)
        {
            
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_LOAD_Click(object sender, EventArgs e)
        {
            conet.Open();
            string query = "set dateformat dmy SELECT STT,NGAYDANG,LOAIDAOTAO,NOIDUNG  from CHUONGTRINH";
            SqlCommand cmd = new SqlCommand(query, conet);

            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            this.listView1.Items.Clear();
            while (rd.Read())
            {


                ListViewItem itmem = new ListViewItem(rd["STT"].ToString());
                itmem.SubItems.Add(rd["NGAYDANG"].ToString());
                itmem.SubItems.Add(rd["LOAIDAOTAO"].ToString());
                itmem.SubItems.Add(rd["NOIDUNG"].ToString());
               
                this.listView1.Items.Add(itmem);

            }
         
          conet.Close();
        }
    }
}
