using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhDienTichHCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                double chieuDai = double.Parse(txtChieuDai.Text);
                double chieuRong = double.Parse(txtChieuRong.Text);

                // Tính diện tích
                double dienTich = chieuDai * chieuRong;

                // Hiển thị kết quả
                lblKetQua.Text = "Diện tích: " + dienTich.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
