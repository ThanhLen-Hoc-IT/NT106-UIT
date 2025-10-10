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
    }
}
