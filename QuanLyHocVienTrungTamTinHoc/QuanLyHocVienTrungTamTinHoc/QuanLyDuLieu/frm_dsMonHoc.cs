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
    public partial class frm_dsMonHoc : Form
    {
        public frm_dsMonHoc()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            new frm_themMonHoc().ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            new frm_suaThongTinMonHoc().ShowDialog();
        }

    }
}
