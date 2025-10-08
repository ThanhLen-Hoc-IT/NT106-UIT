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
    public partial class frm_Bai1 : Form
    {
        public frm_Bai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Bai1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txt_num1.Text, out a)){
                MessageBox.Show("Vui lòng nhập số nguyên!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            if (!int.TryParse(txt_num2.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!",
                   "",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                   );
                return;
            }

            int tong = a + b;
            txt_result.Text = tong.ToString();


        }
    }
}
