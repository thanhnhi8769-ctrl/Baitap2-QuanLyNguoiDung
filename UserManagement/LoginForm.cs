using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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

        private void btnMinimize_Click(object sender, EventArgs e)
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
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Reset các nhãn lỗi nếu có
            if (lblError != null) lblError.Text = "";
            // Nếu form của bạn có các nhãn lỗi riêng cho từng ô như lblErrorUsername / lblErrorPassword, bạn có thể reset ở đây luôn

            string username = txtTenDangNhap.Text.Trim();
            string password = txtPassword.Text.Trim();

            bool hasError = false;

            // 1. Kiểm tra xem ô Tên đăng nhập có trống không
            if (string.IsNullOrEmpty(username))
            {
                // Nếu form có nhãn lỗi riêng cạnh ô tên đăng nhập, gán text vào đó. Nếu dùng chung lblError thì tùy bạn điều chỉnh giao diện.
                // Ở đây giả sử form có các ô báo lỗi riêng hoặc dùng chung lblError:
                if (lblError != null) lblError.Text = "Tên đăng nhập không được để trống";
                txtTenDangNhap.Focus();
                hasError = true;
            }
            // 2. Kiểm tra xem ô Mật khẩu có trống không
            else if (string.IsNullOrEmpty(password))
            {
                if (lblError != null) lblError.Text = "Mật khẩu không được để trống";
                txtPassword.Focus();
                hasError = true;
            }

            if (hasError) return;

            string connectionString = @"Server=localhost,1433;Database=QuanLyNguoiDung;User Id=sa;Password=Abc12345@ ;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT TenDangNhap, MatKhauBam, Salt, HoTen, Email FROM Users WHERE TenDangNhap = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string tenDangNhapDb = reader["TenDangNhap"].ToString();
                                string storedHash = reader["MatKhauBam"].ToString();
                                string salt = reader["Salt"].ToString();
                                string hoten = reader["HoTen"].ToString();
                                string email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";

                                string enteredHash = PasswordHelper.HashPassword(password, salt);

                                if (enteredHash == storedHash)
                                {
                                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    string loginTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                                    reader.Close();

                                    try
                                    {
                                        string updateTimeQuery = "UPDATE Users SET LanDangNhapCuoi = SYSDATETIME() WHERE TenDangNhap = @Username";
                                        using (SqlCommand updateCmd = new SqlCommand(updateTimeQuery, conn))
                                        {
                                            updateCmd.Parameters.AddWithValue("@Username", username);
                                            updateCmd.ExecuteNonQuery();
                                        }
                                    }
                                    catch { }

                                    MainForm mainForm = new MainForm(tenDangNhapDb, hoten, email, loginTime);
                                    this.Hide();
                                    mainForm.ShowDialog();
                                    this.Close();
                                    return;
                                }
                            }
                        }
                    }
                }

                // Nếu không tìm thấy tên đăng nhập hoặc mật khẩu không khớp -> Hiển thị MỘT câu chung duy nhất[cite: 4]
                lblError.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
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