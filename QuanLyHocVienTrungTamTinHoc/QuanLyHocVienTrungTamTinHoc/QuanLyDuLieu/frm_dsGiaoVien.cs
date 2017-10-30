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
    public partial class frm_dsGiaoVien : Form
    {

        public frm_dsGiaoVien()
        {
            InitializeComponent();
        }

        private void listView_dsGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            new frm_themGV().ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            new frm_suaThongTinGV().ShowDialog();
        }

        private void frm_dsGiaoVien_Load(object sender, EventArgs e)
        {

        }

        private void listView_dsGV_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView_dsGV_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
