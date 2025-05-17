namespace TinhDienTichHCN
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
            this.lblChieuDai = new System.Windows.Forms.Label();
            this.lblChieuRong = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChieuDai
            // 
            this.lblChieuDai.AutoSize = true;
            this.lblChieuDai.Location = new System.Drawing.Point(30, 30);
            this.lblChieuDai.Name = "lblChieuDai";
            this.lblChieuDai.Size = new System.Drawing.Size(100, 16);
            this.lblChieuDai.TabIndex = 0;
            this.lblChieuDai.Text = "Nhập chiều dài:\t";
            // 
            // lblChieuRong
            // 
            this.lblChieuRong.AutoSize = true;
            this.lblChieuRong.Location = new System.Drawing.Point(30, 70);
            this.lblChieuRong.Name = "lblChieuRong";
            this.lblChieuRong.Size = new System.Drawing.Size(108, 16);
            this.lblChieuRong.TabIndex = 1;
            this.lblChieuRong.Text = "Nhập chiều rộng:\t";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(30, 170);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(61, 16);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "Diện tích:\t";
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(150, 30);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(100, 22);
            this.txtChieuDai.TabIndex = 3;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(150, 70);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(100, 22);
            this.txtChieuRong.TabIndex = 4;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(86, 121);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(97, 23);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "Tính diện tích\t";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtChieuRong);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblChieuRong);
            this.Controls.Add(this.lblChieuDai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChieuDai;
        private System.Windows.Forms.Label lblChieuRong;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.Button btnTinh;
    }
}

