namespace quanlytrungtam
{
    partial class frm_dsHocVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_maHocVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_hoDem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ngaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_diaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ngheNghiep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_xem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_stt,
            this.col_maHocVien,
            this.col_hoDem,
            this.col_ten,
            this.col_ngaySinh,
            this.col_diaChi,
            this.col_sdt,
            this.col_ngheNghiep});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(14, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(814, 294);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // col_stt
            // 
            this.col_stt.Text = "SST";
            // 
            // col_maHocVien
            // 
            this.col_maHocVien.Text = "Mã học viên";
            this.col_maHocVien.Width = 100;
            // 
            // col_hoDem
            // 
            this.col_hoDem.Text = "Họ đệm";
            this.col_hoDem.Width = 120;
            // 
            // col_ten
            // 
            this.col_ten.Text = "Tên";
            // 
            // col_ngaySinh
            // 
            this.col_ngaySinh.Text = "Ngày sinh";
            this.col_ngaySinh.Width = 100;
            // 
            // col_diaChi
            // 
            this.col_diaChi.Text = "Địa chỉ";
            this.col_diaChi.Width = 150;
            // 
            // col_sdt
            // 
            this.col_sdt.Text = "Số điện thoại";
            this.col_sdt.Width = 100;
            // 
            // col_ngheNghiep
            // 
            this.col_ngheNghiep.Text = "Nghề nghiệp";
            this.col_ngheNghiep.Width = 120;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(359, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(500, 14);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(75, 23);
            this.btn_xem.TabIndex = 2;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Xem danh sách theo";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(190, 380);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(370, 380);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(550, 380);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(75, 23);
            this.btn_in.TabIndex = 4;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // frm_dsHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 426);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_dsHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_stt;
        private System.Windows.Forms.ColumnHeader col_maHocVien;
        private System.Windows.Forms.ColumnHeader col_hoDem;
        private System.Windows.Forms.ColumnHeader col_ten;
        private System.Windows.Forms.ColumnHeader col_ngaySinh;
        private System.Windows.Forms.ColumnHeader col_diaChi;
        private System.Windows.Forms.ColumnHeader col_sdt;
        private System.Windows.Forms.ColumnHeader col_ngheNghiep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_in;
    }
}