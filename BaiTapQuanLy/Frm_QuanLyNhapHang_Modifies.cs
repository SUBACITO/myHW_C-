using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BaiTapQuanLy.BussinessLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;


namespace BaiTapQuanLy
{
    public partial class Frm_QuanLyNhapHang_Modifies : Form
    {
        public Frm_QuanLyNhapHang_Modifies()
        {
            InitializeComponent();
        }
        Bll_NhapHang bd;
        string err = string.Empty;
        string maPhieuNhap = string.Empty;
        private void Frm_QuanLyNhapHang_Modifies_Load(object sender, System.EventArgs e)
        {
            bd = new Bll_NhapHang(clsMain.path);
            maPhieuNhap =  bd.KiemTraMaPhieuChuaHoanThanh(ref err, clsMain.maNV);
            if (maPhieuNhap.Equals("no"))
            {
                txtMaPhieuNhap.Text = bd.LayPhieuNhapLonNhat(ref err);
                ThemMaPhieuVaoData(txtMaPhieuNhap.Text);
            }
            else
            {
                //load lại phieu nhập cũ
                MessageBox.Show("Phieu nhap cu");
                txtMaPhieuNhap.Text = maPhieuNhap;
                HienThiDuLieuChiTietPhieuNhap(txtMaPhieuNhap.Text);
            }
            HienThiDuLieuNhapHang();

        }

        private void ThemMaPhieuVaoData(string maPhieuNhap)
        {
            bd.ThemPhieuNhap(ref err, maPhieuNhap, clsMain.maNV);
        }


        private void HienThiDuLieuNhapHang()
        {
            HienThiDuLieuLoaiSanPham();
            HienThiDuLieuDonViTinh();
            lblNhanVien.Text = clsMain.nickname;
        }

        bool statusLoadLoaiSanPham = false;
        private void HienThiDuLieuLoaiSanPham()
        {
            DataTable dtLoaiSanPham = new DataTable();
            dtLoaiSanPham = bd.LayLoaiSanPham(ref err);

            cboLoaiSanPham.DataSource = dtLoaiSanPham;
            cboLoaiSanPham.ValueMember = "MaLoaiSanPham";
            cboLoaiSanPham.DisplayMember = "TenLoaiSanPham";

            cboLoaiSanPham.SelectedIndex = -1;
            cboLoaiSanPham.Text = "-- Chọn loại sản phẩm --";
            statusLoadLoaiSanPham = true;
        }

        private void HienThiDuLieuDonViTinh()
        {
            DataTable dtDonViTinh = new DataTable();
            dtDonViTinh = bd.LayDonViTinh(ref err);

            cboDonViTinh.DataSource = dtDonViTinh;
            cboDonViTinh.ValueMember = "MaDonViTinh";
            cboDonViTinh.DisplayMember = "TenDonViTinh";

            cboDonViTinh.SelectedIndex = -1;
            cboDonViTinh.Text = "-- Chọn sản phẩm --";
        }

        private void HienThiDuLieuSanPham(string maLoaiSanPham)
        {
            DataTable dtSanPham = new DataTable();
            dtSanPham = bd.LaySanPham(ref err, maLoaiSanPham);

            cboSanPham.DataSource = dtSanPham;
            cboSanPham.ValueMember = "MaSanPham";
            cboSanPham.DisplayMember = "TenSanPham";

            cboSanPham.SelectedIndex = -1;
            cboSanPham.Text = "-- Chọn sản phẩm --";

        }


        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSanPham.SelectedIndex >= 0 && statusLoadLoaiSanPham)
            {
                HienThiDuLieuSanPham(cboLoaiSanPham.SelectedValue.ToString());
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPhieuNhap.Text))
            {
                if (cboSanPham.SelectedIndex >= 0)
                {
                    //kiểm tra thêm vế sl, dongia, donvitinh.
                    if (bd.ThemChiTietPhieuNhap(ref err, txtMaPhieuNhap.Text, cboSanPham.SelectedValue.ToString(), txtSoLuongNhap.Text, txtDonGiaNhap.Text, cboDonViTinh.SelectedValue.ToString()) > 0)
                    {
                        MessageBox.Show("Them thanh cong");
                        HienThiDuLieuChiTietPhieuNhap(txtMaPhieuNhap.Text);
                    }
                }
                else
                {
                    MessageBox.Show("chua chon san pham");
                }
            }
            else
            {
                MessageBox.Show("cHUA CO PHIEU NHAAP");
            }

        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            if (bd.HoanTatPhieuNhap(ref err, maPhieuNhap, txtMoTa.Text) == 1)
            {
                MessageBox.Show("Hoàn tát phiếu nhập!");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (bd.HuyPhieuNhap(ref err, maPhieuNhap) > 0)
            {
                MessageBox.Show("Đã hủy phiếu nhập!");
                this.Close();
            }
        }
        private int TotalMoney;
        private void HienThiDuLieuChiTietPhieuNhap(string ma)
        {
            TotalMoney = 0;
            DataTable dtb = new DataTable();
            dtb = bd.LayChiTietPhieuNhap(ref err, ma);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                dtb.Rows[i]["STT"] = i + 1;
                TotalMoney += Int32.Parse(dtb.Rows[i]["ThanhTien"].ToString());
            }
            if(dtb.Rows.Count > 0)
            {
                lblTongSoLuong.Text = dtb.Rows[dtb.Rows.Count - 1]["STT"].ToString();
                lblTongThanhTien.Text = vnCashFormat(TotalMoney.ToString());
            }

            clsMain.DinhDangDGV(dgvChiTietPhieuNhap);

            dgvChiTietPhieuNhap.DataSource = dtb.DefaultView;

            if (dgvChiTietPhieuNhap.Columns.Contains("DonViTinh"))
                dgvChiTietPhieuNhap.Columns.Remove("DonViTinh");

            
        }

        private string vnCashFormat(string cash)
        {
            decimal amount;
            if (decimal.TryParse(cash, out amount))
            {
                // Format the number as Vietnamese currency
                string formattedCurrency = amount.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));

                // Display the formatted currency
                return formattedCurrency;
            }
            return cash;
        }

        private void LayThuocTinhToCB()
        {
                
        }
        
    }
}
