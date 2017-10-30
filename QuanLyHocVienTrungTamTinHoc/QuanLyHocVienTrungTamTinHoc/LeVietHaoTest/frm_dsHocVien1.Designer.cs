namespace QuanLyDuLieu
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
            this.groupBox_danhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_filter = new System.Windows.Forms.ComboBox();
            this.btn_xem = new System.Windows.Forms.Button();
            this.groupBox_danhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_danhSach
            // 
            this.groupBox_danhSach.Controls.Add(this.dataGridView_view);
            this.groupBox_danhSach.Location = new System.Drawing.Point(22, 83);
            this.groupBox_danhSach.Name = "groupBox_danhSach";
            this.groupBox_danhSach.Size = new System.Drawing.Size(970, 343);
            this.groupBox_danhSach.TabIndex = 1;
            this.groupBox_danhSach.TabStop = false;
            this.groupBox_danhSach.Text = "Danh sách";
            // 
            // dataGridView_view
            // 
            this.dataGridView_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_view.Location = new System.Drawing.Point(24, 29);
            this.dataGridView_view.Name = "dataGridView_view";
            this.dataGridView_view.Size = new System.Drawing.Size(921, 292);
            this.dataGridView_view.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem danh sách theo";
            // 
            // cbo_filter
            // 
            this.cbo_filter.FormattingEnabled = true;
            this.cbo_filter.Location = new System.Drawing.Point(218, 38);
            this.cbo_filter.Name = "cbo_filter";
            this.cbo_filter.Size = new System.Drawing.Size(121, 21);
            this.cbo_filter.TabIndex = 2;
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(369, 41);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(75, 23);
            this.btn_xem.TabIndex = 3;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            // 
            // frm_dsHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 438);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.cbo_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_danhSach);
            this.Name = "frm_dsHocVien";
            this.Text = "frm_dsHocVien";
            this.Load += new System.EventHandler(this.frm_dsHocVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_dsHocVien_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_dsHocVien_KeyPress);
            this.groupBox_danhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_danhSach;
        private System.Windows.Forms.DataGridView dataGridView_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_filter;
        private System.Windows.Forms.Button btn_xem;
    }
}