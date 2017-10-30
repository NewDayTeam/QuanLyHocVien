using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlytrungtam
{
    public partial class frm_thongKeSoLuong : Form
    {
        ListView viewHV = new ListView();
        ListView viewGV = new ListView();
        ListView viewMon = new ListView();
        ListView viewLop = new ListView();


        public frm_thongKeSoLuong()
        {
            InitializeComponent();
        }

        private void frm_thongKeSoLuong_Load(object sender, EventArgs e)
        {
            rButton_khoa.Checked = true;
            rButton_gvTrungTam.Checked = true;
            rButton_monCuaKhoa.Checked = true;
            rButton_slLopCuaKhoa.Checked = true;
            btn_xem.PerformClick();
        }

        private void rButton_khoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rButton_khoa.Checked)
            {
                viewHV = CreateListView("STT", "Khóa", "Số lượng học viên");
            }
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            
            this.tabControl.TabPages["tab_hocVien"].Controls.Remove(listView_hocVien);
            listView_hocVien = viewHV;
            this.tabControl.TabPages["tab_hocVien"].Controls.Add(listView_hocVien);

            this.tabControl.TabPages["tab_giaoVien"].Controls.Remove(listView_giaoVien);
            listView_giaoVien = viewGV;
            this.tabControl.TabPages["tab_giaoVien"].Controls.Add(listView_giaoVien);

            this.tabControl.TabPages["tab_monHoc"].Controls.Remove(listView_monHoc);
            listView_monHoc = viewMon;
            this.tabControl.TabPages["tab_monHoc"].Controls.Add(listView_monHoc);

            this.tabControl.TabPages["tab_lopHoc"].Controls.Remove(listView_lopHoc);
            listView_lopHoc = viewLop;
            this.tabControl.TabPages["tab_lopHoc"].Controls.Add(listView_lopHoc);

        }

        private ListView CreateListView(string colName1, string colName2, string colName3)
        {
            int col1_size = (int)(listView_hocVien.Size.Width * 0.2);
            int col2_size = (int)(listView_hocVien.Size.Width * 0.5);
            int col3_size = (int)(listView_hocVien.Size.Width * 0.3);

            ListView view = new ListView();
            view.Size = listView_hocVien.Size;
            view.Location = listView_hocVien.Location;
            view.Columns.Add(colName1, col1_size);
            view.Columns.Add(colName2, col2_size);
            view.Columns.Add(colName3, col3_size);
            view.View = View.Details;
            view.GridLines = true;
            return view;
        }

        private ListView CreateListView(string colName)
        {
            ListView view = new ListView();
            view.Size = listView_hocVien.Size;
            view.Location = listView_hocVien.Location;
            view.Columns.Add(colName, listView_hocVien.Size.Width);
            view.View = View.Details;
            view.GridLines = true;
            return view;
        }

        private ListView CreateListView(string colName1, string colName2, string colName3, string colName4)
        {
            int col1_size = (int)(listView_hocVien.Size.Width * 0.1);
            int col2_size = (int)(listView_hocVien.Size.Width * 0.25);
            int col3_size = (int)(listView_hocVien.Size.Width * 0.35);
            int col4_size = (int)(listView_hocVien.Size.Width * 0.3);

            ListView view = new ListView();
            view.Size = listView_hocVien.Size;
            view.Location = listView_hocVien.Location;
            view.Columns.Add(colName1, col1_size);
            view.Columns.Add(colName2, col2_size);
            view.Columns.Add(colName3, col3_size);
            view.Columns.Add(colName4, col4_size);
            view.View = View.Details;
            view.GridLines = true;
            return view;
        }

        private void rButton_mon_CheckedChanged(object sender, EventArgs e)
        {
            if (rButton_mon.Checked)
                viewHV = CreateListView("STT", "Môn", "Số lượng học viên");
        }

        private void tab_hocVien_Click(object sender, EventArgs e)
        {
        }

        private void rButton_lop_CheckedChanged(object sender, EventArgs e)
        {
            if (rButton_lop.Checked)
                viewHV = CreateListView("STT", "Lớp", "Số lượng học viên");
        }

        private void rButton_gvTrungTam_CheckedChanged(object sender, EventArgs e)
        {
            if (rButton_gvTrungTam.Checked)
            {
                viewGV = CreateListView("Số lượng giáo viên của trung tâm");
            }
        }

        private void rButton_gvMon_CheckedChanged(object sender, EventArgs e)
        {
            if (rButton_gvMon.Checked)
                viewGV = CreateListView("STT", "Môn", "Số lượng giáo viên");
        }

        private void rButton_monCuaGV_CheckedChanged(object sender, EventArgs e)
        {
            viewMon = CreateListView("STT", "Mã giáo viên", "Họ tên giáo viên", "Số lượng môn");
        }

        private void rButton_monCuaKhoa_CheckedChanged(object sender, EventArgs e)
        {
            viewMon = CreateListView("STT", "Khóa", "Số lượng môn");
        }

        private void rButton_slLopCuaKhoa_CheckedChanged(object sender, EventArgs e)
        {
            viewLop = CreateListView("STT", "Khóa", "Số lượng lớp");
        }

        private void rButton_slLopTungMon_CheckedChanged(object sender, EventArgs e)
        {
            viewLop = CreateListView("STT", "Môn", "Số lượng lớp");
        }

        private void rButton_slLopGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            viewLop = CreateListView("STT", "Mã giáo viên", "Họ tên giáo viên", "Số lượng lớp");
        }

    }
}
