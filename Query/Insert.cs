using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public static class Insert
    {
        private static SqlConnection conn = SQLServer.GetMySQL();
        private static SqlCommand cmd = new SqlCommand();
        public static class DUAN
        {
            public static bool CreateNewRecord(MyStruct.DUAN _new)
            {
                try
                {
                    string tam1 = @"insert into DUAN (MADA", tam2 = "";
                    if (_new.MAPB != null)
                    {
                        tam1 += @", MAPB";
                        tam2 += @", " + _new.MAPB;
                    }
                    if (!string.IsNullOrEmpty(_new.TENDA))
                    {
                        tam1 += @", TENDA";
                        tam2 += @", N'" + _new.TENDA + "'";
                    }
                    if (!string.IsNullOrEmpty(_new.DIADIEM))
                    {
                        tam1 += @", DIADIEM";
                        tam2 += @", N'" + _new.DIADIEM + "'";
                    }
                    if (_new.TONGSOGIO != null)
                    {
                        tam1 += @", TONGSOGIO";
                        tam2 += @", " + _new.TONGSOGIO;
                    }
                    tam1 += @") values (" + _new.MADA + tam2 + ")";

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
                
            }
        }
        public static class LUONG
        {
            public static bool CreateNewRecord(MyStruct.LUONG _new)
            {
                try
                {
                    string tam1 = @"insert into NHANVIEN (MANV";
                    if (true)
                    {

                    }

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class NHANVIEN
        {
            private static int GetNextIndex()
            {
                //SqlConnection t = SQLServer.GetMySQL();
                //SqlCommand cm = new SqlCommand(@"select top 1 MAX(MANV) as STTCAONHAT from NHANVIEN order by STTCAONHAT desc");
                //DbDataReader reader;

                //cm.Connection = t;
                //t.Open();
                //reader = cm.ExecuteReader();
                
                //if (reader.HasRows)
                //{
                //    int tam = reader.GetFieldValue<int>(0) + 1;
                //    t.Close();
                //    return tam;
                //}
                //t.Close();
                return 1;


                //// buggggggggg
            }
            public static bool CreateNewRecord(MyStruct.NHANVIEN _new, int _index)
            {
                try
                {
                    _new.MANV = _index;
                    string tam1 = @"insert into NHANVIEN (MANV", tam2 = "";
                    if (_new.MAPB != null)
                    {
                        tam1 += @", MAPB";
                        tam2 += @", " + _new.MAPB;
                    }
                    if (!string.IsNullOrEmpty(_new.TENNV))
                    {
                        tam1 += @", TENNV";
                        tam2 += @", N'" + _new.TENNV + "'";
                    }
                    if (_new.NGAYSINH != null)
                    {
                        tam1 += @", NGAYSINH";
                        tam2 += @", N'" + (DateTime.Parse(_new.NGAYSINH.ToString())).ToShortDateString().ToString() + "'";
                    }
                    if (!string.IsNullOrEmpty(_new.GIOITINH))
                    {
                        tam1 += @", GIOITINH";
                        tam2 += @", N'" + _new.GIOITINH + "'";
                    }
                    if (_new.MA_NGS != null)
                    {
                        tam1 += @", MA_NGS";
                        tam2 += @", " + _new.MA_NGS;
                    }
                    if (_new.BACLUONG != null)
                    {
                        tam1 += @", BACLUONG";
                        tam2 += @", " + _new.BACLUONG;
                    }
                    if (!string.IsNullOrEmpty(_new.DIACHI))
                    {
                        tam1 += @", DIACHI";
                        tam2 += @", N'" + _new.DIACHI + "'";
                    }
                    if (!string.IsNullOrEmpty(_new.ACCOUNT))
                    {
                        tam1 += @", ACCOUNT";
                        tam2 += @", N'" + _new.ACCOUNT + "'";
                    }

                    tam1 += ") values (" + _new.MANV + tam2 + ")";

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
    }
        }
        public static class PHANCONG
        {
            public static bool CreateNewRecord(MyStruct.PHANCONG _new)
            {
                try
                {
                    string tam1 = @"insert into NHANVIEN (MANV";
                    if (true)
                    {

                    }

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHONGBAN
        {
            public static bool CreateNewRecord(MyStruct.PHONGBAN _new)
            {
                try
                {
                    string tam1 = @"insert into NHANVIEN (MANV";
                    if (true)
                    {

                    }

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class TAIKHOAN
        {
            public static bool CreateNewRecord(MyStruct.TAIKHOAN _new)
            {
                try
                {
                    string tam1 = @"insert into NHANVIEN (MANV";
                    if (true)
                    {

                    }
                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
            }
        }
    }
}
