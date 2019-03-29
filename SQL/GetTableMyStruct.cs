using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.GUI
{
    public static class GetTableMyStruct
    {
        public enum DUAN
        {
            MADA,
            MAPB,
            TENDA,
            DIADIEM,
            TONGSOGIO,
        }
        public enum LUONG
        {
            BACLUONG,
            LUONGCOBAN,
            HESOLUONG,
            HESOPHUCAP,
        }
        public enum NHANVIEN
        {
            MANV,
            MAPB,
            TENNV,
            NGAYSINH,
            GIOITINH,
            MA_NGS,
            BACLUONG,
            DIACHI,
            ACCOUNT,
        }
        public enum PHANCONG
        {
            MANV,
            MADA,
            SOGIO,
        }
        public enum PHONGBAN
        {
            MAPB,
            TENPB,
            MATP,
            DIADIEM,
            NGAYNC,
        }
        public enum TAIKHOAN
        {
            ACCOUNT,
            PASSWORD,
            ACCESS,
        }
    }
}
