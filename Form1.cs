using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int so1 = int.Parse(textBox1.Text);  // Lấy số từ ô so1
                int so2 = int.Parse(textBox2.Text);  // Lấy số từ ô so2

                int hieu = so1 - so2;                // Tính hiệu

                textBox3.Text = hieu.ToString();     // Hiển thị kết quả ra ô "hieu"
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
