using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserManagement.DataAccess;

namespace UserManagement
{
    public partial class LoginForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public LoginForm()
        {
            InitializeComponent();

            if (panel1 != null)
            {
                panel1.MouseDown += Panel1_MouseDown;
                panel1.MouseMove += Panel1_MouseMove;
                panel1.MouseUp += Panel1_MouseUp;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterPanel();
            // Đảm bảo nhãn lỗi trống khi form vừa tải
            if (lblError != null) lblError.Text = "";
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            // 1. Reset nhãn thông báo lỗi về trạng thái rỗng ban đầu để giữ cố định bố cục
            if (lblError != null) lblError.Text = "";

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                if (lblError != null) lblError.Text = "Vui lòng nhập tên đăng nhập!";
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                if (lblError != null) lblError.Text = "Vui lòng nhập mật khẩu!";
                txtPassword.Focus();
                return;
            }

            // 2. Khóa nút và đổi nhãn thành "Đang xử lý..." theo Bước 6
            Button btn = sender as Button;
            string originalText = btn != null ? btn.Text : "Đăng nhập";
            if (btn != null)
            {
                btn.Enabled = false;
                btn.Text = "Đang xử lý...";
            }

            try
            {
                // 3. Gọi lớp UserDAO để kiểm tra dữ liệu an toàn
                UserDAO dao = new UserDAO();
                bool isValid = dao.KiemTraDangNhap(tenDangNhap, matKhau);

                // 4. Xử lý kết quả đăng nhập
                if (isValid)
                {
                    dao.CapNhatLanDangNhapCuoi(tenDangNhap);
                    // Lấy thêm Họ tên và Email từ Database để hiển thị lên MainForm
                    string hoTen = "";
                    string email = "";
                    dao.LayThongTinUser(tenDangNhap, out hoTen, out email);
                    string thoiGianDangNhap = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Truyền đầy đủ 4 tham số sang MainForm
                    MainForm main = new MainForm(tenDangNhap, hoTen, email, thoiGianDangNhap);
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Hiển thị lỗi chung theo test case
                    if (lblError != null) lblError.Text = "Sai tên đăng nhập hoặc mật khẩu!";

                    // Xóa trắng ô mật khẩu và đưa con trỏ về đó để người dùng nhập lại
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            finally
            {
                // Mở khóa nút lại sau khi xử lý xong
                if (btn != null)
                {
                    btn.Enabled = true;
                    btn.Text = originalText;
                }
            }
        }

        private void lnkRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            this.Hide();
            regForm.ShowDialog();
            this.Close();
        }

        private void CenterPanel()
        {
            if (panelCenter != null)
            {
                panelCenter.Location = new Point(
                    (this.ClientSize.Width - panelCenter.Width) / 2,
                    (this.ClientSize.Height - panelCenter.Height) / 2
                );
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
        }

        
    }
}