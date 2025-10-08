using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class frm_Bai2 : Form
    {
        public frm_Bai2()
        {
            InitializeComponent();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Bai2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            float c;
            if ((float.TryParse(txt_num1.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out a))
                && (float.TryParse(txt_num2.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out b))
                && (float.TryParse(txt_num3.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out c)))
            {

                float max = Math.Max(a, Math.Max(b, c));
                float min = Math.Min(a, Math.Min(b, c));

                txt_numMax.Text = max.ToString(CultureInfo.InvariantCulture);
                txt_numMIn.Text = min.ToString(CultureInfo.InvariantCulture);

            }
            else {
                MessageBox.Show("Dữ liệu không hợp lệ!",
                   "",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                   );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void bnt_delete_Click(object sender, EventArgs e)
        {
            txt_num1.Text= string.Empty;
            txt_num2.Text= string.Empty;
            txt_num3.Text= string.Empty;
        }

        private void txt_numMax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
