namespace quanlytrungtam
{
    partial class frm_timKiemGV
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.listView_dsGV.Location = new System.Drawing.Point(13, 85);
            this.listView_dsGV.Name = "listView_dsGV";
            this.listView_dsGV.Size = new System.Drawing.Size(674, 316);
            this.listView_dsGV.TabIndex = 1;
            this.listView_dsGV.UseCompatibleStateImageBehavior = false;
            this.listView_dsGV.View = System.Windows.Forms.View.Details;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Họ và tên",
            "Mã giáo viên"});
            this.comboBox1.Location = new System.Drawing.Point(256, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(455, 48);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 23);
            this.btn_tim.TabIndex = 16;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "----------------------";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 15;
            // 
            // frm_timKiemGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 415);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView_dsGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_timKiemGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm thông tin giáo viên";
            this.Load += new System.EventHandler(this.frm_timKiemGV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_dsGV;
        private System.Windows.Forms.ColumnHeader col_stt;
        private System.Windows.Forms.ColumnHeader col_msgv;
        private System.Windows.Forms.ColumnHeader col_hoDem;
        private System.Windows.Forms.ColumnHeader col_ten;
        private System.Windows.Forms.ColumnHeader col_ngaySinh;
        private System.Windows.Forms.ColumnHeader col_diaChi;
        private System.Windows.Forms.ColumnHeader col_sdt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}