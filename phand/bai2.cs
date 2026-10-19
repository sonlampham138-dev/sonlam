using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace baitapthaoluan.phand
{
    public class bai2 : Form
    {
        private Label lblMangGoc;
        private TextBox txtMangGoc;

        private Label lblKetQua;
        private TextBox txtKetQua;

        private Button btnXuatNgauNhien;
        private Button btnDemSoLe;
        private Button btnTimMin;
        private Button btnTongSoLe;
        private Button btnSapXepTang;
        private Button btnThoat;

        private int[] mangSo = Array.Empty<int>();

        public bai2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblMangGoc = new Label();
            txtMangGoc = new TextBox();
            lblKetQua = new Label();
            txtKetQua = new TextBox();
            btnXuatNgauNhien = new Button();
            btnDemSoLe = new Button();
            btnTimMin = new Button();
            btnTongSoLe = new Button();
            btnSapXepTang = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblMangGoc
            // 
            lblMangGoc.Location = new Point(30, 25);
            lblMangGoc.Name = "lblMangGoc";
            lblMangGoc.Size = new Size(90, 25);
            lblMangGoc.TabIndex = 0;
            lblMangGoc.Text = "Mảng gốc";
            // 
            // txtMangGoc
            // 
            txtMangGoc.BackColor = Color.White;
            txtMangGoc.Location = new Point(130, 22);
            txtMangGoc.Name = "txtMangGoc";
            txtMangGoc.ReadOnly = true;
            txtMangGoc.Size = new Size(370, 29);
            txtMangGoc.TabIndex = 1;
            // 
            // lblKetQua
            // 
            lblKetQua.Location = new Point(30, 68);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(90, 25);
            lblKetQua.TabIndex = 2;
            lblKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            txtKetQua.BackColor = Color.White;
            txtKetQua.Location = new Point(130, 65);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(370, 29);
            txtKetQua.TabIndex = 3;
            // 
            // btnXuatNgauNhien
            // 
            btnXuatNgauNhien.BackColor = Color.FromArgb(235, 240, 245);
            btnXuatNgauNhien.Location = new Point(70, 115);
            btnXuatNgauNhien.Name = "btnXuatNgauNhien";
            btnXuatNgauNhien.Size = new Size(190, 34);
            btnXuatNgauNhien.TabIndex = 4;
            btnXuatNgauNhien.Text = "Xuất ngẫu nhiên";
            btnXuatNgauNhien.UseVisualStyleBackColor = false;
            btnXuatNgauNhien.Click += BtnXuatNgauNhien_Click;
            // 
            // btnDemSoLe
            // 
            btnDemSoLe.BackColor = Color.FromArgb(235, 240, 245);
            btnDemSoLe.Location = new Point(70, 155);
            btnDemSoLe.Name = "btnDemSoLe";
            btnDemSoLe.Size = new Size(190, 34);
            btnDemSoLe.TabIndex = 5;
            btnDemSoLe.Text = "Đếm các số lẻ";
            btnDemSoLe.UseVisualStyleBackColor = false;
            btnDemSoLe.Click += BtnDemSoLe_Click;
            // 
            // btnTimMin
            // 
            btnTimMin.BackColor = Color.FromArgb(235, 240, 245);
            btnTimMin.Location = new Point(70, 195);
            btnTimMin.Name = "btnTimMin";
            btnTimMin.Size = new Size(190, 34);
            btnTimMin.TabIndex = 6;
            btnTimMin.Text = "Tìm phần tử nhỏ nhất";
            btnTimMin.UseVisualStyleBackColor = false;
            btnTimMin.Click += BtnTimMin_Click;
            // 
            // btnTongSoLe
            // 
            btnTongSoLe.BackColor = Color.FromArgb(235, 240, 245);
            btnTongSoLe.Location = new Point(280, 115);
            btnTongSoLe.Name = "btnTongSoLe";
            btnTongSoLe.Size = new Size(190, 34);
            btnTongSoLe.TabIndex = 7;
            btnTongSoLe.Text = "Tổng các số lẻ";
            btnTongSoLe.UseVisualStyleBackColor = false;
            btnTongSoLe.Click += BtnTongSoLe_Click;
            // 
            // btnSapXepTang
            // 
            btnSapXepTang.BackColor = Color.FromArgb(235, 240, 245);
            btnSapXepTang.Location = new Point(280, 155);
            btnSapXepTang.Name = "btnSapXepTang";
            btnSapXepTang.Size = new Size(190, 34);
            btnSapXepTang.TabIndex = 8;
            btnSapXepTang.Text = "Sắp xếp tăng";
            btnSapXepTang.UseVisualStyleBackColor = false;
            btnSapXepTang.Click += BtnSapXepTang_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(235, 240, 245);
            btnThoat.Location = new Point(280, 195);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(190, 34);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += BtnThoat_Click;
            // 
            // bai2
            // 
            BackColor = Color.FromArgb(240, 244, 250);
            ClientSize = new Size(540, 260);
            Controls.Add(lblMangGoc);
            Controls.Add(txtMangGoc);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnXuatNgauNhien);
            Controls.Add(btnDemSoLe);
            Controls.Add(btnTimMin);
            Controls.Add(btnTongSoLe);
            Controls.Add(btnSapXepTang);
            Controls.Add(btnThoat);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dãy số (Tìm Min/Max - Sắp xếp)";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnXuatNgauNhien_Click(object? sender, EventArgs e)
        {
            Random rand = new Random();
            int n = 10;
            mangSo = new int[n];
            for (int i = 0; i < n; i++)
            {
                mangSo[i] = rand.Next(1, 100);
            }
            txtMangGoc.Text = string.Join("  ", mangSo);
            txtKetQua.Clear();
        }

        private void BtnDemSoLe_Click(object? sender, EventArgs e)
        {
            if (mangSo.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Xuất ngẫu nhiên' để tạo mảng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int dem = 0;
            foreach (int x in mangSo)
            {
                if (x % 2 != 0) dem++;
            }
            txtKetQua.Text = $"Số phần tử lẻ: {dem}";
        }

        private void BtnTimMin_Click(object? sender, EventArgs e)
        {
            if (mangSo.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Xuất ngẫu nhiên' để tạo mảng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int min = mangSo[0];
            foreach (int x in mangSo)
            {
                if (x < min) min = x;
            }
            txtKetQua.Text = $"Phần tử nhỏ nhất: {min}";
        }

        private void BtnTongSoLe_Click(object? sender, EventArgs e)
        {
            if (mangSo.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Xuất ngẫu nhiên' để tạo mảng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int tongLe = 0;
            foreach (int x in mangSo)
            {
                if (x % 2 != 0) tongLe += x;
            }
            txtKetQua.Text = $"Tổng các số lẻ: {tongLe}";
        }

        private void BtnSapXepTang_Click(object? sender, EventArgs e)
        {
            if (mangSo.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Xuất ngẫu nhiên' để tạo mảng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int[] sapXep = (int[])mangSo.Clone();
            Array.Sort(sapXep);
            txtKetQua.Text = string.Join("  ", sapXep);
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
