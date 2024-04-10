using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyBanHang.DataLayer;
using System.Data.SqlClient;
using BaiTapQuanLy.DTO;
using System;

namespace BaiTapQuanLy.BussinessLayer
{
    class Bll_NhapHang
    {
        MyDatabase db;
        public string err = string.Empty;
        public Bll_NhapHang(string path)
        {
            db = new MyDatabase(path);
        }

        public string LayPhieuNhapLonNhat(ref string err)
        {
            return db.MyExcuteScalar(ref err, "PSP_PhieuNhap_LayMaxID", CommandType.StoredProcedure, null).ToString();
        }

        public int ThemPhieuNhap(ref string err, string maPhieuNhap, string maNhanVien)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhap",maPhieuNhap),
                new SqlParameter("@MaNV",maNhanVien)
            };
            return db.MyExcuteNonQuery(ref err, "PSP_PhieuNhap_Insert", CommandType.StoredProcedure, sqlParameters);
        }


        public string KiemTraMaPhieuChuaHoanThanh(ref string err,string maNhanVien)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaNhanVien",maNhanVien)
            };
            return db.MyExcuteScalar(ref err, "PSP_PhieuNhap_KiemTraPhieuTonTaiTheoUser",CommandType.StoredProcedure, sqlParameters).ToString();
        }

        public DataTable LayLoaiSanPham(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_LoaiSanPham_SelecToComboBox", CommandType.StoredProcedure, null);
        }

        public DataTable LayDonViTinh(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_DonViTinh_SelectToComboBox", CommandType.StoredProcedure, null);
        }

        public DataTable LaySanPham(ref string err, string maLoaiSanPham)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
        {
            new SqlParameter("@MaLoaiSanPham",maLoaiSanPham)
        };

            return db.GetDataTable(ref err, "PSP_SanPham_SelectToComboBox", CommandType.StoredProcedure, sqlParameters);
        }

        public int ThemChiTietPhieuNhap(ref string err, string maPhieuNhap, string maSanPham, string soLuongNhap, string donGiaNhap, string donViTinh)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                 new SqlParameter("@MaPhieuNhap",maPhieuNhap),
                 new SqlParameter("@MaSanPham",maSanPham),
                 new SqlParameter("@SoLuongNhap",soLuongNhap),
                 new SqlParameter("@DonGiaNhap",donGiaNhap),
                 new SqlParameter("@DonViTinh",donViTinh)
            };
            return db.MyExcuteNonQuery(ref err, "PSP_ChiTietPhieuNhap_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
        }

        public DataTable LayChiTietPhieuNhap(ref string err, string maPhieuNhap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
         new SqlParameter("@MaPhieuNhap",maPhieuNhap)
            };
            return db.GetDataTable(ref err, "PSP_ChiTietPhieuNhap_Select_SUBACITO", CommandType.StoredProcedure, sqlParameters);
        }


        public int HoanTatPhieuNhap(ref string err, string maPhieuNhap, string moTa)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@MaPhieuNhap",maPhieuNhap),
        new SqlParameter("@MoTa", moTa)
            };

            return db.MyExcuteNonQuery(ref err, "PSP_PhieuNhap_HoanTatPhieuNhap", CommandType.StoredProcedure, sqlParameters);
        }

        public int HuyPhieuNhap(ref string err, string maPhieuNhap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieuNhap",maPhieuNhap)
            };

            return db.MyExcuteNonQuery(ref err, "PSP_HuyPhieuNhap_SUBACITO", CommandType.StoredProcedure, sqlParameters);
        }
    }
}
