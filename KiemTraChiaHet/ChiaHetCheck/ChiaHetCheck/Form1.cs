using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiaHetCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox và chuyển sang số nguyên
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);

                // Kiểm tra chia hết
                if (b == 0)
                {
                    lblKetQua.Text = "Không thể chia cho 0!";
                }
                else if (a % b == 0)
                {
                    lblKetQua.Text = $"Số {a} chia hết cho {b}.";
                }
                else
                {
                    lblKetQua.Text = $"Số {a} không chia hết cho {b}.";
                }
            }
            catch (FormatException)
            {
                lblKetQua.Text = "Vui lòng nhập số nguyên hợp lệ!";
            }
        }
    }
}
