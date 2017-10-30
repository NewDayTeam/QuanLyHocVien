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
    public partial class frmhethong : Form
    {
      
        public frmhethong()
        {
            InitializeComponent();
            
           
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
            frmthaydoi frmthaydoi= new frmthaydoi();
            frmthaydoi.ShowDialog();
            this.Show();

        }

        private void saoLưuCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {


            this.Hide();
            chuongtrinhdaotao frmchuongtrinh = new chuongtrinhdaotao();
            frmchuongtrinh.ShowDialog();
            this.Show();
       
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmatkhau frmk = new frmmatkhau();
            frmk.ShowDialog();
            this.Close();
        }

        private void tạoMớiCớSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmquanlytaikhoan frmquanlytk = new frmquanlytaikhoan();
            frmquanlytk.ShowDialog();
            this.Show();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
              
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void frmhethong_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cậpNhậpLịchThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlichthi frmlichthi = new frmlichthi();
            frmlichthi.ShowDialog();
            this.Show();
        }

        private void sắpXếpPhòngThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmsxphongthi frmsxphongthi = new frmsxphongthi();
            frmsxphongthi.ShowDialog();
            this.Show();
        }

        private void xemLịchThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmxemlichthi xemlichthi = new frmxemlichthi();
            xemlichthi.ShowDialog();
            this.Show();
        }

        private void cậpNhậpĐiểmThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcndiemthi capnhapdt = new frmcndiemthi();
            capnhapdt.ShowDialog();
            this.Show();
        }

        private void danhSáchThíSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdsthitheophong dstheophong = new frmdsthitheophong();
            dstheophong.ShowDialog();
            this.Show();

        }

        private void hướngDẫnSửDụngChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmthongtin thongtin = new frmthongtin();
            thongtin.ShowDialog();
            this.Show();
        }
    }
}
