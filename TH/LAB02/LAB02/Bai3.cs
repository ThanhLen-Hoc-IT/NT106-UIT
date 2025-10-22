using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LAB02
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            string newContent = "";
            
            // Mở file input
            string defaultInputPath = Path.Combine(Application.StartupPath, "input3.txt");

            // Tự tạo file input mặc định nếu chưa có
            if (!Directory.Exists(Path.Combine(Application.StartupPath)))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath));
            }

            if (!File.Exists(defaultInputPath))
            {
                // Tạo file input3.txt mẫu 
                string[] sampleData = {
                 "1 + 2 + 3 + 4",
                 "12 – 7 – 5 + 2 – 3",
                 "2024 – 1 – 2 + 3",
                 "222 + 333 – 444 + 1"
                };
                File.WriteAllLines(defaultInputPath, sampleData, Encoding.UTF8);
            }

            string fileInputPath = "";
            if (File.Exists(defaultInputPath))
            {
                // Nếu có file mặc định, hỏi người dùng có muốn dùng nó không
                DialogResult result = MessageBox.Show(
                    "Có muốn đọc file mặc định 'input3.txt' không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    fileInputPath = defaultInputPath;
                }
            }

            // Nếu chưa chọn file → cho phép người dùng chọn
            if (string.IsNullOrEmpty(fileInputPath))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Chọn file cần đọc";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.InitialDirectory = Application.StartupPath; // mở tại thư mục project

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileInputPath = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("Chưa chọn file đầu vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // ---Đọc và tính toán ---
            using (StreamReader sr = new StreamReader(fileInputPath))
            {
                string content = sr.ReadToEnd();
                string[] lines = content.Split(new[] { '\n' }, StringSplitOptions.None);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i])) continue;
                    newContent += lines[i].Trim() + " = " + TinhToan(lines[i]) + '\n';
                }
            }

            // Ghi ra file output
            string folderPath = Path.Combine(Application.StartupPath);
            
            string defaultOutputPath = Path.Combine(folderPath, "output3.txt");

            using (StreamWriter sw = new StreamWriter(defaultOutputPath, false, Encoding.UTF8))
            {
                sw.WriteLine(newContent);
            }

            MessageBox.Show($"Kết quả đã lưu tại:\n{defaultOutputPath}", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double TinhToan(string line)
        {
            //Chuẩn hóa đầu vào
            line = line.Replace('–','-');
            line = line.Replace(" ", "");
            line = line.Trim();

            //Xử lí dấu '-' đầu dòng
            if (line.StartsWith("-"))
            {
                line = "0" + line;
            }

            //Xử lí '-' trong ngoặc
            line = line.Replace("(-", "(0-");

            //  Tính toán theo nguyên tắc ưu tiên phép toán và ngoặc
            DataTable dt = new DataTable(); 
            var result = dt.Compute(line, ""); 
        
            return Convert.ToDouble(result);
        }

    }
}
