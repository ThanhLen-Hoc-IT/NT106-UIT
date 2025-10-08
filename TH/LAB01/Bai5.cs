using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class frm_Bai5 : Form
    {
        public frm_Bai5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Bai5_Load(object sender, EventArgs e)
        {

        }

        int giaiThua(int x)
        {
            if (x <= 1) return 1;   
            return x * giaiThua(x - 1);
        }

        long Tong(int x, int y)
        {
            long kq = 0;
            long tmp = 1; // x^i
            for (int i = 1; i <= y; i++)
            {
                tmp *= x; // tính x^i
                kq += tmp;
            }
            return kq;
        }




        private void btn_tinh_Click(object sender, EventArgs e)
        {
            int a, b;
            bool so1 = int.TryParse(txt_num1.Text, out a);
            bool so2 = int.TryParse(txt_num2.Text, out b);
            if (!so1 || !so2)
            {
                MessageBox.Show("Mời bạn nhập số nguyên!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (cbo_tinh.Text == "Bảng cửu chương")
                {
                    int hieu = Math.Abs(a - b);
                    txt_kq.Text = $"Bảng cửu chương: {Environment.NewLine}";
                    for (int i = 1; i <= 10; i++)
                    {
                        txt_kq.Text +=
                             $" {hieu} * {i} =  {hieu * i}{Environment.NewLine}";
                    }
                }
                else if (cbo_tinh.Text == "Tính toán giá trị")
                {
                    int hieu = Math.Abs(a - b);
                    txt_kq.Text = $"(A - B)! = {giaiThua(hieu)}{Environment.NewLine}" +
                                  $"Tổng S = {Tong(a, b)}{Environment.NewLine}";



                }
            }
        }

        private void txt_kq_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_num1.Text = "";
            txt_num2.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
