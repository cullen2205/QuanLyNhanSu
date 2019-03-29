using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class frmNhanVien : Form
    {
        SqlConnection localConnect;
        SqlCommand localCommand = new SqlCommand();
        public static int SoLuongBanGhi = 0;
        public frmNhanVien()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MaximumSize = this.MinimumSize = new Size(1200, 600);
            this.btnLuu.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaNV.Enabled = false;
            this.btnCancel.Enabled = false;
            this.dgvNhanVien.ReadOnly = true;

            EditInfoMode(false);

            localConnect = GUI.SQLServer.GetMySQL();
            localCommand.Connection = localConnect;

            GUI.FillTo.DataGridViews("NHANVIEN",ref this.dgvNhanVien);
        }

        private void EditInfoMode(bool _AreYouSure = false)
        {
            this.txtTenNV.Enabled = _AreYouSure;
            this.txtGioiTinh.Enabled = _AreYouSure;
            this.dtpNgaySinh.Enabled = _AreYouSure;
            this.txtDiaChi.Enabled = _AreYouSure;
            this.txtLuong.Enabled = _AreYouSure;
            this.txtMaNGS.Enabled = _AreYouSure;
            this.txtMaPB.Enabled = _AreYouSure;
            this.txtTaiKhoan.Enabled = _AreYouSure;

            this.btnLuu.Enabled = _AreYouSure;
            this.btnXoa.Enabled = _AreYouSure;
            this.btnCancel.Enabled = _AreYouSure;

            this.dgvNhanVien.Enabled = true;
        }

        private bool IsClickAddTwice = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            SoLuongBanGhi = this.dgvNhanVien.RowCount;
            if (IsClickAddTwice)
            {
                MyStruct.NHANVIEN nv = new MyStruct.NHANVIEN();
                nv.TENNV = this.txtTenNV.Text ?? null;
                nv.GIOITINH = this.txtGioiTinh.Text ?? null;
                nv.NGAYSINH = DateTime.Parse(this.dtpNgaySinh.Text);
                nv.DIACHI = this.txtDiaChi.Text ?? null;
                nv.BACLUONG = int.Parse(this.txtLuong.Text);
                nv.MA_NGS = int.Parse(this.txtMaNGS.Text);
                nv.MAPB = int.Parse(this.txtMaPB.Text);
                nv.ACCOUNT = this.txtTaiKhoan.Text;
                this.IsClickAddTwice = false;
                

                GUI.Insert.NHANVIEN.CreateNewRecord(nv, SoLuongBanGhi + 1);

                this.btnCancel_Click(sender, e);
                this.btnRefersh_Click(sender, e);
                this.btnSua.Enabled = true;
                EditInfoMode(false);

                return;
            }

            this.IsClickAddTwice = true;

            EditInfoMode(true);
            this.dgvNhanVien.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnLuu.Enabled = false;

            this.btnRefersh_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EditInfoMode(true);
            this.dgvNhanVien.Enabled = false;
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            GUI.FillTo.DataGridViews("NHANVIEN", ref this.dgvNhanVien);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtTimKiem.Text))
            {
                
            }
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.txtMaNV.Text = this.dgvNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString();
                this.txtTenNV.Text = this.dgvNhanVien.SelectedRows[0].Cells["TenNV"].Value.ToString();
                this.txtGioiTinh.Text = this.dgvNhanVien.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                this.dtpNgaySinh.Text = this.dgvNhanVien.SelectedRows[0].Cells["NgaySinh"].Value.ToString();
                this.txtDiaChi.Text = this.dgvNhanVien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                this.txtLuong.Text = this.dgvNhanVien.SelectedRows[0].Cells["Luong"].Value.ToString();
                this.txtMaNGS.Text = this.dgvNhanVien.SelectedRows[0].Cells["MaNGS"].Value.ToString();
                this.txtMaPB.Text = this.dgvNhanVien.SelectedRows[0].Cells["MaPB"].Value.ToString();
                this.txtTaiKhoan.Text = this.dgvNhanVien.SelectedRows[0].Cells["TaiKhoan"].Value.ToString();
            }
            catch
            {
                this.txtMaNV.Text = "";
                this.txtTenNV.Text = "";
                this.txtGioiTinh.Text = "";
                this.dtpNgaySinh.Text = "";
                this.txtDiaChi.Text = "";
                this.txtLuong.Text = "";
                this.txtMaNGS.Text = "";
                this.txtMaPB.Text = "";
                this.txtTaiKhoan.Text = "";
            }
            
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // luu data vào trong sql
            MyStruct.NHANVIEN nv = new MyStruct.NHANVIEN();
            nv.MANV = int.Parse(this.txtMaNV.Text);
            nv.TENNV = this.txtTenNV.Text;
            nv.GIOITINH = this.txtGioiTinh.Text;
            nv.NGAYSINH = DateTime.Parse(this.dtpNgaySinh.Text);
            nv.DIACHI = this.txtDiaChi.Text;
            nv.BACLUONG = int.Parse(this.txtLuong.Text);
            nv.MA_NGS = int.Parse(this.txtMaNGS.Text);
            nv.MAPB = int.Parse(this.txtMaPB.Text);
            nv.ACCOUNT = this.txtTaiKhoan.Text;

            GUI.Update.NHANVIEN.UpdateOneRecord(nv);

            this.btnRefersh_Click(sender, e);
            EditInfoMode(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xoá nhân viên
            GUI.Delete.NHANVIEN.DeleteOneRecord(int.Parse(this.txtMaNV.Text));

            this.btnRefersh_Click(sender, e);
            EditInfoMode(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EditInfoMode(false);
        }
    }
}
