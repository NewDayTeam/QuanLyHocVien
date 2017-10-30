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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
           
        }

        private void nhanHocVienMoi_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhanHocVienMoi frmChild = new frm_nhanHocVienMoi();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void dsHocVien_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dsHocVien frmChild = new frm_dsHocVien();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void dsGiaoVien_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dsGiaoVien frmChild = new frm_dsGiaoVien();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void dsLopHoc_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dsLopHoc frmChild = new frm_dsLopHoc();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void dsMonHoc_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dsMonHoc frmChild = new frm_dsMonHoc();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void giaoVien_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_timKiemGV frmChild = new frm_timKiemGV();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void hocVien_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_timKiemHV frmChild = new frm_timKiemHV();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void diemThi_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_traCuuKetQua frmChild = new frm_traCuuKetQua();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void thongKeSoLuong_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_thongKeSoLuong frmChild = new frm_thongKeSoLuong();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void thongKeKetQuaHT_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_thongKeKetQuaHocTap frmChild = new frm_thongKeKetQuaHocTap();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        
    }
}
