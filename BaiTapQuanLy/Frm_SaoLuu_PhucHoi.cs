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
    public partial class Frm_SaoLuu_PhucHoi : Frm_Base
    {
        public Frm_SaoLuu_PhucHoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "bak";
            saveFileDialog.Title = "Nơi chứa tập tin sao lưu";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = @"D:\";
            saveFileDialog.FileName = string.Format("fileBackup_{0}{1}{2}{3}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute);
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbSaoLuu.Text = saveFileDialog.FileName;
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if(tbSaoLuu.Text != null)
            {
                if (bll.SaoLuuDatabase(ref err, tbSaoLuu.Text))
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }
        Bll_HeThong bll;
        string err = string.Empty;
        private void Frm_SaoLuu_PhucHoi_Load(object sender, EventArgs e)
        {
            bll = new Bll_HeThong(clsMain.path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "";
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.Title = "Nơi chứa file phục hồi";
            openFileDialog.RestoreDirectory = true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbPhucHoi.Text = openFileDialog.FileName;
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {

        }
        
    }
}
