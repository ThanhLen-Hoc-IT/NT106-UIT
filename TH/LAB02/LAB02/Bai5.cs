using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LAB02
{
    public partial class frmBai5 : Form
    {
        

        public frmBai5()
        {
            InitializeComponent();
            loadAddPhong();

        }

        void loadAddPhong()
        {
            for (int i = 1; i <= 3; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = $"{i}";
                cb.Appearance = Appearance.Button; // Để chữ trong ô cb
                cb.Checked = false;
                cb.Width = 30;
                cb.Height = 30;
                cb.Margin = new Padding(5);//Khoang cach giua cac cb
                cb.Tag = false;
                cb.TextAlign = ContentAlignment.MiddleCenter;
                cb.BackColor = Color.LightGray;
                cb.CheckedChanged += Cb_CheckedChangedPhong;
                flpAddPhong.Controls.Add(cb);

            }

        }




        private void Cb_CheckedChangedPhong(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null)
            {
                if (cb.Checked)
                {
                    cb.BackColor = Color.LightGreen;     // Ghế được chọn
                    cb.Tag = true;
                }
                else
                {
                    cb.BackColor = Color.LightGray; // Ghế bỏ chọn
                    cb.Tag = false;
                }
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenPhim = txtAddPhim.Text.Trim();
            string giaVeText = txtAddGiaVeChuan.Text.Trim();
            List<string> phongChieuDuocChon = new List<string>();


            //Kiểm tra tên phim
            if (string.IsNullOrEmpty(tenPhim))
            {
                MessageBox.Show("Vui lòng nhập Tên phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá vé có hợp lệ không
            if (!double.TryParse(giaVeText, out double giaVe) || giaVe <= 0)
            {
                MessageBox.Show("Giá vé phải là số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy danh sách phòng được chọn trong FlowLayoutPanel

            foreach (CheckBox chk in flpAddPhong.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {

                    phongChieuDuocChon.Add(chk.Text);

                }
            }

            if (phongChieuDuocChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 phòng chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ghi kết quả ra RichTextBox

            string thongTin = $"{tenPhim}\n{giaVe}\n{string.Join(" ", phongChieuDuocChon)}\n\n";
            rtbContent.AppendText(thongTin);

            //Xóa lựa chọn sau khi thêm
            txtAddPhim.Clear();
            txtAddGiaVeChuan.Clear();
            foreach (CheckBox chk in flpAddPhong.Controls.OfType<CheckBox>())
                chk.Checked = false;
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {


            using (FileStream fs = new FileStream("input5.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(rtbContent.Text);
                MessageBox.Show("Đã ghi vào file input5.txt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        PhimManager phimManager = new PhimManager();



        // Load danh sách phim vào ComboBox
        void loadPhimKhiMua()
        {
            cboPhim.DataSource = null; // Xóa nguồn cũ
            cboPhim.DataSource = phimManager.DanhSachPhim; // Gán danh sách phim
            cboPhim.DisplayMember = "TenPhim"; // Hiển thị tên phim
            cboPhim.ValueMember = "TenPhim";   // Có thể để "GiaVe" nếu bạn muốn lấy giá trị đó

            cboPhim.SelectedIndex = -1; // Không chọn mặc định
        }


        // 2️⃣ Load danh sách phòng chiếu khi chọn phim
        void loadPhongKhiMua(Phim ph)
        {
            cboPhong.DataSource = null;
            cboPhong.DataSource = ph.PhongChieuList; // Gán danh sách phòng từ phim được chọn
            cboPhong.DisplayMember = "idPhong";           // Hiển thị ID phòng
            cboPhong.ValueMember = "idPhong";

            cboPhong.SelectedIndex = -1;
        }


        // Load ghế theo phòng đã chọn
        void loadGheKhiMua(PhongChieu phong)
        {
            flpDisplayGhe.Controls.Clear(); // Xóa ghế cũ

            foreach (Ghe g in phong.DanhSachGhe)
            {
                CheckBox cb = new CheckBox();
                cb.Text = g.MaGhe;
                cb.Appearance = Appearance.Button;
                cb.Width = 50;
                cb.Height = 40;
                cb.Margin = new Padding(2);
                cb.TextAlign = ContentAlignment.MiddleCenter;
                cb.Tag = g; // Gắn ghế thật vào Tag để dễ xử lý

                // Màu theo trạng thái ghế
                if (g.DaBan)
                {
                    cb.BackColor = Color.Red;  // Ghế đã bán
                    cb.Enabled = false;        // Không cho chọn
                }
                else
                {
                    cb.BackColor = Color.LightGray; // Ghế trống
                    cb.CheckedChanged += Cb_CheckedChangedGhe;
                }

                flpDisplayGhe.Controls.Add(cb);
            }
        }


        // Sự kiện đổi màu khi chọn ghế
        private void Cb_CheckedChangedGhe(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null && cb.Tag is Ghe ghe && cboPhong.SelectedItem is PhongChieu phong)
            {
                if (!gheDaChonTheoPhong.ContainsKey(phong.idPhong))
                    gheDaChonTheoPhong[phong.idPhong] = new List<Ghe>();

                if (cb.Checked)
                {
                    cb.BackColor = Color.LightGreen;
                    if (!gheDaChonTheoPhong[phong.idPhong].Contains(ghe))
                        gheDaChonTheoPhong[phong.idPhong].Add(ghe);
                }
                else
                {
                    cb.BackColor = Color.LightGray;
                    gheDaChonTheoPhong[phong.idPhong].Remove(ghe);
                }
            }
        }

        // Lưu ghế đã chọn tạm thời trước khi nhấn Mua
        Dictionary<int, List<Ghe>> gheDaChonTheoPhong = new Dictionary<int, List<Ghe>>();


        // Danh sách khách hàng toàn cục
        List<KhachHang> listKH = new List<KhachHang>();

        private void btnMua_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!");
                return;
            }

            KhachHang KH = listKH.FirstOrDefault(k => k.HoTen == hoTen);
            if (KH == null)
            {
                KH = new KhachHang { HoTen = hoTen, DanhSachGhe = new List<Ghe>() };
                listKH.Add(KH);
            }

            // Ràng buộc: kiểm tra ghế mới có hợp lệ
            if (!KH.CoTheMuaThem(gheDaChonTheoPhong))
            {
                MessageBox.Show("Không thể mua quá 2 ghế ở 2 phòng khác nhau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double tongTien = 0;
            foreach (var kvp in gheDaChonTheoPhong)
            {
                int idPhong = kvp.Key;
                List<Ghe> gheList = kvp.Value;

                foreach (Ghe ghe in gheList)
                {
                    if (!ghe.DaBan)
                    {
                        ghe.DaBan = true;
                        ghe.MaPhong = idPhong;
                        KH.DanhSachGhe.Add(ghe);

                        Phim phim = cboPhim.SelectedItem as Phim;
                        tongTien += ghe.tinhGiaGhe(ghe.HeSoGia, phim);
                    }
                }
            }

            // In thông tin của khách hàng
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Khách: {KH.HoTen}");
            sb.AppendLine($"Tổng số ghế đã mua: {KH.DanhSachGhe.Count}");
            sb.AppendLine($"Chi tiết các ghế:");

            Phim phimChon = cboPhim.SelectedItem as Phim;

            foreach (var ghe in KH.DanhSachGhe)
            {
                double giaGhe = ghe.tinhGiaGhe(ghe.HeSoGia, phimChon);
                sb.AppendLine($"  - Phòng {ghe.MaPhong}, Ghế {ghe.MaGhe}, Hệ số giá: {ghe.HeSoGia}, Giá: {giaGhe:N0} đ");
            }

            sb.AppendLine($"Tổng tiền: {tongTien:N0} VNĐ");

            MessageBox.Show(sb.ToString(), "Thông tin mua vé", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Clear tạm thời sau khi mua
            gheDaChonTheoPhong.Clear();

            // Load lại ghế phòng hiện tại
            loadGheKhiMua(cboPhong.SelectedItem as PhongChieu);
        }



        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string filepath = "input5.txt";
            using (StreamReader sr = new StreamReader(filepath))
            {
                phimManager.DocFile(sr); 
            }
            // Sau khi có dữ liệu → nạp vào combobox
            loadPhimKhiMua();

            // Gắn sự kiện chọn phim & phòng
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            cboPhong.SelectedIndexChanged += cboPhong_SelectedIndexChanged;

            MessageBox.Show("Đã tải danh sách phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhim.SelectedItem is Phim selectedPhim)
            {
                loadPhongKhiMua(selectedPhim);
                flpDisplayGhe.Controls.Clear(); // reset ghế khi đổi phim
            }
        }
        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhong.SelectedItem is PhongChieu selectedPhong)
            {
                
                loadGheKhiMua(selectedPhong);
            }
        }

      
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa tên khách để tạo khách mới
            txtHoTen.Clear();

            //Xóa ghế tạm chọn
            gheDaChonTheoPhong.Clear();

            // Load lại ghế phòng hiện tại
            if (cboPhong.SelectedItem is PhongChieu phongHienTai)
            {
                loadGheKhiMua(phongHienTai);
            }

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuẩn bị ProgressBar
                pbThongKe.Minimum = 0;
                pbThongKe.Maximum = phimManager.DanhSachPhim.Count;
                pbThongKe.Value = 0;
                pbThongKe.Step = 1;
                pbThongKe.Visible = true;

                // Ghi thống kê ra file và cập nhật ProgressBar
                phimManager.GhiFileThongKe("output5.txt", pbThongKe);

                MessageBox.Show("Đã xuất thống kê ra file output5.txt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pbThongKe.Visible = false; // ẩn khi xong
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbThongKe.Visible = false;
            }
        }

    }
}



    
