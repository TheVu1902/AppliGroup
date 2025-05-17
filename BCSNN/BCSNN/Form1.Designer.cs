namespace BCSNN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Multiplier = new TextBox();
            Multiplicand = new TextBox();
            Product = new TextBox();
            LabelMultiplier = new Label();
            LabelMultiplicand = new Label();
            LabelProduct = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Multiplier
            // 
            Multiplier.Location = new Point(294, 85);
            Multiplier.Name = "Multiplier";
            Multiplier.Size = new Size(125, 27);
            Multiplier.TabIndex = 0;
            // 
            // Multiplicand
            // 
            Multiplicand.Location = new Point(294, 148);
            Multiplicand.Name = "Multiplicand";
            Multiplicand.Size = new Size(125, 27);
            Multiplicand.TabIndex = 1;
            // 
            // Product
            // 
            Product.Location = new Point(294, 212);
            Product.Name = "Product";
            Product.Size = new Size(125, 27);
            Product.TabIndex = 2;
            // 
            // LabelMultiplier
            // 
            LabelMultiplier.AutoSize = true;
            LabelMultiplier.Location = new Point(193, 89);
            LabelMultiplier.Name = "LabelMultiplier";
            LabelMultiplier.Size = new Size(72, 20);
            LabelMultiplier.TabIndex = 3;
            LabelMultiplier.Text = "number 1";
            LabelMultiplier.Click += label1_Click;
            // 
            // LabelMultiplicand
            // 
            LabelMultiplicand.AutoSize = true;
            LabelMultiplicand.Location = new Point(193, 155);
            LabelMultiplicand.Name = "LabelMultiplicand";
            LabelMultiplicand.Size = new Size(72, 20);
            LabelMultiplicand.TabIndex = 4;
            LabelMultiplicand.Text = "number 2";
            // 
            // LabelProduct
            // 
            LabelProduct.AutoSize = true;
            LabelProduct.Location = new Point(193, 212);
            LabelProduct.Name = "LabelProduct";
            LabelProduct.Size = new Size(45, 20);
            LabelProduct.TabIndex = 5;
            LabelProduct.Text = "result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 34);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "USCLN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(LabelProduct);
            Controls.Add(LabelMultiplicand);
            Controls.Add(LabelMultiplier);
            Controls.Add(Product);
            Controls.Add(Multiplicand);
            Controls.Add(Multiplier);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Multiplier;
        private TextBox Multiplicand;
        private TextBox Product;
        private Label LabelMultiplier;
        private Label LabelMultiplicand;
        private Label LabelProduct;
        private Label label4;
    }
}