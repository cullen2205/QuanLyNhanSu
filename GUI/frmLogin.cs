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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxUser.Text) || string.IsNullOrEmpty(this.textBoxPass.Text))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu trống, xin hãy kiểm tra lại.");
                return;
            }
            MyStruct.TAIKHOAN taikhoan = GUI.Select.TAIKHOAN.GetAll(textBoxUser.Text);

            if (this.textBoxPass.Text == taikhoan.PASSWORD)
            {
                // Thành công
                MessageBox.Show("Đăng nhập thành công.");
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
            }
        }
    }
}
