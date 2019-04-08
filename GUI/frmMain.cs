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
        public frmMain()
        {
            InitializeComponent();
            this.MaximizeBox = this.MinimizeBox = false;
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
    }
}
