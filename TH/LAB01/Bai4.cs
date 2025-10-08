using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LAB01
{
    public partial class frm_Bai4 : Form
    {
        // Danh sách phim: Tên -> (Giá chuẩn, các phòng chiếu)
        Dictionary<string, (int giaChuan, List<int> rap)> dsPhim = new Dictionary<string, (int, List<int>)>()
        {
            { "Đào, phở và piano", (45000, new List<int>{1, 2, 3}) },
            { "Mai", (100000, new List<int>{2, 3}) },
            { "Gặp lại chị bầu", (70000, new List<int>{1}) },
            { "Tarot", (90000, new List<int>{3}) }
        };

        // Loại ghế và hệ số giá
        Dictionary<string, double> loaiGhe = new Dictionary<string, double>()
        {
            { "A1", 0.25 }, { "A5", 0.25 }, { "C1", 0.25 }, { "C5", 0.25 }, // vé vớt
            { "A2", 1 }, { "A3", 1 }, { "A4", 1 }, { "C2", 1 }, { "C3", 1 }, { "C4", 1 }, // vé thường
            { "B2", 2 }, { "B3", 2 }, { "B4", 2 } // vé VIP
        };

        // Ghế đã bán: "Phòng-Ghế"
        HashSet<string> gheDaBan = new HashSet<string>();

        // Lưu số phòng mà khách hàng hiện tại đã mua
        Dictionary<string, HashSet<int>> phongKhachDaMua = new Dictionary<string, HashSet<int>>();

        public frm_Bai4()
        {
            InitializeComponent();
        }

        // Khi chọn phim -> load các phòng chiếu
        private void cbo_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_phong.Items.Clear();
            string tenPhim = cbo_phim.SelectedItem.ToString();
            var phim = dsPhim[tenPhim];
            foreach (int phong in phim.rap)
                cbo_phong.Items.Add(phong);
        }

        private void btn_mua_Click(object sender, EventArgs e)
        {
            string tenKH = txt_hoTen.Text.Trim();
            if (string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!");
                return;
            }

            if (cbo_phim.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim!");
                return;
            }

            if (cbo_phong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu!");
                return;
            }

            var gheChon = clb_ghe.CheckedItems.Cast<string>().ToList();
            if (gheChon.Count == 0)
            {
                MessageBox.Show("Chưa chọn ghế!");
                return;
            }

            string tenPhim = cbo_phim.SelectedItem.ToString();
            int phong = int.Parse(cbo_phong.SelectedItem.ToString());
            int giaChuan = dsPhim[tenPhim].giaChuan;

            // Kiểm tra ghế đã bán
            foreach (var ghe in gheChon)
            {
                if (gheDaBan.Contains($"{phong}-{ghe}"))
                {
                    MessageBox.Show($"Ghế {ghe} ở phòng {phong} đã được bán!");
                    return;
                }
            }

            // Kiểm tra số phòng khách đã mua
            if (!phongKhachDaMua.ContainsKey(tenKH))
                phongKhachDaMua[tenKH] = new HashSet<int>();

            var phongDaMua = phongKhachDaMua[tenKH];

            // Nếu khách đã mua vé ở >=2 phòng khác phòng hiện tại
            if (phongDaMua.Count >= 2 && !phongDaMua.Contains(phong))
            {
                MessageBox.Show("Không thể mua vé ở quá 2 phòng chiếu khác nhau!");
                return;
            }

            // Tính tiền
            double tongTien = 0;
            foreach (var ghe in gheChon)
            {
                double heSo = loaiGhe.ContainsKey(ghe) ? loaiGhe[ghe] : 1;
                tongTien += giaChuan * heSo;
                gheDaBan.Add($"{phong}-{ghe}");
            }

            // Cập nhật phòng đã mua cho khách
            phongDaMua.Add(phong);

            // Hiển thị thông tin mua
            txt_ThongTinMua.Text =
               $"Khách hàng: {tenKH}{Environment.NewLine}" +
               $"Phim: {tenPhim}{Environment.NewLine}" +
               $"Phòng: {phong}{Environment.NewLine}" +
               $"Ghế: {string.Join(", ", gheChon)}{Environment.NewLine}" +
               $"Tổng tiền: {tongTien:N0} đ";

            // Reset CheckedListBox
            for (int i = 0; i < clb_ghe.Items.Count; i++)
                clb_ghe.SetItemChecked(i, false);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_hoTen.Text = "";
            txt_ThongTinMua.Text = "";
            clb_ghe.ClearSelected();
            for (int i = 0; i < clb_ghe.Items.Count; i++)
                clb_ghe.SetItemChecked(i, false);
        }

      
    }
}
