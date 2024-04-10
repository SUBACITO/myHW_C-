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
    public partial class Frm_QuanLySanPham_Main : Form
    {
        public SanPham sanPham;
        public Frm_QuanLySanPham_Main()
        {
            InitializeComponent();
            clsMain.DinhDangDGV(dgvQLSP);
        }

        Bll_SanPham bd;
        string err = string.Empty;
        DataTable dtSanPham;

        private void Frm_QuanLySanPham_Main_Load(object sender, EventArgs e)
        {
            bd = new Bll_SanPham(clsMain.path);
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            dtSanPham = new DataTable();
            dtSanPham = bd.LayDsSanPham(ref err, "0");
            dgvQLSP.DataSource = dtSanPham.DefaultView;

            foreach (DataColumn item in dtSanPham.Columns)
            {
                cboThuocTinh.Items.Add(item.ColumnName);
            }
        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_QuanLySanPham_Modified f = new Frm_QuanLySanPham_Modified();
            f.isAdd = true;
            f.ShowDialog();
        }


        private void dgvQLSP_Click(object sender, EventArgs e)
        {
            if (dgvQLSP.Rows.Count > 0)
            {
                sanPham = new SanPham()
                {
                    MaSanPham = dgvQLSP.CurrentRow.Cells["colMaSanPham"].Value.ToString(),
                    TenSanPham = dgvQLSP.CurrentRow.Cells["colTenSanPham"].Value.ToString(),
                    MaDonViTinh = dgvQLSP.CurrentRow.Cells["colMaDonViTinh"].Value.ToString(),
                    MaLoaiSanPham = dgvQLSP.CurrentRow.Cells["colMaLoaiSanPham"].Value.ToString(),
                    QuyCachSanPham = dgvQLSP.CurrentRow.Cells["colQuyCachSanPham"].Value.ToString()
                };
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_QuanLySanPham_Modified f = new Frm_QuanLySanPham_Modified();
            f.isAdd = false;
            f.ShowDialog();
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtSanPham.DefaultView;
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                switch (cboThuocTinh. Text)
                {
                case "SoLuongTon":
                    dv.RowFilter = string.Format("{0} >= {1}", cboThuocTinh. Text, txtTimKiem.Text);
                    break;
                default:
                     dv.RowFilter = string.Format("{0} LIKE '%{1}%'", cboThuocTinh.Text, txtTimKiem.Text);
                    break;
                }
            }
            else
            {
                dv.RowFilter = "";
            }
            
        }


      



    }
}
