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

    public partial class frm_ketThuc : Form
    {
        frm_nhanHocVienMoi refForm;
        public frm_ketThuc(frm_nhanHocVienMoi frm)
        {
            refForm = frm;
            InitializeComponent();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            refForm.status = "Luu";
            this.Close();
        }

        private void btn_khongLuu_Click(object sender, EventArgs e)
        {
            refForm.status = "KhongLuu";
            this.Close();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            refForm.status = "Dong";
            this.Close();
        }

    }
}
