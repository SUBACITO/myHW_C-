namespace BaiTapQuanLy
{
    partial class Frm_ThemSuaKhachHang
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
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbhoKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbdcKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbtenKh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbdtKH = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(146, 295);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(99, 40);
            this.btnThemSua.TabIndex = 0;
            this.btnThemSua.Text = "Cập nhật";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(251, 295);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 40);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Enabled = false;
            this.tbMaKH.Location = new System.Drawing.Point(146, 27);
            this.tbMaKH.Multiline = true;
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(208, 38);
            this.tbMaKH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ KH:";
            // 
            // tbhoKH
            // 
            this.tbhoKH.Location = new System.Drawing.Point(146, 80);
            this.tbhoKH.Multiline = true;
            this.tbhoKH.Name = "tbhoKH";
            this.tbhoKH.Size = new System.Drawing.Size(208, 38);
            this.tbhoKH.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Địa chỉ:";
            // 
            // tbdcKH
            // 
            this.tbdcKH.Location = new System.Drawing.Point(146, 189);
            this.tbdcKH.Multiline = true;
            this.tbdcKH.Name = "tbdcKH";
            this.tbdcKH.Size = new System.Drawing.Size(208, 38);
            this.tbdcKH.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên KH:";
            // 
            // tbtenKh
            // 
            this.tbtenKh.Location = new System.Drawing.Point(146, 136);
            this.tbtenKh.Multiline = true;
            this.tbtenKh.Name = "tbtenKh";
            this.tbtenKh.Size = new System.Drawing.Size(208, 38);
            this.tbtenKh.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "SDT:";
            // 
            // tbdtKH
            // 
            this.tbdtKH.Location = new System.Drawing.Point(146, 241);
            this.tbdtKH.Multiline = true;
            this.tbdtKH.Name = "tbdtKH";
            this.tbdtKH.Size = new System.Drawing.Size(208, 38);
            this.tbdtKH.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(376, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(18, 19);
            this.lblErr.Text = "...";
            // 
            // Frm_ThemSuaKhachHang
            // 
            this.AcceptButton = this.btnThemSua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(376, 371);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbdtKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbdcKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtenKh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbhoKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaKH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemSua);
            this.Name = "Frm_ThemSuaKhachHang";
            this.Text = "Frm_ThemSuaKhachHang";
            this.Load += new System.EventHandler(this.Frm_ThemSuaKhachHang_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbhoKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbdcKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbtenKh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbdtKH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblErr;
    }
}