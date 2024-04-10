using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaiTapQuanLy.BussinessLayer
{
    class Bll_SanPham
    {
        MyDatabase db;

        public Bll_SanPham(string path)
        {
            db = new MyDatabase(path);
        }

        public DataTable LayDsSanPham(ref string err, string maSanPham)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", maSanPham)
            };
            return db.GetDataTable(ref err, "PSP_SanPham_Select", CommandType.StoredProcedure, sqlParameters);
        }

        public DataTable LayDlCboDonViTinh(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_DonViTinh_SelectToCbo", CommandType.StoredProcedure, null);
        }

        public DataTable LayDlCboLoaiSanPham(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_LoaiSanPham_SelectToCbo", CommandType.StoredProcedure, null);
        }

        public object SinhMaLonNhat(ref string err)
        {
            return db.MyExcuteScalar(ref err, "PSP_SanPham_LayMaSanPham", CommandType.StoredProcedure, null);
        }
    }
}
