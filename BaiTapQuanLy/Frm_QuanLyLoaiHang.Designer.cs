namespace BaiTapQuanLy
{
    partial class Frm_QuanLyLoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyLoaiHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbHienThiLoaiHang = new System.Windows.Forms.ToolStripButton();
            this.tsbThemLoaiHang = new System.Windows.Forms.ToolStripButton();
            this.tsbSuaLoaiHang = new System.Windows.Forms.ToolStripButton();
            this.tsbXoaLoaiHang = new System.Windows.Forms.ToolStripButton();
            this.dgvQLLH = new System.Windows.Forms.DataGridView();
            this.colMaLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLH)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHienThiLoaiHang,
            this.tsbThemLoaiHang,
            this.tsbSuaLoaiHang,
            this.tsbXoaLoaiHang});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbHienThiLoaiHang
            // 
            this.tsbHienThiLoaiHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbHienThiLoaiHang.Image = ((System.Drawing.Image)(resources.GetObject("tsbHienThiLoaiHang.Image")));
            this.tsbHienThiLoaiHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHienThiLoaiHang.Name = "tsbHienThiLoaiHang";
            this.tsbHienThiLoaiHang.Size = new System.Drawing.Size(28, 24);
            this.tsbHienThiLoaiHang.Text = "F5";
            // 
            // tsbThemLoaiHang
            // 
            this.tsbThemLoaiHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbThemLoaiHang.Image = ((System.Drawing.Image)(resources.GetObject("tsbThemLoaiHang.Image")));
            this.tsbThemLoaiHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThemLoaiHang.Name = "tsbThemLoaiHang";
            this.tsbThemLoaiHang.Size = new System.Drawing.Size(50, 24);
            this.tsbThemLoaiHang.Text = "Thêm";
            this.tsbThemLoaiHang.Click += new System.EventHandler(this.tsbThemLoaiHang_Click);
            // 
            // tsbSuaLoaiHang
            // 
            this.tsbSuaLoaiHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSuaLoaiHang.Image = ((System.Drawing.Image)(resources.GetObject("tsbSuaLoaiHang.Image")));
            this.tsbSuaLoaiHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSuaLoaiHang.Name = "tsbSuaLoaiHang";
            this.tsbSuaLoaiHang.Size = new System.Drawing.Size(38, 24);
            this.tsbSuaLoaiHang.Text = "Sửa";
            this.tsbSuaLoaiHang.Click += new System.EventHandler(this.tsbSuaLoaiHang_Click);
            // 
            // tsbXoaLoaiHang
            // 
            this.tsbXoaLoaiHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbXoaLoaiHang.Image = ((System.Drawing.Image)(resources.GetObject("tsbXoaLoaiHang.Image")));
            this.tsbXoaLoaiHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoaLoaiHang.Name = "tsbXoaLoaiHang";
            this.tsbXoaLoaiHang.Size = new System.Drawing.Size(39, 24);
            this.tsbXoaLoaiHang.Text = "Xóa";
            this.tsbXoaLoaiHang.Click += new System.EventHandler(this.tsbXoaLoaiHang_Click);
            // 
            // dgvQLLH
            // 
            this.dgvQLLH.AllowUserToAddRows = false;
            this.dgvQLLH.AllowUserToDeleteRows = false;
            this.dgvQLLH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQLLH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLH,
            this.colTenLH});
            this.dgvQLLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLLH.Location = new System.Drawing.Point(0, 57);
            this.dgvQLLH.MultiSelect = false;
            this.dgvQLLH.Name = "dgvQLLH";
            this.dgvQLLH.ReadOnly = true;
            this.dgvQLLH.RowHeadersVisible = false;
            this.dgvQLLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLLH.Size = new System.Drawing.Size(584, 349);
            this.dgvQLLH.TabIndex = 2;
            this.dgvQLLH.Click += new System.EventHandler(this.dgvQLLH_Click);
            // 
            // colMaLH
            // 
            this.colMaLH.DataPropertyName = "MaLH";
            this.colMaLH.HeaderText = "Mã loại hàng";
            this.colMaLH.Name = "colMaLH";
            this.colMaLH.ReadOnly = true;
            // 
            // colTenLH
            // 
            this.colTenLH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLH.DataPropertyName = "TenLH";
            this.colTenLH.HeaderText = "Tên loại hoàng";
            this.colTenLH.Name = "colTenLH";
            this.colTenLH.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý loại hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_QuanLyLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 406);
            this.Controls.Add(this.dgvQLLH);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QuanLyLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_QuanLyLoaiHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_QuanLyLoaiHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThemLoaiHang;
        private System.Windows.Forms.DataGridView dgvQLLH;
        private System.Windows.Forms.ToolStripButton tsbHienThiLoaiHang;
        private System.Windows.Forms.ToolStripButton tsbSuaLoaiHang;
        private System.Windows.Forms.ToolStripButton tsbXoaLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLH;
        private System.Windows.Forms.Label label1;
    }
}