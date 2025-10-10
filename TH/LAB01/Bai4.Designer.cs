namespace LAB01
{


    partial class frm_Bai4
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_hoTen = new System.Windows.Forms.Label();
            this.lbl_phim = new System.Windows.Forms.Label();
            this.lbl_phong = new System.Windows.Forms.Label();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.cbo_phim = new System.Windows.Forms.ComboBox();
            this.cbo_phong = new System.Windows.Forms.ComboBox();
            this.clb_ghe = new System.Windows.Forms.CheckedListBox();
            this.lbl_ghe = new System.Windows.Forms.Label();
            this.btn_mua = new System.Windows.Forms.Button();
            this.txt_ThongTinMua = new System.Windows.Forms.TextBox();
            this.lbl_ThongTInMua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(224, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(332, 38);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "QUẢN LÍ PHÒNG VÉ";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_hoTen
            // 
            this.lbl_hoTen.AutoSize = true;
            this.lbl_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoTen.Location = new System.Drawing.Point(12, 92);
            this.lbl_hoTen.Name = "lbl_hoTen";
            this.lbl_hoTen.Size = new System.Drawing.Size(74, 25);
            this.lbl_hoTen.TabIndex = 1;
            this.lbl_hoTen.Text = "Họ tên ";
            this.lbl_hoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_hoTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_phim
            // 
            this.lbl_phim.AutoSize = true;
            this.lbl_phim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phim.Location = new System.Drawing.Point(382, 92);
            this.lbl_phim.Name = "lbl_phim";
            this.lbl_phim.Size = new System.Drawing.Size(56, 25);
            this.lbl_phim.TabIndex = 2;
            this.lbl_phim.Text = "Phim";
            this.lbl_phim.Click += new System.EventHandler(this.lbl_phim_Click);
            // 
            // lbl_phong
            // 
            this.lbl_phong.AutoSize = true;
            this.lbl_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phong.Location = new System.Drawing.Point(674, 92);
            this.lbl_phong.Name = "lbl_phong";
            this.lbl_phong.Size = new System.Drawing.Size(69, 25);
            this.lbl_phong.TabIndex = 3;
            this.lbl_phong.Text = "Phòng";
            this.lbl_phong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_phong.Click += new System.EventHandler(this.lbl_phong_Click);
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoTen.Location = new System.Drawing.Point(117, 92);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(241, 30);
            this.txt_hoTen.TabIndex = 4;
            // 
            // cbo_phim
            // 
            this.cbo_phim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phim.FormattingEnabled = true;
            this.cbo_phim.Items.AddRange(new object[] {
            "Đào, phở và piano",
            "Mai",
            "Gặp lại chị bầu",
            "Tarot"});
            this.cbo_phim.Location = new System.Drawing.Point(444, 92);
            this.cbo_phim.Name = "cbo_phim";
            this.cbo_phim.Size = new System.Drawing.Size(205, 33);
            this.cbo_phim.TabIndex = 5;
            this.cbo_phim.SelectedIndexChanged += new System.EventHandler(this.cbo_phim_SelectedIndexChanged);
            // 
            // cbo_phong
            // 
            this.cbo_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phong.FormattingEnabled = true;
            this.cbo_phong.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbo_phong.Location = new System.Drawing.Point(749, 92);
            this.cbo_phong.Name = "cbo_phong";
            this.cbo_phong.Size = new System.Drawing.Size(79, 33);
            this.cbo_phong.TabIndex = 6;
            this.cbo_phong.SelectedIndexChanged += new System.EventHandler(this.cbo_phong_SelectedIndexChanged);
            // 
            // clb_ghe
            // 
            this.clb_ghe.CheckOnClick = true;
            this.clb_ghe.ColumnWidth = 70;
            this.clb_ghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_ghe.FormattingEnabled = true;
            this.clb_ghe.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5"});
            this.clb_ghe.Location = new System.Drawing.Point(117, 172);
            this.clb_ghe.MultiColumn = true;
            this.clb_ghe.Name = "clb_ghe";
            this.clb_ghe.Size = new System.Drawing.Size(241, 156);
            this.clb_ghe.TabIndex = 7;
            this.clb_ghe.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lbl_ghe
            // 
            this.lbl_ghe.AutoSize = true;
            this.lbl_ghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ghe.Location = new System.Drawing.Point(12, 172);
            this.lbl_ghe.Name = "lbl_ghe";
            this.lbl_ghe.Size = new System.Drawing.Size(98, 25);
            this.lbl_ghe.TabIndex = 8;
            this.lbl_ghe.Text = "Chọn ghế";
            // 
            // btn_mua
            // 
            this.btn_mua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mua.Location = new System.Drawing.Point(117, 356);
            this.btn_mua.Name = "btn_mua";
            this.btn_mua.Size = new System.Drawing.Size(83, 41);
            this.btn_mua.TabIndex = 9;
            this.btn_mua.Text = "Mua";
            this.btn_mua.UseVisualStyleBackColor = true;
            this.btn_mua.Click += new System.EventHandler(this.btn_mua_Click);
            // 
            // txt_ThongTinMua
            // 
            this.txt_ThongTinMua.Location = new System.Drawing.Point(551, 176);
            this.txt_ThongTinMua.Multiline = true;
            this.txt_ThongTinMua.Name = "txt_ThongTinMua";
            this.txt_ThongTinMua.ReadOnly = true;
            this.txt_ThongTinMua.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_ThongTinMua.Size = new System.Drawing.Size(277, 224);
            this.txt_ThongTinMua.TabIndex = 10;
            this.txt_ThongTinMua.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_ThongTInMua
            // 
            this.lbl_ThongTInMua.AutoSize = true;
            this.lbl_ThongTInMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongTInMua.Location = new System.Drawing.Point(382, 172);
            this.lbl_ThongTInMua.Name = "lbl_ThongTInMua";
            this.lbl_ThongTInMua.Size = new System.Drawing.Size(163, 25);
            this.lbl_ThongTInMua.TabIndex = 11;
            this.lbl_ThongTInMua.Text = "Thông tin mua vé";
            // 
            // frm_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.lbl_ThongTInMua);
            this.Controls.Add(this.txt_ThongTinMua);
            this.Controls.Add(this.btn_mua);
            this.Controls.Add(this.lbl_ghe);
            this.Controls.Add(this.clb_ghe);
            this.Controls.Add(this.cbo_phong);
            this.Controls.Add(this.cbo_phim);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.lbl_phong);
            this.Controls.Add(this.lbl_phim);
            this.Controls.Add(this.lbl_hoTen);
            this.Controls.Add(this.lbl_title);
            this.Name = "frm_Bai4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 4";
            this.Load += new System.EventHandler(this.frm_Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_hoTen;
        private System.Windows.Forms.Label lbl_phim;
        private System.Windows.Forms.Label lbl_phong;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.ComboBox cbo_phim;
        private System.Windows.Forms.ComboBox cbo_phong;
        private System.Windows.Forms.CheckedListBox clb_ghe;
        private System.Windows.Forms.Label lbl_ghe;
        private System.Windows.Forms.Button btn_mua;
        private System.Windows.Forms.TextBox txt_ThongTinMua;
        private System.Windows.Forms.Label lbl_ThongTInMua;
    }
}