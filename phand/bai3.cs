using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace baitapthaoluan.phand
{
    public class bai3 : Form
    {
        private Label lblN;
        private TextBox txtN;

        private Label lblMang;
        private TextBox txtMang;

        private GroupBox grpMinMax;
        private RadioButton radMax;
        private RadioButton radMin;
        private TextBox txtKetQuaMinMax;

        private GroupBox grpSapXep;
        private RadioButton radTang;
        private RadioButton radGiam;
        private TextBox txtKetQuaSapXep;

        private Button btnTaoMang;
        private Button btnTimMinMax;
        private Button btnSapXep;
        private Button btnThoat;

        private int[] mangHienTai = Array.Empty<int>();

        public bai3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblN = new Label();
            txtN = new TextBox();
            lblMang = new Label();
            txtMang = new TextBox();
            grpMinMax = new GroupBox();
            radMax = new RadioButton();
            radMin = new RadioButton();
            txtKetQuaMinMax = new TextBox();
            grpSapXep = new GroupBox();
            radTang = new RadioButton();
            radGiam = new RadioButton();
            txtKetQuaSapXep = new TextBox();
            btnTaoMang = new Button();
            btnTimMinMax = new Button();
            btnSapXep = new Button();
            btnThoat = new Button();
            grpMinMax.SuspendLayout();
            grpSapXep.SuspendLayout();
            SuspendLayout();
            // 
            // lblN
            // 
            lblN.Location = new Point(25, 25);
            lblN.Name = "lblN";
            lblN.Size = new Size(110, 25);
            lblN.TabIndex = 0;
            lblN.Text = "Nhập N";
            // 
            // txtN
            // 
            txtN.Location = new Point(145, 22);
            txtN.Name = "txtN";
            txtN.Size = new Size(270, 29);
            txtN.TabIndex = 1;
            txtN.Text = "10";
            // 
            // lblMang
            // 
            lblMang.Location = new Point(25, 68);
            lblMang.Name = "lblMang";
            lblMang.Size = new Size(115, 25);
            lblMang.TabIndex = 2;
            lblMang.Text = "Dãy số vừa nhập";
            // 
            // txtMang
            // 
            txtMang.BackColor = Color.White;
            txtMang.Location = new Point(145, 65);
            txtMang.Name = "txtMang";
            txtMang.ReadOnly = true;
            txtMang.Size = new Size(270, 29);
            txtMang.TabIndex = 3;
            // 
            // grpMinMax
            // 
            grpMinMax.Controls.Add(radMax);
            grpMinMax.Controls.Add(radMin);
            grpMinMax.Location = new Point(25, 110);
            grpMinMax.Name = "grpMinMax";
            grpMinMax.Size = new Size(130, 95);
            grpMinMax.TabIndex = 4;
            grpMinMax.TabStop = false;
            grpMinMax.Text = "Tìm Min_Max";
            // 
            // radMax
            // 
            radMax.Checked = true;
            radMax.Location = new Point(15, 25);
            radMax.Name = "radMax";
            radMax.Size = new Size(80, 25);
            radMax.TabIndex = 0;
            radMax.TabStop = true;
            radMax.Text = "Max";
            // 
            // radMin
            // 
            radMin.Location = new Point(15, 58);
            radMin.Name = "radMin";
            radMin.Size = new Size(80, 25);
            radMin.TabIndex = 1;
            radMin.Text = "Min";
            // 
            // txtKetQuaMinMax
            // 
            txtKetQuaMinMax.BackColor = Color.White;
            txtKetQuaMinMax.Location = new Point(165, 125);
            txtKetQuaMinMax.Name = "txtKetQuaMinMax";
            txtKetQuaMinMax.ReadOnly = true;
            txtKetQuaMinMax.Size = new Size(250, 29);
            txtKetQuaMinMax.TabIndex = 5;
            // 
            // grpSapXep
            // 
            grpSapXep.Controls.Add(radTang);
            grpSapXep.Controls.Add(radGiam);
            grpSapXep.Location = new Point(25, 225);
            grpSapXep.Name = "grpSapXep";
            grpSapXep.Size = new Size(130, 95);
            grpSapXep.TabIndex = 6;
            grpSapXep.TabStop = false;
            grpSapXep.Text = "Sắp xếp";
            // 
            // radTang
            // 
            radTang.Checked = true;
            radTang.Location = new Point(15, 25);
            radTang.Name = "radTang";
            radTang.Size = new Size(80, 25);
            radTang.TabIndex = 0;
            radTang.TabStop = true;
            radTang.Text = "Tăng";
            // 
            // radGiam
            // 
            radGiam.Location = new Point(15, 58);
            radGiam.Name = "radGiam";
            radGiam.Size = new Size(80, 25);
            radGiam.TabIndex = 1;
            radGiam.Text = "Giảm";
            // 
            // txtKetQuaSapXep
            // 
            txtKetQuaSapXep.BackColor = Color.White;
            txtKetQuaSapXep.Location = new Point(165, 240);
            txtKetQuaSapXep.Name = "txtKetQuaSapXep";
            txtKetQuaSapXep.ReadOnly = true;
            txtKetQuaSapXep.Size = new Size(250, 29);
            txtKetQuaSapXep.TabIndex = 7;
            // 
            // btnTaoMang
            // 
            btnTaoMang.BackColor = Color.FromArgb(235, 240, 245);
            btnTaoMang.Location = new Point(445, 63);
            btnTaoMang.Name = "btnTaoMang";
            btnTaoMang.Size = new Size(145, 34);
            btnTaoMang.TabIndex = 8;
            btnTaoMang.Text = "Tạo mảng";
            btnTaoMang.UseVisualStyleBackColor = false;
            btnTaoMang.Click += BtnTaoMang_Click;
            // 
            // btnTimMinMax
            // 
            btnTimMinMax.BackColor = Color.FromArgb(235, 240, 245);
            btnTimMinMax.Location = new Point(445, 123);
            btnTimMinMax.Name = "btnTimMinMax";
            btnTimMinMax.Size = new Size(145, 34);
            btnTimMinMax.TabIndex = 9;
            btnTimMinMax.Text = "Tìm Min - Max";
            btnTimMinMax.UseVisualStyleBackColor = false;
            btnTimMinMax.Click += BtnTimMinMax_Click;
            // 
            // btnSapXep
            // 
            btnSapXep.BackColor = Color.FromArgb(235, 240, 245);
            btnSapXep.Location = new Point(445, 238);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(145, 34);
            btnSapXep.TabIndex = 10;
            btnSapXep.Text = "Sắp xếp";
            btnSapXep.UseVisualStyleBackColor = false;
            btnSapXep.Click += BtnSapXep_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(235, 240, 245);
            btnThoat.Location = new Point(445, 282);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(145, 34);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += BtnThoat_Click;
            // 
            // bai3
            // 
            BackColor = Color.FromArgb(240, 244, 250);
            ClientSize = new Size(620, 360);
            Controls.Add(lblN);
            Controls.Add(txtN);
            Controls.Add(lblMang);
            Controls.Add(txtMang);
            Controls.Add(grpMinMax);
            Controls.Add(txtKetQuaMinMax);
            Controls.Add(grpSapXep);
            Controls.Add(txtKetQuaSapXep);
            Controls.Add(btnTaoMang);
            Controls.Add(btnTimMinMax);
            Controls.Add(btnSapXep);
            Controls.Add(btnThoat);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dãy số (Tạo mảng - Min/Max - Sắp xếp)";
            grpMinMax.ResumeLayout(false);
            grpSapXep.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnTaoMang_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text.Trim(), out int n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập N nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtN.Focus();
                return;
            }

            Random rand = new Random();
            mangHienTai = new int[n];
            for (int i = 0; i < n; i++)
            {
                mangHienTai[i] = rand.Next(1, 100);
            }

            txtMang.Text = string.Join(" ", mangHienTai);
            txtKetQuaMinMax.Clear();
            txtKetQuaSapXep.Clear();
        }

        private void BtnTimMinMax_Click(object? sender, EventArgs e)
        {
            if (mangHienTai.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Tạo mảng' trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int val = mangHienTai[0];
            if (radMax.Checked)
            {
                foreach (int x in mangHienTai)
                {
                    if (x > val) val = x;
                }
            }
            else
            {
                foreach (int x in mangHienTai)
                {
                    if (x < val) val = x;
                }
            }
            txtKetQuaMinMax.Text = val.ToString();
        }

        private void BtnSapXep_Click(object? sender, EventArgs e)
        {
            if (mangHienTai.Length == 0)
            {
                MessageBox.Show("Vui lòng bấm 'Tạo mảng' trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[] sapXep = (int[])mangHienTai.Clone();
            Array.Sort(sapXep);
            if (radGiam.Checked)
            {
                Array.Reverse(sapXep);
            }

            txtKetQuaSapXep.Text = string.Join(" ", sapXep);
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
