using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.GUI
{
    public class Select
    {
        static SqlConnection conn = SQLServer.GetMySQL();
        static DbDataReader reader;
        static SqlCommand cmd = new SqlCommand();
        public Select()
        {
            conn = SQLServer.GetMySQL();
            cmd = new SqlCommand();
        }
        public static class DUAN
        {
            public static MyStruct.DUAN GetAll(int _MADA)
            {
                cmd.CommandText = @"select top 1 MADA, MAPB, TENDA, DIADIEM, TONGSOGIO from DUAN where MADA = " + _MADA;
                cmd.Connection = conn;
                conn.Open();

                reader = cmd.ExecuteReader();
                MyStruct.DUAN t = new MyStruct.DUAN();
                if (reader.Read())
                {
                    t.MADA = reader.GetFieldValue<int>(0);
                    t.MAPB = reader.GetFieldValue<int>(1);
                    t.TENDA = reader.GetFieldValue<string>(2);
                    t.DIADIEM = reader.GetFieldValue<string>(3);
                    t.TONGSOGIO = reader.GetFieldValue<float>(4);
                }
                conn.Close();
                return t;
            }
        }
        public static class LUONG
        {
            public static MyStruct.LUONG GetAll(int _BACLUONG)
            {
                cmd.CommandText = @"select top 1 BACLUONG, LUONGCOBAN, HESOLUONG, HESOPHUCAP from LUONG where BACLUONG = " + _BACLUONG;
                cmd.Connection = conn;
                conn.Open();

                reader = cmd.ExecuteReader();
                MyStruct.LUONG t = new MyStruct.LUONG();
                if (reader.Read())
                {
                    t.BACLUONG = reader.GetFieldValue<int>(0);
                    t.LUONGCOBAN = reader.GetFieldValue<int>(1);
                    t.HESOLUONG = reader.GetFieldValue<float>(2);
                    t.HESOPHUCAP = reader.GetFieldValue<float>(3);
                }
                conn.Close();
                return t;
            }
        }
        public static class NHANVIEN
        {
            public static MyStruct.NHANVIEN GetAll(int _MANV)
            {
                cmd.CommandText = @"select top 1 MANV, MAPB, TENNV, NGAYSINH, GIOITINH, MA_NGS, BACLUONG, DIACHI, ACCOUNT from NHANVIEN where MANV = " + _MANV;
                cmd.Connection = conn;
                conn.Open();

                reader = cmd.ExecuteReader();
                MyStruct.NHANVIEN t = new MyStruct.NHANVIEN();
                if (reader.Read())
                {
                    t.MANV = reader.GetFieldValue<int>(0);
                    t.MAPB = reader.GetFieldValue<int>(1);
                    t.TENNV = reader.GetFieldValue<string>(2);
                    t.NGAYSINH = reader.GetFieldValue<DateTime>(3);
                    t.GIOITINH = reader.GetFieldValue<string>(4);
                    t.MA_NGS = reader.GetFieldValue<int>(5);
                    t.BACLUONG = reader.GetFieldValue<int>(6);
                    t.DIACHI = reader.GetFieldValue<string>(7);
                    t.ACCOUNT = reader.GetFieldValue<string>(8);
                }
                conn.Close();
                return t;
            }
        }
        public static class PHANCONG
        {
            public static MyStruct.PHANCONG GetAll(int _MANV)
            {
                cmd.CommandText = @"select top 1 MANV, MADA, SOGIO from PHANCONG where MANV = " + _MANV;
                cmd.Connection = conn;
                conn.Open();

                reader = cmd.ExecuteReader();
                MyStruct.PHANCONG t = new MyStruct.PHANCONG();
                if (reader.Read())
                {
                    t.MANV = reader.GetFieldValue<int>(0);
                    t.MADA = reader.GetFieldValue<int>(1);
                    t.SOGIO = reader.GetFieldValue<float>(2);
                }
                conn.Close();
                return t;
            }
        }
        public static class PHONGBAN
        {
            public static MyStruct.PHONGBAN GetAll(int _MAPB)
            {
                cmd.CommandText = @"select top 1 MAPB, TENPB, MATP, DIADIEM, NGAYNC from PHONGBAN where MAPB = " + _MAPB;
                cmd.Connection = conn;
                conn.Open();

                reader = cmd.ExecuteReader();
                MyStruct.PHONGBAN t = new MyStruct.PHONGBAN();
                if (reader.Read())
                {
                    t.MAPB = reader.GetFieldValue<int>(0);
                    t.TENPB = reader.GetFieldValue<string>(1);
                    t.MATP = reader.GetFieldValue<int>(2);
                    t.DIADIEM = reader.GetFieldValue<string>(3);
                    t.NGAYNC = reader.GetFieldValue<DateTime>(4);
                }
                conn.Close();
                return t;
            }
        }
        public static class TAIKHOAN
        {
            public static MyStruct.TAIKHOAN GetAll(string _ACCOUNT)
            {
                cmd.CommandText = @"select top 1 ACCOUNT, PASSWORD, ACCESS from TAIKHOAN where ACCOUNT = '" + _ACCOUNT + "'";
                cmd.Connection = conn;
                conn.Open();

                reader = cmd.ExecuteReader();
                MyStruct.TAIKHOAN t = new MyStruct.TAIKHOAN();
                if (reader.Read())
                {
                    t.ACCOUNT = reader.GetFieldValue<string>(0);
                    t.PASSWORD = reader.GetFieldValue<string>(1);
                    try
                    {
                        t.ACCESS = reader.GetFieldValue<string>(2).ToString();

                    }
                    catch
                    {
                        t.ACCESS = "";
                    }
                }
                conn.Close();
                return t;
            }
        }
    }
}
