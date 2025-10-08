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
    public partial class frm_Bai7 : Form
    {
        public frm_Bai7()
        {
            InitializeComponent();
        }

        private void lnl_thongTin_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_thongTin.Text = "";
            txt_kq.Text = "";
        }

        string xepLoai(Double DTB, List<double> diem)
        {
            if (DTB >= 8 && diem.All(d => d >= 6.5))
                return "Giỏi";
            else if (DTB >= 6.5 && diem.All(d => d >= 5))
                return "Khá";
            else if (DTB >= 5 && diem.All(d => d >= 3.5))
                return "Trung bình";
            else if (DTB >= 3.5 && diem.All(d => d >= 2))
                return "Yếu";
            else
                return "Kém";
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            // Tách chuỗi theo dấu phẩy và loại bỏ khoảng trắng
            string[] str = txt_thongTin.Text.Split(',');
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].Trim();
            }

            // Hiển thị họ tên
            txt_kq.Text = $"Họ và tên: {str[0]}{Environment.NewLine}";

            // Chuyển các phần tử còn lại thành danh sách điểm
            List<double> diem = new List<double>();
            for (int i = 1; i < str.Length; i++)
            {
                // Chuyển dấu '.' sang ',' để parse theo định dạng Việt Nam
                string s = str[i].Replace('.', ',');
                if (Double.TryParse(s, out double d))
                {
                    diem.Add(d);
                }
                else
                {
                    MessageBox.Show($"Sai format: {str[i]} không phải là điểm hợp lệ.");
                }
            }

            if (diem.Count == 0)
            {
                MessageBox.Show("Không có điểm hợp lệ để tính toán!");
                return;
            }

            // Tính tổng, tìm max, min
            double Tong = 0;
            double maxValue = diem[0], minValue = diem[0];
            int maxIndex = 0, minIndex = 0;

            for (int i = 0; i < diem.Count; i++)
            {
                Tong += diem[i];

                if (diem[i] > maxValue)
                {
                    maxValue = diem[i];
                    maxIndex = i;
                }
                if (diem[i] < minValue)
                {
                    minValue = diem[i];
                    minIndex = i;
                }

                // Hiển thị điểm từng môn, 1 chữ số thập phân
                txt_kq.Text += $"Môn {i + 1}: {diem[i]:F1}{Environment.NewLine}";
            }

            // Tính trung bình và làm tròn 2 chữ số
            double DTB = Tong / diem.Count;
            txt_kq.Text += $"DTB: {DTB:F2}{Environment.NewLine}";

            // Hiển thị môn cao nhất/thấp nhất, +1 vì index mảng bắt đầu từ 0
            txt_kq.Text += $"Môn có điểm cao nhất: Môn {maxIndex + 1}{Environment.NewLine}" +
                           $"Môn có điểm thấp nhất: Môn {minIndex + 1}{Environment.NewLine}";

            // Xếp loại
            txt_kq.Text += $"Xếp loại: {xepLoai(DTB, diem)}";
        }

        private void Bai7_Load(object sender, EventArgs e)
        {

        }
    }
}
