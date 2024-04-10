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

namespace BaiTapQuanLy
{
    public partial class Frm_DoiMatKhau : Frm_Base
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        Bll_HeThong bll;
        DataTable dt;
        string err = string.Empty;
        bool trangThaiLoadCombo = false;
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            bll = new Bll_HeThong(clsMain.path);
            LayDanhSachTaiKhoan();
            
        }

        private void LayDanhSachTaiKhoan()
        {
            if(clsMain.role == "admin")
            {
                dt = new DataTable();
                dt = bll.LayDanhSachTaiKhoan(ref err);
                cbChonTk.DataSource = dt;

                cbChonTk.DisplayMember = "TaiKhoan";
                cbChonTk.ValueMember = "HoTenNV";


                cbChonTk.SelectedIndex = -1;
                cbChonTk.Text = "chọn nhóm User ";
                trangThaiLoadCombo = true;

                btnCapLaiMk.Enabled = true;
            }
            else
            {
                cbChonTk.Enabled = false;
                btnCapLaiMk.Enabled = false;
            }

            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string password = tbMatKhau.Text.ToString();
            string passwordConfirm = tbMatKhauNhapLai.Text.ToString();

            if(password == passwordConfirm && password != null && passwordConfirm != null)
            {   
                if (bll.NhanVienDoiMatKHau(ref err, clsMain.username, password) != 0)
                {
                    MessageBox.Show("Reset mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Reset mật khẩu thất bại!");
                }
            }
        }

        private void btnCapLaiMk_Click(object sender, EventArgs e)
        {
            string passwordDefault = "123456";
            string targetUser = cbChonTk.Text.ToString();
            if(targetUser != null)
            {
                if( bll.NhanVienDoiMatKHau(ref err, targetUser, passwordDefault) != 0)
                {
                    MessageBox.Show("Reset mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Reset mật khẩu thất bại!");
                }
            }

        }
    }
}
