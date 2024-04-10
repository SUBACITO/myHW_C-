namespace BaiTapQuanLy
{
    partial class Frm_DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapLaiMk = new System.Windows.Forms.Button();
            this.cbChonTk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMatKhauNhapLai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapLaiMk);
            this.groupBox1.Controls.Add(this.cbChonTk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reset mật khẩu";
            // 
            // btnCapLaiMk
            // 
            this.btnCapLaiMk.Location = new System.Drawing.Point(296, 37);
            this.btnCapLaiMk.Name = "btnCapLaiMk";
            this.btnCapLaiMk.Size = new System.Drawing.Size(118, 21);
            this.btnCapLaiMk.TabIndex = 2;
            this.btnCapLaiMk.Text = "Cấp lại mật khẩu";
            this.btnCapLaiMk.UseVisualStyleBackColor = true;
            this.btnCapLaiMk.Click += new System.EventHandler(this.btnCapLaiMk_Click);
            // 
            // cbChonTk
            // 
            this.cbChonTk.FormattingEnabled = true;
            this.cbChonTk.Location = new System.Drawing.Point(10, 37);
            this.cbChonTk.Name = "cbChonTk";
            this.cbChonTk.Size = new System.Drawing.Size(279, 21);
            this.cbChonTk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn tài khoản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMatKhauNhapLai);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbMatKhau);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đổi mật khẩu";
            // 
            // tbMatKhauNhapLai
            // 
            this.tbMatKhauNhapLai.Location = new System.Drawing.Point(130, 67);
            this.tbMatKhauNhapLai.Name = "tbMatKhauNhapLai";
            this.tbMatKhauNhapLai.Size = new System.Drawing.Size(159, 20);
            this.tbMatKhauNhapLai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập lại mật khẩu mới:";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(130, 37);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(159, 20);
            this.tbMatKhau.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(296, 37);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(118, 50);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // Frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DoiMatKhau";
            this.Text = "Frm_DoiMatKhau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapLaiMk;
        private System.Windows.Forms.ComboBox cbChonTk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMatKhauNhapLai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatKhau;
    }
}