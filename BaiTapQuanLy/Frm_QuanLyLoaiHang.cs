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
    public partial class Frm_QuanLyLoaiHang : Frm_Base
    {
        public Frm_QuanLyLoaiHang()
        {
            InitializeComponent();
        }
        string err = string.Empty;
        Bll_HangHoa bll_HangHoa;
        DataTable dt;

        private void Frm_QuanLyLoaiHang_Load(object sender, EventArgs e)
        {
            bll_HangHoa = new Bll_HangHoa(clsMain.path);
            HienThiLoaiHang();
        }

        private void HienThiLoaiHang()
        {
            dt = new DataTable();
            dt = bll_HangHoa.HienThiLoaiHang(ref err, "0");
            dgvQLLH.DataSource = dt.DefaultView;
        }

       
        private void tsbThemLoaiHang_Click(object sender, EventArgs e)
        {
            Frm_QuanLyLoaiHang_modifer f = new Frm_QuanLyLoaiHang_modifer();
            f.isThem = true;
            f.ShowDialog();
        }
        LoaiHang loaiHang;
        private void tsbSuaLoaiHang_Click(object sender, EventArgs e)
        {
            if (loaiHang != null)
            {
                Frm_QuanLyLoaiHang_modifer f = new Frm_QuanLyLoaiHang_modifer();
                f.isThem = false;
                f.loaiHang = loaiHang;
                f.ShowDialog();
                HienThiLoaiHang();
                loaiHang = null;
            }
            else
            {
                MessageBox.Show("Loai Hang Rong");
            }
        }

        private void dgvQLLH_Click(object sender, EventArgs e)
        {
            if (dgvQLLH.Rows.Count > 0)
            {
                loaiHang = new LoaiHang()
                {
                    MaLH = dgvQLLH.CurrentRow.Cells["colMaLH"].Value.ToString(),
                    TenLH = dgvQLLH.CurrentRow.Cells["colTenLH"].Value.ToString()
                };
            }
        }

        private void tsbXoaLoaiHang_Click(object sender, EventArgs e)
        {
            if (loaiHang == null) return;

            if (bll_HangHoa.XoaLoaiHangTheoID(ref err, loaiHang) > 0)
            {
                MessageBox.Show("Xoa Thanh Cong");
                HienThiLoaiHang();
                loaiHang = null;
            }
            else
            {
                MessageBox.Show("Xoa Khong Thanh Cong " + err);
            }
        }

    }
}
