using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class FrmBai6 : Form
    {
        public FrmBai6()
        {
            InitializeComponent();
            db.CreateTables();
            LoadND();
            LoadMA();
        }

        List<NguoiDung> nguoiDungs = new List<NguoiDung>();
        
        DatabaseHelper db = new DatabaseHelper();

        private void LoadMA()
        {
            HienThiMA(cboXoaMA);
            HienThiMA(cboSuaMA);
            LoadMonAnToListView();
        }

        private void LoadND()
        {
            HienThiND(cboNguoiThem);
            HienThiND(cboNguoiXoa);
            HienThiND(cboNguoiSua);
        }
        private void HienThiND(ComboBox cb)
        {
            var listND = db.GetAllNguoiDung();

            cb.DataSource = listND;
            cb.DisplayMember = "HoVaTen";   // Hiển thị tên
            cb.ValueMember = "IDNCC";

            // Nếu muốn hiển thị cả ID và tên
            cb.DisplayMember = "ToString";  // dùng override ở trên
        }

        private void HienThiMA(ComboBox cb)
        {
            var listMA = db.GetAllMonAn();

            cb.DataSource = listMA;
            cb.DisplayMember = "TenMonAn";
            cb.ValueMember = "IDMA";

            // Nếu muốn hiển thị cả ID và tên
            cb.DisplayMember = "ToString";  // dùng override ở trên

        }
        private void btnAddND_Click(object sender, EventArgs e)
        {
            
           
            string hoTen = txtHoVaTen.Text.Trim();
            string quyen = cboAddQuyenHan.SelectedItem?.ToString() ?? "User";

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên người dùng!");
                return;
            }

            db.InsertNguoiDung(hoTen, quyen);
            MessageBox.Show($"Đã thêm người dùng '{hoTen}' ({quyen}) thành công!");
            LoadND();
            txtHoVaTen.Clear();

        }

        private void btnAddMA_Click(object sender, EventArgs e)
        {
            int idNCC = (int)cboNguoiThem.SelectedValue;
            string quyen = db.GetQuyen(idNCC);

            if (quyen != "Admin")
            {
                MessageBox.Show("Bạn không có quyền thêm món ăn!");
                return;
            }

            string tenMA = txtAddMA.Text.Trim();
            string hinh = txtAddHinh.Text.Trim();

            if (string.IsNullOrEmpty(tenMA) || string.IsNullOrEmpty(hinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin món ăn!");
                return;
            }

            db.InsertMonAn(tenMA, hinh, idNCC);
            MessageBox.Show("Thêm món ăn thành công!");
            LoadMA();
            txtAddMA.Clear();
            txtAddHinh.Clear();

        }

        private void btnXoaMA_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng và món ăn được chọn
            if (cboNguoiXoa.SelectedValue == null || cboXoaMA.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ người xóa và món ăn cần xóa!",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idNCC = (int)cboNguoiXoa.SelectedValue;
            int idMA = (int)cboXoaMA.SelectedValue;

            // Kiểm tra quyền hạn người dùng
            string quyen = db.GetQuyen(idNCC);
            if (quyen != "Admin")
            {
                MessageBox.Show("Bạn không có quyền xóa món ăn!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa món ăn này không?",
                                          "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                db.DeleteMonAn(idMA);
                MessageBox.Show("Xóa món ăn thành công!", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMA(); // cập nhật lại danh sách món
            }
        }

        
        

        private void btbSuaMA_Click(object sender, EventArgs e)
        {
            // 1️⃣ Kiểm tra các control đã chọn/nhập đủ chưa
            if (cboNguoiSua.SelectedValue == null || cboSuaMA.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn người sửa và món ăn cần sửa!",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string tenMoi = txtSuaMA.Text.Trim();
            string hinhMoi = txtSuaHinh.Text.Trim();

            if (string.IsNullOrEmpty(tenMoi) || string.IsNullOrEmpty(hinhMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin món ăn!",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Lấy ID người sửa và kiểm tra quyền
            int idNCC = (int)cboNguoiSua.SelectedValue;
            string quyen = db.GetQuyen(idNCC);

            if (quyen != "Admin")
            {
                MessageBox.Show("Bạn không có quyền sửa món ăn!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3️⃣ Lấy ID món cần sửa
            int idMA = (int)cboSuaMA.SelectedValue;

            // 4️⃣ Xác nhận sửa
            var confirm = MessageBox.Show("Bạn có chắc muốn sửa món ăn này không?",
                                          "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // 5️⃣ Gọi hàm cập nhật món ăn trong DatabaseHelper
                db.UpdateMonAn(idMA, tenMoi, hinhMoi, idNCC);

                MessageBox.Show("Sửa món ăn thành công!",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadMA(); // Cập nhật lại danh sách món ăn
            }

            txtSuaMA.Clear();
            txtSuaHinh.Clear();
        }

        private void LoadMonAnToListView()
        {
            lvMonAn.Columns.Clear();
            lvMonAn.Columns.Add("ID", 60);
            lvMonAn.Columns.Add("Tên món ăn", 180);
            lvMonAn.Columns.Add("Hình ảnh", 180);
            lvMonAn.Columns.Add("Người đóng góp", 150);

            lvMonAn.Items.Clear();

            var dsMonAn = db.GetAllMonAn(); // db là DatabaseHelper

            foreach (var mon in dsMonAn)
            {
                ListViewItem item = new ListViewItem(mon.IDMA.ToString());
                item.SubItems.Add(mon.TenMonAn);
                item.SubItems.Add(mon.HinhAnh);
                item.SubItems.Add(mon.NguoiDongGop);

                lvMonAn.Items.Add(item);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var listMonAn = db.GetAllMonAn();

            if (listMonAn == null || listMonAn.Count == 0)
            {
                MessageBox.Show("Chưa có món ăn nào trong cơ sở dữ liệu!");
                return;
            }

            // Random món ăn
            Random rnd = new Random();
            int index = rnd.Next(listMonAn.Count);
            var monAn = listMonAn[index];

            // Hiển thị tên món ăn + người đóng góp
            txtResult.Text = $"{monAn.TenMonAn}  -  {monAn.NguoiDongGop} ";

            // Lấy đường dẫn hình
            string pathHinh = monAn.HinhAnh?.Trim();

            // Kiểm tra ảnh có tồn tại không
            if (string.IsNullOrEmpty(pathHinh) || !File.Exists(pathHinh))
            {
                picResult.Image = null; // clear hình cũ
                MessageBox.Show($"Ảnh không tồn tại:\n{pathHinh}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dùng FileStream để đọc ảnh mà không khóa file
            try
            {
                using (FileStream fs = new FileStream(pathHinh, FileMode.Open, FileAccess.Read))
                {
                    // Clone ảnh để tránh lỗi "file is in use"
                    picResult.Image = Image.FromStream(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đọc file ảnh:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                picResult.Image = null;
            }

        }

    }
}

