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
    public partial class Frm_QuanLyNhapHang_Main : Frm_Base
    {
        public Frm_QuanLyNhapHang_Main()
        {
            InitializeComponent();
        }

      

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_QuanLyNhapHang_Modifies f = new Frm_QuanLyNhapHang_Modifies();
            f.ShowDialog();
        }
        DataTable dt;

        private void HienThiDuLieu()
        {
            dt = new DataTable();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            //DataView dv = dtPhieuNhap.defa
            if(string.IsNullOrEmpty(txtSearch.Text))
            {

            }
            else
            {

            }
        }

        
    }
}
