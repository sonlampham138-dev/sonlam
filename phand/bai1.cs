using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace baitapthaoluan.phand
{
    public class bai1 : Form
    {
        private Label lblN;
        private TextBox txtN;
        private Button btnTaoMang;

        private Label lblX;
        private TextBox txtX;
        private Button btnTimX;

        private Button btnTimMaxMin;
        private Button btnDemDau;
        private Button btnDuongNhoNhatAmLonNhat;
        private Button btnSapXepGiam;
        private Button btnChayTatCa;
        private Button btnXoaConsole;

        private RichTextBox rtbConsole;

        private int[]? mangHienTai = null;

        public bai1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblN = new Label();
            txtN = new TextBox();
            btnTaoMang = new Button();
            lblX = new Label();
            txtX = new TextBox();
            btnTimX = new Button();
            btnTimMaxMin = new Button();
            btnDemDau = new Button();
            btnDuongNhoNhatAmLonNhat = new Button();
            btnSapXepGiam = new Button();
            btnChayTatCa = new Button();
            btnXoaConsole = new Button();
            rtbConsole = new RichTextBox();
            SuspendLayout();
            // 
            // lblN
            // 
            lblN.Location = new Point(20, 20);
            lblN.Name = "lblN";
            lblN.Size = new Size(115, 25);
            lblN.TabIndex = 0;
            lblN.Text = "Nhập N (N < 20):";
            // 
            // txtN
            // 
            txtN.Location = new Point(140, 17);
            txtN.Name = "txtN";
            txtN.Size = new Size(70, 29);
            txtN.TabIndex = 1;
            txtN.Text = "10";
            // 
            // btnTaoMang
            // 
            btnTaoMang.BackColor = Color.FromArgb(41, 128, 185);
            btnTaoMang.FlatStyle = FlatStyle.Flat;
            btnTaoMang.ForeColor = Color.White;
            btnTaoMang.Location = new Point(220, 15);
            btnTaoMang.Name = "btnTaoMang";
            btnTaoMang.Size = new Size(200, 32);
            btnTaoMang.TabIndex = 2;
            btnTaoMang.Text = "Phát sinh mảng [-100, 100]";
            btnTaoMang.UseVisualStyleBackColor = false;
            btnTaoMang.Click += BtnTaoMang_Click;
            // 
            // lblX
            // 
            lblX.Location = new Point(440, 20);
            lblX.Name = "lblX";
            lblX.Size = new Size(80, 25);
            lblX.TabIndex = 3;
            lblX.Text = "Nhập số x:";
            // 
            // txtX
            // 
            txtX.Location = new Point(525, 17);
            txtX.Name = "txtX";
            txtX.Size = new Size(70, 29);
            txtX.TabIndex = 4;
            txtX.Text = "5";
            // 
            // btnTimX
            // 
            btnTimX.BackColor = Color.FromArgb(52, 73, 94);
            btnTimX.FlatStyle = FlatStyle.Flat;
            btnTimX.ForeColor = Color.White;
            btnTimX.Location = new Point(605, 15);
            btnTimX.Name = "btnTimX";
            btnTimX.Size = new Size(115, 32);
            btnTimX.TabIndex = 5;
            btnTimX.Text = "c. Kiểm tra x";
            btnTimX.UseVisualStyleBackColor = false;
            btnTimX.Click += BtnTimX_Click;
            // 
            // btnTimMaxMin
            // 
            btnTimMaxMin.Location = new Point(20, 60);
            btnTimMaxMin.Name = "btnTimMaxMin";
            btnTimMaxMin.Size = new Size(170, 32);
            btnTimMaxMin.TabIndex = 6;
            btnTimMaxMin.Text = "a. Tìm Max, Min & vị trí";
            btnTimMaxMin.Click += BtnTimMaxMin_Click;
            // 
            // btnDemDau
            // 
            btnDemDau.Location = new Point(200, 60);
            btnDemDau.Name = "btnDemDau";
            btnDemDau.Size = new Size(160, 32);
            btnDemDau.TabIndex = 7;
            btnDemDau.Text = "b. Đếm dương, âm, 0";
            btnDemDau.Click += BtnDemDau_Click;
            // 
            // btnDuongNhoNhatAmLonNhat
            // 
            btnDuongNhoNhatAmLonNhat.Location = new Point(370, 60);
            btnDuongNhoNhatAmLonNhat.Name = "btnDuongNhoNhatAmLonNhat";
            btnDuongNhoNhatAmLonNhat.Size = new Size(170, 32);
            btnDuongNhoNhatAmLonNhat.TabIndex = 8;
            btnDuongNhoNhatAmLonNhat.Text = "d. Dương min, Âm max";
            btnDuongNhoNhatAmLonNhat.Click += BtnDuongNhoNhatAmLonNhat_Click;
            // 
            // btnSapXepGiam
            // 
            btnSapXepGiam.Location = new Point(550, 60);
            btnSapXepGiam.Name = "btnSapXepGiam";
            btnSapXepGiam.Size = new Size(170, 32);
            btnSapXepGiam.TabIndex = 9;
            btnSapXepGiam.Text = "e. Sắp xếp giảm dần";
            btnSapXepGiam.Click += BtnSapXepGiam_Click;
            // 
            // btnChayTatCa
            // 
            btnChayTatCa.BackColor = Color.FromArgb(46, 125, 50);
            btnChayTatCa.FlatStyle = FlatStyle.Flat;
            btnChayTatCa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnChayTatCa.ForeColor = Color.White;
            btnChayTatCa.Location = new Point(20, 100);
            btnChayTatCa.Name = "btnChayTatCa";
            btnChayTatCa.Size = new Size(250, 35);
            btnChayTatCa.TabIndex = 10;
            btnChayTatCa.Text = "★ Chạy tất cả các câu (Full Report)";
            btnChayTatCa.UseVisualStyleBackColor = false;
            btnChayTatCa.Click += BtnChayTatCa_Click;
            // 
            // btnXoaConsole
            // 
            btnXoaConsole.BackColor = Color.FromArgb(108, 117, 125);
            btnXoaConsole.FlatStyle = FlatStyle.Flat;
            btnXoaConsole.ForeColor = Color.White;
            btnXoaConsole.Location = new Point(285, 100);
            btnXoaConsole.Name = "btnXoaConsole";
            btnXoaConsole.Size = new Size(170, 35);
            btnXoaConsole.TabIndex = 11;
            btnXoaConsole.Text = "Xóa màn hình Console";
            btnXoaConsole.UseVisualStyleBackColor = false;
            btnXoaConsole.Click += BtnXoaConsole_Click;
            // 
            // rtbConsole
            // 
            rtbConsole.BackColor = Color.FromArgb(12, 12, 12);
            rtbConsole.Font = new Font("Consolas", 10.5F);
            rtbConsole.ForeColor = Color.FromArgb(0, 255, 65);
            rtbConsole.Location = new Point(20, 145);
            rtbConsole.Name = "rtbConsole";
            rtbConsole.ReadOnly = true;
            rtbConsole.Size = new Size(700, 355);
            rtbConsole.TabIndex = 12;
            rtbConsole.Text = "";
            // 
            // bai1
            // 
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(740, 520);
            Controls.Add(lblN);
            Controls.Add(txtN);
            Controls.Add(btnTaoMang);
            Controls.Add(lblX);
            Controls.Add(txtX);
            Controls.Add(btnTimX);
            Controls.Add(btnTimMaxMin);
            Controls.Add(btnDemDau);
            Controls.Add(btnDuongNhoNhatAmLonNhat);
            Controls.Add(btnSapXepGiam);
            Controls.Add(btnChayTatCa);
            Controls.Add(btnXoaConsole);
            Controls.Add(rtbConsole);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "bai1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mảng một chiều Console Simulator";
            ResumeLayout(false);
            PerformLayout();
        }

        private void WriteConsole(string text)
        {
            rtbConsole.AppendText(text + Environment.NewLine);
            rtbConsole.ScrollToCaret();
        }

        private bool KiemTraMang()
        {
            if (mangHienTai == null || mangHienTai.Length == 0)
            {
                MessageBox.Show("Vui lòng phát sinh mảng ngẫu nhiên trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ================= HÀM RIÊNG BIỆT CHO TỪNG YÊU CẦU =================
        public static int[] PhatSinhMang(int n)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-100, 101);
            }
            return arr;
        }

        // a. Tìm max, min và vị trí của chúng
        public static void TimMaxMin(int[] arr, out int max, out int posMax, out int min, out int posMin)
        {
            max = arr[0];
            min = arr[0];
            posMax = 0;
            posMin = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    posMax = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    posMin = i;
                }
            }
        }

        // b. Đếm số dương, số âm, số 0
        public static void DemSo(int[] arr, out int duong, out int am, out int so0)
        {
            duong = 0;
            am = 0;
            so0 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) duong++;
                else if (arr[i] < 0) am++;
                else so0++;
            }
        }

        // c. Kiểm tra số x có thuộc mảng hay không
        public static bool KiemTraX(int[] arr, int x, out System.Collections.Generic.List<int> viTri)
        {
            viTri = new System.Collections.Generic.List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    viTri.Add(i);
                }
            }
            return viTri.Count > 0;
        }

        // d. Tìm số dương nhỏ nhất, số âm lớn nhất
        public static void TimDuongMinAmMax(int[] arr, out int? duongMin, out int? amMax)
        {
            duongMin = null;
            amMax = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    if (duongMin == null || arr[i] < duongMin)
                        duongMin = arr[i];
                }
                else if (arr[i] < 0)
                {
                    if (amMax == null || arr[i] > amMax)
                        amMax = arr[i];
                }
            }
        }

        // e. Sắp xếp lại dãy số theo chiều giảm dần
        public static int[] SapXepGiamDan(int[] arr)
        {
            int[] ketQua = (int[])arr.Clone();
            Array.Sort(ketQua);
            Array.Reverse(ketQua);
            return ketQua;
        }

        // ================= XỬ LÝ SỰ KIỆN GIAO DIỆN =================
        private void BtnTaoMang_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text.Trim(), out int n) || n <= 0 || n >= 20)
            {
                MessageBox.Show("Vui lòng nhập N nguyên dương thỏa mãn N < 20!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtN.Focus();
                return;
            }

            mangHienTai = PhatSinhMang(n);

            WriteConsole($"=================== KHỞI TẠO MẢNG MỚI (N = {n}) ===================");
            WriteConsole("Mảng ban đầu: " + string.Join(", ", mangHienTai));
        }

        private void BtnTimMaxMin_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            TimMaxMin(mangHienTai!, out int max, out int posMax, out int min, out int posMin);

            WriteConsole(">>> a. TÌM MAX, MIN VÀ VỊ TRÍ:");
            WriteConsole($" - Giá trị lớn nhất (Max): {max} tại chỉ số [{posMax}]");
            WriteConsole($" - Giá trị nhỏ nhất (Min): {min} tại chỉ số [{posMin}]");
        }

        private void BtnDemDau_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            DemSo(mangHienTai!, out int duong, out int am, out int so0);

            WriteConsole(">>> b. ĐẾM SỐ DƯƠNG, SỐ ÂM, SỐ 0:");
            WriteConsole($" - Số phần tử dương (> 0): {duong}");
            WriteConsole($" - Số phần tử âm (< 0):    {am}");
            WriteConsole($" - Số phần tử bằng 0:       {so0}");
        }

        private void BtnTimX_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            if (!int.TryParse(txtX.Text.Trim(), out int x))
            {
                MessageBox.Show("Vui lòng nhập số nguyên x hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtX.Focus();
                return;
            }

            bool tonTai = KiemTraX(mangHienTai!, x, out var viTri);

            WriteConsole($">>> c. KIỂM TRA SỐ x = {x} CÓ THUỘC MẢNG HAY KHÔNG:");
            if (tonTai)
            {
                WriteConsole($" => Số {x} CÓ thuộc mảng tại các vị trí: [{string.Join(", ", viTri)}]");
            }
            else
            {
                WriteConsole($" => Số {x} KHÔNG thuộc mảng!");
            }
        }

        private void BtnDuongNhoNhatAmLonNhat_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            TimDuongMinAmMax(mangHienTai!, out int? duongMin, out int? amMax);

            WriteConsole(">>> d. TÌM SỐ DƯƠNG NHỎ NHẤT, SỐ ÂM LỚN NHẤT:");
            if (duongMin.HasValue)
                WriteConsole($" - Số dương nhỏ nhất: {duongMin.Value}");
            else
                WriteConsole(" - Không có số dương nào trong mảng.");

            if (amMax.HasValue)
                WriteConsole($" - Số âm lớn nhất:    {amMax.Value}");
            else
                WriteConsole(" - Không có số âm nào trong mảng.");
        }

        private void BtnSapXepGiam_Click(object? sender, EventArgs e)
        {
            if (!KiemTraMang()) return;

            int[] mangSapXep = SapXepGiamDan(mangHienTai!);

            WriteConsole(">>> e. SẮP XẾP LẠI DÃY SỐ THEO CHIỀU GIẢM DẦN:");
            WriteConsole("Dãy sau khi sắp xếp giảm dần: " + string.Join(", ", mangSapXep));
        }

        private void BtnChayTatCa_Click(object? sender, EventArgs e)
        {
            BtnTaoMang_Click(sender, e);
            if (mangHienTai == null) return;
            BtnTimMaxMin_Click(sender, e);
            BtnDemDau_Click(sender, e);
            BtnTimX_Click(sender, e);
            BtnDuongNhoNhatAmLonNhat_Click(sender, e);
            BtnSapXepGiam_Click(sender, e);
        }

        private void BtnXoaConsole_Click(object? sender, EventArgs e)
        {
            rtbConsole.Clear();
        }
    }
}
