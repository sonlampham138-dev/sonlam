using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai1 : Form
    {
        private Label lblTieuDe;
        private Label lblMaKhach;
        private Label lblTenKhach;
        private Label lblChiSoMoi;
        private Label lblChiSoCu;
        private Label lblSoKw;
        private Label lblThanhTien;
        private Label lblVAT;
        private Label lblTongCong;

        private ComboBox cboMaKhach;
        private TextBox txtTenKhach;
        private RadioButton radCaNhan;
        private RadioButton radCoQuan;
        private GroupBox grpLoaiKhach;
        private TextBox txtChiSoMoi;
        private TextBox txtChiSoCu;
        private TextBox txtSoKw;
        private TextBox txtThanhTien;
        private TextBox txtVAT;
        private TextBox txtTongCong;

        private Button btnThucHien;
        private Button btnTiepTuc;
        private Button btnThoat;

        public bai1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblMaKhach = new Label();
            lblTenKhach = new Label();
            lblChiSoMoi = new Label();
            lblChiSoCu = new Label();
            lblSoKw = new Label();
            lblThanhTien = new Label();
            lblVAT = new Label();
            lblTongCong = new Label();
            cboMaKhach = new ComboBox();
            txtTenKhach = new TextBox();
            grpLoaiKhach = new GroupBox();
            radCaNhan = new RadioButton();
            radCoQuan = new RadioButton();
            txtChiSoMoi = new TextBox();
            txtChiSoCu = new TextBox();
            txtSoKw = new TextBox();
            txtThanhTien = new TextBox();
            txtVAT = new TextBox();
            txtTongCong = new TextBox();
            btnThucHien = new Button();
            btnTiepTuc = new Button();
            btnThoat = new Button();
            grpLoaiKhach.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(180, 40, 40);
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(580, 35);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BẢNG TÍNH TIỀN ĐIỆN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Click += lblTieuDe_Click;
            // 
            // lblMaKhach
            // 
            lblMaKhach.Location = new Point(40, 65);
            lblMaKhach.Name = "lblMaKhach";
            lblMaKhach.Size = new Size(110, 25);
            lblMaKhach.TabIndex = 1;
            lblMaKhach.Text = "Mã khách";
            // 
            // lblTenKhach
            // 
            lblTenKhach.Location = new Point(310, 65);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(90, 25);
            lblTenKhach.TabIndex = 3;
            lblTenKhach.Text = "Tên khách";
            // 
            // lblChiSoMoi
            // 
            lblChiSoMoi.Location = new Point(40, 160);
            lblChiSoMoi.Name = "lblChiSoMoi";
            lblChiSoMoi.Size = new Size(110, 25);
            lblChiSoMoi.TabIndex = 6;
            lblChiSoMoi.Text = "Chỉ số mới";
            // 
            // lblChiSoCu
            // 
            lblChiSoCu.Location = new Point(40, 205);
            lblChiSoCu.Name = "lblChiSoCu";
            lblChiSoCu.Size = new Size(110, 25);
            lblChiSoCu.TabIndex = 10;
            lblChiSoCu.Text = "Chỉ số cũ";
            // 
            // lblSoKw
            // 
            lblSoKw.Location = new Point(40, 250);
            lblSoKw.Name = "lblSoKw";
            lblSoKw.Size = new Size(110, 25);
            lblSoKw.TabIndex = 14;
            lblSoKw.Text = "Số Kw tiêu thụ";
            // 
            // lblThanhTien
            // 
            lblThanhTien.Location = new Point(310, 160);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(90, 25);
            lblThanhTien.TabIndex = 8;
            lblThanhTien.Text = "Thành tiền";
            // 
            // lblVAT
            // 
            lblVAT.Location = new Point(310, 205);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(90, 25);
            lblVAT.TabIndex = 12;
            lblVAT.Text = "Thuế VAT";
            // 
            // lblTongCong
            // 
            lblTongCong.Location = new Point(310, 250);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(90, 25);
            lblTongCong.TabIndex = 16;
            lblTongCong.Text = "Tổng cộng";
            // 
            // cboMaKhach
            // 
            cboMaKhach.Items.AddRange(new object[] { "A01", "A02", "B01", "B02", "C01", "C02" });
            cboMaKhach.Location = new Point(155, 62);
            cboMaKhach.Name = "cboMaKhach";
            cboMaKhach.Size = new Size(130, 29);
            cboMaKhach.TabIndex = 2;
            cboMaKhach.SelectedIndexChanged += CboMaKhach_SelectedIndexChanged;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(405, 62);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(175, 29);
            txtTenKhach.TabIndex = 4;
            txtTenKhach.Text = "Nguyễn Văn A";
            // 
            // grpLoaiKhach
            // 
            grpLoaiKhach.Controls.Add(radCaNhan);
            grpLoaiKhach.Controls.Add(radCoQuan);
            grpLoaiKhach.Location = new Point(40, 95);
            grpLoaiKhach.Name = "grpLoaiKhach";
            grpLoaiKhach.Size = new Size(540, 50);
            grpLoaiKhach.TabIndex = 5;
            grpLoaiKhach.TabStop = false;
            grpLoaiKhach.Text = "Loại khách hàng";
            // 
            // radCaNhan
            // 
            radCaNhan.Checked = true;
            radCaNhan.Location = new Point(115, 18);
            radCaNhan.Name = "radCaNhan";
            radCaNhan.Size = new Size(120, 25);
            radCaNhan.TabIndex = 0;
            radCaNhan.TabStop = true;
            radCaNhan.Text = "Cá nhân";
            // 
            // radCoQuan
            // 
            radCoQuan.Location = new Point(365, 18);
            radCoQuan.Name = "radCoQuan";
            radCoQuan.Size = new Size(120, 25);
            radCoQuan.TabIndex = 1;
            radCoQuan.Text = "Cơ quan";
            // 
            // txtChiSoMoi
            // 
            txtChiSoMoi.Location = new Point(155, 157);
            txtChiSoMoi.Name = "txtChiSoMoi";
            txtChiSoMoi.Size = new Size(130, 29);
            txtChiSoMoi.TabIndex = 7;
            // 
            // txtChiSoCu
            // 
            txtChiSoCu.Location = new Point(155, 202);
            txtChiSoCu.Name = "txtChiSoCu";
            txtChiSoCu.Size = new Size(130, 29);
            txtChiSoCu.TabIndex = 11;
            // 
            // txtSoKw
            // 
            txtSoKw.BackColor = Color.WhiteSmoke;
            txtSoKw.Location = new Point(155, 247);
            txtSoKw.Name = "txtSoKw";
            txtSoKw.ReadOnly = true;
            txtSoKw.Size = new Size(130, 29);
            txtSoKw.TabIndex = 15;
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = Color.WhiteSmoke;
            txtThanhTien.Location = new Point(405, 157);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(175, 29);
            txtThanhTien.TabIndex = 9;
            // 
            // txtVAT
            // 
            txtVAT.BackColor = Color.WhiteSmoke;
            txtVAT.Location = new Point(405, 202);
            txtVAT.Name = "txtVAT";
            txtVAT.ReadOnly = true;
            txtVAT.Size = new Size(175, 29);
            txtVAT.TabIndex = 13;
            // 
            // txtTongCong
            // 
            txtTongCong.BackColor = Color.FromArgb(220, 240, 255);
            txtTongCong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtTongCong.ForeColor = Color.DarkRed;
            txtTongCong.Location = new Point(405, 247);
            txtTongCong.Name = "txtTongCong";
            txtTongCong.ReadOnly = true;
            txtTongCong.Size = new Size(175, 29);
            txtTongCong.TabIndex = 17;
            // 
            // btnThucHien
            // 
            btnThucHien.BackColor = Color.FromArgb(192, 255, 255);
            btnThucHien.FlatStyle = FlatStyle.Flat;
            btnThucHien.ForeColor = Color.Black;
            btnThucHien.Location = new Point(130, 320);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(110, 38);
            btnThucHien.TabIndex = 18;
            btnThucHien.Text = "Tính tiền";
            btnThucHien.UseVisualStyleBackColor = false;
            btnThucHien.Click += BtnThucHien_Click;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.BackColor = Color.FromArgb(70, 130, 180);
            btnTiepTuc.FlatStyle = FlatStyle.Flat;
            btnTiepTuc.ForeColor = Color.White;
            btnTiepTuc.Location = new Point(265, 320);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(110, 38);
            btnTiepTuc.TabIndex = 19;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = false;
            btnTiepTuc.Click += BtnTiepTuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(205, 92, 92);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(400, 320);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 38);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += BtnThoat_Click;
            // 
            // bai1
            // 
            BackColor = Color.FromArgb(240, 248, 240);
            ClientSize = new Size(620, 420);
            Controls.Add(lblTieuDe);
            Controls.Add(lblMaKhach);
            Controls.Add(cboMaKhach);
            Controls.Add(lblTenKhach);
            Controls.Add(txtTenKhach);
            Controls.Add(grpLoaiKhach);
            Controls.Add(lblChiSoMoi);
            Controls.Add(txtChiSoMoi);
            Controls.Add(lblThanhTien);
            Controls.Add(txtThanhTien);
            Controls.Add(lblChiSoCu);
            Controls.Add(txtChiSoCu);
            Controls.Add(lblVAT);
            Controls.Add(txtVAT);
            Controls.Add(lblSoKw);
            Controls.Add(txtSoKw);
            Controls.Add(lblTongCong);
            Controls.Add(txtTongCong);
            Controls.Add(btnThucHien);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnThoat);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn tiền điện (Cá nhân / Cơ quan)";
            grpLoaiKhach.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnThucHien_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtChiSoCu.Text.Trim(), out double cu) || cu < 0)
            {
                MessageBox.Show("Vui lòng nhập chỉ số cũ >= 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoCu.Focus();
                return;
            }

            if (!double.TryParse(txtChiSoMoi.Text.Trim(), out double moi) || moi < cu)
            {
                MessageBox.Show("Chỉ số mới phải >= chỉ số cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoMoi.Focus();
                return;
            }

            double soKw = moi - cu;
            double donGia = radCaNhan.Checked ? 5000 : 6000;
            double thanhTien = soKw * donGia;
            double vat = thanhTien * 0.10;
            double tongCong = thanhTien + vat;

            txtSoKw.Text = soKw.ToString("N0");
            txtThanhTien.Text = thanhTien.ToString("#,##0") + " đ";
            txtVAT.Text = vat.ToString("#,##0") + " đ";
            txtTongCong.Text = tongCong.ToString("#,##0") + " đ";
        }

        private void BtnTiepTuc_Click(object? sender, EventArgs e)
        {
            txtChiSoCu.Clear();
            txtChiSoMoi.Clear();
            txtSoKw.Clear();
            txtThanhTien.Clear();
            txtVAT.Clear();
            txtTongCong.Clear();
            radCaNhan.Checked = true;
            cboMaKhach.Focus();
        }

        private void CboMaKhach_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboMaKhach.SelectedItem?.ToString() == "A01") txtTenKhach.Text = "Nguyễn Văn An";
            else if (cboMaKhach.SelectedItem?.ToString() == "A02") txtTenKhach.Text = "Trần Thị Bình";
            else if (cboMaKhach.SelectedItem?.ToString() == "B01") txtTenKhach.Text = "Công ty TNHH Ánh Dương";
            else if (cboMaKhach.SelectedItem?.ToString() == "B02") txtTenKhach.Text = "Công ty CP Sao Mai";
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
