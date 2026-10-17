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

        // Cho phép nhận trạng thái WindowState từ Form trước đó
        public LoginForm(FormWindowState state = FormWindowState.Normal)
        {
            InitializeComponent();
            this.WindowState = state;

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
            txtTenDangNhap.TabStop = true;
            txtPassword.TabStop = true;
            btnDangNhap.TabStop = true;
            btnThoat.TabStop = true;

            // Gán thứ tự TabIndex chuẩn
            txtTenDangNhap.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnDangNhap.TabIndex = 2;
            btnThoat.TabIndex = 3;
            lnkRegister.TabIndex = 4;

            // Đảm bảo nhãn lỗi trống khi form vừa tải
            if (lblError != null) lblError.Text = "";

            // 1. Cấu hình phím Enter thực hiện thao tác đăng nhập
            if (btnDangNhap != null)
            {
                this.AcceptButton = btnDangNhap;
            }

            // Gán sự kiện KeyDown cho các ô nhập liệu
            if (txtTenDangNhap != null)
            {
                txtTenDangNhap.KeyDown -= InputBox_KeyDown;
                txtTenDangNhap.KeyDown += InputBox_KeyDown;
            }

            if (txtPassword != null)
            {
                txtPassword.KeyDown -= InputBox_KeyDown;
                txtPassword.KeyDown += InputBox_KeyDown;
            }

            // 2. Cấu hình thứ tự phím Tab
            SetupTabOrder();
        }

        private void SetupTabOrder()
        {
            if (txtTenDangNhap != null)
            {
                txtTenDangNhap.TabStop = true;
                txtTenDangNhap.TabIndex = 0;
            }

            if (txtPassword != null)
            {
                txtPassword.TabStop = true;
                txtPassword.TabIndex = 1;
            }

            if (btnDangNhap != null)
            {
                btnDangNhap.TabStop = true;
                btnDangNhap.TabIndex = 2;
            }

            if (btnThoat != null)
            {
                btnThoat.TabStop = true;
                btnThoat.TabIndex = 3;
            }

            if (lnkRegister != null)
            {
                lnkRegister.TabStop = true;
                lnkRegister.TabIndex = 4;
            }

            if (btnMinimize != null) btnMinimize.TabStop = false;
            if (btnMaximize != null) btnMaximize.TabStop = false;
            if (btnExit != null) btnExit.TabStop = false;
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnDangNhap_Click_1(btnDangNhap, EventArgs.Empty);
            }
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
            if (dragging && this.WindowState == FormWindowState.Normal)
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
            CenterPanel();
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (lblError != null) lblError.Text = "";

            string tenDangNhap = txtTenDangNhap != null ? txtTenDangNhap.Text.Trim() : "";
            string matKhau = txtPassword != null ? txtPassword.Text.Trim() : "";

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                if (lblError != null) lblError.Text = "Vui lòng nhập tên đăng nhập!";
                if (txtTenDangNhap != null) txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                if (lblError != null) lblError.Text = "Vui lòng nhập mật khẩu!";
                if (txtPassword != null) txtPassword.Focus();
                return;
            }

            Button btn = sender as Button;
            string originalText = btn != null ? btn.Text : "Đăng nhập";
            if (btn != null)
            {
                btn.Enabled = false;
                btn.Text = "Đang xử lý...";
            }

            try
            {
                UserDAO dao = new UserDAO();
                bool isValid = dao.KiemTraDangNhap(tenDangNhap, matKhau);

                if (isValid)
                {
                    dao.CapNhatLanDangNhapCuoi(tenDangNhap);
                    string hoTen = "";
                    string email = "";
                    dao.LayThongTinUser(tenDangNhap, out hoTen, out email);
                    string thoiGianDangNhap = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Truyền WindowState hiện tại sang MainForm
                    MainForm main = new MainForm(tenDangNhap, hoTen, email, thoiGianDangNhap, this.WindowState);
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
<<<<<<< HEAD
                    // Xóa ô mật khẩu trước
=======
                    if (lblError != null) lblError.Text = "Sai tên đăng nhập hoặc mật khẩu!";
>>>>>>> 20a24a6 (update)
                    if (txtPassword != null)
                    {
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }

                     // Hiển thị thông báo lỗi màu đỏ sau khi xóa mật khẩu
                     if (lblError != null)
                     {
                         lblError.Text = "Sai tên đăng nhập hoặc mật khẩu!";
                         lblError.ForeColor = Color.Red;
                         lblError.Visible = true;
                         lblError.BringToFront();
                    }
                }
            }
            finally
            {
                if (btn != null)
                {
                    btn.Enabled = true;
                    btn.Text = originalText;
                }
            }
        }

        private void lnkRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Truyền WindowState hiện tại sang RegisterForm
            RegisterForm regForm = new RegisterForm(this.WindowState);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (lblError != null) lblError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (lblError != null) lblError.Text = "";
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            if (lblError != null) lblError.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (lblError != null) lblError.Text = "";
        }
    }
}
