using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;


namespace LAB02
{
    public partial class frmBai4 : Form
    {
        List<SinhVien> students = new List<SinhVien>();
        int index = 0;

        public frmBai4()
        {
            InitializeComponent();
        }

     
        

        private void btbAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddName.Text) ||
                string.IsNullOrWhiteSpace(txtAddID.Text) ||
                string.IsNullOrWhiteSpace(txtAddPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddCourse1.Text) ||
                string.IsNullOrWhiteSpace(txtAddCourse2.Text) ||
               string.IsNullOrWhiteSpace(txtAddCourse3.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Kiểm tra MSSV có đúng 8 chữ số
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtAddID.Text, @"^\d{8}$"))
            {
                MessageBox.Show("Mã số sinh viên phải gồm 8 chữ số!");
                txtAddID.Focus();
                return;
            }

            // Kiểm tra số điện thoại bắt đầu bằng 0 và có đúng 10 chữ số
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtAddPhone.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!");
                txtAddPhone.Focus();
                return;
            }

            // Kiểm tra điểm hợp lệ (0–10)
            if (!float.TryParse(txtAddCourse1.Text, out float c1) ||
                !float.TryParse(txtAddCourse2.Text, out float c2) ||
                !float.TryParse(txtAddCourse3.Text, out float c3))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ!");
                return;
            }

            if (c1 < 0 || c1 > 10 || c2 < 0 || c2 > 10 || c3 < 0 || c3 > 10)
            {
                MessageBox.Show("Điểm từng học phần phải trong khoảng 0 đến 10!");
                return;
            }

            //Nếu hợp lệ → tạo đối tượng SinhVien
            SinhVien sv = new SinhVien(txtAddName.Text,
                                       int.Parse(txtAddID.Text),
                                       txtAddPhone.Text,
                                       c1, c2, c3);

            students.Add(sv);

            // Hiển thị thông tin
            rtbInfo.Text += $"{sv.Name}\n" +
                            $"{sv.ID}\n" +
                            $"{sv.Phone}\n" +
                            $"{sv.Course1}\n" +
                            $"{sv.Course2}\n" +
                            $"{sv.Course3}\n" +
                            $"\n\n";

            // Xóa dữ liệu nhập
            txtAddName.Clear();
            txtAddID.Clear();
            txtAddPhone.Clear();
            txtAddCourse1.Clear();
            txtAddCourse2.Clear();
            txtAddCourse3.Clear();
            txtAddName.Focus();

        }

      

        void HienThiSinhVien(SinhVien sv)
        {
            lblThuTu.Text = (index + 1).ToString();
            txtName.Text = sv.Name;
            txtID.Text = sv.ID.ToString();
            txtPhone.Text = sv.Phone;
            txtCourse1.Text = sv.Course1.ToString();
            txtCourse2.Text = sv.Course2.ToString();
            txtCourse3.Text = sv.Course3.ToString();
            txtAverage.Text = Math.Round(sv.Average,2).ToString();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            //Ghi vào input4.json
            string path = "input4.json";
            string jsonString = JsonSerializer.Serialize(students, new JsonSerializerOptions 
            { 
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });
            File.WriteAllText(path, jsonString);
            MessageBox.Show("Ghi file thành công");
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string path = "input4.json";
           

            if (!File.Exists(path))
            {
                MessageBox.Show("File input4.json chưa tồn tại!");
                return;
            }

            string jsonString = File.ReadAllText(path);
           
            if (string.IsNullOrWhiteSpace(jsonString))
            {
                MessageBox.Show("File input4.json trống!");
                return;
            }

            students = JsonSerializer.Deserialize<List<SinhVien>>(jsonString);

            foreach (var sv in students)
            {
                sv.Average = sv.TinhDiemTrungBinh();
            }

            

            string pathOutput = "output4.json";
            string jsonStringOutput = JsonSerializer.Serialize(students, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });
            File.WriteAllText(pathOutput, jsonStringOutput);




            // Hiển thị sinh viên đầu tiên
            index = 0;
            HienThiSinhVien(students[index]);

            MessageBox.Show("Đã tính điểm trung bình và ghi xuống file output4.json");

        }

        private void btbBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                HienThiSinhVien(students[index]);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < students.Count - 1)
            {
                index++;
                HienThiSinhVien(students[index]);
            }

        }
    }
}
