﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoNhoNHat
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) && double.TryParse(textBox2.Text, out double b))
            {
                if (a < b)
                {
                    textBox3.Text = a.ToString();
                }
                else
                {
                    textBox3.Text = b.ToString();
                }
            }
            else
            {
                textBox3.Text = "Vui lòng nhập giá trị số hợp lệ cho A và B.";
            }
        }
    }
}
