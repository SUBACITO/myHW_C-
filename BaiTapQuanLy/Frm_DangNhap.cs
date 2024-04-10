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
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == null && tbPassword.Text == null) return;

            if (KiemTraDangNhap(tbUsername.Text, tbPassword.Text))
            {
                clsMain.nickname = dtUser.Rows[0]["HoTenNV"].ToString();
                clsMain.username = dtUser.Rows[0]["TaiKhoan"].ToString();
                clsMain.maNV = dtUser.Rows[0]["MaNV"].ToString();
                if (dtUser.Rows[0]["GroupID"].ToString() == "1")
                    clsMain.role = "admin";
                else clsMain.role = "user";

                MessageBox.Show(clsMain.role);
                this.Close();
            }

        }

        
        private bool KiemTraDangNhap(string username, string password)
        {
            dtUser = new DataTable();
            dtUser = bll_HeThong.KiemTraDangNhap(ref err, tbUsername.Text, tbPassword.Text);
            if(dtUser.Rows.Count > 0)
            {
                if (dtUser.Rows[0]["Code"].ToString().Equals("1"))
                {
                    LayGiaTriQuyen(dtUser.Rows[0]["MaNV"].ToString());
                    return true;
                }
                else
                {
                    MessageBox.Show("Tài khoản không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
      
            return false;
        }

        private void LayGiaTriQuyen(string maNV)
        {
            DataTable dtQuyen = new DataTable();
            dtQuyen = bll_HeThong.LayDanhSachQuyen(ref err, maNV);
            if(dtQuyen.Rows.Count > 0)
            {
                foreach(DataRow item in dtQuyen.Rows)
                {
                        //clsMain.hsQuyenByUser.Add(item["Alias"], Convert.ToInt32(item["Total"].ToString()));
                }
            }
        }

        string err = string.Empty;
        Bll_HeThong bll_HeThong;
        DataTable dtUser;

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            bll_HeThong = new Bll_HeThong(clsMain.path);
            tbUsername.Text = "admin";
            tbPassword.Text = "123456";
            tbPassword.UseSystemPasswordChar = false; 
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = checkBox1.Checked;
        }

    

 

    }
}
