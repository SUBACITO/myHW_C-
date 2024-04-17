using BaiTapQuanLy.BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapQuanLy
{
    public partial class Frm_BanHang : Frm_Base
    {
        public Frm_BanHang()
        {
            InitializeComponent();
        }
        Bll_HoaDon bd;
        string err = string.Empty;

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            bd = new Bll_HoaDon(clsMain.path);
            HienThiThongTinHoaDon();
        }

        private void HienThiThongTinHoaDon()
        {
            lblTenNhanVien.Text = clsMain.nickname;
            HienThiDuLieuCboKhachHang();
            SinhMaHoaDonTuDong(dtpNgayLap.Value);
        }

        private void SinhMaHoaDonTuDong(DateTime ngayLap)
        {
            int number = Convert.ToInt32(bd.LayMaHoaDonLonNhatTheoNgayLap(ref err, ngayLap));
            string maKh = cboKhachHang.ValueMember = "MaKH";
            lblMaHoaDon.Text = string.Format("{0:0000}{1:00}{2:00}", ngayLap.Year, ngayLap.Month, number);
            LuuHoaDon(number.ToString(), ngayLap, ngayLap, maKh, clsMain.maNV);
        }

        private void LuuHoaDon(string maHD, DateTime ngayLap, DateTime ngayGiao, string maKhachHang, string maNV)
        {
            bd.LuuThongTinHoaDon(ref err, maHD, ngayLap,ngayGiao, maKhachHang, maNV);
        }

        bool statusLoadKhachHang = false;

        private void HienThiDuLieuCboKhachHang()
        {
            DataTable dt = new DataTable();
            dt = bd.LayKhachHangToCbo(ref err);
            cboKhachHang.DataSource = dt;

            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.DisplayMember = "HoTenKhachHang";

            cboKhachHang.SelectedIndex = -1;
            cboKhachHang.Text = "--Chọn khách hàng";
            statusLoadKhachHang = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboKhachHang.SelectedIndex >-1 && statusLoadKhachHang)
            {
                SinhMaHoaDonTuDong(dtpNgayLap.Value);
            }
        }

      
    }
}
