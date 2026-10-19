using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai7 : Form
    {
        private Panel pnlHeader;
        private Label lblHeader;

        private GroupBox grpThongTinNhap;
        private Label lblMaNV;
        private ComboBox cboMaNV;
        private Label lblTenNV;
        private TextBox txtTenNV;
        private Label lblLuongCB;
        private TextBox txtLuongCB;
        private Label lblSoNgayCong;
        private TextBox txtSoNgayCong;
        private Label lblHeSoPhuCap;
        private TextBox txtHeSoPhuCap;

        private GroupBox grpKetQua;
        private Label lblPhuCapCV;
        private TextBox txtPhuCapCV;
        private Label lblThuongNgay;
        private TextBox txtThuongNgay;
        private Label lblLuongThoiGian;
        private TextBox txtLuongThoiGian;
        private Label lblTongCong;
        private TextBox txtTongCong;

        private Button btnTinhLuong;
        private Button btnLamLai;
        private Button btnThoat;

        public bai7()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblHeader = new Label();
            grpThongTinNhap = new GroupBox();
            lblMaNV = new Label();
            cboMaNV = new ComboBox();
            lblTenNV = new Label();
            txtTenNV = new TextBox();
            lblLuongCB = new Label();
            txtLuongCB = new TextBox();
            lblSoNgayCong = new Label();
            txtSoNgayCong = new TextBox();
            lblHeSoPhuCap = new Label();
            txtHeSoPhuCap = new TextBox();
            grpKetQua = new GroupBox();
            lblPhuCapCV = new Label();
            txtPhuCapCV = new TextBox();
            lblThuongNgay = new Label();
            txtThuongNgay = new TextBox();
            lblLuongThoiGian = new Label();
            txtLuongThoiGian = new TextBox();
            lblTongCong = new Label();
            txtTongCong = new TextBox();
            btnTinhLuong = new Button();
            btnLamLai = new Button();
            btnThoat = new Button();
            pnlHeader.SuspendLayout();
            grpThongTinNhap.SuspendLayout();
            grpKetQua.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(13, 71, 161);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(680, 50);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(680, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "TINH LUONG NHAN VIEN";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongTinNhap
            // 
            grpThongTinNhap.Controls.Add(lblMaNV);
            grpThongTinNhap.Controls.Add(cboMaNV);
            grpThongTinNhap.Controls.Add(lblTenNV);
            grpThongTinNhap.Controls.Add(txtTenNV);
            grpThongTinNhap.Controls.Add(lblLuongCB);
            grpThongTinNhap.Controls.Add(txtLuongCB);
            grpThongTinNhap.Controls.Add(lblSoNgayCong);
            grpThongTinNhap.Controls.Add(txtSoNgayCong);
            grpThongTinNhap.Controls.Add(lblHeSoPhuCap);
            grpThongTinNhap.Controls.Add(txtHeSoPhuCap);
            grpThongTinNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpThongTinNhap.ForeColor = Color.FromArgb(13, 71, 161);
            grpThongTinNhap.Location = new Point(25, 65);
            grpThongTinNhap.Name = "grpThongTinNhap";
            grpThongTinNhap.Size = new Size(300, 290);
            grpThongTinNhap.TabIndex = 1;
            grpThongTinNhap.TabStop = false;
            grpThongTinNhap.Text = "THONG TIN NHAP";
            // 
            // lblMaNV
            // 
            lblMaNV.Font = new Font("Segoe UI", 9F);
            lblMaNV.ForeColor = Color.Black;
            lblMaNV.Location = new Point(15, 25);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(130, 20);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Ma nhan vien:";
            // 
            // cboMaNV
            // 
            cboMaNV.Font = new Font("Segoe UI", 9.5F);
            cboMaNV.ForeColor = Color.Black;
            cboMaNV.Items.AddRange(new object[] { "A001", "B002", "C003" });
            cboMaNV.Location = new Point(15, 25);
            cboMaNV.Name = "cboMaNV";
            cboMaNV.Size = new Size(265, 29);
            cboMaNV.TabIndex = 1;
            cboMaNV.SelectedIndexChanged += CboMaNV_SelectedIndexChanged;
            // 
            // lblTenNV
            // 
            lblTenNV.Font = new Font("Segoe UI", 9F);
            lblTenNV.ForeColor = Color.Black;
            lblTenNV.Location = new Point(15, 25);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(130, 20);
            lblTenNV.TabIndex = 2;
            lblTenNV.Text = "Ten nhan vien:";
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Segoe UI", 9.5F);
            txtTenNV.ForeColor = Color.Black;
            txtTenNV.Location = new Point(15, 25);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(265, 29);
            txtTenNV.TabIndex = 3;
            txtTenNV.Text = "Giang Thanh Tron";
            // 
            // lblLuongCB
            // 
            lblLuongCB.Font = new Font("Segoe UI", 9F);
            lblLuongCB.ForeColor = Color.Black;
            lblLuongCB.Location = new Point(15, 25);
            lblLuongCB.Name = "lblLuongCB";
            lblLuongCB.Size = new Size(130, 20);
            lblLuongCB.TabIndex = 4;
            lblLuongCB.Text = "Luong co ban:";
            // 
            // txtLuongCB
            // 
            txtLuongCB.Font = new Font("Segoe UI", 9.5F);
            txtLuongCB.ForeColor = Color.Black;
            txtLuongCB.Location = new Point(15, 25);
            txtLuongCB.Name = "txtLuongCB";
            txtLuongCB.Size = new Size(265, 29);
            txtLuongCB.TabIndex = 5;
            txtLuongCB.Text = "500,000";
            // 
            // lblSoNgayCong
            // 
            lblSoNgayCong.Font = new Font("Segoe UI", 9F);
            lblSoNgayCong.ForeColor = Color.Black;
            lblSoNgayCong.Location = new Point(15, 25);
            lblSoNgayCong.Name = "lblSoNgayCong";
            lblSoNgayCong.Size = new Size(130, 20);
            lblSoNgayCong.TabIndex = 6;
            lblSoNgayCong.Text = "So ngay cong:";
            // 
            // txtSoNgayCong
            // 
            txtSoNgayCong.Font = new Font("Segoe UI", 9.5F);
            txtSoNgayCong.ForeColor = Color.Black;
            txtSoNgayCong.Location = new Point(15, 25);
            txtSoNgayCong.Name = "txtSoNgayCong";
            txtSoNgayCong.Size = new Size(265, 29);
            txtSoNgayCong.TabIndex = 7;
            txtSoNgayCong.Text = "25";
            // 
            // lblHeSoPhuCap
            // 
            lblHeSoPhuCap.Font = new Font("Segoe UI", 9F);
            lblHeSoPhuCap.ForeColor = Color.Black;
            lblHeSoPhuCap.Location = new Point(15, 25);
            lblHeSoPhuCap.Name = "lblHeSoPhuCap";
            lblHeSoPhuCap.Size = new Size(130, 20);
            lblHeSoPhuCap.TabIndex = 8;
            lblHeSoPhuCap.Text = "He so phu cap:";
            // 
            // txtHeSoPhuCap
            // 
            txtHeSoPhuCap.Font = new Font("Segoe UI", 9.5F);
            txtHeSoPhuCap.ForeColor = Color.Black;
            txtHeSoPhuCap.Location = new Point(15, 25);
            txtHeSoPhuCap.Name = "txtHeSoPhuCap";
            txtHeSoPhuCap.Size = new Size(265, 29);
            txtHeSoPhuCap.TabIndex = 9;
            txtHeSoPhuCap.Text = "1.5";
            // 
            // grpKetQua
            // 
            grpKetQua.Controls.Add(lblPhuCapCV);
            grpKetQua.Controls.Add(txtPhuCapCV);
            grpKetQua.Controls.Add(lblThuongNgay);
            grpKetQua.Controls.Add(txtThuongNgay);
            grpKetQua.Controls.Add(lblLuongThoiGian);
            grpKetQua.Controls.Add(txtLuongThoiGian);
            grpKetQua.Controls.Add(lblTongCong);
            grpKetQua.Controls.Add(txtTongCong);
            grpKetQua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpKetQua.ForeColor = Color.FromArgb(46, 125, 50);
            grpKetQua.Location = new Point(345, 65);
            grpKetQua.Name = "grpKetQua";
            grpKetQua.Size = new Size(305, 290);
            grpKetQua.TabIndex = 2;
            grpKetQua.TabStop = false;
            grpKetQua.Text = "KET QUA TINH TOAN";
            // 
            // lblPhuCapCV
            // 
            lblPhuCapCV.Font = new Font("Segoe UI", 9F);
            lblPhuCapCV.ForeColor = Color.Black;
            lblPhuCapCV.Location = new Point(15, 25);
            lblPhuCapCV.Name = "lblPhuCapCV";
            lblPhuCapCV.Size = new Size(140, 20);
            lblPhuCapCV.TabIndex = 0;
            lblPhuCapCV.Text = "Phu cap chuc vu:";
            // 
            // txtPhuCapCV
            // 
            txtPhuCapCV.BackColor = Color.FromArgb(235, 245, 235);
            txtPhuCapCV.Font = new Font("Segoe UI", 9.5F);
            txtPhuCapCV.ForeColor = Color.Black;
            txtPhuCapCV.Location = new Point(15, 25);
            txtPhuCapCV.Name = "txtPhuCapCV";
            txtPhuCapCV.ReadOnly = true;
            txtPhuCapCV.Size = new Size(270, 29);
            txtPhuCapCV.TabIndex = 1;
            // 
            // lblThuongNgay
            // 
            lblThuongNgay.Font = new Font("Segoe UI", 9F);
            lblThuongNgay.ForeColor = Color.Black;
            lblThuongNgay.Location = new Point(15, 25);
            lblThuongNgay.Name = "lblThuongNgay";
            lblThuongNgay.Size = new Size(140, 20);
            lblThuongNgay.TabIndex = 2;
            lblThuongNgay.Text = "Thuong ngay:";
            // 
            // txtThuongNgay
            // 
            txtThuongNgay.BackColor = Color.FromArgb(235, 245, 235);
            txtThuongNgay.Font = new Font("Segoe UI", 9.5F);
            txtThuongNgay.ForeColor = Color.Black;
            txtThuongNgay.Location = new Point(15, 25);
            txtThuongNgay.Name = "txtThuongNgay";
            txtThuongNgay.ReadOnly = true;
            txtThuongNgay.Size = new Size(270, 29);
            txtThuongNgay.TabIndex = 3;
            // 
            // lblLuongThoiGian
            // 
            lblLuongThoiGian.Font = new Font("Segoe UI", 9F);
            lblLuongThoiGian.ForeColor = Color.Black;
            lblLuongThoiGian.Location = new Point(15, 25);
            lblLuongThoiGian.Name = "lblLuongThoiGian";
            lblLuongThoiGian.Size = new Size(140, 20);
            lblLuongThoiGian.TabIndex = 4;
            lblLuongThoiGian.Text = "Luong thoi gian:";
            // 
            // txtLuongThoiGian
            // 
            txtLuongThoiGian.BackColor = Color.FromArgb(235, 245, 235);
            txtLuongThoiGian.Font = new Font("Segoe UI", 9.5F);
            txtLuongThoiGian.ForeColor = Color.Black;
            txtLuongThoiGian.Location = new Point(15, 25);
            txtLuongThoiGian.Name = "txtLuongThoiGian";
            txtLuongThoiGian.ReadOnly = true;
            txtLuongThoiGian.Size = new Size(270, 29);
            txtLuongThoiGian.TabIndex = 5;
            // 
            // lblTongCong
            // 
            lblTongCong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongCong.ForeColor = Color.FromArgb(180, 40, 40);
            lblTongCong.Location = new Point(15, 25);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(140, 20);
            lblTongCong.TabIndex = 6;
            lblTongCong.Text = "TONG CONG:";
            // 
            // txtTongCong
            // 
            txtTongCong.BackColor = Color.FromArgb(255, 240, 240);
            txtTongCong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTongCong.ForeColor = Color.FromArgb(180, 40, 40);
            txtTongCong.Location = new Point(15, 25);
            txtTongCong.Name = "txtTongCong";
            txtTongCong.ReadOnly = true;
            txtTongCong.Size = new Size(270, 30);
            txtTongCong.TabIndex = 7;
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.BackColor = Color.FromArgb(13, 71, 161);
            btnTinhLuong.FlatStyle = FlatStyle.Flat;
            btnTinhLuong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTinhLuong.ForeColor = Color.White;
            btnTinhLuong.Location = new Point(70, 370);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(140, 40);
            btnTinhLuong.TabIndex = 3;
            btnTinhLuong.Text = "TINH LUONG";
            btnTinhLuong.UseVisualStyleBackColor = false;
            btnTinhLuong.Click += BtnTinhLuong_Click;
            // 
            // btnLamLai
            // 
            btnLamLai.BackColor = Color.FromArgb(239, 108, 0);
            btnLamLai.FlatStyle = FlatStyle.Flat;
            btnLamLai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLamLai.ForeColor = Color.White;
            btnLamLai.Location = new Point(270, 370);
            btnLamLai.Name = "btnLamLai";
            btnLamLai.Size = new Size(140, 40);
            btnLamLai.TabIndex = 4;
            btnLamLai.Text = "LAM LAI";
            btnLamLai.UseVisualStyleBackColor = false;
            btnLamLai.Click += BtnLamLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(198, 40, 40);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(470, 370);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(140, 40);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOAT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += BtnThoat_Click;
            // 
            // bai7
            // 
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(680, 430);
            Controls.Add(pnlHeader);
            Controls.Add(grpThongTinNhap);
            Controls.Add(grpKetQua);
            Controls.Add(btnTinhLuong);
            Controls.Add(btnLamLai);
            Controls.Add(btnThoat);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính lương nhân viên";
            pnlHeader.ResumeLayout(false);
            grpThongTinNhap.ResumeLayout(false);
            grpThongTinNhap.PerformLayout();
            grpKetQua.ResumeLayout(false);
            grpKetQua.PerformLayout();
            ResumeLayout(false);
        }

        private void CboMaNV_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string ma = cboMaNV.SelectedItem?.ToString() ?? "";
            if (ma == "A001")
            {
                txtTenNV.Text = "Giang Thanh Tron";
                txtLuongCB.Text = "500,000";
            }
            else if (ma == "B002")
            {
                txtTenNV.Text = "Nguyen Van Binh";
                txtLuongCB.Text = "400,000";
            }
            else if (ma == "C003")
            {
                txtTenNV.Text = "Tran Thi Cam";
                txtLuongCB.Text = "350,000";
            }
        }

        private void BtnTinhLuong_Click(object? sender, EventArgs e)
        {
            string rawLuong = txtLuongCB.Text.Trim().Replace(",", "").Replace(".", "").Replace(" ", "");
            if (!double.TryParse(rawLuong, out double luongCB) || luongCB < 0)
            {
                MessageBox.Show("Lương cơ bản không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongCB.Focus();
                return;
            }

            if (!int.TryParse(txtSoNgayCong.Text.Trim(), out int soNgayCong) || soNgayCong < 0)
            {
                MessageBox.Show("Số ngày công không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNgayCong.Focus();
                return;
            }

            string maNV = cboMaNV.Text.Trim().ToUpper();
            char kyTuDau = maNV.Length > 0 ? maNV[0] : ' ';
            double phuCapCV = 0;
            switch (kyTuDau)
            {
                case 'A': phuCapCV = 500000; break;
                case 'B': phuCapCV = 300000; break;
                case 'C': phuCapCV = 200000; break;
                default: phuCapCV = 0; break;
            }

            double thuongNgay = soNgayCong * 50000;

            // Lương thời gian = Số ngày × Lương cơ bản. Nếu số ngày > 22 → số ngày dư được tính gấp đôi
            double luongThoiGian;
            if (soNgayCong > 22)
            {
                int ngayDu = soNgayCong - 22;
                luongThoiGian = (22 + ngayDu * 2.0) * luongCB;
            }
            else
            {
                luongThoiGian = soNgayCong * luongCB;
            }

            double tongCong = luongThoiGian + phuCapCV + thuongNgay;

            txtPhuCapCV.Text = phuCapCV.ToString("#,##0");
            txtThuongNgay.Text = thuongNgay.ToString("#,##0");
            txtLuongThoiGian.Text = luongThoiGian.ToString("#,##0");
            txtTongCong.Text = tongCong.ToString("#,##0");
        }

        private void BtnLamLai_Click(object? sender, EventArgs e)
        {
            cboMaNV.SelectedIndex = 0;
            txtSoNgayCong.Text = "25";
            txtHeSoPhuCap.Text = "1.5";
            txtPhuCapCV.Clear();
            txtThuongNgay.Clear();
            txtLuongThoiGian.Clear();
            txtTongCong.Clear();
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
