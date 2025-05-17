namespace Chiahaiso
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
            this.label5 = new System.Windows.Forms.Label();
            this.LabelProduct = new System.Windows.Forms.Label();
            this.LabelMultiplicand = new System.Windows.Forms.Label();
            this.LabelMultiplier = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.TextBox();
            this.Multiplicand = new System.Windows.Forms.TextBox();
            this.Multiplier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Division of two numbers";
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.Location = new System.Drawing.Point(335, 271);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(39, 16);
            this.LabelProduct.TabIndex = 12;
            this.LabelProduct.Text = "result";
            // 
            // LabelMultiplicand
            // 
            this.LabelMultiplicand.AutoSize = true;
            this.LabelMultiplicand.Location = new System.Drawing.Point(335, 221);
            this.LabelMultiplicand.Name = "LabelMultiplicand";
            this.LabelMultiplicand.Size = new System.Drawing.Size(65, 16);
            this.LabelMultiplicand.TabIndex = 11;
            this.LabelMultiplicand.Text = "number 2:";
            // 
            // LabelMultiplier
            // 
            this.LabelMultiplier.AutoSize = true;
            this.LabelMultiplier.Location = new System.Drawing.Point(335, 163);
            this.LabelMultiplier.Name = "LabelMultiplier";
            this.LabelMultiplier.Size = new System.Drawing.Size(65, 16);
            this.LabelMultiplier.TabIndex = 10;
            this.LabelMultiplier.Text = "number 1:";
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(421, 268);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(100, 22);
            this.Product.TabIndex = 9;
            // 
            // Multiplicand
            // 
            this.Multiplicand.Location = new System.Drawing.Point(421, 215);
            this.Multiplicand.Name = "Multiplicand";
            this.Multiplicand.Size = new System.Drawing.Size(100, 22);
            this.Multiplicand.TabIndex = 8;
            // 
            // Multiplier
            // 
            this.Multiplier.Location = new System.Drawing.Point(421, 158);
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Size = new System.Drawing.Size(100, 22);
            this.Multiplier.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelProduct);
            this.Controls.Add(this.LabelMultiplicand);
            this.Controls.Add(this.LabelMultiplier);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Multiplicand);
            this.Controls.Add(this.Multiplier);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.Label LabelMultiplicand;
        private System.Windows.Forms.Label LabelMultiplier;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.TextBox Multiplicand;
        private System.Windows.Forms.TextBox Multiplier;
    }
}

