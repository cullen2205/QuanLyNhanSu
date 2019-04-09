using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class frmMain : Form
    {
        public static GUI.PasswordChangingForm fchangepass;
        private MyStruct.TAIKHOAN myAccount = new MyStruct.TAIKHOAN();

        public frmMain(MyStruct.TAIKHOAN _Account)
        {
            InitializeComponent();
            this.MaximizeBox = this.MinimizeBox = false;

            myAccount = _Account;
        }

        private void btnQuanLyDuAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmQuanLy t = new frmQuanLy(MyStruct.MyTableName.DUAN);
            t.Show();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmQuanLy t = new frmQuanLy(MyStruct.MyTableName.NHANVIEN);
            t.Show();
        }

        private void btnQuanLyPhanCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmQuanLy t = new frmQuanLy(MyStruct.MyTableName.PHANCONG);
            t.Show();
        }

        private void btnQuanLyPhongBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmQuanLy t = new frmQuanLy(MyStruct.MyTableName.PHONGBAN);
            t.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Program.flogin.Show();
            this.Dispose();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            GUI.frmMain.fchangepass = new PasswordChangingForm(myAccount);
            fchangepass.Show();
            this.Hide();
        }
    }
}
