namespace BaiTapQuanLy
{
    partial class Frm_SaoLuu_PhucHoi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveSL = new System.Windows.Forms.Button();
            this.btnSaoLuu = new System.Windows.Forms.Button();
            this.tbSaoLuu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPhucHoi = new System.Windows.Forms.Button();
            this.tbPhucHoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenPH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveSL);
            this.groupBox1.Controls.Add(this.btnSaoLuu);
            this.groupBox1.Controls.Add(this.tbSaoLuu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao Lưu Database";
            // 
            // btnSaveSL
            // 
            this.btnSaveSL.Location = new System.Drawing.Point(488, 23);
            this.btnSaveSL.Name = "btnSaveSL";
            this.btnSaveSL.Size = new System.Drawing.Size(30, 23);
            this.btnSaveSL.TabIndex = 3;
            this.btnSaveSL.Text = "...";
            this.btnSaveSL.UseVisualStyleBackColor = true;
            this.btnSaveSL.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Location = new System.Drawing.Point(488, 53);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(130, 23);
            this.btnSaoLuu.TabIndex = 2;
            this.btnSaoLuu.Text = "Sao lưu";
            this.btnSaoLuu.UseVisualStyleBackColor = true;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // tbSaoLuu
            // 
            this.tbSaoLuu.Location = new System.Drawing.Point(91, 34);
            this.tbSaoLuu.Name = "tbSaoLuu";
            this.tbSaoLuu.Size = new System.Drawing.Size(378, 20);
            this.tbSaoLuu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenPH);
            this.groupBox2.Controls.Add(this.btnPhucHoi);
            this.groupBox2.Controls.Add(this.tbPhucHoi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phục hồi Database";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Location = new System.Drawing.Point(488, 53);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(130, 23);
            this.btnPhucHoi.TabIndex = 2;
            this.btnPhucHoi.Text = "Phục hồi";
            this.btnPhucHoi.UseVisualStyleBackColor = true;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // tbPhucHoi
            // 
            this.tbPhucHoi.Location = new System.Drawing.Point(91, 34);
            this.tbPhucHoi.Name = "tbPhucHoi";
            this.tbPhucHoi.Size = new System.Drawing.Size(378, 20);
            this.tbPhucHoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đường dẫn:";
            // 
            // btnOpenPH
            // 
            this.btnOpenPH.Location = new System.Drawing.Point(488, 24);
            this.btnOpenPH.Name = "btnOpenPH";
            this.btnOpenPH.Size = new System.Drawing.Size(30, 23);
            this.btnOpenPH.TabIndex = 4;
            this.btnOpenPH.Text = "...";
            this.btnOpenPH.UseVisualStyleBackColor = true;
            this.btnOpenPH.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_SaoLuu_PhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 213);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_SaoLuu_PhucHoi";
            this.Text = "Frm_SaoLuu_PhucHoi";
            this.Load += new System.EventHandler(this.Frm_SaoLuu_PhucHoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.TextBox tbSaoLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPhucHoi;
        private System.Windows.Forms.TextBox tbPhucHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSL;
        private System.Windows.Forms.Button btnOpenPH;
    }
}