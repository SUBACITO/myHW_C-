using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapQuanLy
{
    class clsMain
    {
        public static string path = string.Format(@"{0}\Connection.ini", Application.StartupPath);
        public static string dataName = string.Empty;
        public static string nickname = string.Empty;
        public static string username = string.Empty;
        public static string role = string.Empty;
        public static string maNV = string.Empty;

        public static Hashtable hsQuyenByUser = new Hashtable();

        public static bool CheckQuyen(Form frm, QUYEN quyen)
        {
            foreach (string key in hsQuyenByUser.Keys)
            {
                if (key.Equals(frm.Name))
                {
                    return (Convert.ToInt32(hsQuyenByUser[key].ToString()) & ((int)quyen)) == ((int)quyen) ? true : false;
                    //15&2==2?true:false
                }
            }
            return false;
        }

        public static void DinhDangDGV(DataGridView dgv)
        {
            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.DarkGray
            };

            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter, Font = new Font("Arial", 12f, FontStyle.Bold)
            };

            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowTemplate.Height = 32;
        }

    }
}
