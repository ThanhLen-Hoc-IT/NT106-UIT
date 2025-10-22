using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class frm_MENU : Form
    {
        public frm_MENU()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBai6 frmBai6 = new FrmBai6();
            frmBai6.ShowDialog();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            frmBai1 frmBai1 = new frmBai1();
            frmBai1.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            frmBai2 frmBai2 = new frmBai2();
            frmBai2.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            frmBai3 frmBai3 = new frmBai3();
            frmBai3.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            frmBai4 frmBai4 = new frmBai4();
            frmBai4.ShowDialog();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            frmBai5 frmBai5 = new frmBai5();
            frmBai5.ShowDialog();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            frmBai7 frmBai7 = new frmBai7();
            frmBai7.ShowDialog();
        }
    }
}
