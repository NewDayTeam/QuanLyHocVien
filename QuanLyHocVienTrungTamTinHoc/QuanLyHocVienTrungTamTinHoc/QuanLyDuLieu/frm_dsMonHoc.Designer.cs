namespace quanlytrungtam
{
    partial class frm_dsMonHoc
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
            this.listView_dsMonHoc = new System.Windows.Forms.ListView();
            this.col_maMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_maKhoaHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tenMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_hocPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_dsMonHoc
            // 
            this.listView_dsMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_dsMonHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_maMonHoc,
            this.col_maKhoaHoc,
            this.col_tenMonHoc,
            this.col_hocPhi});
            this.listView_dsMonHoc.FullRowSelect = true;
            this.listView_dsMonHoc.GridLines = true;
            this.listView_dsMonHoc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_dsMonHoc.Location = new System.Drawing.Point(12, 13);
            this.listView_dsMonHoc.Name = "listView_dsMonHoc";
            this.listView_dsMonHoc.Size = new System.Drawing.Size(505, 298);
            this.listView_dsMonHoc.TabIndex = 0;
            this.listView_dsMonHoc.UseCompatibleStateImageBehavior = false;
            this.listView_dsMonHoc.View = System.Windows.Forms.View.Details;
            // 
            // col_maMonHoc
            // 
            this.col_maMonHoc.Text = "Mã môn học";
            this.col_maMonHoc.Width = 100;
            // 
            // col_maKhoaHoc
            // 
            this.col_maKhoaHoc.Text = "Mã khóa học";
            this.col_maKhoaHoc.Width = 100;
            // 
            // col_tenMonHoc
            // 
            this.col_tenMonHoc.Text = "Tên môn học";
            this.col_tenMonHoc.Width = 200;
            // 
            // col_hocPhi
            // 
            this.col_hocPhi.Text = "Học phí";
            this.col_hocPhi.Width = 100;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(78, 334);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(174, 334);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(270, 334);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(366, 334);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(75, 23);
            this.btn_in.TabIndex = 1;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = true;
            // 
            // frm_dsMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 378);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.listView_dsMonHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_dsMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách môn học";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_dsMonHoc;
        private System.Windows.Forms.ColumnHeader col_maMonHoc;
        private System.Windows.Forms.ColumnHeader col_maKhoaHoc;
        private System.Windows.Forms.ColumnHeader col_tenMonHoc;
        private System.Windows.Forms.ColumnHeader col_hocPhi;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_in;
    }
}