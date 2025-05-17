using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiahaiso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đăng ký sự kiện KeyDown cho các TextBox
            Multiplier.KeyDown += TxtMultiplier_KeyDown;
            Multiplicand.KeyDown += TxtMultiplicand_KeyDown;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void TxtMultiplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Multiplicand.Focus();
            }
        }

        private void TxtMultiplicand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateProduct();
            }
        }

        private void CalculateProduct()
        {
            try
            {
                double multiplier = Convert.ToDouble(Multiplier.Text);
                double multiplicand = Convert.ToDouble(Multiplicand.Text);

                double product = multiplier / multiplicand;
                Product.Text = product.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter numbers only.");
                Product.Text = "";
            }
        }
    }
}
