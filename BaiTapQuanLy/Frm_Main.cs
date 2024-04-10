using DevComponents.DotNetBar;
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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Frm_DangNhap f = new Frm_DangNhap();
            f.ShowDialog();
            statusLogin.Text = "Đăng nhập bởi: " + clsMain.nickname;
        }


        private void mnuQLKH_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quản lý khách hàng", new Frm_QuanLyKhachHang_Main(), QUYEN.XEM);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quản lý loại hàng", new Frm_QuanLyLoaiHang(), QUYEN.XEM);
        }

        //Tabcontrol
        bool bKTraMotab = false;
        string sTieuDe;
        public Frm_Main frm_Main;

        public delegate void _deDongTab();
        public _deDongTab deDongTab;

        #region cac phuong thuc mo form
        private bool CheckOpenTab(string name)
        {
            for (int i = 0; i < tabControl1.Tabs.Count; i++)
            {
                if (tabControl1.Tabs[i].Text == name)
                {
                    tabControl1.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void vDongTab()
        {
            foreach (TabItem iten in tabControl1.Tabs)
            {
                if (iten.IsSelected)
                {
                    tabControl1.Tabs.Remove(iten);
                    return;
                }
            }
        }


        private void tabControl1_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            TabItem t = tabControl1.SelectedTab;
            tabControl1.Tabs.Remove(t);

        }

        private void OpenForm(bool statusOpen, string title, Frm_Base frm)
        {
            bKTraMotab = statusOpen;
            sTieuDe = title;
            if (!CheckOpenTab(sTieuDe))
            {
                TabItem t = tabControl1.CreateTab(sTieuDe);
                t.Name = frm.Name;

                frm.deDongtab = new Frm_Base._deDongtab(vDongTab);
                this.frm_Main = this;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();

                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
        }

        private void OpenForm(bool statusOpen, string title, Frm_Base frm, QUYEN quyen)
        {
            if(clsMain.CheckQuyen(frm, quyen))
            {
                bKTraMotab = statusOpen;
                sTieuDe = title;
                if (!CheckOpenTab(sTieuDe))
                {
                    TabItem t = tabControl1.CreateTab(sTieuDe);
                    t.Name = frm.Name;

                    frm.deDongtab = new Frm_Base._deDongtab(vDongTab);
                    this.frm_Main = this;
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;
                    t.AttachedControl.Controls.Add(frm);
                    frm.Show();

                    tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
                }
            }
            else
            {
                MessageBox.Show("Lmao ban ko quyen!");
            }
            
        }


        #endregion

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quản lý phân quyền", new Frm_PhanQuyen());
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Thay đổi mật khẩu", new Frm_DoiMatKhau());
        }

        private void saoLưuPhụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Sao lưu và phục hồi", new Frm_SaoLuu_PhucHoi());
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(true, "Quan Ly Nhap Hang", new Frm_QuanLyNhapHang_Main());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DangNhap f = new Frm_DangNhap();
            f.ShowDialog();
            statusLogin.Text = "Đăng nhập bởi: " + clsMain.nickname;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
