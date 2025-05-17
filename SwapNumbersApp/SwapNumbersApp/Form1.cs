using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwapNumbersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ 2 ô nhập
            string temp = txtSo1.Text;
            txtSo1.Text = txtSo2.Text;
            txtSo2.Text = temp;
        }
    }
}
