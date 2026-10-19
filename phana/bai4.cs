using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phana
{
    public class bai4 : Form
    {
        private Label lblTieuDe;
        private Label lblChiSoDau;
        private Label lblChiSoCuoi;
        private Label lblTienPhaiDong;
        private TextBox txtChiSoDau;
        private TextBox txtChiSoCuoi;
        private TextBox txtTienPhaiDong;
        private Button btnDongY;
        private Button btnLamLai;

        public bai4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblChiSoDau = new Label();
            lblChiSoCuoi = new Label();
            lblTienPhaiDong = new Label();
            txtChiSoDau = new TextBox();
            txtChiSoCuoi = new TextBox();
            txtTienPhaiDong = new TextBox();
            btnDongY = new Button();
            btnLamLai = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(20, 40, 80);
            lblTieuDe.Location = new Point(20, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(440, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "TÍNH TIỀN ĐIỆN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChiSoDau
            // 
            lblChiSoDau.Location = new Point(50, 70);
            lblChiSoDau.Name = "lblChiSoDau";
            lblChiSoDau.Size = new Size(130, 25);
            lblChiSoDau.TabIndex = 1;
            lblChiSoDau.Text = "Chỉ số đầu";
            // 
            // lblChiSoCuoi
            // 
            lblChiSoCuoi.Location = new Point(50, 115);
            lblChiSoCuoi.Name = "lblChiSoCuoi";
            lblChiSoCuoi.Size = new Size(130, 25);
            lblChiSoCuoi.TabIndex = 3;
            lblChiSoCuoi.Text = "Chỉ số cuối";
            // 
            // lblTienPhaiDong
            // 
            lblTienPhaiDong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTienPhaiDong.Location = new Point(50, 160);
            lblTienPhaiDong.Name = "lblTienPhaiDong";
            lblTienPhaiDong.Size = new Size(135, 25);
            lblTienPhaiDong.TabIndex = 5;
            lblTienPhaiDong.Text = "Số tiền phải đóng:";
            // 
            // txtChiSoDau
            // 
            txtChiSoDau.Location = new Point(190, 67);
            txtChiSoDau.Name = "txtChiSoDau";
            txtChiSoDau.Size = new Size(220, 30);
            txtChiSoDau.TabIndex = 2;
            // 
            // txtChiSoCuoi
            // 
            txtChiSoCuoi.Location = new Point(190, 112);
            txtChiSoCuoi.Name = "txtChiSoCuoi";
            txtChiSoCuoi.Size = new Size(220, 30);
            txtChiSoCuoi.TabIndex = 4;
            // 
            // txtTienPhaiDong
            // 
            txtTienPhaiDong.BackColor = Color.White;
            txtTienPhaiDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTienPhaiDong.ForeColor = Color.Black;
            txtTienPhaiDong.Location = new Point(190, 157);
            txtTienPhaiDong.Name = "txtTienPhaiDong";
            txtTienPhaiDong.ReadOnly = true;
            txtTienPhaiDong.Size = new Size(220, 30);
            txtTienPhaiDong.TabIndex = 6;
            // 
            // btnDongY
            // 
            btnDongY.BackColor = Color.White;
            btnDongY.FlatStyle = FlatStyle.Flat;
            btnDongY.ForeColor = Color.Black;
            btnDongY.Location = new Point(140, 210);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(100, 35);
            btnDongY.TabIndex = 7;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = false;
            btnDongY.Click += BtnDongY_Click;
            // 
            // btnLamLai
            // 
            btnLamLai.BackColor = Color.White;
            btnLamLai.FlatStyle = FlatStyle.Flat;
            btnLamLai.ForeColor = Color.Black;
            btnLamLai.Location = new Point(270, 210);
            btnLamLai.Name = "btnLamLai";
            btnLamLai.Size = new Size(100, 35);
            btnLamLai.TabIndex = 8;
            btnLamLai.Text = "Làm lại";
            btnLamLai.UseVisualStyleBackColor = false;
            btnLamLai.Click += BtnLamLai_Click;
            // 
            // bai4
            // 
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(480, 270);
            Controls.Add(lblTieuDe);
            Controls.Add(lblChiSoDau);
            Controls.Add(txtChiSoDau);
            Controls.Add(lblChiSoCuoi);
            Controls.Add(txtChiSoCuoi);
            Controls.Add(lblTienPhaiDong);
            Controls.Add(txtTienPhaiDong);
            Controls.Add(btnDongY);
            Controls.Add(btnLamLai);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính tiền điện theo bậc thang";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnDongY_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtChiSoDau.Text.Trim(), out double dau) || dau < 0)
            {
                MessageBox.Show("Vui lòng nhập chỉ số đầu >= 0 hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoDau.Focus();
                txtChiSoDau.SelectAll();
                return;
            }

            if (!double.TryParse(txtChiSoCuoi.Text.Trim(), out double cuoi) || cuoi < dau)
            {
                MessageBox.Show("Vui lòng nhập chỉ số cuối >= chỉ số đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoCuoi.Focus();
                txtChiSoCuoi.SelectAll();
                return;
            }

            double kw = cuoi - dau;
            double tongTien = 0;

            if (kw <= 100)
            {
                tongTien = kw * 500;
            }
            else if (kw <= 250)
            {
                tongTien = (100 * 500) + ((kw - 100) * 600);
            }
            else if (kw <= 300)
            {
                tongTien = (100 * 500) + (150 * 600) + ((kw - 250) * 800);
            }
            else
            {
                tongTien = (100 * 500) + (150 * 600) + (50 * 800) + ((kw - 300) * 1000);
            }

            txtTienPhaiDong.Text = tongTien.ToString("#,##0.00");
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            txtChiSoDau.Clear();
            txtChiSoCuoi.Clear();
            txtTienPhaiDong.Clear();
            txtChiSoDau.Focus();
        }
    }
}
