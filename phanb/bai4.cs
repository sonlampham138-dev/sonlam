using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitapthaoluan.phanb
{
    public class bai4 : Form
    {
        private GroupBox grpNhap;
        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;

        private GroupBox grpTuyChon;
        private RadioButton radUSCLN;
        private RadioButton radBSCNN;

        private Label lblKetQua;
        private TextBox txtKetQua;

        private Button btnTim;
        private Button btnThoat;

        public bai4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            grpNhap = new GroupBox();
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            grpTuyChon = new GroupBox();
            radUSCLN = new RadioButton();
            radBSCNN = new RadioButton();
            lblKetQua = new Label();
            txtKetQua = new TextBox();
            btnTim = new Button();
            btnThoat = new Button();
            grpNhap.SuspendLayout();
            grpTuyChon.SuspendLayout();
            SuspendLayout();
            // 
            // grpNhap
            // 
            grpNhap.BackColor = Color.FromArgb(220, 245, 230);
            grpNhap.Controls.Add(lblA);
            grpNhap.Controls.Add(txtA);
            grpNhap.Controls.Add(lblB);
            grpNhap.Controls.Add(txtB);
            grpNhap.Location = new Point(25, 20);
            grpNhap.Name = "grpNhap";
            grpNhap.Size = new Size(320, 115);
            grpNhap.TabIndex = 0;
            grpNhap.TabStop = false;
            grpNhap.Text = "Nhập dữ liệu:";
            // 
            // lblA
            // 
            lblA.Location = new Point(15, 32);
            lblA.Name = "lblA";
            lblA.Size = new Size(110, 25);
            lblA.TabIndex = 0;
            lblA.Text = "Số nguyên a:";
            // 
            // txtA
            // 
            txtA.Location = new Point(130, 29);
            txtA.Name = "txtA";
            txtA.Size = new Size(165, 29);
            txtA.TabIndex = 1;
            // 
            // lblB
            // 
            lblB.Location = new Point(15, 72);
            lblB.Name = "lblB";
            lblB.Size = new Size(110, 25);
            lblB.TabIndex = 2;
            lblB.Text = "Số nguyên b:";
            // 
            // txtB
            // 
            txtB.Location = new Point(130, 69);
            txtB.Name = "txtB";
            txtB.Size = new Size(165, 29);
            txtB.TabIndex = 3;
            // 
            // grpTuyChon
            // 
            grpTuyChon.Controls.Add(radUSCLN);
            grpTuyChon.Controls.Add(radBSCNN);
            grpTuyChon.Location = new Point(365, 20);
            grpTuyChon.Name = "grpTuyChon";
            grpTuyChon.Size = new Size(150, 115);
            grpTuyChon.TabIndex = 1;
            grpTuyChon.TabStop = false;
            grpTuyChon.Text = "Tùy chọn:";
            // 
            // radUSCLN
            // 
            radUSCLN.Checked = true;
            radUSCLN.Location = new Point(20, 32);
            radUSCLN.Name = "radUSCLN";
            radUSCLN.Size = new Size(110, 25);
            radUSCLN.TabIndex = 0;
            radUSCLN.TabStop = true;
            radUSCLN.Text = "USCLN";
            // 
            // radBSCNN
            // 
            radBSCNN.Location = new Point(20, 72);
            radBSCNN.Name = "radBSCNN";
            radBSCNN.Size = new Size(110, 25);
            radBSCNN.TabIndex = 1;
            radBSCNN.Text = "BSCNN";
            // 
            // lblKetQua
            // 
            lblKetQua.Location = new Point(25, 155);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(80, 25);
            lblKetQua.TabIndex = 2;
            lblKetQua.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            txtKetQua.BackColor = Color.FromArgb(235, 245, 255);
            txtKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtKetQua.Location = new Point(155, 152);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(190, 30);
            txtKetQua.TabIndex = 3;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(41, 128, 185);
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(385, 150);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(110, 32);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += BtnTim_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(108, 117, 125);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(385, 195);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 32);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += BtnThoat_Click;
            // 
            // bai4
            // 
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(540, 260);
            Controls.Add(grpNhap);
            Controls.Add(grpTuyChon);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnTim);
            Controls.Add(btnThoat);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            grpNhap.ResumeLayout(false);
            grpNhap.PerformLayout();
            grpTuyChon.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private long TimUSCLN(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                long r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private long TimBSCNN(long a, long b)
        {
            if (a == 0 || b == 0) return 0;
            long uscln = TimUSCLN(a, b);
            return Math.Abs(a * b) / uscln;
        }

        private void BtnTim_Click(object? sender, EventArgs e)
        {
            if (!long.TryParse(txtA.Text.Trim(), out long a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên a hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                return;
            }

            if (!long.TryParse(txtB.Text.Trim(), out long b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên b hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                return;
            }

            if (radUSCLN.Checked)
            {
                long uscln = TimUSCLN(a, b);
                txtKetQua.Text = uscln.ToString();
            }
            else
            {
                if (a == 0 && b == 0)
                {
                    MessageBox.Show("Không có BSCNN cho hai số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                long bscnn = TimBSCNN(a, b);
                txtKetQua.Text = bscnn.ToString();
            }
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
