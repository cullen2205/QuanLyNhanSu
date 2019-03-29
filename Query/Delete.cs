using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public static class Delete
    {
        private static SqlConnection conn = SQLServer.GetMySQL();
        private static SqlCommand cmd = new SqlCommand();
        public static class NHANVIEN
        {
            public static bool DeleteOneRecord(int _MANV)
            {
                try
                {
                    cmd.CommandText = @"delete from NHANVIEN where MANV = " + _MANV;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class TAIKHOAN
        {
            public static bool DeleteOneRecord(int _ACCOUNT)
            {
                try
                {
                    cmd.CommandText = @"delete from TAIKHOAN where ACCOUNT = N'" + _ACCOUNT + "'";
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHANCONG
        {
            public static bool DeleteOneRecord(int _MANV, int _MADA)
            {
                try
                {
                    cmd.CommandText = @"delete from PHANCONG where MANV = " + _MANV + " and MADA = " + _MADA;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHONGBAN
        {
            public static bool DeleteOneRecord(int _MAPB)
            {
                try
                {
                    cmd.CommandText = @"delete from PHONGBAN where MAPB = " + _MAPB;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class DUAN
        {
            public static bool DeleteOneRecord(int _MADA)
            {
                try
                {
                    cmd.CommandText = @"delete from DUAN where MADA = " + _MADA;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class LUONG
        {
            public static bool DeleteOneRecord(int _BACLUONG)
            {
                try
                {
                    cmd.CommandText = @"delete from LUONG where BACLUONG = " + _BACLUONG;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }

    }
}
