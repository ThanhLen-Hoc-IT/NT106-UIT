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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\UIT-Subjects\Foundational-Subjects\NT106-UIT\TH\LAB02\FILE\input1.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string content = sr.ReadToEnd();
                    rtbInput.Text = content;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy file input.txt!", "Lỗi đọc file");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }
        }


        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\UIT-Subjects\Foundational-Subjects\NT106-UIT\TH\LAB02\FILE\output1.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    string str = rtbInput.Text.ToUpper();
                    sw.WriteLine(str);
                }

                MessageBox.Show("Ghi file thành công!", "Thông báo");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Không có quyền ghi file hoặc file đang bị khóa!", "Lỗi ghi file");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }
        }

    }
}
