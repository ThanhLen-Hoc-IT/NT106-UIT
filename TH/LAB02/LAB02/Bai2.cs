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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

       

        private void btnReadFile_Click(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file cần đọc";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Lấy tên file
                string fileName = ofd.SafeFileName;
                txtFileName.Text = fileName;

                // Lấy đường dẫn file
                string filePath = ofd.FileName;
                txtURL.Text = filePath;

                // Dùng FileStream và StreamReader để đọc
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string content = sr.ReadToEnd();
                    rtbInfor.Text = content;

                    // Kích thước file (bytes)
                    FileInfo fi = new FileInfo(filePath);
                    txtSize.Text = fi.Length.ToString() + " bytes";

                    // Số dòng
                    int lineCount = 0;
                    while (sr.ReadLine() != null)
                        lineCount++;
                    txtLineCount.Text = lineCount.ToString();

                    // Số từ
                    char[] dk = { ' ', '\n', '\r', '\t' };
                    int wordCount = content.Split(dk, StringSplitOptions.RemoveEmptyEntries).Length;
                    txtWordCount.Text = wordCount.ToString();

                    // Số ký tự
                    txtCharacterCount.Text = content.Length.ToString();
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
