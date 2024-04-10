using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyBanHang.DataLayer;
using System.Data.SqlClient;
using BaiTapQuanLy.DTO;


namespace BaiTapQuanLy.BussinessLayer
{
    class Bll_HangHoa
    {
        MyDatabase db;

        public Bll_HangHoa(string path)
        {
            db = new MyDatabase(path);
        }

        //Get List Customer
        public DataTable HienThiLoaiHang (ref string err, string MaLH)
        {
            SqlParameter[] sqlPara = new SqlParameter[]{
                new SqlParameter("@MaLH", MaLH),
            };
            return db.GetDataTable(ref err, "PSP_SUBACITO_HienThiLoaiHang", CommandType.StoredProcedure, sqlPara);
        }


        public int CapNhatLoaiHang(ref string err, LoaiHang loaiHang)
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaLH", loaiHang.MaLH),
                new SqlParameter("@TenLH", loaiHang.TenLH),
            };
            return db.MyExcuteNonQuery(ref err, "PSP_SUBACITO_CapNhatLoaiHang", CommandType.StoredProcedure, sp);
        }

        public int XoaLoaiHangTheoID(ref string err, LoaiHang loaiHang)
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaLH", loaiHang.MaLH)
            };
            return db.MyExcuteNonQuery(ref err, "PSP_SUBACITO_Delete_LoaiHang", CommandType.StoredProcedure, sp);
        }
    }
}
