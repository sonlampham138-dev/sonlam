using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai2 : Form
    {
        private Label lblTieuDe;
        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblGioiTinh;
        private Label lblDTB;
        private Label lblXepLoai;

        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private RadioButton radNam;
        private RadioButton radNu;
        private GroupBox grpGioiTinh;
        private TextBox txtDTB;
        private TextBox txtXepLoai;

        private GroupBox grpMonHoc;
        private Label lblCSharp;
        private Label lblTruyenThong;
        private Label lblMaNguonMo;
        private Label lblQuanTriMang;
        private TextBox txtCSharp;
        private TextBox txtTruyenThong;
        private TextBox txtMaNguonMo;
        private TextBox txtQuanTriMang;

        private Button btnTinhDiem;
        private Button btnTiepTuc;
        private Button btnThoat;

        public bai2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblMaSV = new Label();
            lblHoTen = new Label();
            lblGioiTinh = new Label();
            lblDTB = new Label();
            lblXepLoai = new Label();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            grpGioiTinh = new GroupBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            txtDTB = new TextBox();
            txtXepLoai = new TextBox();
            grpMonHoc = new GroupBox();
            lblCSharp = new Label();
            txtCSharp = new TextBox();
            lblTruyenThong = new Label();
            txtTruyenThong = new TextBox();
            lblMaNguonMo = new Label();
            txtMaNguonMo = new TextBox();
            lblQuanTriMang = new Label();
            txtQuanTriMang = new TextBox();
            btnTinhDiem = new Button();
            btnTiepTuc = new Button();
            btnThoat = new Button();
            grpGioiTinh.SuspendLayout();
            grpMonHoc.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(20, 60, 20);
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(640, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "XẾP LOẠI HỌC LỰC";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaSV
            // 
            lblMaSV.Location = new Point(30, 65);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(110, 25);
            lblMaSV.TabIndex = 1;
            lblMaSV.Text = "Mã sinh viên";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(30, 105);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(110, 25);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "Họ và tên";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(30, 145);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(80, 25);
            lblGioiTinh.TabIndex = 5;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblDTB
            // 
            lblDTB.Location = new Point(30, 195);
            lblDTB.Name = "lblDTB";
            lblDTB.Size = new Size(110, 25);
            lblDTB.TabIndex = 7;
            lblDTB.Text = "Điểm trung bình";
            // 
            // lblXepLoai
            // 
            lblXepLoai.Location = new Point(30, 235);
            lblXepLoai.Name = "lblXepLoai";
            lblXepLoai.Size = new Size(110, 25);
            lblXepLoai.TabIndex = 9;
            lblXepLoai.Text = "Xếp loại";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(145, 62);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(165, 29);
            txtMaSV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(145, 102);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(165, 29);
            txtHoTen.TabIndex = 4;
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(radNam);
            grpGioiTinh.Controls.Add(radNu);
            grpGioiTinh.Location = new Point(145, 135);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(165, 45);
            grpGioiTinh.TabIndex = 6;
            grpGioiTinh.TabStop = false;
            // 
            // radNam
            // 
            radNam.Checked = true;
            radNam.Location = new Point(10, 15);
            radNam.Name = "radNam";
            radNam.Size = new Size(65, 25);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            // 
            // radNu
            // 
            radNu.Location = new Point(85, 15);
            radNu.Name = "radNu";
            radNu.Size = new Size(65, 25);
            radNu.TabIndex = 1;
            radNu.Text = "Nữ";
            // 
            // txtDTB
            // 
            txtDTB.BackColor = Color.WhiteSmoke;
            txtDTB.Location = new Point(145, 192);
            txtDTB.Name = "txtDTB";
            txtDTB.ReadOnly = true;
            txtDTB.Size = new Size(165, 29);
            txtDTB.TabIndex = 8;
            // 
            // txtXepLoai
            // 
            txtXepLoai.BackColor = Color.WhiteSmoke;
            txtXepLoai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtXepLoai.Location = new Point(145, 232);
            txtXepLoai.Name = "txtXepLoai";
            txtXepLoai.ReadOnly = true;
            txtXepLoai.Size = new Size(165, 29);
            txtXepLoai.TabIndex = 10;
            // 
            // grpMonHoc
            // 
            grpMonHoc.Controls.Add(lblCSharp);
            grpMonHoc.Controls.Add(txtCSharp);
            grpMonHoc.Controls.Add(lblTruyenThong);
            grpMonHoc.Controls.Add(txtTruyenThong);
            grpMonHoc.Controls.Add(lblMaNguonMo);
            grpMonHoc.Controls.Add(txtMaNguonMo);
            grpMonHoc.Controls.Add(lblQuanTriMang);
            grpMonHoc.Controls.Add(txtQuanTriMang);
            grpMonHoc.Location = new Point(335, 55);
            grpMonHoc.Name = "grpMonHoc";
            grpMonHoc.Size = new Size(315, 220);
            grpMonHoc.TabIndex = 11;
            grpMonHoc.TabStop = false;
            grpMonHoc.Text = "Danh sách các môn học";
            // 
            // lblCSharp
            // 
            lblCSharp.Location = new Point(15, 35);
            lblCSharp.Name = "lblCSharp";
            lblCSharp.Size = new Size(160, 25);
            lblCSharp.TabIndex = 0;
            lblCSharp.Text = "Lập trình C#";
            // 
            // txtCSharp
            // 
            txtCSharp.Location = new Point(185, 32);
            txtCSharp.Name = "txtCSharp";
            txtCSharp.Size = new Size(115, 29);
            txtCSharp.TabIndex = 1;
            // 
            // lblTruyenThong
            // 
            lblTruyenThong.Location = new Point(15, 75);
            lblTruyenThong.Name = "lblTruyenThong";
            lblTruyenThong.Size = new Size(160, 25);
            lblTruyenThong.TabIndex = 2;
            lblTruyenThong.Text = "Lập trình truyền thông";
            // 
            // txtTruyenThong
            // 
            txtTruyenThong.Location = new Point(185, 72);
            txtTruyenThong.Name = "txtTruyenThong";
            txtTruyenThong.Size = new Size(115, 29);
            txtTruyenThong.TabIndex = 3;
            // 
            // lblMaNguonMo
            // 
            lblMaNguonMo.Location = new Point(15, 115);
            lblMaNguonMo.Name = "lblMaNguonMo";
            lblMaNguonMo.Size = new Size(160, 25);
            lblMaNguonMo.TabIndex = 4;
            lblMaNguonMo.Text = "Mã nguồn mở";
            // 
            // txtMaNguonMo
            // 
            txtMaNguonMo.Location = new Point(185, 112);
            txtMaNguonMo.Name = "txtMaNguonMo";
            txtMaNguonMo.Size = new Size(115, 29);
            txtMaNguonMo.TabIndex = 5;
            // 
            // lblQuanTriMang
            // 
            lblQuanTriMang.Location = new Point(15, 155);
            lblQuanTriMang.Name = "lblQuanTriMang";
            lblQuanTriMang.Size = new Size(160, 25);
            lblQuanTriMang.TabIndex = 6;
            lblQuanTriMang.Text = "Quản trị mạng";
            // 
            // txtQuanTriMang
            // 
            txtQuanTriMang.Location = new Point(185, 152);
            txtQuanTriMang.Name = "txtQuanTriMang";
            txtQuanTriMang.Size = new Size(115, 29);
            txtQuanTriMang.TabIndex = 7;
            // 
            // btnTinhDiem
            // 
            btnTinhDiem.BackColor = Color.SpringGreen;
            btnTinhDiem.FlatStyle = FlatStyle.Flat;
            btnTinhDiem.ForeColor = Color.White;
            btnTinhDiem.Location = new Point(155, 310);
            btnTinhDiem.Name = "btnTinhDiem";
            btnTinhDiem.Size = new Size(110, 38);
            btnTinhDiem.TabIndex = 12;
            btnTinhDiem.Text = "Tính điểm";
            btnTinhDiem.UseVisualStyleBackColor = false;
            btnTinhDiem.Click += BtnTinhDiem_Click;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.BackColor = Color.FromArgb(70, 130, 180);
            btnTiepTuc.FlatStyle = FlatStyle.Flat;
            btnTiepTuc.ForeColor = Color.White;
            btnTiepTuc.Location = new Point(290, 310);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(110, 38);
            btnTiepTuc.TabIndex = 13;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = false;
            btnTiepTuc.Click += BtnTiepTuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(205, 92, 92);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(425, 310);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 38);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += BtnThoat_Click;
            // 
            // bai2
            // 
            BackColor = Color.FromArgb(240, 248, 240);
            ClientSize = new Size(680, 390);
            Controls.Add(lblTieuDe);
            Controls.Add(lblMaSV);
            Controls.Add(txtMaSV);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblGioiTinh);
            Controls.Add(grpGioiTinh);
            Controls.Add(lblDTB);
            Controls.Add(txtDTB);
            Controls.Add(lblXepLoai);
            Controls.Add(txtXepLoai);
            Controls.Add(grpMonHoc);
            Controls.Add(btnTinhDiem);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnThoat);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xếp loại học lực (nhiều môn)";
            grpGioiTinh.ResumeLayout(false);
            grpMonHoc.ResumeLayout(false);
            grpMonHoc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnTinhDiem_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtCSharp.Text.Trim(), out double csharp) || csharp < 0 || csharp > 10)
            {
                MessageBox.Show("Điểm Lập trình C# phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCSharp.Focus();
                return;
            }

            if (!double.TryParse(txtTruyenThong.Text.Trim(), out double truyenThong) || truyenThong < 0 || truyenThong > 10)
            {
                MessageBox.Show("Điểm Lập trình truyền thông phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTruyenThong.Focus();
                return;
            }

            if (!double.TryParse(txtMaNguonMo.Text.Trim(), out double maNguonMo) || maNguonMo < 0 || maNguonMo > 10)
            {
                MessageBox.Show("Điểm Mã nguồn mở phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNguonMo.Focus();
                return;
            }

            if (!double.TryParse(txtQuanTriMang.Text.Trim(), out double quanTriMang) || quanTriMang < 0 || quanTriMang > 10)
            {
                MessageBox.Show("Điểm Quản trị mạng phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuanTriMang.Focus();
                return;
            }

            double dtb = (csharp + truyenThong + maNguonMo + quanTriMang) / 4.0;
            txtDTB.Text = dtb.ToString("F2");

            string xepLoai;
            if (dtb >= 8.0)
                xepLoai = "Giỏi";
            else if (dtb >= 7.0)
                xepLoai = "Khá";
            else if (dtb >= 5.0)
                xepLoai = "Trung bình";
            else
                xepLoai = "Yếu";

            txtXepLoai.Text = xepLoai;
        }

        private void BtnTiepTuc_Click(object? sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            radNam.Checked = true;
            txtCSharp.Clear();
            txtTruyenThong.Clear();
            txtMaNguonMo.Clear();
            txtQuanTriMang.Clear();
            txtDTB.Clear();
            txtXepLoai.Clear();
            txtMaSV.Focus();
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
