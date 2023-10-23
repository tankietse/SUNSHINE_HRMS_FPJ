namespace SunShine_HRMs.View
{
    partial class frmTrangChinh
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSoUVLoai = new System.Windows.Forms.Label();
            this.lblTongUngVienLoai = new System.Windows.Forms.Label();
            this.cpbUVLoai = new CircularProgressBar.CircularProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblSoNhanVien = new System.Windows.Forms.Label();
            this.lblTongNhanVien = new System.Windows.Forms.Label();
            this.cpbNhanVien = new CircularProgressBar.CircularProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSoUngVien = new System.Windows.Forms.Label();
            this.lblTongUV = new System.Windows.Forms.Label();
            this.cpbUngVien = new CircularProgressBar.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 206);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trang chính";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 172);
            this.panel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel6.Controls.Add(this.lblSoUVLoai);
            this.panel6.Controls.Add(this.lblTongUngVienLoai);
            this.panel6.Controls.Add(this.cpbUVLoai);
            this.panel6.Location = new System.Drawing.Point(1080, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(277, 169);
            this.panel6.TabIndex = 0;
            // 
            // lblSoUVLoai
            // 
            this.lblSoUVLoai.AutoSize = true;
            this.lblSoUVLoai.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoUVLoai.ForeColor = System.Drawing.Color.Black;
            this.lblSoUVLoai.Location = new System.Drawing.Point(19, 60);
            this.lblSoUVLoai.Name = "lblSoUVLoai";
            this.lblSoUVLoai.Size = new System.Drawing.Size(39, 29);
            this.lblSoUVLoai.TabIndex = 1;
            this.lblSoUVLoai.Text = "10";
            // 
            // lblTongUngVienLoai
            // 
            this.lblTongUngVienLoai.AutoSize = true;
            this.lblTongUngVienLoai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongUngVienLoai.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTongUngVienLoai.Location = new System.Drawing.Point(3, 12);
            this.lblTongUngVienLoai.Name = "lblTongUngVienLoai";
            this.lblTongUngVienLoai.Size = new System.Drawing.Size(98, 16);
            this.lblTongUngVienLoai.TabIndex = 1;
            this.lblTongUngVienLoai.Text = "Ứng Viên Loại";
            // 
            // cpbUVLoai
            // 
            this.cpbUVLoai.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbUVLoai.AnimationSpeed = 500;
            this.cpbUVLoai.BackColor = System.Drawing.Color.Transparent;
            this.cpbUVLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbUVLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbUVLoai.InnerColor = System.Drawing.Color.Transparent;
            this.cpbUVLoai.InnerMargin = 2;
            this.cpbUVLoai.InnerWidth = -1;
            this.cpbUVLoai.Location = new System.Drawing.Point(137, 12);
            this.cpbUVLoai.MarqueeAnimationSpeed = 2000;
            this.cpbUVLoai.Name = "cpbUVLoai";
            this.cpbUVLoai.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.cpbUVLoai.OuterMargin = -25;
            this.cpbUVLoai.OuterWidth = 26;
            this.cpbUVLoai.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cpbUVLoai.ProgressWidth = 15;
            this.cpbUVLoai.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbUVLoai.Size = new System.Drawing.Size(140, 140);
            this.cpbUVLoai.StartAngle = 270;
            this.cpbUVLoai.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbUVLoai.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbUVLoai.SubscriptText = "";
            this.cpbUVLoai.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbUVLoai.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbUVLoai.SuperscriptText = "";
            this.cpbUVLoai.TabIndex = 0;
            this.cpbUVLoai.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbUVLoai.Value = 68;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.LblSoNhanVien);
            this.panel5.Controls.Add(this.lblTongNhanVien);
            this.panel5.Controls.Add(this.cpbNhanVien);
            this.panel5.Location = new System.Drawing.Point(546, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 169);
            this.panel5.TabIndex = 0;
            // 
            // LblSoNhanVien
            // 
            this.LblSoNhanVien.AutoSize = true;
            this.LblSoNhanVien.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSoNhanVien.ForeColor = System.Drawing.Color.Black;
            this.LblSoNhanVien.Location = new System.Drawing.Point(19, 60);
            this.LblSoNhanVien.Name = "LblSoNhanVien";
            this.LblSoNhanVien.Size = new System.Drawing.Size(39, 29);
            this.LblSoNhanVien.TabIndex = 1;
            this.LblSoNhanVien.Text = "10";
            // 
            // lblTongNhanVien
            // 
            this.lblTongNhanVien.AutoSize = true;
            this.lblTongNhanVien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongNhanVien.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTongNhanVien.Location = new System.Drawing.Point(3, 12);
            this.lblTongNhanVien.Name = "lblTongNhanVien";
            this.lblTongNhanVien.Size = new System.Drawing.Size(108, 16);
            this.lblTongNhanVien.TabIndex = 1;
            this.lblTongNhanVien.Text = "Tổng Nhân Viên";
            // 
            // cpbNhanVien
            // 
            this.cpbNhanVien.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbNhanVien.AnimationSpeed = 500;
            this.cpbNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cpbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbNhanVien.InnerColor = System.Drawing.Color.Transparent;
            this.cpbNhanVien.InnerMargin = 2;
            this.cpbNhanVien.InnerWidth = -1;
            this.cpbNhanVien.Location = new System.Drawing.Point(137, 12);
            this.cpbNhanVien.MarqueeAnimationSpeed = 2000;
            this.cpbNhanVien.Name = "cpbNhanVien";
            this.cpbNhanVien.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.cpbNhanVien.OuterMargin = -25;
            this.cpbNhanVien.OuterWidth = 26;
            this.cpbNhanVien.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbNhanVien.ProgressWidth = 15;
            this.cpbNhanVien.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbNhanVien.Size = new System.Drawing.Size(140, 140);
            this.cpbNhanVien.StartAngle = 270;
            this.cpbNhanVien.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbNhanVien.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbNhanVien.SubscriptText = "";
            this.cpbNhanVien.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbNhanVien.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbNhanVien.SuperscriptText = "";
            this.cpbNhanVien.TabIndex = 0;
            this.cpbNhanVien.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbNhanVien.Value = 68;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel4.Controls.Add(this.lblSoUngVien);
            this.panel4.Controls.Add(this.lblTongUV);
            this.panel4.Controls.Add(this.cpbUngVien);
            this.panel4.Location = new System.Drawing.Point(25, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 169);
            this.panel4.TabIndex = 0;
            // 
            // lblSoUngVien
            // 
            this.lblSoUngVien.AutoSize = true;
            this.lblSoUngVien.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoUngVien.ForeColor = System.Drawing.Color.Black;
            this.lblSoUngVien.Location = new System.Drawing.Point(19, 60);
            this.lblSoUngVien.Name = "lblSoUngVien";
            this.lblSoUngVien.Size = new System.Drawing.Size(39, 29);
            this.lblSoUngVien.TabIndex = 1;
            this.lblSoUngVien.Text = "10";
            // 
            // lblTongUV
            // 
            this.lblTongUV.AutoSize = true;
            this.lblTongUV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongUV.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTongUV.Location = new System.Drawing.Point(3, 12);
            this.lblTongUV.Name = "lblTongUV";
            this.lblTongUV.Size = new System.Drawing.Size(102, 16);
            this.lblTongUV.TabIndex = 1;
            this.lblTongUV.Text = "Tổng Ứng Viên";
            // 
            // cpbUngVien
            // 
            this.cpbUngVien.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbUngVien.AnimationSpeed = 500;
            this.cpbUngVien.BackColor = System.Drawing.Color.Transparent;
            this.cpbUngVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbUngVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbUngVien.InnerColor = System.Drawing.Color.Transparent;
            this.cpbUngVien.InnerMargin = 2;
            this.cpbUngVien.InnerWidth = -1;
            this.cpbUngVien.Location = new System.Drawing.Point(137, 12);
            this.cpbUngVien.MarqueeAnimationSpeed = 2000;
            this.cpbUngVien.Name = "cpbUngVien";
            this.cpbUngVien.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.cpbUngVien.OuterMargin = -25;
            this.cpbUngVien.OuterWidth = 26;
            this.cpbUngVien.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.cpbUngVien.ProgressWidth = 15;
            this.cpbUngVien.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbUngVien.Size = new System.Drawing.Size(140, 140);
            this.cpbUngVien.StartAngle = 270;
            this.cpbUngVien.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbUngVien.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbUngVien.SubscriptText = "";
            this.cpbUngVien.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbUngVien.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbUngVien.SuperscriptText = "";
            this.cpbUngVien.TabIndex = 0;
            this.cpbUngVien.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbUngVien.Value = 68;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1394, 558);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(15, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1367, 540);
            this.panel7.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.chart1);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(707, 540);
            this.panel9.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Location = new System.Drawing.Point(707, 67);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 236);
            this.panel12.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(44, 23);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(636, 497);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(707, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(660, 540);
            this.panel10.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(6, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(654, 540);
            this.panel8.TabIndex = 0;
            // 
            // frmTrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1394, 764);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrangChinh";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Trang Chính";
            this.Load += new System.EventHandler(this.frmTrangChinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private CircularProgressBar.CircularProgressBar cpbUngVien;
        private System.Windows.Forms.Label lblSoUngVien;
        private System.Windows.Forms.Label lblTongUV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSoUVLoai;
        private System.Windows.Forms.Label lblTongUngVienLoai;
        private CircularProgressBar.CircularProgressBar cpbUVLoai;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblSoNhanVien;
        private System.Windows.Forms.Label lblTongNhanVien;
        private CircularProgressBar.CircularProgressBar cpbNhanVien;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
    }
}