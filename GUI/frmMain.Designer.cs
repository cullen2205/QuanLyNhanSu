namespace QuanLyNhanSu.GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoatChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaoLoi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuanLyPhanCong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuanLyPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuanLyDuAn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuanLy,
            this.btnTroGiup,
            this.btnHeThong,
            this.btnThoatChuongTrinh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnHeThong
            // 
            this.btnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDangXuat,
            this.btnDoiMatKhau});
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(72, 20);
            this.btnHeThong.Text = "Hệ Thống";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(152, 22);
            this.btnDangXuat.Text = "Đăng xuất";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(152, 22);
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaoLoi,
            this.btnTacGia});
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(64, 20);
            this.btnTroGiup.Text = "Trợ Giúp";
            // 
            // btnThoatChuongTrinh
            // 
            this.btnThoatChuongTrinh.Name = "btnThoatChuongTrinh";
            this.btnThoatChuongTrinh.Size = new System.Drawing.Size(50, 20);
            this.btnThoatChuongTrinh.Text = "Thoát";
            // 
            // btnBaoLoi
            // 
            this.btnBaoLoi.Name = "btnBaoLoi";
            this.btnBaoLoi.Size = new System.Drawing.Size(152, 22);
            this.btnBaoLoi.Text = "Báo lỗi";
            // 
            // btnTacGia
            // 
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(152, 22);
            this.btnTacGia.Text = "Tác giả";
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuanLyDuAn,
            this.btnQuanLyNhanVien,
            this.btnQuanLyPhanCong,
            this.btnQuanLyPhongBan});
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(62, 20);
            this.btnQuanLy.Text = "Quản Lý";
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(176, 22);
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // btnQuanLyPhanCong
            // 
            this.btnQuanLyPhanCong.Name = "btnQuanLyPhanCong";
            this.btnQuanLyPhanCong.Size = new System.Drawing.Size(176, 22);
            this.btnQuanLyPhanCong.Text = "Quản lý phân công";
            // 
            // btnQuanLyPhongBan
            // 
            this.btnQuanLyPhongBan.Name = "btnQuanLyPhongBan";
            this.btnQuanLyPhongBan.Size = new System.Drawing.Size(176, 22);
            this.btnQuanLyPhongBan.Text = "Quản lý phòng ban";
            // 
            // btnQuanLyDuAn
            // 
            this.btnQuanLyDuAn.Name = "btnQuanLyDuAn";
            this.btnQuanLyDuAn.Size = new System.Drawing.Size(176, 22);
            this.btnQuanLyDuAn.Text = "Quản lý dự án";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 202);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "Quản Lý Nhân Sự";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnHeThong;
        private System.Windows.Forms.ToolStripMenuItem btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem btnDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem btnTroGiup;
        private System.Windows.Forms.ToolStripMenuItem btnThoatChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem btnQuanLy;
        private System.Windows.Forms.ToolStripMenuItem btnBaoLoi;
        private System.Windows.Forms.ToolStripMenuItem btnTacGia;
        private System.Windows.Forms.ToolStripMenuItem btnQuanLyDuAn;
        private System.Windows.Forms.ToolStripMenuItem btnQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem btnQuanLyPhanCong;
        private System.Windows.Forms.ToolStripMenuItem btnQuanLyPhongBan;
    }
}