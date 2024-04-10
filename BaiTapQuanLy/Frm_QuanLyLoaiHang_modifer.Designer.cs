namespace BaiTapQuanLy
{
    partial class Frm_QuanLyLoaiHang_modifer
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenLH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaLH = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên LH:";
            // 
            // tbTenLH
            // 
            this.tbTenLH.Location = new System.Drawing.Point(115, 69);
            this.tbTenLH.Multiline = true;
            this.tbTenLH.Name = "tbTenLH";
            this.tbTenLH.Size = new System.Drawing.Size(208, 38);
            this.tbTenLH.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã LH:";
            // 
            // tbMaLH
            // 
            this.tbMaLH.Enabled = false;
            this.tbMaLH.Location = new System.Drawing.Point(115, 16);
            this.tbMaLH.Multiline = true;
            this.tbMaLH.Name = "tbMaLH";
            this.tbMaLH.Size = new System.Drawing.Size(208, 38);
            this.tbMaLH.TabIndex = 14;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(220, 137);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 40);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(115, 137);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(99, 40);
            this.btnThemSua.TabIndex = 12;
            this.btnThemSua.Text = "Cập nhật";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // Frm_QuanLyLoaiHang_modifer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTenLH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaLH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemSua);
            this.Name = "Frm_QuanLyLoaiHang_modifer";
            this.Text = "Frm_QuanLyLoaiHang_modifer";
            this.Load += new System.EventHandler(this.Frm_QuanLyLoaiHang_modifer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaLH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemSua;
    }
}