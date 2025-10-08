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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frm_Bai1 bai1 = new frm_Bai1();
            bai1.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            frm_Bai3_1 bai3_1= new frm_Bai3_1();
            bai3_1.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            frm_Bai6 bai6 = new frm_Bai6();
            bai6.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frm_Bai2 bai2 = new frm_Bai2();
            bai2.Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            frm_Bai3 bai3 = new frm_Bai3();
            bai3.Show();
        }

        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            frm_Bai4 bai4 = new frm_Bai4();
            bai4.Show();
        }

        private void btn_Bai5_Click(object sender, EventArgs e)
        {
            frm_Bai5 bai5 = new frm_Bai5();
            bai5.Show();
        }

        private void btn_Bai7_Click(object sender, EventArgs e)
        {
            frm_Bai7 bai7 = new frm_Bai7();
            bai7.Show();
        }

        private void btn_Bai8_Click(object sender, EventArgs e)
        {
            frm_Bai8 bai8 = new frm_Bai8();
            bai8.Show();
        }
    }
}
