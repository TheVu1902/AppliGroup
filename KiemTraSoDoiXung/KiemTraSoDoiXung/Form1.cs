using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraSoDoiXung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string soNhap = txtSo.Text.Trim();

            // Kiểm tra chuỗi có phải là số không
            if (!long.TryParse(soNhap, out long soNguyen))
            {
                lblKetQua.Text = "Vui lòng nhập một số nguyên hợp lệ.";
                return;
            }

            // Kiểm tra đối xứng
            string soDaoNguoc = new string(soNhap.Reverse().ToArray());
            if (soNhap == soDaoNguoc)
            {
                lblKetQua.Text = $"{soNhap} là số đối xứng.";
            }
            else
            {
                lblKetQua.Text = $"{soNhap} không phải là số đối xứng.";
            }
        }
    }
}
