using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class frm_Bai6 : Form
    {
        public frm_Bai6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txt_birthday.Text, out DateTime dt))
            {
                MessageBox.Show("Lỗi!Vui lòng nhập lại.",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }else
            {
                int ngay = dt.Day;
                int thang = dt.Month;
                switch (thang)
                {
                    case 1:
                        if (ngay <= 20)
                            txt_cungHD.Text = "Ma Kết";
                        else
                            txt_cungHD.Text = "Bảo Bình";
                        break;
                    case 2:
                        if (ngay <= 19)
                            txt_cungHD.Text = "Bảo Bình";
                        else
                            txt_cungHD.Text = "Song Ngư";
                        break;
                    case 3:
                        if (ngay <= 20)
                            txt_cungHD.Text = "Song Ngư";
                        else
                            txt_cungHD.Text = "Bạch Dương";
                        break;
                    case 4:
                        if (ngay <= 19)
                            txt_cungHD.Text = "Bạch Dương";
                        else
                            txt_cungHD.Text = "Kim Ngưu";
                        break;
                    case 5:
                        if (ngay <= 20)
                            txt_cungHD.Text = "Kim Ngưu";
                        else
                            txt_cungHD.Text = "Song Tử";
                        break;
                    case 6:
                        if (ngay <= 20)
                            txt_cungHD.Text = "Song Tử";
                        else
                            txt_cungHD.Text = "Cự Giải";
                        break;
                    case 7:
                        if (ngay <= 22)
                            txt_cungHD.Text = "Cự Giải";
                        else
                            txt_cungHD.Text = "Sư Tử";
                        break;
                    case 8:
                        if (ngay <= 22)
                            txt_cungHD.Text = "Sư Tử";
                        else
                            txt_cungHD.Text = "Xử Nữ";
                        break;
                    case 9:
                        if (ngay <= 22)
                            txt_cungHD.Text = "Xử Nữ";
                        else
                            txt_cungHD.Text = "Thiên Bình";
                        break;
                    case 10:
                        if (ngay <= 23)
                            txt_cungHD.Text = "Thiên Bình";
                        else
                            txt_cungHD.Text = "Bọ Cạp";
                        break;
                    case 11:
                        if (ngay <= 22)
                            txt_cungHD.Text = "Bọ Cạp";
                        else
                            txt_cungHD.Text = "Nhân Mã";
                        break;
                    case 12:
                        if (ngay <= 21)
                            txt_cungHD.Text = "Nhân Mã";
                        else
                            txt_cungHD.Text = "Ma Kết";
                        break;
                    default:
                        txt_cungHD.Text = "Ngày hoặc tháng không hợp lệ";
                        break;
                }

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_birthday.Text = "";
            txt_cungHD.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
