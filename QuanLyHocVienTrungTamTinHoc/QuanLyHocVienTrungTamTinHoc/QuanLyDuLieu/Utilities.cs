using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace quanlytrungtam
{
    class Utilities
    {


        public static void FillDataToComboBox(ComboBox cbo, string connString, string query, string displayMember, string valueMember)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, connString);
            DataTable table = new DataTable();
            adap.Fill(table);

            cbo.DataSource = table;
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
            cbo.SelectedIndex = -1;
            cbo.Text = "--Chọn--";
        }

        public static int TaoMaBienLai()
        {
            int maBL = 0;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConnectionString.connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(MaBL) FROM BIEN_LAI", conn);
                int max = (int)cmd.ExecuteScalar();

                maBL = max + 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return maBL;
        }
        public static string TaoMaDien(string prefix)
        {
            string maDien = "";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = ConnectionString.connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(MaDien) FROM DIEN_GIAM_PHI", conn);
                string max = cmd.ExecuteScalar().ToString();
                if (max.Length == 0)
                    maDien = prefix + "0";
                else
                    maDien = prefix + (int.Parse(max.Substring(1)) + 1).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                conn.Close();
            }
            return maDien;
        }


        public static string TaoMaHocVien()
        {
            string maHocVien = "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConnectionString.connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(MaHocVien) FROM HOC_VIEN", conn);
                string res = cmd.ExecuteScalar().ToString();
                if (res.Length == 0)
                    maHocVien = "S0";
                else
                    maHocVien = "S" + (int.Parse(res.Substring(1)) + 1).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                conn.Close();
            }
            return maHocVien;
        }


        public static void TachHoTen(string fullName, out string hoDem, out string ten)
        {
            hoDem = ten = "";
            string[] arr = fullName.Trim().Split(' ');
            for (int i = 0; i < arr.Length - 1; i++)
                if (i == 0)
                    hoDem += arr[i];
                else 
                    hoDem += " " + arr[i];
            ten = arr[arr.Length - 1];
        }

        public static string Doc1ChuSo(int n)
        {
            switch (n)
            {
                case 0:
                    return "không";
                case 1:
                    return "một";
                case 2:
                    return "hai";
                case 3:
                    return "ba";
                case 4:
                    return "bốn";
                case 5:
                    return "năm";
                case 6:
                    return "sáu";
                case 7:
                    return "bảy";
                case 8:
                    return "tám";
                case 9:
                    return "chín";
            }
            return "";
        }

        public static string DocDonVi(int n)
        {
            switch (n)
            {
                case 0:
                    return "";
                case 1:
                    return "mốt";
                case 5:
                    return "lăm";
                default:
                    return Doc1ChuSo(n);
            }
        }

        public static string Doc2ChuSo(int n)
        {
            if (n == 11) return "mười một";
            if (n / 10 == 1) return "mười " + DocDonVi(n % 10);
            if (n == 0) return "";
            if (n / 10 == 0 && n % 10 != 0) return "lẻ " + Doc1ChuSo(n % 10);
            return Doc1ChuSo(n / 10) + " mươi " + Doc1ChuSo(n % 10);
        }

        public static string Doc3ChuSo(int n)
        {
            //if (n == 0) return "";
            return Doc1ChuSo(n / 100) + " trăm " + Doc2ChuSo(n % 100);
        }

        public static string DocSoBangChu(int n)
        {
            if (n < 10)
                return Doc1ChuSo(n);
            if (n < 100)
                return Doc2ChuSo(n);
            if (n < 1000)
                return Doc3ChuSo(n);
            if (n < 10000)
                return Doc1ChuSo(n / 1000) + " nghìn " + Doc3ChuSo(n % 1000);
            if (n < 100000)
                return Doc2ChuSo(n / 1000) + " nghìn " + Doc3ChuSo(n % 1000);
            if (n < 1000000)
                return Doc3ChuSo(n / 1000) + " nghìn " + Doc3ChuSo(n % 1000);
            if (n < 10000000)
                return Doc1ChuSo(n / 1000000) + " triệu " + Doc3ChuSo((n / 1000) % 1000) + " nghìn " + Doc3ChuSo(n % 1000);
            if (n < 100000000)
                return Doc2ChuSo(n / 1000000) + " triệu " + Doc3ChuSo((n / 1000) % 1000) + " nghìn " + Doc3ChuSo(n % 1000);
            if (n < 1000000000)
                return Doc3ChuSo(n / 1000000) + " triệu " + Doc3ChuSo((n / 1000) % 1000) + " nghìn " + Doc3ChuSo(n % 1000);

            return "N/A";

            /*
             * n < 10 
             * >Doc1so(n, 1)
             * n < 100
             * > if (n == 10) => "muoi"
             * > if (n == 11) => "muoi mot"
             * if (chuc == 1) => "muoi" + Docdonvi(n, 1)
             * else => Doc1So(n, 2) + "muoi" + Docdonvi(n, 1)
             * n < 1000
             * >Doc1So() +  "tram" + Doc2chuso()
             * 
             * 4chu so
             * > Doc1chuso() + "nghin" + Doc3chuso()
             * 
             * 5 chu so 
             * >Doc2chuso() +  "nghin" + Doc3chuso()
             * 
             * 6chuso
             * >Doc3chuso() + "nghin" + Doc3chuso()
             * 
             * 7chuso
             * >Doc1chuso() + "trieu " + Doc6chuso()
             * 
             * 8 chuso
             * >Doc2ChuSo() + "trieu" + Doc6chuso()
             * 
             * 9chu so
             * > Doc3chuso() + "trieu" + Doc6chuso()
             * 10chuso
             * > Doc1chuso() + "ti" + Doc9Chuso()
             * 11 chuso
             * > Doc2chuso() + "ti" + Doc9chuso()
             * 12 chuso
             * > Doc3chuso() + "ti"  + Doc9chuso()
             * > 
             */
        }

    }
}
