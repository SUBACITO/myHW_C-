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
    public partial class Frm_ThemSuaKhachHang : Form
    {
        public Frm_ThemSuaKhachHang()
        {
            InitializeComponent();
        }
        Bll_KhachHang bd;
        string err = string.Empty;
        public KhachHang khachHang = new KhachHang();
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbtenKh.Text))
            {
                khachHang = new KhachHang()
                {
                    MaKH = tbMaKH.Text,
                    HoKH = tbhoKH.Text,
                    TenKh = tbtenKh.Text,
                    DcKH = tbdcKH.Text,
                    DtKH = tbdtKH.Text
                    
                };
                if(bd.CapNhatKhachHang(ref err, khachHang) > 0)
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
                MessageBox.Show("Chua nhap ten kh");
            }
        }

        public bool isThem = false;

        private void Frm_ThemSuaKhachHang_Load(object sender, EventArgs e)
        {
            bd = new Bll_KhachHang(clsMain.path);
            if(isThem)
            {
                tbMaKH.Text = "0";
                tbhoKH.Focus();
            }
            else
            {
                KhachHangToControl(khachHang);
            }
        } //Them hay sua

        private void KhachHangToControl(KhachHang khachHang)
        {
            if (khachHang == null) return;

            tbMaKH.Text = khachHang.MaKH;
            tbhoKH.Text = khachHang.HoKH;
            tbtenKh.Text = khachHang.TenKh;
            tbdcKH.Text = khachHang.DcKH;
            tbdtKH.Text = khachHang.DtKH;
        }
    }
}
