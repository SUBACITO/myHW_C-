using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyBanHang.DataLayer;
using System.Data.SqlClient;
using BaiTapQuanLy.DTO;


namespace BaiTapQuanLy.BussinessLayer
{

    class Bll_HeThong
    {
        MyDatabase db;
        
        public Bll_HeThong(string path)
        {
            db = new MyDatabase(path);
        }

        //Get List Customer
        public DataTable KiemTraDangNhap (ref string err, string username, string password)
        {
            SqlParameter[] sqlPara = new SqlParameter[]{
                new SqlParameter("@TaiKhoan", username),
                new SqlParameter("@MatKhau", password)
            };
            return db.GetDataTable(ref err, "PSP_201103_NhanVien_KiemTraDangNhap", CommandType.StoredProcedure, sqlPara);
        }

        #region Phân quyền
        public DataTable LayDuLieuCboGroupUser(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_GroupUser_SelectToCombo", CommandType.StoredProcedure, null);
        }
        #endregion

        public DataTable LayDanhSachChucNangTheoGroupID(ref string err, string groupID)
        {
            SqlParameter[] sqlPara = new SqlParameter[]{
                new SqlParameter("@GroupID", groupID),
            };
            return db.GetDataTable(ref err, "PSP_PhanQuyen_SelectToGrid", CommandType.StoredProcedure, sqlPara);
        }

        public int CapNhatPhanQuyen(ref string err, string funcId, string groupId, int tong)
        {
                SqlParameter[] sqlParameters = new SqlParameter[]
         {
             new SqlParameter("@GroupID",groupId),
              new SqlParameter("@FuncID",funcId),
               new SqlParameter("@Total",tong)
         };
                return db.MyExcuteNonQuery(ref err, "PSP_PhanQuyen_InsertAndUpdate", CommandType.StoredProcedure, sqlParameters);
            }


        public DataTable LayDanhSachQuyen(ref string err, string maNV)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                 new SqlParameter("@MaNV",maNV)
             };
             return db.GetDataTable(ref err, "PSP_PhanQuyen_Select", CommandType.StoredProcedure, sqlParameters);
        }

        public DataTable LayDanhSachTaiKhoan(ref string err)
        {
            return db.GetDataTable(ref err, "PSP_NhanVien_SelectToCboTaiKhoan", CommandType.StoredProcedure, null);
        }


        public int NhanVienDoiMatKHau(ref string err, string taiKhoan, string matKhau)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
         {
             new SqlParameter("@TaiKhoan", taiKhoan),
              new SqlParameter("@MatKhau", matKhau)
         };
            return db.MyExcuteNonQuery(ref err, "PSP_NhanVien_DoiMatKhau", CommandType.StoredProcedure, sqlParameters);
        }

        public bool SaoLuuDatabase(ref string err, string path)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                 new SqlParameter("@Path", path)
             };
            return db.MyExcuteNonQuery(ref err, "PSP_BackUp", CommandType.StoredProcedure, sqlParameters) == 1?true : false;
        }

        public bool PhucHoiDatabase(ref string err, string path)
        {
            string commandText = "...";
            return db.MyExcuteNonQuery(ref err, commandText,CommandType.Text) == 1 ? true : false;
        }
    }
}
