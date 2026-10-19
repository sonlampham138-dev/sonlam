using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phana
{
    public class bai2 : Form
    {
        private Label lblTieuDe;
        private Label lblChieuDai;
        private Label lblChieuRong;
        private Label lblChuVi;
        private Label lblDienTich;
        private TextBox txtChieuDai;
        private TextBox txtChieuRong;
        private TextBox txtChuVi;
        private TextBox txtDienTich;
        private Button btnTinh;
        private Button btnLamLai;

        public bai2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblChieuDai = new Label();
            lblChieuRong = new Label();
            lblChuVi = new Label();
            lblDienTich = new Label();
            txtChieuDai = new TextBox();
            txtChieuRong = new TextBox();
            txtChuVi = new TextBox();
            txtDienTich = new TextBox();
            btnTinh = new Button();
            btnLamLai = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Black;
            lblTieuDe.Location = new Point(20, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(440, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "TÍNH CHU VI, DIỆN TÍCH HÌNH CHỮ NHẬT";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChieuDai
            // 
            lblChieuDai.Location = new Point(60, 70);
            lblChieuDai.Name = "lblChieuDai";
            lblChieuDai.Size = new Size(90, 25);
            lblChieuDai.TabIndex = 1;
            lblChieuDai.Text = "Chiều dài";
            // 
            // lblChieuRong
            // 
            lblChieuRong.Location = new Point(60, 112);
            lblChieuRong.Name = "lblChieuRong";
            lblChieuRong.Size = new Size(90, 25);
            lblChieuRong.TabIndex = 3;
            lblChieuRong.Text = "Chiều rộng";
            // 
            // lblChuVi
            // 
            lblChuVi.Location = new Point(60, 154);
            lblChuVi.Name = "lblChuVi";
            lblChuVi.Size = new Size(90, 25);
            lblChuVi.TabIndex = 5;
            lblChuVi.Text = "Chu vi";
            // 
            // lblDienTich
            // 
            lblDienTich.Location = new Point(60, 196);
            lblDienTich.Name = "lblDienTich";
            lblDienTich.Size = new Size(90, 25);
            lblDienTich.TabIndex = 7;
            lblDienTich.Text = "Diện tích";
            // 
            // txtChieuDai
            // 
            txtChieuDai.Location = new Point(160, 67);
            txtChieuDai.Name = "txtChieuDai";
            txtChieuDai.Size = new Size(240, 30);
            txtChieuDai.TabIndex = 2;
            // 
            // txtChieuRong
            // 
            txtChieuRong.Location = new Point(160, 109);
            txtChieuRong.Name = "txtChieuRong";
            txtChieuRong.Size = new Size(240, 30);
            txtChieuRong.TabIndex = 4;
            // 
            // txtChuVi
            // 
            txtChuVi.BackColor = Color.White;
            txtChuVi.Location = new Point(160, 151);
            txtChuVi.Name = "txtChuVi";
            txtChuVi.ReadOnly = true;
            txtChuVi.Size = new Size(240, 30);
            txtChuVi.TabIndex = 6;
            // 
            // txtDienTich
            // 
            txtDienTich.BackColor = Color.White;
            txtDienTich.Location = new Point(160, 193);
            txtDienTich.Name = "txtDienTich";
            txtDienTich.ReadOnly = true;
            txtDienTich.Size = new Size(240, 30);
            txtDienTich.TabIndex = 8;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.White;
            btnTinh.FlatStyle = FlatStyle.Flat;
            btnTinh.ForeColor = Color.Black;
            btnTinh.Location = new Point(130, 245);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(100, 35);
            btnTinh.TabIndex = 9;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += BtnTinh_Click;
            // 
            // btnLamLai
            // 
            btnLamLai.BackColor = Color.White;
            btnLamLai.FlatStyle = FlatStyle.Flat;
            btnLamLai.ForeColor = Color.Black;
            btnLamLai.Location = new Point(260, 245);
            btnLamLai.Name = "btnLamLai";
            btnLamLai.Size = new Size(100, 35);
            btnLamLai.TabIndex = 10;
            btnLamLai.Text = "Làm lại";
            btnLamLai.UseVisualStyleBackColor = false;
            btnLamLai.Click += BtnLamLai_Click;
            // 
            // bai2
            // 
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(480, 310);
            Controls.Add(lblTieuDe);
            Controls.Add(lblChieuDai);
            Controls.Add(txtChieuDai);
            Controls.Add(lblChieuRong);
            Controls.Add(txtChieuRong);
            Controls.Add(lblChuVi);
            Controls.Add(txtChuVi);
            Controls.Add(lblDienTich);
            Controls.Add(txtDienTich);
            Controls.Add(btnTinh);
            Controls.Add(btnLamLai);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính chu vi, diện tích hình chữ nhật";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnTinh_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtChieuDai.Text.Trim(), out double dai) || dai <= 0)
            {
                MessageBox.Show("Vui lòng nhập chiều dài > 0 hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChieuDai.Focus();
                txtChieuDai.SelectAll();
                return;
            }

            if (!double.TryParse(txtChieuRong.Text.Trim(), out double rong) || rong <= 0)
            {
                MessageBox.Show("Vui lòng nhập chiều rộng > 0 hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChieuRong.Focus();
                txtChieuRong.SelectAll();
                return;
            }

            double chuVi = 2 * (dai + rong);
            double dienTich = dai * rong;

            txtChuVi.Text = chuVi.ToString("G");
            txtDienTich.Text = dienTich.ToString("G");
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            txtChieuDai.Clear();
            txtChieuRong.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtChieuDai.Focus();
        }
    }
}
