namespace BaiTapQuanLy
{
    partial class Frm_QuanLySanPham_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLySanPham_Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvQLSP = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuyCachSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboThuocTinh = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1261, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton1.Text = "Nạp lại";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 24);
            this.toolStripButton2.Text = "Thêm";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(54, 24);
            this.toolStripButton3.Text = "Sửa";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(55, 24);
            this.toolStripButton4.Text = "Xóa";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(67, 24);
            this.toolStripButton5.Text = "Thoát";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1261, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvQLSP
            // 
            this.dgvQLSP.AllowUserToAddRows = false;
            this.dgvQLSP.AllowUserToDeleteRows = false;
            this.dgvQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colXoa,
            this.colMaSanPham,
            this.colTenSanPham,
            this.colSoLuongTon,
            this.colMaDonViTinh,
            this.colTenDonViTinh,
            this.colMaLoaiSanPham,
            this.colTenLoaiSanPham,
            this.colQuyCachSanPham});
            this.dgvQLSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLSP.Location = new System.Drawing.Point(0, 27);
            this.dgvQLSP.Name = "dgvQLSP";
            this.dgvQLSP.ReadOnly = true;
            this.dgvQLSP.RowHeadersVisible = false;
            this.dgvQLSP.Size = new System.Drawing.Size(1261, 562);
            this.dgvQLSP.TabIndex = 2;
            this.dgvQLSP.Click += new System.EventHandler(this.dgvQLSP_Click);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 50;
            // 
            // colXoa
            // 
            this.colXoa.DataPropertyName = "Xoa";
            this.colXoa.HeaderText = "Xóa";
            this.colXoa.Name = "colXoa";
            this.colXoa.ReadOnly = true;
            this.colXoa.Visible = false;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã Sản Phẩm";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.ReadOnly = true;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.ReadOnly = true;
            this.colTenSanPham.Width = 200;
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.HeaderText = "Số Lượng Tồn";
            this.colSoLuongTon.Name = "colSoLuongTon";
            this.colSoLuongTon.ReadOnly = true;
            this.colSoLuongTon.Width = 200;
            // 
            // colMaDonViTinh
            // 
            this.colMaDonViTinh.DataPropertyName = "MaDonViTinh";
            this.colMaDonViTinh.HeaderText = "Mã Đơn Vị Tính";
            this.colMaDonViTinh.Name = "colMaDonViTinh";
            this.colMaDonViTinh.ReadOnly = true;
            this.colMaDonViTinh.Width = 120;
            // 
            // colTenDonViTinh
            // 
            this.colTenDonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDonViTinh.DataPropertyName = "TenDonViTinh";
            this.colTenDonViTinh.HeaderText = "Tên Đơn Vị Tính";
            this.colTenDonViTinh.Name = "colTenDonViTinh";
            this.colTenDonViTinh.ReadOnly = true;
            // 
            // colMaLoaiSanPham
            // 
            this.colMaLoaiSanPham.DataPropertyName = "MaLoaiSanPham";
            this.colMaLoaiSanPham.HeaderText = "Mã Loại Sản Phẩm";
            this.colMaLoaiSanPham.Name = "colMaLoaiSanPham";
            this.colMaLoaiSanPham.ReadOnly = true;
            this.colMaLoaiSanPham.Width = 120;
            // 
            // colTenLoaiSanPham
            // 
            this.colTenLoaiSanPham.DataPropertyName = "TenLoaiSanPham";
            this.colTenLoaiSanPham.HeaderText = "Loại Sản Phẩm";
            this.colTenLoaiSanPham.Name = "colTenLoaiSanPham";
            this.colTenLoaiSanPham.ReadOnly = true;
            this.colTenLoaiSanPham.Width = 130;
            // 
            // colQuyCachSanPham
            // 
            this.colQuyCachSanPham.DataPropertyName = "QuyCachSanPham";
            this.colQuyCachSanPham.HeaderText = "Quy Cách Sản Phẩm";
            this.colQuyCachSanPham.Name = "colQuyCachSanPham";
            this.colQuyCachSanPham.ReadOnly = true;
            this.colQuyCachSanPham.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn thuộc tính:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(867, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(239, 20);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm:";
            // 
            // cboThuocTinh
            // 
            this.cboThuocTinh.FormattingEnabled = true;
            this.cboThuocTinh.Location = new System.Drawing.Point(546, 2);
            this.cboThuocTinh.Name = "cboThuocTinh";
            this.cboThuocTinh.Size = new System.Drawing.Size(238, 21);
            this.cboThuocTinh.TabIndex = 7;
            // 
            // Frm_QuanLySanPham_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 611);
            this.Controls.Add(this.cboThuocTinh);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQLSP);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_QuanLySanPham_Main";
            this.Text = "Frm_QuanLySanPham_Main";
            this.Load += new System.EventHandler(this.Frm_QuanLySanPham_Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvQLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuyCachSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboThuocTinh;
    }
}