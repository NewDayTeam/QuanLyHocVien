namespace quanlytrungtam
{
    partial class frm_dsLopHoc
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
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.listView_dsLopHoc = new System.Windows.Forms.ListView();
            this.col_stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_maLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_maMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_siSoDK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ngayBD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ngayKT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(432, 397);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(75, 23);
            this.btn_in.TabIndex = 3;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(329, 397);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(226, 397);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(123, 397);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // listView_dsLopHoc
            // 
            this.listView_dsLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_dsLopHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_stt,
            this.col_maLop,
            this.col_maMon,
            this.col_siSoDK,
            this.col_ngayBD,
            this.col_ngayKT,
            this.col_tinhTrang});
            this.listView_dsLopHoc.GridLines = true;
            this.listView_dsLopHoc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_dsLopHoc.Location = new System.Drawing.Point(12, 62);
            this.listView_dsLopHoc.Name = "listView_dsLopHoc";
            this.listView_dsLopHoc.Size = new System.Drawing.Size(621, 311);
            this.listView_dsLopHoc.TabIndex = 2;
            this.listView_dsLopHoc.UseCompatibleStateImageBehavior = false;
            this.listView_dsLopHoc.View = System.Windows.Forms.View.Details;
            // 
            // col_stt
            // 
            this.col_stt.Text = "STT";
            // 
            // col_maLop
            // 
            this.col_maLop.Text = "Mã lớp";
            this.col_maLop.Width = 80;
            // 
            // col_maMon
            // 
            this.col_maMon.Text = "Mã môn";
            this.col_maMon.Width = 80;
            // 
            // col_siSoDK
            // 
            this.col_siSoDK.Text = "Sỉ số đăng ký";
            this.col_siSoDK.Width = 77;
            // 
            // col_ngayBD
            // 
            this.col_ngayBD.Text = "Ngày bắt đầu";
            this.col_ngayBD.Width = 120;
            // 
            // col_ngayKT
            // 
            this.col_ngayKT.Text = "Ngày kết thúc";
            this.col_ngayKT.Width = 120;
            // 
            // col_tinhTrang
            // 
            this.col_tinhTrang.Text = "Tình trạng";
            this.col_tinhTrang.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xem danh sách theo";
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(414, 20);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(75, 23);
            this.btn_xem.TabIndex = 8;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // frm_dsLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.listView_dsLopHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_dsLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lớp học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ListView listView_dsLopHoc;
        private System.Windows.Forms.ColumnHeader col_stt;
        private System.Windows.Forms.ColumnHeader col_maLop;
        private System.Windows.Forms.ColumnHeader col_maMon;
        private System.Windows.Forms.ColumnHeader col_siSoDK;
        private System.Windows.Forms.ColumnHeader col_ngayBD;
        private System.Windows.Forms.ColumnHeader col_ngayKT;
        private System.Windows.Forms.ColumnHeader col_tinhTrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}