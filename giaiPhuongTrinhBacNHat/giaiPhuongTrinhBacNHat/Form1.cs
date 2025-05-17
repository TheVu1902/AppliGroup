using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace giaiPhuongTrinhBacNHat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double a) && double.TryParse(textBox2.Text, out double b))
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        textBox4.Text = "Phương trình có vô số nghiệm.";
                    }
                    else
                    {
                        textBox4.Text = "Phương trình vô nghiệm.";
                    }
                }
                else
                {
                    double x = -b / a;
                    textBox4.Text = $"Nghiệm của phương trình là: x = {x}";
                }
            }
            else
            {
                textBox4.Text = "Vui lòng nhập giá trị số hợp lệ cho a và b.";
            }
        }
    }
}
