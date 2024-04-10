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
    public partial class Frm_PhanQuyen : Frm_Base
    {
        public Frm_PhanQuyen()
        {
            InitializeComponent();
        }

        Bll_HeThong bd;
        string err = string.Empty;
        DataTable dtgGroupUser;
        bool trangThaiLoadCombo = false;


        string funcId, groupId;
        int toltal = 0;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dtgPhanQuyen.Rows.Count; i++)
            {
                funcId = dtgPhanQuyen.Rows[i].Cells["colFuncID"].Value.ToString();
                groupId = dtgPhanQuyen.Rows[i].Cells["colGroupID"].Value.ToString();
                toltal = Convert.ToInt32(dtgPhanQuyen.Rows[i].Cells["colTong"].Value.ToString());
                bd.CapNhatPhanQuyen(ref err, funcId, groupId, toltal);

            }
            HienThiDSFunctionsByUser(cbGroupUser.SelectedValue.ToString());
        }

        private void Frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            bd = new Bll_HeThong(clsMain.path);
            HienThiDuLieuCboGroupUser();
        }

        private void HienThiDuLieuCboGroupUser()
        {
            dtgGroupUser = new DataTable();
            dtgGroupUser = bd.LayDuLieuCboGroupUser(ref err);

            cbGroupUser.DataSource = dtgGroupUser;
            cbGroupUser.DisplayMember = "GroupName";
            cbGroupUser.ValueMember = "GroupID";

            cbGroupUser.SelectedIndex = -1;
            cbGroupUser.Text = "chọn nhóm User ";
            trangThaiLoadCombo = true;


        }

        private void cbGroupUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGroupUser.SelectedIndex >=0 && trangThaiLoadCombo==true)
            {
                HienThiDSFunctionsByUser(cbGroupUser.SelectedValue.ToString());
            }
        }
        DataTable dtPhanQuyen;
        private void HienThiDSFunctionsByUser(string groupID)
        {
            dtPhanQuyen = new DataTable();
            dtPhanQuyen = bd.LayDanhSachChucNangTheoGroupID(ref err, groupID);
            dtgPhanQuyen.DataSource = dtPhanQuyen.DefaultView;
        }

        private void dtgPhanQuyen_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPhanQuyen.CurrentCell.ColumnIndex >= 5 && dtgPhanQuyen.CurrentCell.ColumnIndex <= 8)
            {
                int diem = 0;
                for (int i = 5; i <= 8; i++)
                {
                    if (dtgPhanQuyen.CurrentRow.Cells[i].Value.ToString().Equals("1"))
                    {
                        switch (i)
                        {
                            case 5:
                                diem += 1;
                                break;
                            case 6:
                                diem += 2;
                                break;
                            case 7:
                                diem += 4;
                                break;
                            case 8:
                                diem += 8;
                                break;
                        }
                    }    
                }
                dtgPhanQuyen.CurrentRow.Cells["colTong"].Value = string.Format("{0}", diem);

                }
            }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        }
    }
