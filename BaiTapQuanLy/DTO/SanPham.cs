using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapQuanLy.DTO
{
    public class SanPham
    {
        string maSanPham, tenSanPham, maDonViTinh, maLoaiSanPham, quyCachSanPham;
        bool isDelete;

        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
        int soLuongTon;
        public string QuyCachSanPham
        {
            get { return quyCachSanPham; }
            set { quyCachSanPham = value; }
        }

        public string MaLoaiSanPham
        {
            get { return maLoaiSanPham; }
            set { maLoaiSanPham = value; }
        }

        public string MaDonViTinh
        {
            get { return maDonViTinh; }
            set { maDonViTinh = value; }
        }

        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }

        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }
        

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

    }
}
