using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public static class Update
    {
        private static SqlConnection conn = SQLServer.GetMySQL();
        private static SqlCommand cmd = new SqlCommand();
        public static class DUAN
        {
            public static bool UpdateOneRecord(MyStruct.DUAN _newValue)
            {
                try
                {
                    cmd.CommandText
                        = @"update DUAN set MAPB = " + _newValue.MAPB
                        + ", TENDA = N'" + _newValue.TENDA + "'"
                        + ", DIADIEM = N'" + _newValue.DIADIEM + "'"
                        + ", TONGSOGIO = " + _newValue.TONGSOGIO
                        + " where MADA = " + _newValue.MADA;
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class LUONG
        {
            public static bool UpdateOneRecord(MyStruct.LUONG _newValue)
            {
                try
                {
                    cmd.CommandText
                        = @"update LUONG set LUONGCOBAN = " + _newValue.LUONGCOBAN
                        + ", HESOLUONG = " + _newValue.HESOLUONG
                        + ", HESOPHUCAP = " + _newValue.HESOPHUCAP
                        + " where BACLUONG = " + _newValue.BACLUONG;
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class NHANVIEN
        {
            public static bool UpdateOneRecord(MyStruct.NHANVIEN _newValue)
            {
                try
                {
                    cmd.CommandText
                        = @"update NHANVIEN set MAPB = " + _newValue.MAPB
                        + ", TENNV = N'" + _newValue.TENNV + "'"
                        + ", NGAYSINH = N'" + (DateTime.Parse(_newValue.NGAYSINH.ToString())).ToShortDateString().ToString() + "'"
                        + ", GIOITINH = N'" + _newValue.GIOITINH + "'"
                        + ", MA_NGS = " + _newValue.MA_NGS
                        + ", BACLUONG = " + _newValue.BACLUONG
                        + ", DIACHI = N'" + _newValue.DIACHI + "'"
                        + ", ACCOUNT = N'" + _newValue.ACCOUNT + "'"
                        + " where MANV = " + _newValue.MANV;
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;

                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHANCONG
        {
            public static bool UpdateOneRecord(MyStruct.PHANCONG _newValue)
            {
                try
                {
                    cmd.CommandText
                        = @"update PHANCONG set SOGIO = " + _newValue.SOGIO
                        + " where MANV = " + _newValue.MANV
                        + " and MADA = " + _newValue.MADA;
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHONGBAN
        {
            public static bool UpdateOneRecord(MyStruct.PHONGBAN _newValue)
            {
                try
                {
                    cmd.CommandText
                        = @"update PHONGBAN set TENPB = N'" + _newValue.TENPB + "'"
                        + ", MATP = " + _newValue.MATP
                        + ", DIADIEM = N'" + _newValue.DIADIEM + "'"
                        + ", NGAYNC = N'" + (DateTime.Parse(_newValue.NGAYNC.ToString())).ToShortDateString().ToString() + "'"
                        + " where MAPB = " + _newValue.MAPB;
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class TAIKHOAN
        {
            public static bool UpdateOneRecord(MyStruct.TAIKHOAN _newValue)
            {
                try
                {
                    cmd.CommandText
                        = @"update TAIKHOAN set ACCESS = N'" + _newValue.ACCESS + "'"
                        + ", PASSWORD = N'" + _newValue.PASSWORD + "'"
                        + " where ACCOUNT = N'" + _newValue.ACCOUNT + "'";
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
    }
}
