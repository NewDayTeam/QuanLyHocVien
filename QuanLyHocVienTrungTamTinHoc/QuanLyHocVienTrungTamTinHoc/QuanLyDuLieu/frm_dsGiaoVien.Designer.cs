namespace quanlytrungtam
{
    partial class frm_dsGiaoVien
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
            this.listView_dsGV = new System.Windows.Forms.ListView();
            this.col_stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_msgv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_hoDem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ngaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_diaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView_dsGV
            // 
            this.listView_dsGV.AllowDrop = true;
            this.listView_dsGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_dsGV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_stt,
            this.col_msgv,
            this.col_hoDem,
            this.col_ten,
            this.col_ngaySinh,
            this.col_diaChi,
            this.col_sdt});
            this.listView_dsGV.FullRowSelect = true;
            this.listView_dsGV.GridLines = true;
            this.listView_dsGV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_dsGV.Location = new System.Drawing.Point(12, 60);
            this.listView_dsGV.Name = "listView_dsGV";
            this.listView_dsGV.Size = new System.Drawing.Size(674, 401);
            this.listView_dsGV.TabIndex = 0;
            this.listView_dsGV.UseCompatibleStateImageBehavior = false;
            this.listView_dsGV.View = System.Windows.Forms.View.Details;
            this.listView_dsGV.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView_dsGV_DrawItem);
            this.listView_dsGV.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_dsGV_DrawSubItem);
            this.listView_dsGV.SelectedIndexChanged += new System.EventHandler(this.listView_dsGV_SelectedIndexChanged);
            // 
            // col_stt
            // 
            this.col_stt.Text = "STT";
            // 
            // col_msgv
            // 
            this.col_msgv.Text = "MSGV";
            this.col_msgv.Width = 80;
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
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(245, 487);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(475, 487);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(75, 23);
            this.btn_in.TabIndex = 1;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(130, 487);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(360, 487);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xem danh sách theo";
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(435, 20);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(75, 23);
            this.btn_xem.TabIndex = 5;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(294, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // frm_dsGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.listView_dsGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_dsGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách giáo viên";
            this.Load += new System.EventHandler(this.frm_dsGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ColumnHeader col_stt;
        private System.Windows.Forms.ColumnHeader col_msgv;
        private System.Windows.Forms.ColumnHeader col_hoDem;
        private System.Windows.Forms.ColumnHeader col_ten;
        private System.Windows.Forms.ColumnHeader col_ngaySinh;
        private System.Windows.Forms.ColumnHeader col_diaChi;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.ColumnHeader col_sdt;
        private System.Windows.Forms.ListView listView_dsGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}