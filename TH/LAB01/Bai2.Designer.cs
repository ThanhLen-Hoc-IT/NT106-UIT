namespace LAB01
{
    partial class frm_Bai2
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
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_num3 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num3 = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.bnt_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_maxNum = new System.Windows.Forms.Label();
            this.lbl_numMin = new System.Windows.Forms.Label();
            this.txt_numMax = new System.Windows.Forms.TextBox();
            this.txt_numMIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(147, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(496, 38);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "TÌM SỐ LỚN NHẤT, NHỎ NHẤT";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num1.Location = new System.Drawing.Point(4, 80);
            this.lbl_num1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(112, 25);
            this.lbl_num1.TabIndex = 1;
            this.lbl_num1.Text = "Số thứ nhất";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num2.Location = new System.Drawing.Point(245, 80);
            this.lbl_num2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(85, 25);
            this.lbl_num2.TabIndex = 2;
            this.lbl_num2.Text = "Số thứ 2";
            this.lbl_num2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_num3
            // 
            this.lbl_num3.AutoSize = true;
            this.lbl_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num3.Location = new System.Drawing.Point(472, 80);
            this.lbl_num3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_num3.Name = "lbl_num3";
            this.lbl_num3.Size = new System.Drawing.Size(85, 25);
            this.lbl_num3.TabIndex = 3;
            this.lbl_num3.Text = "Số thứ 3";
            // 
            // txt_num1
            // 
            this.txt_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num1.Location = new System.Drawing.Point(124, 75);
            this.txt_num1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(95, 30);
            this.txt_num1.TabIndex = 4;
            // 
            // txt_num2
            // 
            this.txt_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num2.Location = new System.Drawing.Point(338, 75);
            this.txt_num2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(95, 30);
            this.txt_num2.TabIndex = 5;
            // 
            // txt_num3
            // 
            this.txt_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num3.Location = new System.Drawing.Point(565, 75);
            this.txt_num3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_num3.Name = "txt_num3";
            this.txt_num3.Size = new System.Drawing.Size(95, 30);
            this.txt_num3.TabIndex = 6;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(89, 133);
            this.btn_find.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(112, 36);
            this.btn_find.TabIndex = 7;
            this.btn_find.Text = "Tìm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnt_delete
            // 
            this.bnt_delete.Location = new System.Drawing.Point(245, 135);
            this.bnt_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnt_delete.Name = "bnt_delete";
            this.bnt_delete.Size = new System.Drawing.Size(112, 36);
            this.bnt_delete.TabIndex = 8;
            this.bnt_delete.Text = "Xóa";
            this.bnt_delete.UseVisualStyleBackColor = true;
            this.bnt_delete.Click += new System.EventHandler(this.bnt_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(426, 133);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 36);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_maxNum
            // 
            this.lbl_maxNum.AutoSize = true;
            this.lbl_maxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxNum.Location = new System.Drawing.Point(27, 197);
            this.lbl_maxNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maxNum.Name = "lbl_maxNum";
            this.lbl_maxNum.Size = new System.Drawing.Size(111, 25);
            this.lbl_maxNum.TabIndex = 10;
            this.lbl_maxNum.Text = "Số lớn nhất";
            this.lbl_maxNum.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_numMin
            // 
            this.lbl_numMin.AutoSize = true;
            this.lbl_numMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numMin.Location = new System.Drawing.Point(351, 197);
            this.lbl_numMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numMin.Name = "lbl_numMin";
            this.lbl_numMin.Size = new System.Drawing.Size(118, 25);
            this.lbl_numMin.TabIndex = 11;
            this.lbl_numMin.Text = "Số nhỏ nhất";
            this.lbl_numMin.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txt_numMax
            // 
            this.txt_numMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numMax.Location = new System.Drawing.Point(146, 192);
            this.txt_numMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_numMax.Name = "txt_numMax";
            this.txt_numMax.ReadOnly = true;
            this.txt_numMax.Size = new System.Drawing.Size(148, 30);
            this.txt_numMax.TabIndex = 12;
            this.txt_numMax.TextChanged += new System.EventHandler(this.txt_numMax_TextChanged);
            // 
            // txt_numMIn
            // 
            this.txt_numMIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numMIn.Location = new System.Drawing.Point(477, 192);
            this.txt_numMIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_numMIn.Name = "txt_numMIn";
            this.txt_numMIn.ReadOnly = true;
            this.txt_numMIn.Size = new System.Drawing.Size(148, 30);
            this.txt_numMIn.TabIndex = 13;
            // 
            // frm_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 250);
            this.Controls.Add(this.txt_numMIn);
            this.Controls.Add(this.txt_numMax);
            this.Controls.Add(this.lbl_numMin);
            this.Controls.Add(this.lbl_maxNum);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.bnt_delete);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.txt_num3);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lbl_num3);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.frm_Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_num3;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num3;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button bnt_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_maxNum;
        private System.Windows.Forms.Label lbl_numMin;
        private System.Windows.Forms.TextBox txt_numMax;
        private System.Windows.Forms.TextBox txt_numMIn;
    }
}