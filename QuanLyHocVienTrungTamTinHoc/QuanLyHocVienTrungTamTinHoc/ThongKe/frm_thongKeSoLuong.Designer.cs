namespace quanlytrungtam
{
    partial class frm_thongKeSoLuong
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_hocVien = new System.Windows.Forms.TabPage();
            this.listView_hocVien = new System.Windows.Forms.ListView();
            this.rButton_lop = new System.Windows.Forms.RadioButton();
            this.rButton_mon = new System.Windows.Forms.RadioButton();
            this.rButton_khoa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tab_giaoVien = new System.Windows.Forms.TabPage();
            this.listView_giaoVien = new System.Windows.Forms.ListView();
            this.rButton_gvMon = new System.Windows.Forms.RadioButton();
            this.rButton_gvTrungTam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tab_monHoc = new System.Windows.Forms.TabPage();
            this.listView_monHoc = new System.Windows.Forms.ListView();
            this.rButton_monCuaGV = new System.Windows.Forms.RadioButton();
            this.rButton_monCuaKhoa = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tab_lopHoc = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_xem = new System.Windows.Forms.Button();
            this.listView_lopHoc = new System.Windows.Forms.ListView();
            this.rButton_slLopGiaoVien = new System.Windows.Forms.RadioButton();
            this.rButton_slLopTungMon = new System.Windows.Forms.RadioButton();
            this.rButton_slLopCuaKhoa = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tab_hocVien.SuspendLayout();
            this.tab_giaoVien.SuspendLayout();
            this.tab_monHoc.SuspendLayout();
            this.tab_lopHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_hocVien);
            this.tabControl.Controls.Add(this.tab_giaoVien);
            this.tabControl.Controls.Add(this.tab_monHoc);
            this.tabControl.Controls.Add(this.tab_lopHoc);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(642, 297);
            this.tabControl.TabIndex = 0;
            // 
            // tab_hocVien
            // 
            this.tab_hocVien.Controls.Add(this.listView_hocVien);
            this.tab_hocVien.Controls.Add(this.rButton_lop);
            this.tab_hocVien.Controls.Add(this.rButton_mon);
            this.tab_hocVien.Controls.Add(this.rButton_khoa);
            this.tab_hocVien.Controls.Add(this.label1);
            this.tab_hocVien.Controls.Add(this.comboBox1);
            this.tab_hocVien.Location = new System.Drawing.Point(4, 22);
            this.tab_hocVien.Name = "tab_hocVien";
            this.tab_hocVien.Padding = new System.Windows.Forms.Padding(3);
            this.tab_hocVien.Size = new System.Drawing.Size(634, 271);
            this.tab_hocVien.TabIndex = 0;
            this.tab_hocVien.Text = "Học viên";
            this.tab_hocVien.UseVisualStyleBackColor = true;
            this.tab_hocVien.Click += new System.EventHandler(this.tab_hocVien_Click);
            // 
            // listView_hocVien
            // 
            this.listView_hocVien.GridLines = true;
            this.listView_hocVien.Location = new System.Drawing.Point(270, 24);
            this.listView_hocVien.Name = "listView_hocVien";
            this.listView_hocVien.Size = new System.Drawing.Size(340, 223);
            this.listView_hocVien.TabIndex = 10;
            this.listView_hocVien.UseCompatibleStateImageBehavior = false;
            // 
            // rButton_lop
            // 
            this.rButton_lop.AutoSize = true;
            this.rButton_lop.Location = new System.Drawing.Point(51, 183);
            this.rButton_lop.Name = "rButton_lop";
            this.rButton_lop.Size = new System.Drawing.Size(173, 17);
            this.rButton_lop.TabIndex = 7;
            this.rButton_lop.TabStop = true;
            this.rButton_lop.Text = "Số lượng học viên của từng lớp";
            this.rButton_lop.UseVisualStyleBackColor = true;
            this.rButton_lop.CheckedChanged += new System.EventHandler(this.rButton_lop_CheckedChanged);
            // 
            // rButton_mon
            // 
            this.rButton_mon.AutoSize = true;
            this.rButton_mon.Location = new System.Drawing.Point(51, 143);
            this.rButton_mon.Name = "rButton_mon";
            this.rButton_mon.Size = new System.Drawing.Size(179, 17);
            this.rButton_mon.TabIndex = 8;
            this.rButton_mon.TabStop = true;
            this.rButton_mon.Text = "Số lượng học viên của từng môn";
            this.rButton_mon.UseVisualStyleBackColor = true;
            this.rButton_mon.CheckedChanged += new System.EventHandler(this.rButton_mon_CheckedChanged);
            // 
            // rButton_khoa
            // 
            this.rButton_khoa.AutoSize = true;
            this.rButton_khoa.Location = new System.Drawing.Point(51, 103);
            this.rButton_khoa.Name = "rButton_khoa";
            this.rButton_khoa.Size = new System.Drawing.Size(159, 17);
            this.rButton_khoa.TabIndex = 9;
            this.rButton_khoa.TabStop = true;
            this.rButton_khoa.Text = "Số lượng học viên của khóa";
            this.rButton_khoa.UseVisualStyleBackColor = true;
            this.rButton_khoa.CheckedChanged += new System.EventHandler(this.rButton_khoa_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Khóa học";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // tab_giaoVien
            // 
            this.tab_giaoVien.Controls.Add(this.listView_giaoVien);
            this.tab_giaoVien.Controls.Add(this.rButton_gvMon);
            this.tab_giaoVien.Controls.Add(this.rButton_gvTrungTam);
            this.tab_giaoVien.Controls.Add(this.label2);
            this.tab_giaoVien.Controls.Add(this.comboBox2);
            this.tab_giaoVien.Location = new System.Drawing.Point(4, 22);
            this.tab_giaoVien.Name = "tab_giaoVien";
            this.tab_giaoVien.Padding = new System.Windows.Forms.Padding(3);
            this.tab_giaoVien.Size = new System.Drawing.Size(634, 271);
            this.tab_giaoVien.TabIndex = 1;
            this.tab_giaoVien.Text = "Giáo viên";
            this.tab_giaoVien.UseVisualStyleBackColor = true;
            // 
            // listView_giaoVien
            // 
            this.listView_giaoVien.GridLines = true;
            this.listView_giaoVien.Location = new System.Drawing.Point(258, 24);
            this.listView_giaoVien.Name = "listView_giaoVien";
            this.listView_giaoVien.Size = new System.Drawing.Size(340, 223);
            this.listView_giaoVien.TabIndex = 16;
            this.listView_giaoVien.UseCompatibleStateImageBehavior = false;
            // 
            // rButton_gvMon
            // 
            this.rButton_gvMon.AutoSize = true;
            this.rButton_gvMon.Location = new System.Drawing.Point(39, 163);
            this.rButton_gvMon.Name = "rButton_gvMon";
            this.rButton_gvMon.Size = new System.Drawing.Size(184, 17);
            this.rButton_gvMon.TabIndex = 14;
            this.rButton_gvMon.TabStop = true;
            this.rButton_gvMon.Text = "Số lượng giáo viên theo từng môn";
            this.rButton_gvMon.UseVisualStyleBackColor = true;
            this.rButton_gvMon.CheckedChanged += new System.EventHandler(this.rButton_gvMon_CheckedChanged);
            // 
            // rButton_gvTrungTam
            // 
            this.rButton_gvTrungTam.AutoSize = true;
            this.rButton_gvTrungTam.Location = new System.Drawing.Point(39, 123);
            this.rButton_gvTrungTam.Name = "rButton_gvTrungTam";
            this.rButton_gvTrungTam.Size = new System.Drawing.Size(181, 17);
            this.rButton_gvTrungTam.TabIndex = 15;
            this.rButton_gvTrungTam.TabStop = true;
            this.rButton_gvTrungTam.Text = "Số lượng giáo viên của trung tâm";
            this.rButton_gvTrungTam.UseVisualStyleBackColor = true;
            this.rButton_gvTrungTam.CheckedChanged += new System.EventHandler(this.rButton_gvTrungTam_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khóa học";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(98, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // tab_monHoc
            // 
            this.tab_monHoc.Controls.Add(this.listView_monHoc);
            this.tab_monHoc.Controls.Add(this.rButton_monCuaGV);
            this.tab_monHoc.Controls.Add(this.rButton_monCuaKhoa);
            this.tab_monHoc.Controls.Add(this.label3);
            this.tab_monHoc.Controls.Add(this.comboBox3);
            this.tab_monHoc.Location = new System.Drawing.Point(4, 22);
            this.tab_monHoc.Name = "tab_monHoc";
            this.tab_monHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tab_monHoc.Size = new System.Drawing.Size(634, 271);
            this.tab_monHoc.TabIndex = 2;
            this.tab_monHoc.Text = "Môn học";
            this.tab_monHoc.UseVisualStyleBackColor = true;
            // 
            // listView_monHoc
            // 
            this.listView_monHoc.GridLines = true;
            this.listView_monHoc.Location = new System.Drawing.Point(258, 24);
            this.listView_monHoc.Name = "listView_monHoc";
            this.listView_monHoc.Size = new System.Drawing.Size(340, 223);
            this.listView_monHoc.TabIndex = 21;
            this.listView_monHoc.UseCompatibleStateImageBehavior = false;
            // 
            // rButton_monCuaGV
            // 
            this.rButton_monCuaGV.AutoSize = true;
            this.rButton_monCuaGV.Location = new System.Drawing.Point(39, 163);
            this.rButton_monCuaGV.Name = "rButton_monCuaGV";
            this.rButton_monCuaGV.Size = new System.Drawing.Size(201, 17);
            this.rButton_monCuaGV.TabIndex = 19;
            this.rButton_monCuaGV.TabStop = true;
            this.rButton_monCuaGV.Text = "Số lượng môn dạy của từng giáo viên";
            this.rButton_monCuaGV.UseVisualStyleBackColor = true;
            this.rButton_monCuaGV.CheckedChanged += new System.EventHandler(this.rButton_monCuaGV_CheckedChanged);
            // 
            // rButton_monCuaKhoa
            // 
            this.rButton_monCuaKhoa.AutoSize = true;
            this.rButton_monCuaKhoa.Location = new System.Drawing.Point(39, 123);
            this.rButton_monCuaKhoa.Name = "rButton_monCuaKhoa";
            this.rButton_monCuaKhoa.Size = new System.Drawing.Size(138, 17);
            this.rButton_monCuaKhoa.TabIndex = 20;
            this.rButton_monCuaKhoa.TabStop = true;
            this.rButton_monCuaKhoa.Text = "Số lượng môn của khóa";
            this.rButton_monCuaKhoa.UseVisualStyleBackColor = true;
            this.rButton_monCuaKhoa.CheckedChanged += new System.EventHandler(this.rButton_monCuaKhoa_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Khóa học";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(98, 79);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 17;
            // 
            // tab_lopHoc
            // 
            this.tab_lopHoc.Controls.Add(this.listView_lopHoc);
            this.tab_lopHoc.Controls.Add(this.rButton_slLopGiaoVien);
            this.tab_lopHoc.Controls.Add(this.rButton_slLopTungMon);
            this.tab_lopHoc.Controls.Add(this.rButton_slLopCuaKhoa);
            this.tab_lopHoc.Controls.Add(this.label4);
            this.tab_lopHoc.Controls.Add(this.comboBox4);
            this.tab_lopHoc.Location = new System.Drawing.Point(4, 22);
            this.tab_lopHoc.Name = "tab_lopHoc";
            this.tab_lopHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tab_lopHoc.Size = new System.Drawing.Size(634, 271);
            this.tab_lopHoc.TabIndex = 3;
            this.tab_lopHoc.Text = "Lớp học";
            this.tab_lopHoc.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(204, 320);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(75, 23);
            this.btn_xem.TabIndex = 3;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // listView_lopHoc
            // 
            this.listView_lopHoc.GridLines = true;
            this.listView_lopHoc.Location = new System.Drawing.Point(258, 24);
            this.listView_lopHoc.Name = "listView_lopHoc";
            this.listView_lopHoc.Size = new System.Drawing.Size(340, 223);
            this.listView_lopHoc.TabIndex = 16;
            this.listView_lopHoc.UseCompatibleStateImageBehavior = false;
            // 
            // rButton_slLopGiaoVien
            // 
            this.rButton_slLopGiaoVien.AutoSize = true;
            this.rButton_slLopGiaoVien.Location = new System.Drawing.Point(39, 183);
            this.rButton_slLopGiaoVien.Name = "rButton_slLopGiaoVien";
            this.rButton_slLopGiaoVien.Size = new System.Drawing.Size(150, 17);
            this.rButton_slLopGiaoVien.TabIndex = 13;
            this.rButton_slLopGiaoVien.TabStop = true;
            this.rButton_slLopGiaoVien.Text = "Số lượng lớp giáo viên dạy";
            this.rButton_slLopGiaoVien.UseVisualStyleBackColor = true;
            this.rButton_slLopGiaoVien.CheckedChanged += new System.EventHandler(this.rButton_slLopGiaoVien_CheckedChanged);
            // 
            // rButton_slLopTungMon
            // 
            this.rButton_slLopTungMon.AutoSize = true;
            this.rButton_slLopTungMon.Location = new System.Drawing.Point(39, 143);
            this.rButton_slLopTungMon.Name = "rButton_slLopTungMon";
            this.rButton_slLopTungMon.Size = new System.Drawing.Size(152, 17);
            this.rButton_slLopTungMon.TabIndex = 14;
            this.rButton_slLopTungMon.TabStop = true;
            this.rButton_slLopTungMon.Text = "Số lượng lớp của từng môn";
            this.rButton_slLopTungMon.UseVisualStyleBackColor = true;
            this.rButton_slLopTungMon.CheckedChanged += new System.EventHandler(this.rButton_slLopTungMon_CheckedChanged);
            // 
            // rButton_slLopCuaKhoa
            // 
            this.rButton_slLopCuaKhoa.AutoSize = true;
            this.rButton_slLopCuaKhoa.Location = new System.Drawing.Point(39, 103);
            this.rButton_slLopCuaKhoa.Name = "rButton_slLopCuaKhoa";
            this.rButton_slLopCuaKhoa.Size = new System.Drawing.Size(132, 17);
            this.rButton_slLopCuaKhoa.TabIndex = 15;
            this.rButton_slLopCuaKhoa.TabStop = true;
            this.rButton_slLopCuaKhoa.Text = "Số lượng lớp của khóa";
            this.rButton_slLopCuaKhoa.UseVisualStyleBackColor = true;
            this.rButton_slLopCuaKhoa.CheckedChanged += new System.EventHandler(this.rButton_slLopCuaKhoa_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Khóa học";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(98, 59);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 11;
            // 
            // frm_thongKeSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 359);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_xem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_thongKeSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê số lượng";
            this.Load += new System.EventHandler(this.frm_thongKeSoLuong_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_hocVien.ResumeLayout(false);
            this.tab_hocVien.PerformLayout();
            this.tab_giaoVien.ResumeLayout(false);
            this.tab_giaoVien.PerformLayout();
            this.tab_monHoc.ResumeLayout(false);
            this.tab_monHoc.PerformLayout();
            this.tab_lopHoc.ResumeLayout(false);
            this.tab_lopHoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_hocVien;
        private System.Windows.Forms.ListView listView_hocVien;
        private System.Windows.Forms.RadioButton rButton_lop;
        private System.Windows.Forms.RadioButton rButton_mon;
        private System.Windows.Forms.RadioButton rButton_khoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tab_giaoVien;
        private System.Windows.Forms.TabPage tab_monHoc;
        private System.Windows.Forms.TabPage tab_lopHoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.ListView listView_giaoVien;
        private System.Windows.Forms.RadioButton rButton_gvMon;
        private System.Windows.Forms.RadioButton rButton_gvTrungTam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listView_monHoc;
        private System.Windows.Forms.RadioButton rButton_monCuaGV;
        private System.Windows.Forms.RadioButton rButton_monCuaKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ListView listView_lopHoc;
        private System.Windows.Forms.RadioButton rButton_slLopGiaoVien;
        private System.Windows.Forms.RadioButton rButton_slLopTungMon;
        private System.Windows.Forms.RadioButton rButton_slLopCuaKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}