namespace SunShine_HRMs.View
{
    partial class frmXacThucMa
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnGuiLaiMa = new System.Windows.Forms.Button();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 29);
            this.textBox1.TabIndex = 0;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.Location = new System.Drawing.Point(155, 157);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(108, 40);
            this.btnTiepTuc.TabIndex = 1;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnGuiLaiMa
            // 
            this.btnGuiLaiMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiLaiMa.Location = new System.Drawing.Point(155, 216);
            this.btnGuiLaiMa.Name = "btnGuiLaiMa";
            this.btnGuiLaiMa.Size = new System.Drawing.Size(108, 40);
            this.btnGuiLaiMa.TabIndex = 1;
            this.btnGuiLaiMa.Text = "Gửi lại mã";
            this.btnGuiLaiMa.UseVisualStyleBackColor = true;
            this.btnGuiLaiMa.Click += new System.EventHandler(this.btnGuiLaiMa_Click);
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Location = new System.Drawing.Point(140, 62);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(53, 29);
            this.txtThoiGian.TabIndex = 2;
            this.txtThoiGian.Text = "00:05";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(155, 275);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 40);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // frmXacThucMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.btnGuiLaiMa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.textBox1);
            this.Name = "frmXacThucMa";
            this.Text = "XacThucMa";
            this.Load += new System.EventHandler(this.XacThucMa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnGuiLaiMa;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.Button btnHuy;
    }
}