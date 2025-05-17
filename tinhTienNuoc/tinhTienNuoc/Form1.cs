using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinhTienNuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text.Trim(), out int soDau))
            {
                MessageBox.Show("Số đầu không hợp lệ. Hãy nhập số nguyên.");
                return;
            }

            if (!int.TryParse(textBox2.Text.Trim(), out int soCuoi))
            {
                MessageBox.Show("Số cuối không hợp lệ. Hãy nhập số nguyên.");
                return;
            }

            if (soCuoi < soDau)
            {
                MessageBox.Show("Số cuối phải lớn hơn hoặc bằng số đầu.");
                return;
            }

            int soTieuThu = soCuoi - soDau;
            int donGia = 10000;
            int thanhTien = soTieuThu * donGia;

            textBox3.Text = thanhTien.ToString("N0") + " VND";
        }
    }
}
