using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BaiTapQuanLy.BussinessLayer
{
    class Bll_HoaDon
    {
        MyDatabase db;
        
        public Bll_HoaDon(string path)
        {
            db = new MyDatabase(path);
        }

        public object LayMaHoaDonLonNhat(ref string err)
        {
            return db.MyExcuteScalar(ref err, "PSP_HoaDon_GetMaxOrderID", CommandType.StoredProcedure, null);
        }

        public object LayMaHoaDonLonNhatTheoNgayLap(ref string err, DateTime ngayLap)
        {
            SqlParameter[] sqls = new SqlParameter[]
                {
                        new SqlParameter("@NgayLap", ngayLap)
                };
                
                return db.MyExcuteScalar(ref err, "PSP_HoaDon_GetMaxOrderIDByDate", CommandType.StoredProcedure, sqls);
        }

        public DataTable LayKhachHangToCbo(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_KhachHangLayCbo", CommandType.StoredProcedure, null);
        }

        public int LuuThongTinHoaDon(ref string err, string maHD, DateTime ngayLap, DateTime ngayGiao ,string maKhachHang, string maNV)
        {
            SqlParameter[] sqls = new SqlParameter[]
                {
                        new SqlParameter("@MaHoaDon", maHD),
                         new SqlParameter("@NgayLap", ngayLap),
                          new SqlParameter("@NgayGiao", ngayGiao),
                          new SqlParameter("@MaKH", maKhachHang),
                          new SqlParameter("@MaNV", maNV)
                };

            return db.MyExcuteNonQuery(ref err, "PSP_HoaDon_GetMaxOrderIDByDate", CommandType.StoredProcedure, sqls);
        }
    }
}
