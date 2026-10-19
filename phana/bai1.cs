using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phana
{
    public class bai1 : Form
    {
        private Label lblTieuDe;
        private Label lblBanKinh;
        private Label lblChuVi;
        private Label lblDienTich;
        private TextBox txtBanKinh;
        private TextBox txtChuVi;
        private TextBox txtDienTich;
        private Button btnTinh;
        private Button btnLamLai;

        public bai1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblBanKinh = new Label();
            lblChuVi = new Label();
            lblDienTich = new Label();
            txtBanKinh = new TextBox();
            txtChuVi = new TextBox();
            txtDienTich = new TextBox();
            btnTinh = new Button();
            btnLamLai = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Black;
            lblTieuDe.Location = new Point(20, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(440, 35);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "TÍNH CHU VI, DIỆN TÍCH HÌNH TRÒN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBanKinh
            // 
            lblBanKinh.Location = new Point(60, 75);
            lblBanKinh.Name = "lblBanKinh";
            lblBanKinh.Size = new Size(90, 25);
            lblBanKinh.TabIndex = 1;
            lblBanKinh.Text = "Bán kính";
            // 
            // lblChuVi
            // 
            lblChuVi.Location = new Point(60, 118);
            lblChuVi.Name = "lblChuVi";
            lblChuVi.Size = new Size(90, 25);
            lblChuVi.TabIndex = 3;
            lblChuVi.Text = "Chu vi";
            // 
            // lblDienTich
            // 
            lblDienTich.Location = new Point(60, 160);
            lblDienTich.Name = "lblDienTich";
            lblDienTich.Size = new Size(90, 25);
            lblDienTich.TabIndex = 5;
            lblDienTich.Text = "Diện tích";
            // 
            // txtBanKinh
            // 
            txtBanKinh.Location = new Point(160, 72);
            txtBanKinh.Name = "txtBanKinh";
            txtBanKinh.Size = new Size(240, 30);
            txtBanKinh.TabIndex = 2;
            // 
            // txtChuVi
            // 
            txtChuVi.BackColor = Color.White;
            txtChuVi.Location = new Point(160, 115);
            txtChuVi.Name = "txtChuVi";
            txtChuVi.ReadOnly = true;
            txtChuVi.Size = new Size(240, 30);
            txtChuVi.TabIndex = 4;
            // 
            // txtDienTich
            // 
            txtDienTich.BackColor = Color.White;
            txtDienTich.Location = new Point(160, 157);
            txtDienTich.Name = "txtDienTich";
            txtDienTich.ReadOnly = true;
            txtDienTich.Size = new Size(240, 30);
            txtDienTich.TabIndex = 6;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.Transparent;
            btnTinh.FlatStyle = FlatStyle.Flat;
            btnTinh.ForeColor = Color.Black;
            btnTinh.Location = new Point(130, 210);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(100, 35);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += BtnTinh_Click;
            // 
            // btnLamLai
            // 
            btnLamLai.BackColor = Color.White;
            btnLamLai.FlatStyle = FlatStyle.Flat;
            btnLamLai.ForeColor = Color.Black;
            btnLamLai.Location = new Point(260, 210);
            btnLamLai.Name = "btnLamLai";
            btnLamLai.Size = new Size(100, 35);
            btnLamLai.TabIndex = 8;
            btnLamLai.Text = "Làm lại";
            btnLamLai.UseVisualStyleBackColor = false;
            btnLamLai.Click += BtnLamLai_Click;
            // 
            // bai1
            // 
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(480, 270);
            Controls.Add(lblTieuDe);
            Controls.Add(lblBanKinh);
            Controls.Add(txtBanKinh);
            Controls.Add(lblChuVi);
            Controls.Add(txtChuVi);
            Controls.Add(lblDienTich);
            Controls.Add(txtDienTich);
            Controls.Add(btnTinh);
            Controls.Add(btnLamLai);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính chu vi, diện tích hình tròn";
            Load += bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnTinh_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtBanKinh.Text.Trim(), out double r) || r <= 0)
            {
                MessageBox.Show("Vui lòng nhập bán kính r > 0 hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBanKinh.Focus();
                txtBanKinh.SelectAll();
                return;
            }

            double chuVi = 2 * Math.PI * r;
            double dienTich = Math.PI * r * r;

            txtChuVi.Text = chuVi.ToString("F2");
            txtDienTich.Text = dienTich.ToString("F2");
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtBanKinh.Focus();
        }

        private void bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
