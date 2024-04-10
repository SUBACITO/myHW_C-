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
    public partial class Frm_QuanLyLoaiHang_modifer : Form
    {
        public Frm_QuanLyLoaiHang_modifer()
        {
            InitializeComponent();
        }
        public bool isThem;
        Bll_HangHoa bd;
        string err = string.Empty;
        public LoaiHang loaiHang = new LoaiHang();

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTenLH.Text))
            {
                loaiHang = new LoaiHang()
                {
                    MaLH = tbMaLH.Text,
                    TenLH = tbTenLH.Text
                };
                if (bd.CapNhatLoaiHang(ref err, loaiHang) > 0)
                {
                    MessageBox.Show("Thanh Cong");
                }
                else
                {
                    MessageBox.Show(err);
                }
            }
            else
            {
                MessageBox.Show("Chua nhap ten lh");
            }
        }

        private void Frm_QuanLyLoaiHang_modifer_Load(object sender, EventArgs e)
        {
            bd = new Bll_HangHoa(clsMain.path);
            if(isThem)
            {
                tbMaLH.Text = "0";
                tbTenLH.Focus();
            }
            else
            {
                LoaiHangToControl(loaiHang);
            }
        }

        private void LoaiHangToControl(LoaiHang loaiHang)
        {
            if (loaiHang == null) return;

            tbMaLH.Text = loaiHang.MaLH;
            tbTenLH.Text = loaiHang.TenLH;
           
        }


     
    }
}
