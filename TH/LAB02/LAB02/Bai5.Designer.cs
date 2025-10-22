namespace LAB02
{
    partial class frmBai5
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
            this.flpDisplayGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flpAddPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAddGiaVeChuan = new System.Windows.Forms.TextBox();
            this.txtAddPhim = new System.Windows.Forms.TextBox();
            this.lblAddPhongChieu = new System.Windows.Forms.Label();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.lblAddGiaVeChuan = new System.Windows.Forms.Label();
            this.lblAddFilm = new System.Windows.Forms.Label();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.btnMua = new System.Windows.Forms.Button();
            this.blbMuaVe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pbThongKe = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpDisplayGhe
            // 
            this.flpDisplayGhe.Location = new System.Drawing.Point(388, 175);
            this.flpDisplayGhe.Name = "flpDisplayGhe";
            this.flpDisplayGhe.Size = new System.Drawing.Size(400, 170);
            this.flpDisplayGhe.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReadFile);
            this.panel1.Controls.Add(this.rtbContent);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.flpAddPhong);
            this.panel1.Controls.Add(this.txtAddGiaVeChuan);
            this.panel1.Controls.Add(this.txtAddPhim);
            this.panel1.Controls.Add(this.lblAddPhongChieu);
            this.panel1.Controls.Add(this.btnWriteFile);
            this.panel1.Controls.Add(this.lblAddGiaVeChuan);
            this.panel1.Controls.Add(this.lblAddFilm);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 453);
            this.panel1.TabIndex = 1;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(114, 393);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(161, 48);
            this.btnReadFile.TabIndex = 8;
            this.btnReadFile.Text = "Read input5.txt";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(36, 218);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(324, 169);
            this.rtbContent.TabIndex = 8;
            this.rtbContent.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(32, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flpAddPhong
            // 
            this.flpAddPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpAddPhong.Location = new System.Drawing.Point(160, 92);
            this.flpAddPhong.Name = "flpAddPhong";
            this.flpAddPhong.Size = new System.Drawing.Size(201, 45);
            this.flpAddPhong.TabIndex = 6;
            // 
            // txtAddGiaVeChuan
            // 
            this.txtAddGiaVeChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddGiaVeChuan.Location = new System.Drawing.Point(160, 59);
            this.txtAddGiaVeChuan.Name = "txtAddGiaVeChuan";
            this.txtAddGiaVeChuan.Size = new System.Drawing.Size(201, 27);
            this.txtAddGiaVeChuan.TabIndex = 5;
            // 
            // txtAddPhim
            // 
            this.txtAddPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPhim.Location = new System.Drawing.Point(160, 21);
            this.txtAddPhim.Name = "txtAddPhim";
            this.txtAddPhim.Size = new System.Drawing.Size(201, 27);
            this.txtAddPhim.TabIndex = 4;
            // 
            // lblAddPhongChieu
            // 
            this.lblAddPhongChieu.AutoSize = true;
            this.lblAddPhongChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPhongChieu.Location = new System.Drawing.Point(27, 106);
            this.lblAddPhongChieu.Name = "lblAddPhongChieu";
            this.lblAddPhongChieu.Size = new System.Drawing.Size(104, 20);
            this.lblAddPhongChieu.TabIndex = 3;
            this.lblAddPhongChieu.Text = "Phòng Chiếu";
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteFile.Location = new System.Drawing.Point(159, 155);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(201, 42);
            this.btnWriteFile.TabIndex = 2;
            this.btnWriteFile.Text = "Write to input5.txt";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // lblAddGiaVeChuan
            // 
            this.lblAddGiaVeChuan.AutoSize = true;
            this.lblAddGiaVeChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGiaVeChuan.Location = new System.Drawing.Point(27, 66);
            this.lblAddGiaVeChuan.Name = "lblAddGiaVeChuan";
            this.lblAddGiaVeChuan.Size = new System.Drawing.Size(113, 20);
            this.lblAddGiaVeChuan.TabIndex = 1;
            this.lblAddGiaVeChuan.Text = "Giá Vé Chuẩn";
            // 
            // lblAddFilm
            // 
            this.lblAddFilm.AutoSize = true;
            this.lblAddFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFilm.Location = new System.Drawing.Point(27, 28);
            this.lblAddFilm.Name = "lblAddFilm";
            this.lblAddFilm.Size = new System.Drawing.Size(80, 20);
            this.lblAddFilm.TabIndex = 0;
            this.lblAddFilm.Text = "Tên Phim";
            // 
            // cboPhim
            // 
            this.cboPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(490, 89);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(251, 28);
            this.cboPhim.TabIndex = 2;
            // 
            // btnMua
            // 
            this.btnMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMua.Location = new System.Drawing.Point(385, 395);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(114, 40);
            this.btnMua.TabIndex = 3;
            this.btnMua.Text = "Mua";
            this.btnMua.UseVisualStyleBackColor = true;
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // blbMuaVe
            // 
            this.blbMuaVe.AutoSize = true;
            this.blbMuaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbMuaVe.Location = new System.Drawing.Point(531, 9);
            this.blbMuaVe.Name = "blbMuaVe";
            this.blbMuaVe.Size = new System.Drawing.Size(192, 25);
            this.blbMuaVe.TabIndex = 4;
            this.blbMuaVe.Text = "MUA VÉ XEM PHIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phòng";
            // 
            // cboPhong
            // 
            this.cboPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(490, 129);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(98, 28);
            this.cboPhong.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(490, 49);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(251, 27);
            this.txtHoTen.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Họ tên";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(674, 394);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(114, 40);
            this.btnThongKe.TabIndex = 10;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(536, 395);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 40);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pbThongKe
            // 
            this.pbThongKe.Location = new System.Drawing.Point(388, 360);
            this.pbThongKe.Name = "pbThongKe";
            this.pbThongKe.Size = new System.Drawing.Size(400, 23);
            this.pbThongKe.TabIndex = 9;
            // 
            // frmBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbThongKe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blbMuaVe);
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpDisplayGhe);
            this.Name = "frmBai5";
            this.Text = "Bài 5";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDisplayGhe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddPhongChieu;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Label lblAddGiaVeChuan;
        private System.Windows.Forms.Label lblAddFilm;
        private System.Windows.Forms.FlowLayoutPanel flpAddPhong;
        private System.Windows.Forms.TextBox txtAddGiaVeChuan;
        private System.Windows.Forms.TextBox txtAddPhim;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Button btnMua;
        private System.Windows.Forms.Label blbMuaVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThongKe;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ProgressBar pbThongKe;
    }
}