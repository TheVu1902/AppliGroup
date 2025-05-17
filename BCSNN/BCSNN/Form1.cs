namespace BCSNN
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
        private void label1_Click(object sender, EventArgs e)
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
                CalculateLCM();
            }
        }

        private void CalculateLCM()
        {
            try
            {
                int number1 = Convert.ToInt32(Multiplier.Text);
                int number2 = Convert.ToInt32(Multiplicand.Text);

                int lcm = LCM(number1, number2);
                Product.Text = lcm.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter integers only.");
                Product.Text = "";
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        private int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
    }
}

