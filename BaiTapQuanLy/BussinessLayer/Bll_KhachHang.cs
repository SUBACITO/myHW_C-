using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyBanHang.DataLayer;
using System.Data.SqlClient;
using BaiTapQuanLy.DTO;

namespace BaiTapQuanLy.BussinessLayer
{
    public class Bll_KhachHang
    {
        MyDatabase db;
        
        public Bll_KhachHang(string path)
        {
            db = new MyDatabase(path);
        }

        //Get List Customer
        public DataTable LayKhachHangs (ref string err, string maKH)
        {
            return db.GetDataTable(ref err, "VSP_240305_KhachHang_Select", CommandType.StoredProcedure, new SqlParameter("@MaKH", maKH));
        }

        public int CapNhatKhachHang(ref string err, KhachHang khachHang)
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaKH", khachHang.MaKH),
                new SqlParameter("@HoKH", khachHang.HoKH),
                new SqlParameter("@TenKh", khachHang.TenKh),
                new SqlParameter("@DcKH", khachHang.DcKH),
                new SqlParameter("@DtKH", khachHang.DtKH)
            }; 
            return db.MyExcuteNonQuery(ref err, "PSP_240303_KhachHang_InsertAndUpdate", CommandType.StoredProcedure, sp);
        }

        public int XoaKhachHangTheoID(ref string err, KhachHang khachHang)
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaKH", khachHang.MaKH)
            };
            return db.MyExcuteNonQuery(ref err, "PSP_240304_KhachHang_Delete", CommandType.StoredProcedure, sp);
        }
    }
}
