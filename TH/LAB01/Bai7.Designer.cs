namespace LAB01
{
    partial class frm_Bai7
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
            this.lnl_thongTin = new System.Windows.Forms.Label();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.txt_thongTin = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnl_thongTin
            // 
            this.lnl_thongTin.AutoSize = true;
            this.lnl_thongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnl_thongTin.Location = new System.Drawing.Point(55, 41);
            this.lnl_thongTin.Name = "lnl_thongTin";
            this.lnl_thongTin.Size = new System.Drawing.Size(138, 25);
            this.lnl_thongTin.TabIndex = 0;
            this.lnl_thongTin.Text = "Nhập thông tin";
            this.lnl_thongTin.Click += new System.EventHandler(this.lnl_thongTin_Click);
            // 
            // lbl_kq
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kq.Location = new System.Drawing.Point(55, 118);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(80, 25);
            this.lbl_kq.TabIndex = 1;
            this.lbl_kq.Text = "Kết quả";
            // 
            // txt_thongTin
            // 
            this.txt_thongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thongTin.Location = new System.Drawing.Point(215, 41);
            this.txt_thongTin.Multiline = true;
            this.txt_thongTin.Name = "txt_thongTin";
            this.txt_thongTin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_thongTin.Size = new System.Drawing.Size(373, 57);
            this.txt_thongTin.TabIndex = 2;
            // 
            // txt_kq
            // 
            this.txt_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kq.Location = new System.Drawing.Point(215, 118);
            this.txt_kq.Multiline = true;
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.ReadOnly = true;
            this.txt_kq.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_kq.Size = new System.Drawing.Size(373, 185);
            this.txt_kq.TabIndex = 3;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(387, 324);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(85, 38);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(259, 324);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 38);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xuat
            // 
            this.btn_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.Location = new System.Drawing.Point(125, 324);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(75, 38);
            this.btn_xuat.TabIndex = 8;
            this.btn_xuat.Text = "Xuất";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // frm_Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 383);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_thongTin);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.lnl_thongTin);
            this.Name = "frm_Bai7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnl_thongTin;
        private System.Windows.Forms.Label lbl_kq;
        private System.Windows.Forms.TextBox txt_thongTin;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xuat;
    }
}