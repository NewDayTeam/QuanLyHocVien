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

namespace quanlytrungtam
{
    public partial class frm_nhanHocVienMoi : Form
    {
        public string status = "";
        List<object> container = new List<object>();

        public frm_nhanHocVienMoi()
        {
            InitializeComponent();
            container.AddRange(new object[] {cbo_khoa, cbo_nam, txt_ngayDangKi, txt_hoTen, txt_ngaySinh, txt_diaChi, txt_soDienThoai,
                txt_ngheNghiep, cbo_monHoc, cbo_lop, cbo_buoi, cbo_ca, txt_hocPhi, rButton_noHocPhi, txt_conNo, rButton_giamHocPhi, 
                txt_duocGiam, rButton_mienHocPhi});
           
        }

        private void frm_nhanHocVienMoi_Load(object sender, EventArgs e)
        {
            //Fill data for cbo_khoa
            Utilities.FillDataToComboBox(cbo_khoa, ConnectionString.connectionString, "SELECT * FROM KHOA_HOC", "TenKhoaHoc", "MaKhoaHoc");
            //Fill data for cbo_monHoc
            Utilities.FillDataToComboBox(cbo_monHoc, ConnectionString.connectionString, "SELECT * FROM MON_HOC", "TenMonHoc", "MaMonHoc");
            //Fill data for cbo_lop
            Utilities.FillDataToComboBox(cbo_lop, ConnectionString.connectionString, "SELECT * FROM LOP_HOC", "MaLopHoc", "MaLopHoc");
            //Fill data for cbo_ca
            Utilities.FillDataToComboBox(cbo_ca, ConnectionString.connectionString, "SELECT * FROM CA_HOC", "MaCaHoc", "MaCaHoc");
            //Fill data for cbo_buoi
            Utilities.FillDataToComboBox(cbo_buoi, ConnectionString.connectionString, "SELECT DISTINCT BUOI FROM CA_HOC", "Buoi", "Buoi");

            
        }

        
        private void groupBox_dangKi_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_thongTinCaNhan_Enter(object sender, EventArgs e)
        {

        }

        private void frm_nhanHocVienMoi_Click(object sender, EventArgs e)
        {

        }



        private void btn_luu_Click(object sender, EventArgs e)
        {
            //
            SqlConnection conn = new SqlConnection();
            SqlTransaction trans = null;
            SqlCommand cmd;

            try
            {
                conn.ConnectionString = ConnectionString.connectionString;
                conn.Open();
                trans = conn.BeginTransaction();

                //Insert into BIEN_LAI
                int mabl = Utilities.TaoMaBienLai();
                cmd = new SqlCommand("SET DATEFORMAT DMY; INSERT INTO BIEN_LAI VALUES (@mabl, @ngaybl, 'N/A', @sotien, @bangchu)", conn, trans);
                cmd.Parameters.AddWithValue("@mabl", mabl);
                cmd.Parameters.AddWithValue("@ngaybl", txt_ngayDangKi.Text);
                cmd.Parameters.AddWithValue("@sotien", int.Parse(txt_hocPhi.Text));
                cmd.Parameters.AddWithValue("@bangchu", Utilities.DocSoBangChu(int.Parse(txt_hocPhi.Text)));
                cmd.ExecuteNonQuery();

                //Insert into DIEN_GIAM_PHI
                string maDien = "N/A";
                string tenDien = "N/A";
                int mucGiam = 0;
                if (rButton_noHocPhi.Checked)
                {
                    maDien = Utilities.TaoMaDien("N");
                    tenDien = "Nợ học phí";
                    mucGiam = int.Parse(txt_conNo.Text);
                }
                else if (rButton_giamHocPhi.Checked)
                {
                    maDien = Utilities.TaoMaDien("G");
                    tenDien = "Giảm học phí";
                    mucGiam = int.Parse(txt_duocGiam.Text);
                }
                else if (rButton_mienHocPhi.Checked)
                {
                    maDien = Utilities.TaoMaDien("M");
                    tenDien = "Miễn học phí";
                }

                if (maDien != "") // nếu là diện giảm phí
                {
                    cmd = new SqlCommand("INSERT INTO DIEN_GIAM_PHI VALUES (@madien, @tendien, @mucgiam)", conn, trans);
                    cmd.Parameters.AddWithValue("@madien", maDien);
                    cmd.Parameters.AddWithValue("@tendien", tenDien);
                    cmd.Parameters.AddWithValue("@mucgiam", mucGiam);
                    cmd.ExecuteNonQuery();
                }

                //Insert into HOC_VIEN
                string hoDem = "", ten = "";
                Utilities.TachHoTen(txt_hoTen.Text, out hoDem, out ten);
                string maHocVien = Utilities.TaoMaHocVien();

                cmd = new SqlCommand("SET DATEFORMAT DMY; INSERT INTO HOC_VIEN VALUES (@mahocvien, @hohocvien, @tenhocvien, @ngaysinh, @diachi, @sdt, @nghenghiep)", conn, trans);
                cmd.Parameters.AddWithValue("@mahocvien", maHocVien);
                cmd.Parameters.AddWithValue("@hohocvien", hoDem);
                cmd.Parameters.AddWithValue("@tenhocvien", ten);
                cmd.Parameters.AddWithValue("@ngaysinh", txt_ngaySinh.Text);
                cmd.Parameters.AddWithValue("@diachi", txt_diaChi.Text);
                cmd.Parameters.AddWithValue("@sdt", txt_soDienThoai.Text);
                cmd.Parameters.AddWithValue("@nghenghiep", txt_ngheNghiep.Text);
                cmd.ExecuteNonQuery();

                //Update SiSoDK LOP_HOC
                cmd = new SqlCommand("SELECT SiSoDK FROM LOP_HOC WHERE MaLopHoc = @malophoc", conn, trans);
                cmd.Parameters.AddWithValue("@malophoc", cbo_lop.Text);
                int sisodk = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("UPDATE LOP_HOC SET SiSoDK = @sisodk WHERE MaLopHoc = @malophoc", conn, trans);
                cmd.Parameters.AddWithValue("@sisodk", sisodk + 1);
                cmd.Parameters.AddWithValue("@malophoc", cbo_lop.Text);
                cmd.ExecuteNonQuery();

                //Insert into DANG_KY
                cmd = new SqlCommand("INSERT INTO DANG_KY VALUES (@malophoc, @mabl)", conn, trans);
                cmd.Parameters.AddWithValue("@malophoc", cbo_lop.Text);
                cmd.Parameters.AddWithValue("@mabl", mabl);
                cmd.ExecuteNonQuery();

                //Insert into GIAM_PHI
                cmd = new SqlCommand("INSERT INTO GIAM_PHI VALUES (@mahocvien, @madien)", conn, trans);
                cmd.Parameters.AddWithValue("@mahocvien", maHocVien);
                cmd.Parameters.AddWithValue("@madien", maDien);
                cmd.ExecuteNonQuery();

                //Insert into XUAT
                cmd = new SqlCommand("INSERT INTO XUAT VALUES (@mabl, @mahocvien)", conn, trans);
                cmd.Parameters.AddWithValue("@mabl", mabl);
                cmd.Parameters.AddWithValue("@mahocvien", maHocVien);
                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Lưu thành công");
            }
            catch (SqlException ex)
            {
                trans.Rollback();
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Đăng ký thất bại");
                this.status = "LuuThatBai";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Đăng ký thất bại");
                this.status = "LuuThatBai";
            }
            finally
            {
                conn.Close();
            }
        }

        private void rButton_noHocPhi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_ketThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_nhanHocVienMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frm_ketThuc(this).ShowDialog();
            //luu
            switch (this.status)
            {
                case "Luu":
                    {
                        btn_luu.PerformClick();
                        if (this.status == "LuuThatBai")
                            e.Cancel = true;
                    } break;

                case "Dong":
                    {
                        e.Cancel = true;
                    } break;
            }

        }

        private void btn_lamLai_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            foreach (object o in container)
            {
                if (o is TextBox)
                    ((TextBox)o).Clear();
                else if (o is ComboBox)
                {
                    ((ComboBox)o).SelectedIndex = -1;
                    ((ComboBox)o).Text = "--Chọn--";
                }
                else if (o is RadioButton)
                    ((RadioButton)o).Checked = false;
            }
        }

        private void btn_luuVaThemMoi_Click(object sender, EventArgs e)
        {
            btn_luu.PerformClick();
            Reset();
        }

    }
}
