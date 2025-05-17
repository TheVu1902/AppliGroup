using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinhTienDien
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra số đầu
            if (!int.TryParse(textBox1.Text.Trim(), out int soDau))
            {
                MessageBox.Show("Số đầu không hợp lệ. Vui lòng nhập số nguyên.");
                textBox2.Focus();
                return;
            }

            // Kiểm tra số cuối
            if (!int.TryParse(textBox2.Text.Trim(), out int soCuoi))
            {
                MessageBox.Show("Số cuối không hợp lệ. Vui lòng nhập số nguyên.");
                textBox2.Focus();
                return;
            }

            // Kiểm tra số cuối >= số đầu
            if (soCuoi < soDau)
            {
                MessageBox.Show("Số cuối phải lớn hơn hoặc bằng số đầu.");
                textBox2.Focus();
                return;
            }

            // Tính tiền (giả sử đơn giá 10,000)
            int donGia = 2000;
            int soTien = (soCuoi - soDau) * donGia;

            // Hiển thị kết quả
            textBox3.Text = soTien.ToString("N0") + " VND";
        }
    }
}
