using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai6 : Form
    {
        private Label lblTieuDe;
        private Label lblMaHV;
        private ComboBox cboMaHV;
        private Label lblGioiTinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private GroupBox grpGioiTinh;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgayDangKy;
        private DateTimePicker dtpNgayDangKy;

        private CheckBox chkTinHocA;
        private CheckBox chkTinHocB;
        private CheckBox chkTiengAnhA;
        private CheckBox chkTiengAnhB;

        private Label lblGiaTinHocA;
        private Label lblGiaTinHocB;
        private Label lblGiaTiengAnhA;
        private Label lblGiaTiengAnhB;

        private Label lblTongTien;
        private TextBox txtTongTien;

        private Button btnTinhTien;
        private Button btnCancel;
        private Button btnExit;

        public bai6()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblMaHV = new Label();
            cboMaHV = new ComboBox();
            lblGioiTinh = new Label();
            grpGioiTinh = new GroupBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgayDangKy = new Label();
            dtpNgayDangKy = new DateTimePicker();
            chkTinHocA = new CheckBox();
            chkTinHocB = new CheckBox();
            chkTiengAnhA = new CheckBox();
            chkTiengAnhB = new CheckBox();
            lblGiaTinHocA = new Label();
            lblGiaTinHocB = new Label();
            lblGiaTiengAnhA = new Label();
            lblGiaTiengAnhB = new Label();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            btnTinhTien = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            grpGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(160, 32, 240);
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(540, 40);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaHV
            // 
            lblMaHV.Location = new Point(40, 68);
            lblMaHV.Name = "lblMaHV";
            lblMaHV.Size = new Size(110, 25);
            lblMaHV.TabIndex = 1;
            lblMaHV.Text = "Mã Học Viên";
            // 
            // cboMaHV
            // 
            cboMaHV.Items.AddRange(new object[] { "HV001", "HV002", "HV003", "HV004" });
            cboMaHV.Location = new Point(160, 65);
            cboMaHV.Name = "cboMaHV";
            cboMaHV.Size = new Size(130, 29);
            cboMaHV.TabIndex = 2;
            cboMaHV.SelectedIndexChanged += CboMaHV_SelectedIndexChanged;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(315, 68);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(80, 25);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(radNam);
            grpGioiTinh.Controls.Add(radNu);
            grpGioiTinh.Location = new Point(395, 55);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(145, 45);
            grpGioiTinh.TabIndex = 4;
            grpGioiTinh.TabStop = false;
            // 
            // radNam
            // 
            radNam.Checked = true;
            radNam.Location = new Point(10, 15);
            radNam.Name = "radNam";
            radNam.Size = new Size(60, 25);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            // 
            // radNu
            // 
            radNu.Location = new Point(75, 15);
            radNu.Name = "radNu";
            radNu.Size = new Size(60, 25);
            radNu.TabIndex = 1;
            radNu.Text = "Nữ";
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(40, 110);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(110, 25);
            lblHoTen.TabIndex = 5;
            lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(160, 107);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(380, 29);
            txtHoTen.TabIndex = 6;
            txtHoTen.Text = "Nguyễn Văn Tuấn";
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.Location = new Point(40, 152);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(110, 25);
            lblNgayDangKy.TabIndex = 7;
            lblNgayDangKy.Text = "Ngày Đăng Ký";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Location = new Point(160, 149);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(380, 29);
            dtpNgayDangKy.TabIndex = 8;
            // 
            // chkTinHocA
            // 
            chkTinHocA.Location = new Point(120, 195);
            chkTinHocA.Name = "chkTinHocA";
            chkTinHocA.Size = new Size(160, 25);
            chkTinHocA.TabIndex = 9;
            chkTinHocA.Text = "Tin học A";
            // 
            // chkTinHocB
            // 
            chkTinHocB.Location = new Point(120, 195);
            chkTinHocB.Name = "chkTinHocB";
            chkTinHocB.Size = new Size(160, 25);
            chkTinHocB.TabIndex = 11;
            chkTinHocB.Text = "Tin học B";
            // 
            // chkTiengAnhA
            // 
            chkTiengAnhA.Location = new Point(120, 195);
            chkTiengAnhA.Name = "chkTiengAnhA";
            chkTiengAnhA.Size = new Size(160, 25);
            chkTiengAnhA.TabIndex = 13;
            chkTiengAnhA.Text = "Tiếng Anh A";
            // 
            // chkTiengAnhB
            // 
            chkTiengAnhB.Location = new Point(120, 195);
            chkTiengAnhB.Name = "chkTiengAnhB";
            chkTiengAnhB.Size = new Size(160, 25);
            chkTiengAnhB.TabIndex = 15;
            chkTiengAnhB.Text = "Tiếng Anh B";
            // 
            // lblGiaTinHocA
            // 
            lblGiaTinHocA.Location = new Point(350, 195);
            lblGiaTinHocA.Name = "lblGiaTinHocA";
            lblGiaTinHocA.Size = new Size(150, 25);
            lblGiaTinHocA.TabIndex = 10;
            lblGiaTinHocA.Text = "300.000 đồng";
            lblGiaTinHocA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGiaTinHocB
            // 
            lblGiaTinHocB.Location = new Point(350, 195);
            lblGiaTinHocB.Name = "lblGiaTinHocB";
            lblGiaTinHocB.Size = new Size(150, 25);
            lblGiaTinHocB.TabIndex = 12;
            lblGiaTinHocB.Text = "500.000 đồng";
            lblGiaTinHocB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGiaTiengAnhA
            // 
            lblGiaTiengAnhA.Location = new Point(350, 195);
            lblGiaTiengAnhA.Name = "lblGiaTiengAnhA";
            lblGiaTiengAnhA.Size = new Size(150, 25);
            lblGiaTiengAnhA.TabIndex = 14;
            lblGiaTiengAnhA.Text = "400.000 đồng";
            lblGiaTiengAnhA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGiaTiengAnhB
            // 
            lblGiaTiengAnhB.Location = new Point(350, 195);
            lblGiaTiengAnhB.Name = "lblGiaTiengAnhB";
            lblGiaTiengAnhB.Size = new Size(150, 25);
            lblGiaTiengAnhB.TabIndex = 16;
            lblGiaTiengAnhB.Text = "600.000 đồng";
            lblGiaTiengAnhB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTien.Location = new Point(120, 195);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(110, 25);
            lblTongTien.TabIndex = 17;
            lblTongTien.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.FromArgb(230, 245, 255);
            txtTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTongTien.ForeColor = Color.DarkBlue;
            txtTongTien.Location = new Point(270, 195);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(230, 30);
            txtTongTien.TabIndex = 18;
            // 
            // btnTinhTien
            // 
            btnTinhTien.BackColor = Color.FromArgb(41, 128, 185);
            btnTinhTien.FlatStyle = FlatStyle.Flat;
            btnTinhTien.ForeColor = Color.White;
            btnTinhTien.Location = new Point(70, 420);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(120, 38);
            btnTinhTien.TabIndex = 19;
            btnTinhTien.Text = "Tính Tiền";
            btnTinhTien.UseVisualStyleBackColor = false;
            btnTinhTien.Click += BtnTinhTien_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(220, 100, 100);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(230, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 38);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "✖ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(108, 117, 125);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(390, 420);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 38);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // bai6
            // 
            BackColor = Color.FromArgb(248, 248, 255);
            ClientSize = new Size(580, 480);
            Controls.Add(lblTieuDe);
            Controls.Add(lblMaHV);
            Controls.Add(cboMaHV);
            Controls.Add(lblGioiTinh);
            Controls.Add(grpGioiTinh);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblNgayDangKy);
            Controls.Add(dtpNgayDangKy);
            Controls.Add(chkTinHocA);
            Controls.Add(lblGiaTinHocA);
            Controls.Add(chkTinHocB);
            Controls.Add(lblGiaTinHocB);
            Controls.Add(chkTiengAnhA);
            Controls.Add(lblGiaTiengAnhA);
            Controls.Add(chkTiengAnhB);
            Controls.Add(lblGiaTiengAnhB);
            Controls.Add(lblTongTien);
            Controls.Add(txtTongTien);
            Controls.Add(btnTinhTien);
            Controls.Add(btnCancel);
            Controls.Add(btnExit);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính tiền học trung tâm";
            grpGioiTinh.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnTinhTien_Click(object? sender, EventArgs e)
        {
            double tongTien = 0;
            if (chkTinHocA.Checked) tongTien += 300000;
            if (chkTinHocB.Checked) tongTien += 500000;
            if (chkTiengAnhA.Checked) tongTien += 400000;
            if (chkTiengAnhB.Checked) tongTien += 600000;

            txtTongTien.Text = tongTien.ToString("#,##0") + " đồng";
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            chkTinHocA.Checked = false;
            chkTinHocB.Checked = false;
            chkTiengAnhA.Checked = false;
            chkTiengAnhB.Checked = false;
            txtTongTien.Clear();
        }

        private void CboMaHV_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboMaHV.SelectedItem?.ToString() == "HV001") txtHoTen.Text = "Nguyễn Văn Tuấn";
            else if (cboMaHV.SelectedItem?.ToString() == "HV002") txtHoTen.Text = "Trần Thị Mai";
            else if (cboMaHV.SelectedItem?.ToString() == "HV003") txtHoTen.Text = "Lê Hoàng Nam";
            else if (cboMaHV.SelectedItem?.ToString() == "HV004") txtHoTen.Text = "Phạm Thị Hương";
        }

        private void BtnExit_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
