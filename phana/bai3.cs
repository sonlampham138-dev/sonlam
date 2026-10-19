using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phana
{
    public class bai3 : Form
    {
        private Label lblTieuDe;
        private Label lblHK1;
        private Label lblHK2;
        private Label lblDTB;
        private Label lblXepLoai;
        private TextBox txtHK1;
        private TextBox txtHK2;
        private TextBox txtDTB;
        private TextBox txtXepLoai;
        private Button btnDongY;
        private Button btnLamLai;

        public bai3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblHK1 = new Label();
            lblHK2 = new Label();
            lblDTB = new Label();
            lblXepLoai = new Label();
            txtHK1 = new TextBox();
            txtHK2 = new TextBox();
            txtDTB = new TextBox();
            txtXepLoai = new TextBox();
            btnDongY = new Button();
            btnLamLai = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Black;
            lblTieuDe.Location = new Point(20, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(440, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "XẾP LOẠI HỌC TẬP";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHK1
            // 
            lblHK1.Location = new Point(60, 68);
            lblHK1.Name = "lblHK1";
            lblHK1.Size = new Size(90, 25);
            lblHK1.TabIndex = 1;
            lblHK1.Text = "Điểm HKI";
            // 
            // lblHK2
            // 
            lblHK2.Location = new Point(60, 110);
            lblHK2.Name = "lblHK2";
            lblHK2.Size = new Size(90, 25);
            lblHK2.TabIndex = 3;
            lblHK2.Text = "Điểm HKII";
            // 
            // lblDTB
            // 
            lblDTB.Location = new Point(60, 152);
            lblDTB.Name = "lblDTB";
            lblDTB.Size = new Size(90, 25);
            lblDTB.TabIndex = 5;
            lblDTB.Text = "Điểm TB";
            // 
            // lblXepLoai
            // 
            lblXepLoai.Location = new Point(60, 194);
            lblXepLoai.Name = "lblXepLoai";
            lblXepLoai.Size = new Size(90, 25);
            lblXepLoai.TabIndex = 7;
            lblXepLoai.Text = "Xếp loại";
            // 
            // txtHK1
            // 
            txtHK1.Location = new Point(160, 65);
            txtHK1.Name = "txtHK1";
            txtHK1.Size = new Size(240, 30);
            txtHK1.TabIndex = 2;
            // 
            // txtHK2
            // 
            txtHK2.Location = new Point(160, 107);
            txtHK2.Name = "txtHK2";
            txtHK2.Size = new Size(240, 30);
            txtHK2.TabIndex = 4;
            // 
            // txtDTB
            // 
            txtDTB.BackColor = Color.White;
            txtDTB.Location = new Point(160, 149);
            txtDTB.Name = "txtDTB";
            txtDTB.ReadOnly = true;
            txtDTB.Size = new Size(240, 30);
            txtDTB.TabIndex = 6;
            // 
            // txtXepLoai
            // 
            txtXepLoai.BackColor = Color.White;
            txtXepLoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtXepLoai.Location = new Point(160, 191);
            txtXepLoai.Name = "txtXepLoai";
            txtXepLoai.ReadOnly = true;
            txtXepLoai.Size = new Size(240, 30);
            txtXepLoai.TabIndex = 8;
            // 
            // btnDongY
            // 
            btnDongY.BackColor = Color.White;
            btnDongY.FlatStyle = FlatStyle.Flat;
            btnDongY.ForeColor = Color.Black;
            btnDongY.Location = new Point(130, 245);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(100, 35);
            btnDongY.TabIndex = 9;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = false;
            btnDongY.Click += BtnDongY_Click;
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
            // bai3
            // 
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(480, 310);
            Controls.Add(lblTieuDe);
            Controls.Add(lblHK1);
            Controls.Add(txtHK1);
            Controls.Add(lblHK2);
            Controls.Add(txtHK2);
            Controls.Add(lblDTB);
            Controls.Add(txtDTB);
            Controls.Add(lblXepLoai);
            Controls.Add(txtXepLoai);
            Controls.Add(btnDongY);
            Controls.Add(btnLamLai);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xếp loại học tập";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnDongY_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtHK1.Text.Trim(), out double hk1) || hk1 < 0 || hk1 > 10)
            {
                MessageBox.Show("Vui lòng nhập điểm HKI hợp lệ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHK1.Focus();
                txtHK1.SelectAll();
                return;
            }

            if (!double.TryParse(txtHK2.Text.Trim(), out double hk2) || hk2 < 0 || hk2 > 10)
            {
                MessageBox.Show("Vui lòng nhập điểm HKII hợp lệ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHK2.Focus();
                txtHK2.SelectAll();
                return;
            }

            double dtb = (hk1 + hk2 * 2.0) / 3.0;
            txtDTB.Text = dtb.ToString("F2");

            string xepLoai;
            if (dtb >= 8.0)
                xepLoai = "Giỏi";
            else if (dtb >= 6.5)
                xepLoai = "Khá";
            else if (dtb >= 5.0)
                xepLoai = "Trung bình";
            else
                xepLoai = "Yếu";

            txtXepLoai.Text = xepLoai;
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            txtHK1.Clear();
            txtHK2.Clear();
            txtDTB.Clear();
            txtXepLoai.Clear();
            txtHK1.Focus();
        }
    }
}
