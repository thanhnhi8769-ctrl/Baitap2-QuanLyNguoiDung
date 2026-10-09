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
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            CenterPanel();
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
            // 1. Lấy dữ liệu từ các ô nhập trên form đăng ký của bạn
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();
            string hoTen = txtHovaTen.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin bắt buộc!");
                return;
            }

            // (Lưu ý: Ở bài tập của bạn nếu có phần tạo Salt và băm mật khẩu thì gọi hàm băm ở đây, 
            // còn nếu lưu trực tiếp thì bạn truyền biến mật khẩu vào, ví dụ tạm thời dùng chuỗi giả lập):
            string saltBaoMat = "dummy_salt_string";
            string matKhauBamBaoMat = matKhau; // (Thay bằng biến mật khẩu đã băm của bạn nếu có)

            // 2. Gọi hàm đăng ký an toàn từ UserDAO
            UserDAO dao = new UserDAO();
            bool success = dao.DangKyUser(tenDangNhap, matKhauBamBaoMat, saltBaoMat, hoTen, email);

            // 3. Thông báo kết quả
            if (success)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form đăng ký sau khi thành công
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại! Tên đăng nhập có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Reset các nhãn lỗi
            if (lblErrorUsername != null) lblErrorUsername.Text = "";
            if (lblErrorPassword != null) lblErrorPassword.Text = "";
            if (lblErrorConfirm != null) lblErrorConfirm.Text = "";
            if (lblErrorHoTen != null) lblErrorHoTen.Text = "";
            if (lblErrorEmail != null) lblErrorEmail.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string hoten = txtHovaTen.Text.Trim();
            email = txtEmail.Text.Trim();
            bool hasError = false;

            // 1. Kiểm tra Tên đăng nhập (3-20 ký tự, chỉ chữ, số, gạch dưới)[cite: 5]
            if (string.IsNullOrEmpty(username))
            {
                if (lblErrorUsername != null) lblErrorUsername.Text = "Không được để trống";
                txtUsername.Focus();
                hasError = true;
            }
            else if (username.Length < 3 || username.Length > 20)
            {
                if (lblErrorUsername != null) lblErrorUsername.Text = "3-20 ký tự";
                txtUsername.Focus();
                hasError = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                if (lblErrorUsername != null) lblErrorUsername.Text = "Chỉ gồm chữ, số, gạch dưới";
                txtUsername.Focus();
                hasError = true;
            }

            // 2. Kiểm tra Mật khẩu (Tối thiểu 8 ký tự, có chữ và số)[cite: 5]
            if (string.IsNullOrEmpty(password))
            {
                if (lblErrorPassword != null) lblErrorPassword.Text = "Không được để trống";
                if (!hasError) txtPassword.Focus();
                hasError = true;
            }
            else if (password.Length < 8)
            {
                if (lblErrorPassword != null) lblErrorPassword.Text = "Tối thiểu 8 ký tự";
                if (!hasError) txtPassword.Focus();
                hasError = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[a-zA-Z]") || !System.Text.RegularExpressions.Regex.IsMatch(password, @"[0-9]"))
            {
                if (lblErrorPassword != null) lblErrorPassword.Text = "Phải có cả chữ và số";
                if (!hasError) txtPassword.Focus();
                hasError = true;
            }

            // 3. Kiểm tra Xác nhận mật khẩu[cite: 5]
            if (password != confirmPassword)
            {
                if (lblErrorConfirm != null) lblErrorConfirm.Text = "Không khớp";
                if (!hasError) txtConfirmPassword.Focus();
                hasError = true;
            }

            // 4. Kiểm tra Họ và tên (2-50 ký tự)[cite: 5]
            if (string.IsNullOrEmpty(hoten))
            {
                if (lblErrorHoTen != null) lblErrorHoTen.Text = "Không được để trống";
                if (!hasError) txtHovaTen.Focus();
                hasError = true;
            }
            else if (hoten.Length < 2 || hoten.Length > 50)
            {
                if (lblErrorHoTen != null) lblErrorHoTen.Text = "2-50 ký tự";
                if (!hasError) txtHovaTen.Focus();
                hasError = true;
            }

            // 5. Kiểm tra Email[cite: 5, 6]
            if (string.IsNullOrEmpty(email))
            {
                if (lblErrorEmail != null) lblErrorEmail.Text = "Không được để trống";
                if (!hasError) txtEmail.Focus();
                hasError = true;
            }
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    if (addr.Address != email)
                    {
                        throw new FormatException();
                    }
                }
                catch
                {
                    if (lblErrorEmail != null) lblErrorEmail.Text = "Không đúng định dạng";
                    if (!hasError) txtEmail.Focus();
                    hasError = true;
                }
            }

            if (hasError) return;

            string connectionString = @"Server=localhost,1433;Database=QuanLyNguoiDung;User Id=sa;Password=Abc12345@ ;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra trùng tên đăng nhập trong CSDL
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE TenDangNhap = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int existingCount = (int)checkCmd.ExecuteScalar();

                        if (existingCount > 0)
                        {
                            if (lblErrorUsername != null)
                            {
                                lblErrorUsername.Text = "Tên này đã có người dùng";
                            }
                            txtUsername.Focus();
                            return; // Giữ nguyên dữ liệu đã gõ trên form
                        }
                    }

                    // Băm mật khẩu kèm Salt trước khi lưu[cite: 3]
                    string salt = PasswordHelper.GenerateSalt();
                    string hashedPassword = PasswordHelper.HashPassword(password, salt);

                    string insertQuery = "INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email) VALUES (@Username, @PasswordHash, @Salt, @HoTen, @Email)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        insertCmd.Parameters.AddWithValue("@Salt", salt);
                        insertCmd.Parameters.AddWithValue("@HoTen", hoten);
                        insertCmd.Parameters.AddWithValue("@Email", email);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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