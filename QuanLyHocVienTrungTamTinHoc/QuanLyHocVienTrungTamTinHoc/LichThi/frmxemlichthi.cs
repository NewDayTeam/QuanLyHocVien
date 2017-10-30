using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace quanlytrungtam
{
    public partial class frmxemlichthi : Form
    {
        SqlConnection conn;
        public frmxemlichthi()
        {
            InitializeComponent();
            string s = @"Data Source=DESKTOP-0U8HQ4G\SQLEXPRESS;Initial Catalog=QL_HOCVIEN;Integrated Security=True";
            conn = new SqlConnection(s);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                    string query = "select * FROM XEPLICHTHI";
                    conn.Open();
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    dt.Fill(table);
                    dataGridView1.DataSource = table;
                    conn.Close();
         
                MessageBox.Show("Thành công ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmxemlichthi_Load(object sender, EventArgs e)
        {
            cmb_luachon.Items.Add("Mã khóa học");
            cmb_luachon.Items.Add("Mã môn thi");
            cmb_luachon.Items.Add("Tên môn thi");
        }

        private void txt_nhapmakhoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (cmb_luachon.Text == "Mã khóa học")
                { 
                    string query = "select * from XEPLICHTHI where  MaKhoaHoc LIKE '" + txt_nhapmakhoa.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    data.Fill(table);
                    dataGridView1.DataSource = table;

                }
                else
                    if (cmb_luachon.Text == "Mã môn thi")
                    {
                        string query = "select * from XEPLICHTHI where  MaMonHoc LIKE '" + txt_nhapmakhoa.Text + "%'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter data = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        data.Fill(table);
                        dataGridView1.DataSource = table;

                    }
                    else
                    {
                        string query = "select * from XEPLICHTHI where  TenMonHoc LIKE '" + txt_nhapmakhoa.Text + "%'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter data = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        data.Fill(table);
                        dataGridView1.DataSource = table;



                    }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            //Microsoft.Office.Interop.Excel._Application app= new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //worksheet.Name = "CustomerDetail";
            //for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[i, 1] = dataGridView1.Columns[i - 1].HeaderText;

            //}
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    for (int j = 0; j<dataGridView1.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //    }

            //}
            //var savefile = new SaveFileDialog();
            //savefile.FileName = "output";
            //savefile.DefaultExt = ".xlsx";
            //if (savefile.ShowDialog() == DialogResult.OK)
            //{
            //    workbook.SaveAs(savefile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                
            //}
            //app.Quit();
        }
    }
}
