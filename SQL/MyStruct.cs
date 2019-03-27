using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.GUI
{
    public class MyStruct
    {
        public class DUAN
        {
            //[MADA] [int] NOT NULL,
	        //[MAPB] [int] NULL,
	        //[TENDA] [nvarchar](50) NULL,
	        //[DIADIEM] [nvarchar](50) NULL,
	        //[TONGSOGIO] [float] NULL,
            public int MADA { get; set; }
            public int MAPB { get; set; }
            public string TENDA { get; set; }
            public string DIADIEM { get; set; }
            public float TONGSOGIO { get; set; }
        }
        public class LUONG
        {
            //[BACLUONG] [int] NOT NULL,
            //[LUONGCOBAN] [int] NULL,
            //[HESOLUONG] [float] NULL,
            //[HESOPHUCAP] [float] NULL,
            public int BACLUONG { get; set; }
            public int LUONGCOBAN { get; set; }
            public float HESOLUONG { get; set; }
            public float HESOPHUCAP { get; set; }
        }
        public class NHANVIEN
        {
            //   [MANV] [int] NOT NULL,
            //[MAPB] [int] NULL,
            //[TENNV] [nvarchar](50) NULL,
            //[NGAYSINH] [date] NULL,
            //[GIOITINH] [nvarchar](50) NULL,
            //[MA_NGS] [int] NULL,
            //[BACLUONG] [int] NULL,
            //[DIACHI] [nvarchar](50) NULL,
            //[ACCOUNT] [varchar](50) NULL,
            public int MANV { get; set; }
            public int MAPB { get; set; }
            public string TENNV { get; set; }
            public DateTime NGAYSINH { get; set; }
            public string GIOITINH { get; set; }
            public int MA_NGS { get; set; }
            public int BACLUONG { get; set; }
            public string DIACHI { get; set; }
            public string ACCOUNT { get; set; }
        }
        public class PHANCONG
        {
            //[MANV] [int] NOT NULL,
            //	[MADA] [int] NOT NULL,
            //	[SOGIO] [float] NULL,
            public int MANV { get; set; }
            public int MADA { get; set; }
            public float SOGIO { get; set; }
        }
        public class PHONGBAN
        {
            //[MAPB] [int] NOT NULL,
            //[TENPB] [nvarchar](50) NULL,
            //[MATP] [int] NULL,
            //[DIADIEM] [nvarchar](50) NULL,
            //[NGAYNC] [date] NULL,
            public int MAPB { get; set; }
            public string TENPB { get; set; }
            public int MATP { get; set; }
            public string DIADIEM { get; set; }
            public DateTime NGAYNC { get; set; }
        }
        public class TAIKHOAN
        {
            //   [ACCOUNT] [varchar](50) NOT NULL,
            //[PASSWORD] [varchar](50) NULL,
            //[ACCESS] [nchar](3) NULL,
            public string ACCOUNT { get; set; }
            public string PASSWORD { get; set; }
            public string ACCESS { get; set; }
        }
    }
}
