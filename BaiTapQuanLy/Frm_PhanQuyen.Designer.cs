namespace BaiTapQuanLy
{
    partial class Frm_PhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PhanQuyen));
            this.dtgPhanQuyen = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colThem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGroupUser = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhanQuyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPhanQuyen
            // 
            this.dtgPhanQuyen.AllowUserToAddRows = false;
            this.dtgPhanQuyen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgPhanQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPhanQuyen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colGroupID,
            this.colFuncID,
            this.colFuncName,
            this.colAlias,
            this.colXem,
            this.colThem,
            this.colSua,
            this.colXoa,
            this.colTong});
            this.dtgPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPhanQuyen.Location = new System.Drawing.Point(0, 74);
            this.dtgPhanQuyen.Name = "dtgPhanQuyen";
            this.dtgPhanQuyen.RowHeadersVisible = false;
            this.dtgPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPhanQuyen.Size = new System.Drawing.Size(1112, 339);
            this.dtgPhanQuyen.TabIndex = 2;
            this.dtgPhanQuyen.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhanQuyen_CellEndEdit);
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colGroupID
            // 
            this.colGroupID.DataPropertyName = "GroupID";
            this.colGroupID.HeaderText = "GroupID";
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.Visible = false;
            // 
            // colFuncID
            // 
            this.colFuncID.DataPropertyName = "FuncID";
            this.colFuncID.HeaderText = "FuncID";
            this.colFuncID.Name = "colFuncID";
            this.colFuncID.Visible = false;
            // 
            // colFuncName
            // 
            this.colFuncName.DataPropertyName = "FuncName";
            this.colFuncName.HeaderText = "Tên chức năng";
            this.colFuncName.Name = "colFuncName";
            this.colFuncName.ReadOnly = true;
            this.colFuncName.Width = 500;
            // 
            // colAlias
            // 
            this.colAlias.DataPropertyName = "Alias";
            this.colAlias.HeaderText = "Alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = false;
            // 
            // colXem
            // 
            this.colXem.DataPropertyName = "Xem";
            this.colXem.FalseValue = "0";
            this.colXem.HeaderText = "Xem";
            this.colXem.Name = "colXem";
            this.colXem.TrueValue = "1";
            // 
            // colThem
            // 
            this.colThem.DataPropertyName = "Them";
            this.colThem.FalseValue = "0";
            this.colThem.HeaderText = "Thêm";
            this.colThem.Name = "colThem";
            this.colThem.TrueValue = "1";
            // 
            // colSua
            // 
            this.colSua.DataPropertyName = "Sua";
            this.colSua.FalseValue = "0";
            this.colSua.HeaderText = "Sửa";
            this.colSua.Name = "colSua";
            this.colSua.TrueValue = "1";
            // 
            // colXoa
            // 
            this.colXoa.DataPropertyName = "Xoa";
            this.colXoa.FalseValue = "0";
            this.colXoa.HeaderText = "Xóa";
            this.colXoa.Name = "colXoa";
            this.colXoa.TrueValue = "1";
            // 
            // colTong
            // 
            this.colTong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTong.DataPropertyName = "Tong";
            this.colTong.HeaderText = "Tổng";
            this.colTong.Name = "colTong";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGroupUser);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1112, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn nhóm người dùng";
            // 
            // cbGroupUser
            // 
            this.cbGroupUser.FormattingEnabled = true;
            this.cbGroupUser.Location = new System.Drawing.Point(6, 17);
            this.cbGroupUser.Name = "cbGroupUser";
            this.cbGroupUser.Size = new System.Drawing.Size(415, 21);
            this.cbGroupUser.TabIndex = 2;
            this.cbGroupUser.SelectedIndexChanged += new System.EventHandler(this.cbGroupUser_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(478, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1112, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 413);
            this.Controls.Add(this.dtgPhanQuyen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PhanQuyen";
            this.Text = "Frm_PhanQuyen";
            this.Load += new System.EventHandler(this.Frm_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhanQuyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dtgPhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colXem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colThem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTong;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cbGroupUser;
    }
}