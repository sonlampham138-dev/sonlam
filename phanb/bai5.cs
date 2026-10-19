using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai5 : Form
    {
        private Panel pnlHeader;
        private Label lblHeader;

        private Label lblNhapSo;
        private TextBox txtSoNguyen;
        private Button btnNhapSo;

        private ListBox lsbDaySo;
        private GroupBox grpChucNang;

        private Button btnTang2;
        private Button btnChonChanDau;
        private Button btnChonLeCuoi;
        private Button btnXoaChon;
        private Button btnXoaDau;
        private Button btnXoaCuoi;
        private Button btnXoaDaySo;
        private Button btnKetThuc;

        public bai5()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblHeader = new Label();
            lblNhapSo = new Label();
            txtSoNguyen = new TextBox();
            btnNhapSo = new Button();
            lsbDaySo = new ListBox();
            grpChucNang = new GroupBox();
            btnTang2 = new Button();
            btnChonChanDau = new Button();
            btnChonLeCuoi = new Button();
            btnXoaChon = new Button();
            btnXoaDau = new Button();
            btnXoaCuoi = new Button();
            btnXoaDaySo = new Button();
            btnKetThuc = new Button();
            pnlHeader.SuspendLayout();
            grpChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(23, 162, 184);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(580, 50);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(580, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Ứng dụng xử lý dãy số";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNhapSo
            // 
            lblNhapSo.Location = new Point(25, 68);
            lblNhapSo.Name = "lblNhapSo";
            lblNhapSo.Size = new Size(130, 25);
            lblNhapSo.TabIndex = 1;
            lblNhapSo.Text = "Nhập số nguyên:";
            // 
            // txtSoNguyen
            // 
            txtSoNguyen.Location = new Point(160, 65);
            txtSoNguyen.Name = "txtSoNguyen";
            txtSoNguyen.Size = new Size(140, 29);
            txtSoNguyen.TabIndex = 2;
            txtSoNguyen.KeyDown += TxtSoNguyen_KeyDown;
            // 
            // btnNhapSo
            // 
            btnNhapSo.BackColor = Color.FromArgb(41, 128, 185);
            btnNhapSo.FlatStyle = FlatStyle.Flat;
            btnNhapSo.ForeColor = Color.White;
            btnNhapSo.Location = new Point(315, 63);
            btnNhapSo.Name = "btnNhapSo";
            btnNhapSo.Size = new Size(100, 32);
            btnNhapSo.TabIndex = 3;
            btnNhapSo.Text = "Nhập số";
            btnNhapSo.UseVisualStyleBackColor = false;
            btnNhapSo.Click += BtnNhapSo_Click;
            // 
            // lsbDaySo
            // 
            lsbDaySo.Font = new Font("Segoe UI", 11F);
            lsbDaySo.ItemHeight = 25;
            lsbDaySo.Location = new Point(25, 115);
            lsbDaySo.Name = "lsbDaySo";
            lsbDaySo.Size = new Size(240, 279);
            lsbDaySo.TabIndex = 4;
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnTang2);
            grpChucNang.Controls.Add(btnChonChanDau);
            grpChucNang.Controls.Add(btnChonLeCuoi);
            grpChucNang.Controls.Add(btnXoaChon);
            grpChucNang.Controls.Add(btnXoaDau);
            grpChucNang.Controls.Add(btnXoaCuoi);
            grpChucNang.Controls.Add(btnXoaDaySo);
            grpChucNang.Location = new Point(285, 105);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(265, 295);
            grpChucNang.TabIndex = 5;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng:";
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(20, 25);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(225, 32);
            btnTang2.TabIndex = 0;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.Click += BtnTang2_Click;
            // 
            // btnChonChanDau
            // 
            btnChonChanDau.Location = new Point(20, 25);
            btnChonChanDau.Name = "btnChonChanDau";
            btnChonChanDau.Size = new Size(225, 32);
            btnChonChanDau.TabIndex = 1;
            btnChonChanDau.Text = "Chọn số chẵn đầu";
            btnChonChanDau.Click += BtnChonChanDau_Click;
            // 
            // btnChonLeCuoi
            // 
            btnChonLeCuoi.Location = new Point(20, 25);
            btnChonLeCuoi.Name = "btnChonLeCuoi";
            btnChonLeCuoi.Size = new Size(225, 32);
            btnChonLeCuoi.TabIndex = 2;
            btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            btnChonLeCuoi.Click += BtnChonLeCuoi_Click;
            // 
            // btnXoaChon
            // 
            btnXoaChon.Location = new Point(20, 25);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.Size = new Size(225, 32);
            btnXoaChon.TabIndex = 3;
            btnXoaChon.Text = "Xóa phần tử đang chọn";
            btnXoaChon.Click += BtnXoaChon_Click;
            // 
            // btnXoaDau
            // 
            btnXoaDau.Location = new Point(20, 25);
            btnXoaDau.Name = "btnXoaDau";
            btnXoaDau.Size = new Size(225, 32);
            btnXoaDau.TabIndex = 4;
            btnXoaDau.Text = "Xóa phần tử đầu";
            btnXoaDau.Click += BtnXoaDau_Click;
            // 
            // btnXoaCuoi
            // 
            btnXoaCuoi.Location = new Point(20, 25);
            btnXoaCuoi.Name = "btnXoaCuoi";
            btnXoaCuoi.Size = new Size(225, 32);
            btnXoaCuoi.TabIndex = 5;
            btnXoaCuoi.Text = "Xóa phần tử cuối";
            btnXoaCuoi.Click += BtnXoaCuoi_Click;
            // 
            // btnXoaDaySo
            // 
            btnXoaDaySo.Location = new Point(20, 25);
            btnXoaDaySo.Name = "btnXoaDaySo";
            btnXoaDaySo.Size = new Size(225, 32);
            btnXoaDaySo.TabIndex = 6;
            btnXoaDaySo.Text = "Xóa dãy số";
            btnXoaDaySo.Click += BtnXoaDaySo_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.BackColor = Color.FromArgb(220, 53, 69);
            btnKetThuc.FlatStyle = FlatStyle.Flat;
            btnKetThuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKetThuc.ForeColor = Color.White;
            btnKetThuc.Location = new Point(25, 415);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(240, 36);
            btnKetThuc.TabIndex = 6;
            btnKetThuc.Text = "Kết thúc ứng dụng";
            btnKetThuc.UseVisualStyleBackColor = false;
            btnKetThuc.Click += BtnKetThuc_Click;
            // 
            // bai5
            // 
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(580, 470);
            Controls.Add(pnlHeader);
            Controls.Add(lblNhapSo);
            Controls.Add(txtSoNguyen);
            Controls.Add(btnNhapSo);
            Controls.Add(lsbDaySo);
            Controls.Add(grpChucNang);
            Controls.Add(btnKetThuc);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xử lý dãy số với ListBox";
            Load += bai5_Load;
            pnlHeader.ResumeLayout(false);
            grpChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnNhapSo_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtSoNguyen.Text.Trim(), out int val))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNguyen.Focus();
                txtSoNguyen.SelectAll();
                return;
            }

            lsbDaySo.Items.Add(val);
            txtSoNguyen.Clear();
            txtSoNguyen.Focus();
        }

        private void BtnTang2_Click(object? sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) return;

            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (int.TryParse(lsbDaySo.Items[i]?.ToString(), out int val))
                {
                    lsbDaySo.Items[i] = val + 2;
                }
            }
        }

        private void BtnChonChanDau_Click(object? sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (int.TryParse(lsbDaySo.Items[i]?.ToString(), out int val))
                {
                    if (val % 2 == 0)
                    {
                        lsbDaySo.SelectedIndex = i;
                        return;
                    }
                }
            }
            MessageBox.Show("Không tìm thấy số chẵn nào trong dãy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnChonLeCuoi_Click(object? sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if (int.TryParse(lsbDaySo.Items[i]?.ToString(), out int val))
                {
                    if (val % 2 != 0)
                    {
                        lsbDaySo.SelectedIndex = i;
                        return;
                    }
                }
            }
            MessageBox.Show("Không tìm thấy số lẻ nào trong dãy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnXoaChon_Click(object? sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex != -1)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnXoaDau_Click(object? sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(0);
            }
        }

        private void BtnXoaCuoi_Click(object? sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
            }
        }

        private void BtnXoaDaySo_Click(object? sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void TxtSoNguyen_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnNhapSo_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnKetThuc_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void bai5_Load(object sender, EventArgs e)
        {

        }
    }
}
