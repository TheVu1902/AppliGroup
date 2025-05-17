namespace Nhanhaiso
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Multiplier = new System.Windows.Forms.TextBox();
            this.Multiplicand = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.TextBox();
            this.LabelMultiplier = new System.Windows.Forms.Label();
            this.LabelMultiplicand = new System.Windows.Forms.Label();
            this.LabelProduct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Multiplier
            // 
            this.Multiplier.Location = new System.Drawing.Point(340, 95);
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Size = new System.Drawing.Size(100, 22);
            this.Multiplier.TabIndex = 0;
            // 
            // Multiplicand
            // 
            this.Multiplicand.Location = new System.Drawing.Point(340, 152);
            this.Multiplicand.Name = "Multiplicand";
            this.Multiplicand.Size = new System.Drawing.Size(100, 22);
            this.Multiplicand.TabIndex = 1;
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(340, 205);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(100, 22);
            this.Product.TabIndex = 2;
            // 
            // LabelMultiplier
            // 
            this.LabelMultiplier.AutoSize = true;
            this.LabelMultiplier.Location = new System.Drawing.Point(254, 100);
            this.LabelMultiplier.Name = "LabelMultiplier";
            this.LabelMultiplier.Size = new System.Drawing.Size(65, 16);
            this.LabelMultiplier.TabIndex = 3;
            this.LabelMultiplier.Text = "number 1:";
            // 
            // LabelMultiplicand
            // 
            this.LabelMultiplicand.AutoSize = true;
            this.LabelMultiplicand.Location = new System.Drawing.Point(254, 158);
            this.LabelMultiplicand.Name = "LabelMultiplicand";
            this.LabelMultiplicand.Size = new System.Drawing.Size(65, 16);
            this.LabelMultiplicand.TabIndex = 4;
            this.LabelMultiplicand.Text = "number 2:";
            this.LabelMultiplicand.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.Location = new System.Drawing.Point(254, 208);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(39, 16);
            this.LabelProduct.TabIndex = 5;
            this.LabelProduct.Text = "result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Multiplication of two numbers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelProduct);
            this.Controls.Add(this.LabelMultiplicand);
            this.Controls.Add(this.LabelMultiplier);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Multiplicand);
            this.Controls.Add(this.Multiplier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Multiplier;
        private System.Windows.Forms.TextBox Multiplicand;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.Label LabelMultiplier;
        private System.Windows.Forms.Label LabelMultiplicand;
        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.Label label4;
    }
}

