using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapQuanLy.BussinessLayer;
using BaiTapQuanLy.DTO;

namespace BaiTapQuanLy
{
        
    public partial class Frm_QuanLyKhachHang_Main : Frm_Base
    {
        public Frm_QuanLyKhachHang_Main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            HienThiKhachHangs();
        }
        string err = string.Empty;
        Bll_KhachHang bll_KhachHang;
        DataTable dtKhachHangs;
        private void Frm_QuanLyKhachHang_Main_Load(object sender, EventArgs e)
        {
            bll_KhachHang = new Bll_KhachHang(clsMain.path);
            HienThiKhachHangs();
        }

        private void HienThiKhachHangs()
        {
            dtKhachHangs = new DataTable();
            dtKhachHangs = bll_KhachHang.LayKhachHangs(ref err, "0");
            dgvKhachHangs.DataSource = dtKhachHangs.DefaultView;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_ThemSuaKhachHang f = new Frm_ThemSuaKhachHang();
            f.isThem = true;
            f.ShowDialog();
            HienThiKhachHangs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(khachHang != null)
            {
                Frm_ThemSuaKhachHang f = new Frm_ThemSuaKhachHang();
                f.isThem = false;
                f.khachHang = khachHang;
                f.ShowDialog();
                HienThiKhachHangs();
                khachHang = null;
            }
            else
            {
                MessageBox.Show("Khach Hang Rong");
            }
           
        }

        KhachHang khachHang;
        private void dgvKhachHangs_Click(object sender, EventArgs e)
        {
            if(dgvKhachHangs.Rows.Count > 0)
            {
                khachHang = new KhachHang()
                {
                    MaKH = dgvKhachHangs.CurrentRow.Cells["colMaKH"].Value.ToString(),
                    HoKH = dgvKhachHangs.CurrentRow.Cells["colHoKH"].Value.ToString(),
                    TenKh = dgvKhachHangs.CurrentRow.Cells["colTenKH"].Value.ToString(),
                    DcKH = dgvKhachHangs.CurrentRow.Cells["colDcKH"].Value.ToString(),
                    DtKH = dgvKhachHangs.CurrentRow.Cells["colDtKH"].Value.ToString()
                };
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (khachHang == null) return;

           if(bll_KhachHang.XoaKhachHangTheoID(ref err, khachHang) > 0)
           {
               MessageBox.Show("Xoa Thanh Cong");
               HienThiKhachHangs();
               khachHang = null;
           }
           else
           {
               MessageBox.Show("Xoa Khong Thanh Cong " + err);
           }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            deDongtab();
        }

        
    }
}
