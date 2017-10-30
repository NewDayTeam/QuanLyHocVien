namespace quanlytrungtam
{
    partial class frm_themMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maMonHoc = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maKhoaHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenMonHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hocPhi = new System.Windows.Forms.TextBox();
            this.btn_themMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // txt_maMonHoc
            // 
            this.txt_maMonHoc.Location = new System.Drawing.Point(117, 16);
            this.txt_maMonHoc.Name = "txt_maMonHoc";
            this.txt_maMonHoc.Size = new System.Drawing.Size(100, 20);
            this.txt_maMonHoc.TabIndex = 1;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(81, 199);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khóa học";
            // 
            // txt_maKhoaHoc
            // 
            this.txt_maKhoaHoc.Location = new System.Drawing.Point(117, 58);
            this.txt_maKhoaHoc.Name = "txt_maKhoaHoc";
            this.txt_maKhoaHoc.Size = new System.Drawing.Size(100, 20);
            this.txt_maKhoaHoc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên môn học";
            // 
            // txt_tenMonHoc
            // 
            this.txt_tenMonHoc.Location = new System.Drawing.Point(117, 100);
            this.txt_tenMonHoc.Name = "txt_tenMonHoc";
            this.txt_tenMonHoc.Size = new System.Drawing.Size(170, 20);
            this.txt_tenMonHoc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Học phí";
            // 
            // txt_hocPhi
            // 
            this.txt_hocPhi.Location = new System.Drawing.Point(117, 142);
            this.txt_hocPhi.Name = "txt_hocPhi";
            this.txt_hocPhi.Size = new System.Drawing.Size(100, 20);
            this.txt_hocPhi.TabIndex = 1;
            // 
            // btn_themMoi
            // 
            this.btn_themMoi.Location = new System.Drawing.Point(185, 199);
            this.btn_themMoi.Name = "btn_themMoi";
            this.btn_themMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_themMoi.TabIndex = 2;
            this.btn_themMoi.Text = "Thêm mới";
            this.btn_themMoi.UseVisualStyleBackColor = true;
            // 
            // frm_themMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 245);
            this.Controls.Add(this.btn_themMoi);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_hocPhi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maKhoaHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maMonHoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_themMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm môn học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maMonHoc;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maKhoaHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hocPhi;
        private System.Windows.Forms.Button btn_themMoi;
    }
}