using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using UserManagement.DataAccess;

namespace UserManagement
{
    public partial class RegisterForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public RegisterForm()
        {
            InitializeComponent();

            if (panel1 != null)
            {
                panel1.MouseDown += Panel1_MouseDown;
                panel1.MouseMove += Panel1_MouseMove;
                panel1.MouseUp += Panel1_MouseUp;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            CenterPanel();

            if (lblErrorUsername != null) lblErrorUsername.Text = "";
            if (lblErrorPassword != null) lblErrorPassword.Text = "";
            if (lblErrorConfirm != null) lblErrorConfirm.Text = "";
            if (lblErrorHoTen != null) lblErrorHoTen.Text = "";
            if (lblErrorEmail != null) lblErrorEmail.Text = "";

            // === BỔ SUNG: Cấu hình phím Enter và Tab Order ===
            if (btnRegister != null)
            {
                this.AcceptButton = btnRegister;
            }

            // Gán sự kiện KeyDown bắt phím Enter cho các ô nhập liệu
            Control[] inputControls = { txtUsername, txtPassword, txtConfirmPassword, txtHovaTen, txtEmail };
            foreach (var ctrl in inputControls)
            {
                if (ctrl != null)
                {
                    ctrl.KeyDown -= InputBox_KeyDown;
                    ctrl.KeyDown += InputBox_KeyDown;
                }
            }

            // Thiết lập thứ tự Tab
            SetupTabOrder();
        }

        /// <summary>
        /// Cấu hình thứ tự phím Tab chuẩn UI/UX cho Form Đăng ký
        /// </summary>
        private void SetupTabOrder()
        {
            if (txtUsername != null) { txtUsername.TabStop = true; txtUsername.TabIndex = 0; }
            if (txtPassword != null) { txtPassword.TabStop = true; txtPassword.TabIndex = 1; }
            if (txtConfirmPassword != null) { txtConfirmPassword.TabStop = true; txtConfirmPassword.TabIndex = 2; }
            if (txtHovaTen != null) { txtHovaTen.TabStop = true; txtHovaTen.TabIndex = 3; }
            if (txtEmail != null) { txtEmail.TabStop = true; txtEmail.TabIndex = 4; }
            if (btnRegister != null) { btnRegister.TabStop = true; btnRegister.TabIndex = 5; }
            if (btnCancel != null) { btnCancel.TabStop = true; btnCancel.TabIndex = 6; }

            // Tắt TabStop cho các nút điều khiển cửa sổ góc trên
            if (btnMinimize != null) btnMinimize.TabStop = false;
            if (btnMaximize != null) btnMaximize.TabStop = false;
            if (btnExit != null) btnExit.TabStop = false;
        }

        /// <summary>
        /// Xử lý phím Enter khi người dùng gõ trong các ô nhập liệu
        /// </summary>
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep" của hệ thống
                btnRegister_Click_1(btnRegister, EventArgs.Empty);
            }
        }

        private void RegisterForm_Resize(object sender, EventArgs e)
        {
            CenterPanel();
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

        private void btnMaximize_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername != null ? txtUsername.Text.Trim() : "";
            string password = txtPassword != null ? txtPassword.Text.Trim() : "";
            string confirmPassword = txtConfirmPassword != null ? txtConfirmPassword.Text.Trim() : "";
            string hoten = txtHovaTen != null ? txtHovaTen.Text.Trim() : "";
            string email = txtEmail != null ? txtEmail.Text.Trim() : "";

            // Reset tất cả nhãn lỗi về rỗng
            if (lblErrorUsername != null) lblErrorUsername.Text = "";
            if (lblErrorPassword != null) lblErrorPassword.Text = "";
            if (lblErrorConfirm != null) lblErrorConfirm.Text = "";
            if (lblErrorHoTen != null) lblErrorHoTen.Text = "";
            if (lblErrorEmail != null) lblErrorEmail.Text = "";

            // 1. Kiểm tra Tên đăng nhập
            if (string.IsNullOrEmpty(username))
            {
                if (lblErrorUsername != null) lblErrorUsername.Text = "Không được để trống";
                if (txtUsername != null) txtUsername.Focus();
                return;
            }
            if (username.Length < 3 || username.Length > 20)
            {
                if (lblErrorUsername != null) lblErrorUsername.Text = "Tên đăng nhập từ 3-20 ký tự";
                if (txtUsername != null) txtUsername.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                if (lblErrorUsername != null) lblErrorUsername.Text = "Chỉ gồm chữ, số và gạch dưới";
                if (txtUsername != null) txtUsername.Focus();
                return;
            }

            // 2. Kiểm tra Mật khẩu
            if (string.IsNullOrEmpty(password))
            {
                if (lblErrorPassword != null) lblErrorPassword.Text = "Không được để trống";
                if (txtPassword != null) txtPassword.Focus();
                return;
            }
            if (password.Length < 8)
            {
                if (lblErrorPassword != null) lblErrorPassword.Text = "Mật khẩu tối thiểu 8 ký tự";
                if (txtPassword != null) txtPassword.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[a-zA-Z]") || !System.Text.RegularExpressions.Regex.IsMatch(password, @"[0-9]"))
            {
                if (lblErrorPassword != null) lblErrorPassword.Text = "Mật khẩu phải có cả chữ và số";
                if (txtPassword != null) txtPassword.Focus();
                return;
            }

            // 3. Kiểm tra Xác nhận mật khẩu
            if (password != confirmPassword)
            {
                if (lblErrorConfirm != null) lblErrorConfirm.Text = "Mật khẩu xác nhận không khớp";
                if (txtConfirmPassword != null) txtConfirmPassword.Focus();
                return;
            }

            // 4. Kiểm tra Họ và tên
            if (string.IsNullOrEmpty(hoten))
            {
                if (lblErrorHoTen != null) lblErrorHoTen.Text = "Không được để trống";
                if (txtHovaTen != null) txtHovaTen.Focus();
                return;
            }
            if (hoten.Length < 2 || hoten.Length > 50)
            {
                if (lblErrorHoTen != null) lblErrorHoTen.Text = "Họ tên từ 2-50 ký tự";
                if (txtHovaTen != null) txtHovaTen.Focus();
                return;
            }

            // 5. Kiểm tra Email
            if (string.IsNullOrEmpty(email))
            {
                if (lblErrorEmail != null) lblErrorEmail.Text = "Không được để trống";
                if (txtEmail != null) txtEmail.Focus();
                return;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email) throw new FormatException();
            }
            catch
            {
                if (lblErrorEmail != null) lblErrorEmail.Text = "Email không đúng định dạng";
                if (txtEmail != null) txtEmail.Focus();
                return;
            }

            // Xử lý nút đăng ký khi dữ liệu đã hợp lệ hoàn toàn
            Button btn = sender as Button;
            string originalText = btn != null ? btn.Text : "Đăng ký";
            if (btn != null)
            {
                btn.Enabled = false;
                btn.Text = "Đang xử lý...";
            }

            try
            {
                UserDAO dao = new UserDAO();
                bool success = dao.DangKyUser(username, password, hoten, email);

                if (success)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (lblErrorUsername != null) lblErrorUsername.Text = "Tên đăng nhập này đã tồn tại";
                    if (txtUsername != null) txtUsername.Focus();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
        }

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}