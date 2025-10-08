namespace LAB01
{
    partial class frm_Bai6
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
            this.tbl_title = new System.Windows.Forms.Label();
            this.lbl_birhday = new System.Windows.Forms.Label();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.lbl_cungHD = new System.Windows.Forms.Label();
            this.txt_cungHD = new System.Windows.Forms.TextBox();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbl_title
            // 
            this.tbl_title.AutoSize = true;
            this.tbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_title.Location = new System.Drawing.Point(53, 18);
            this.tbl_title.Name = "tbl_title";
            this.tbl_title.Size = new System.Drawing.Size(407, 38);
            this.tbl_title.TabIndex = 0;
            this.tbl_title.Text = "XEM CUNG HOÀNG ĐẠO";
            // 
            // lbl_birhday
            // 
            this.lbl_birhday.AutoSize = true;
            this.lbl_birhday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birhday.Location = new System.Drawing.Point(21, 98);
            this.lbl_birhday.Name = "lbl_birhday";
            this.lbl_birhday.Size = new System.Drawing.Size(273, 25);
            this.lbl_birhday.TabIndex = 1;
            this.lbl_birhday.Text = "Nhập ngày sinh (dd/mm/yyyy)";
            this.lbl_birhday.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_birthday
            // 
            this.txt_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday.Location = new System.Drawing.Point(316, 93);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(182, 30);
            this.txt_birthday.TabIndex = 2;
            // 
            // lbl_cungHD
            // 
            this.lbl_cungHD.AutoSize = true;
            this.lbl_cungHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cungHD.Location = new System.Drawing.Point(21, 162);
            this.lbl_cungHD.Name = "lbl_cungHD";
            this.lbl_cungHD.Size = new System.Drawing.Size(158, 25);
            this.lbl_cungHD.TabIndex = 3;
            this.lbl_cungHD.Text = "Cung hoàng đạo";
            // 
            // txt_cungHD
            // 
            this.txt_cungHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cungHD.Location = new System.Drawing.Point(316, 157);
            this.txt_cungHD.Name = "txt_cungHD";
            this.txt_cungHD.ReadOnly = true;
            this.txt_cungHD.Size = new System.Drawing.Size(182, 30);
            this.txt_cungHD.TabIndex = 4;
            // 
            // btn_xem
            // 
            this.btn_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Location = new System.Drawing.Point(85, 218);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(75, 38);
            this.btn_xem.TabIndex = 5;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(219, 218);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 38);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(347, 218);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(85, 38);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 287);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.txt_cungHD);
            this.Controls.Add(this.lbl_cungHD);
            this.Controls.Add(this.txt_birthday);
            this.Controls.Add(this.lbl_birhday);
            this.Controls.Add(this.tbl_title);
            this.Name = "frm_Bai6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbl_title;
        private System.Windows.Forms.Label lbl_birhday;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.Label lbl_cungHD;
        private System.Windows.Forms.TextBox txt_cungHD;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Thoat;
    }
}