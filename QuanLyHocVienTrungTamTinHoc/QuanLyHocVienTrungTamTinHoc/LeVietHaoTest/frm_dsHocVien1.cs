using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDuLieu
{
    public partial class frm_dsHocVien : Form
    {
        DataTable table = new DataTable();

        public frm_dsHocVien()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            table.Columns.Add("SST");
            table.Columns.Add("MSHV");
            table.Columns.Add("Họ đệm");
            table.Columns.Add("Tên");
            table.Columns.Add("Ngày sinh");
            table.Columns.Add("Địa chỉ");
            table.Columns.Add("SĐT");
            table.Columns.Add("Nghề nghiệp");

            table.Columns[0].AutoIncrement = true; //Auto increatement
            dataGridView_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateView(DataTable sourceTable, DataTable destTable)
        {
            destTable.Clear();
            foreach (DataRow row in sourceTable.Rows)
            {
                destTable.Rows.Add(null, row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
        }

        private void frm_dsHocVien_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM HOC_VIEN", ConnectionString.connectionString);
                DataTable tempTable = new DataTable();
                adap.Fill(tempTable);
                UpdateView(tempTable, table);
                dataGridView_view.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có sự cố trong quá trình tải dữ liệu");
                Console.WriteLine("Error: " + ex);
            }
        }

        private void frm_dsHocVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                MessageBox.Show("Q press");
        }

        private void frm_dsHocVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
