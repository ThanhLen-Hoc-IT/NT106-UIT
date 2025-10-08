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
    public partial class frm_Bai3 : Form
    {
        public frm_Bai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(txt_num.Text, out a) && (a >= 0 && a <= 9))
            {
                switch (a) {
                    case 0:
                        txt_result.Text = "Không";
                        break;
                    case 1:
                        txt_result.Text = "Một";
                        break;
                    case 2:
                        txt_result.Text = "Hai";
                        break;
                    case 3:
                        txt_result.Text = "Ba";
                        break;
                    case 4:
                        txt_result.Text = "Bốn";
                        break;
                    case 5:
                        txt_result.Text = "Năm";
                        break;
                    case 6:
                        txt_result.Text = "Sáu";
                        break;
                    case 7:
                        txt_result.Text = "Bảy";
                        break;
                    case 8:
                        txt_result.Text = "Tám";
                        break;
                    case 9:
                        txt_result.Text = "Chín";
                        break;
                }
            }else
            {
                MessageBox.Show("Lỗi!Mời bạn nhập lại",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_num.Text = "";
            txt_result.Text = "";
        }
    }
}
