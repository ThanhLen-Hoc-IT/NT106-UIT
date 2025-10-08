using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class frm_Bai8 : Form
    {
        public frm_Bai8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Random rm = new Random();
            int index = rm.Next(list.Count()-1);
            txt_kq.Text = list[index];
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        List <string> list = new List<string>();


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_input.Text != "")
            {
                list.Add(txt_input.Text);
                txt_input.Text= string.Empty;
            }
            txt_listDishes.Text = "";
            for (int i = 0; i < list.Count; i++) {
                txt_listDishes.Text += $"{list[i]}{Environment.NewLine}";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ danh sách
            list.Clear();

            // Xóa TextBox
            txt_input.Text = string.Empty;
            txt_listDishes.Text = string.Empty;
            txt_kq.Text = string.Empty;
        }
    }
}
