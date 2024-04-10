using BaiTapQuanLy.BussinessLayer;
using BaiTapQuanLy.DTO;
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
    public partial class Frm_QuanLySanPham_Modified : Form
    {
        Bll_SanPham bd;
        string err = string.Empty;
        public SanPham sanPham;
        public bool isAdd = false;

        public Frm_QuanLySanPham_Modified()
        {
            InitializeComponent();
        }

        private void Frm_QuanLySanPham_Modified_Load(object sender, EventArgs e)
        {
            bd = new Bll_SanPham(clsMain.path);
            HienThiCboDonViTinh();
            HienThiCboLoaiSanPham();
            if(isAdd)
            {
                txtMaSanPham.Text = bd.SinhMaLonNhat(ref err).ToString();
                txtTenSanPham.Focus();
            }
            else
            {
                GanSanPhamVaoControl(sanPham);
            }
        }

        private void GanSanPhamVaoControl(SanPham sanPham)
        {
            //throw new NotImplementedException();
            txtMaSanPham.Text = sanPham.MaSanPham;
            txtTenSanPham.Text = sanPham.TenSanPham;
            cboDonViTinh.SelectedValue = sanPham.MaDonViTinh;
            cboLoaiSanPham.SelectedValue = sanPham.MaLoaiSanPham;
            txtSoLuongTon.Text = sanPham.SoLuongTon.ToString();
            txtTenSanPham.Focus();
        }

        private void HienThiCboLoaiSanPham()
        {
            //throw new NotImplementedException();
            DataTable dt = new DataTable();
            dt = bd.LayDlCboLoaiSanPham(ref err);
            cboLoaiSanPham.DataSource = dt;
            cboLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            cboLoaiSanPham.ValueMember = "MaLoaiSanPham";
            cboLoaiSanPham.SelectedIndex = -1;
            cboLoaiSanPham.Text = "--Chọn loại hàng";
        }

        private void HienThiCboDonViTinh()
        {
            //throw new NotImplementedException();
            DataTable dt = new DataTable();
            dt = bd.LayDlCboDonViTinh(ref err);
            cboDonViTinh.DataSource = dt;
            cboDonViTinh.DisplayMember = "TenDonViTinh";
            cboDonViTinh.ValueMember = "MaDonViTinh";
            cboDonViTinh.SelectedIndex = -1;
            cboDonViTinh.Text = "--Chọn đơn vị tính";
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
