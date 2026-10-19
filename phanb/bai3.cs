using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai3 : Form
    {
        private Label lblTieuDe;
        private GroupBox grpHoaDon;
        private Label lblTenKhach;
        private Label lblDiaChi;
        private RadioButton radCaNhan;
        private RadioButton radDonViKhac;
        private Label lblSoLuongVe;
        private Label lblDonGia;
        private Label lblThanhTien;
        private Label lblVAT;
        private Label lblGiamGia;
        private Label lblTongCong;

        private TextBox txtTenKhach;
        private TextBox txtDiaChi;
        private TextBox txtSoLuongVe;
        private TextBox txtDonGia;
        private TextBox txtThanhTien;
        private TextBox txtVAT;
        private TextBox txtGiamGia;
        private TextBox txtTongCong;
        private GroupBox grpChucNang;
        private Button btnTinh;
        private Button btnTiep;
        private Button btnThoat;

        public bai3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            grpHoaDon = new GroupBox();
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            radCaNhan = new RadioButton();
            radDonViKhac = new RadioButton();
            lblSoLuongVe = new Label();
            txtSoLuongVe = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblThanhTien = new Label();
            txtThanhTien = new TextBox();
            lblVAT = new Label();
            txtVAT = new TextBox();
            lblGiamGia = new Label();
            txtGiamGia = new TextBox();
            lblTongCong = new Label();
            txtTongCong = new TextBox();
            grpChucNang = new GroupBox();
            btnTinh = new Button();
            btnTiep = new Button();
            btnThoat = new Button();
            grpHoaDon.SuspendLayout();
            grpChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Black;
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(640, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "CHƯƠNG TRÌNH BÁN VÉ MÁY BAY";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpHoaDon
            // 
            grpHoaDon.Controls.Add(lblTenKhach);
            grpHoaDon.Controls.Add(txtTenKhach);
            grpHoaDon.Controls.Add(lblDiaChi);
            grpHoaDon.Controls.Add(txtDiaChi);
            grpHoaDon.Controls.Add(radCaNhan);
            grpHoaDon.Controls.Add(radDonViKhac);
            grpHoaDon.Controls.Add(lblSoLuongVe);
            grpHoaDon.Controls.Add(txtSoLuongVe);
            grpHoaDon.Controls.Add(lblDonGia);
            grpHoaDon.Controls.Add(txtDonGia);
            grpHoaDon.Controls.Add(lblThanhTien);
            grpHoaDon.Controls.Add(txtThanhTien);
            grpHoaDon.Controls.Add(lblVAT);
            grpHoaDon.Controls.Add(txtVAT);
            grpHoaDon.Controls.Add(lblGiamGia);
            grpHoaDon.Controls.Add(txtGiamGia);
            grpHoaDon.Controls.Add(lblTongCong);
            grpHoaDon.Controls.Add(txtTongCong);
            grpHoaDon.Location = new Point(20, 50);
            grpHoaDon.Name = "grpHoaDon";
            grpHoaDon.Size = new Size(440, 400);
            grpHoaDon.TabIndex = 1;
            grpHoaDon.TabStop = false;
            grpHoaDon.Text = "Hóa đơn";
            // 
            // lblTenKhach
            // 
            lblTenKhach.Location = new Point(15, 30);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(115, 25);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách hàng";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(135, 27);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(285, 29);
            txtTenKhach.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(15, 70);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(115, 25);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(135, 67);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(285, 29);
            txtDiaChi.TabIndex = 3;
            // 
            // radCaNhan
            // 
            radCaNhan.Checked = true;
            radCaNhan.Location = new Point(135, 105);
            radCaNhan.Name = "radCaNhan";
            radCaNhan.Size = new Size(100, 25);
            radCaNhan.TabIndex = 4;
            radCaNhan.TabStop = true;
            radCaNhan.Text = "Cá nhân";
            // 
            // radDonViKhac
            // 
            radDonViKhac.Location = new Point(265, 105);
            radDonViKhac.Name = "radDonViKhac";
            radDonViKhac.Size = new Size(120, 25);
            radDonViKhac.TabIndex = 5;
            radDonViKhac.Text = "Đơn vị khác";
            // 
            // lblSoLuongVe
            // 
            lblSoLuongVe.Location = new Point(15, 145);
            lblSoLuongVe.Name = "lblSoLuongVe";
            lblSoLuongVe.Size = new Size(115, 25);
            lblSoLuongVe.TabIndex = 6;
            lblSoLuongVe.Text = "Số lượng vé";
            // 
            // txtSoLuongVe
            // 
            txtSoLuongVe.Location = new Point(135, 142);
            txtSoLuongVe.Name = "txtSoLuongVe";
            txtSoLuongVe.Size = new Size(285, 29);
            txtSoLuongVe.TabIndex = 7;
            // 
            // lblDonGia
            // 
            lblDonGia.Location = new Point(15, 185);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(115, 25);
            lblDonGia.TabIndex = 8;
            lblDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(135, 182);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(285, 29);
            txtDonGia.TabIndex = 9;
            // 
            // lblThanhTien
            // 
            lblThanhTien.Location = new Point(15, 225);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(115, 25);
            lblThanhTien.TabIndex = 10;
            lblThanhTien.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = Color.WhiteSmoke;
            txtThanhTien.Location = new Point(135, 222);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(285, 29);
            txtThanhTien.TabIndex = 11;
            // 
            // lblVAT
            // 
            lblVAT.Location = new Point(15, 265);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(115, 25);
            lblVAT.TabIndex = 12;
            lblVAT.Text = "Thuế VAT";
            // 
            // txtVAT
            // 
            txtVAT.BackColor = Color.WhiteSmoke;
            txtVAT.Location = new Point(135, 262);
            txtVAT.Name = "txtVAT";
            txtVAT.ReadOnly = true;
            txtVAT.Size = new Size(285, 29);
            txtVAT.TabIndex = 13;
            // 
            // lblGiamGia
            // 
            lblGiamGia.Location = new Point(15, 305);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(115, 25);
            lblGiamGia.TabIndex = 14;
            lblGiamGia.Text = "Giảm giá";
            // 
            // txtGiamGia
            // 
            txtGiamGia.BackColor = Color.WhiteSmoke;
            txtGiamGia.Location = new Point(135, 302);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.ReadOnly = true;
            txtGiamGia.Size = new Size(285, 29);
            txtGiamGia.TabIndex = 15;
            // 
            // lblTongCong
            // 
            lblTongCong.Location = new Point(15, 345);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(115, 25);
            lblTongCong.TabIndex = 16;
            lblTongCong.Text = "Tổng cộng";
            // 
            // txtTongCong
            // 
            txtTongCong.BackColor = Color.FromArgb(220, 235, 252);
            txtTongCong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtTongCong.ForeColor = Color.DarkBlue;
            txtTongCong.Location = new Point(135, 342);
            txtTongCong.Name = "txtTongCong";
            txtTongCong.ReadOnly = true;
            txtTongCong.Size = new Size(285, 29);
            txtTongCong.TabIndex = 17;
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnTinh);
            grpChucNang.Controls.Add(btnTiep);
            grpChucNang.Controls.Add(btnThoat);
            grpChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpChucNang.Location = new Point(480, 220);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(180, 230);
            grpChucNang.TabIndex = 3;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng";
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.FromArgb(128, 255, 128);
            btnTinh.FlatStyle = FlatStyle.Flat;
            btnTinh.ForeColor = Color.White;
            btnTinh.Location = new Point(35, 40);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(110, 38);
            btnTinh.TabIndex = 0;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += BtnTinh_Click;
            // 
            // btnTiep
            // 
            btnTiep.BackColor = Color.FromArgb(108, 117, 125);
            btnTiep.FlatStyle = FlatStyle.Flat;
            btnTiep.ForeColor = Color.White;
            btnTiep.Location = new Point(35, 100);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(110, 38);
            btnTiep.TabIndex = 1;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = false;
            btnTiep.Click += BtnTiep_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(205, 92, 92);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(35, 160);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 38);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += BtnThoat_Click;
            // 
            // bai3
            // 
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(680, 470);
            Controls.Add(lblTieuDe);
            Controls.Add(grpHoaDon);
            Controls.Add(grpChucNang);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chương trình bán vé máy bay";
            grpHoaDon.ResumeLayout(false);
            grpHoaDon.PerformLayout();
            grpChucNang.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void PicMayBay_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var brush = new LinearGradientBrush(picMayBay.ClientRectangle, Color.FromArgb(135, 206, 250), Color.FromArgb(70, 130, 180), LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, picMayBay.ClientRectangle);
            }

            using (var planeBrush = new SolidBrush(Color.WhiteSmoke))
            using (var wingBrush = new SolidBrush(Color.FromArgb(220, 230, 240)))
            using (var borderPen = new Pen(Color.FromArgb(30, 60, 100), 2))
            {
                Point[] body = new Point[]
                {
                    new Point(30, 80),
                    new Point(120, 50),
                    new Point(155, 45),
                    new Point(145, 60),
                    new Point(60, 85),
                    new Point(30, 95)
                };
                g.FillPolygon(planeBrush, body);
                g.DrawPolygon(borderPen, body);

                Point[] wing = new Point[]
                {
                    new Point(70, 70),
                    new Point(100, 25),
                    new Point(120, 30),
                    new Point(95, 65)
                };
                g.FillPolygon(wingBrush, wing);
                g.DrawPolygon(borderPen, wing);

                Point[] tail = new Point[]
                {
                    new Point(35, 80),
                    new Point(20, 55),
                    new Point(35, 55),
                    new Point(50, 75)
                };
                g.FillPolygon(wingBrush, tail);
                g.DrawPolygon(borderPen, tail);
            }
        }

        private void BtnTinh_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtSoLuongVe.Text.Trim(), out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng vé phải là số nguyên > 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongVe.Focus();
                return;
            }

            if (!double.TryParse(txtDonGia.Text.Trim(), out double donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số > 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            double thanhTien = sl * donGia;
            double vat = 0.10 * thanhTien;
            double tiLeGiam = radCaNhan.Checked ? 0.03 : 0.05;
            double giamGia = tiLeGiam * thanhTien;
            double tongTien = (thanhTien + vat) - giamGia;

            txtThanhTien.Text = thanhTien.ToString("#,##0") + " đ";
            txtVAT.Text = vat.ToString("#,##0") + " đ";
            txtGiamGia.Text = giamGia.ToString("#,##0") + " đ";
            txtTongCong.Text = tongTien.ToString("#,##0") + " đ";
        }

        private void BtnTiep_Click(object? sender, EventArgs e)
        {
            txtTenKhach.Clear();
            txtDiaChi.Clear();
            radCaNhan.Checked = true;
            txtSoLuongVe.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtVAT.Clear();
            txtGiamGia.Clear();
            txtTongCong.Clear();
            txtTenKhach.Focus();
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
