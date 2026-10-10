using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class MainForm : Form
    {
        private string tenDangNhap;
        private string hoTen;
        private string email;
        private string loginTime;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();

            if (panel1 != null)
            {
                panel1.MouseDown += Panel1_MouseDown;
                panel1.MouseMove += Panel1_MouseMove;
                panel1.MouseUp += Panel1_MouseUp;
            }
        }

        public MainForm(string user, string name, string mail, string time) : this()
        {
            tenDangNhap = user;
            hoTen = name;
            email = mail;
            loginTime = time;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterPanel();

            if (!string.IsNullOrEmpty(hoTen))
            {
                lblWelcome.Text += $" {hoTen}!";
            }
            else
            {
                lblWelcome.Text += " Khách!";
            }

            if (!string.IsNullOrEmpty(tenDangNhap))
            {
                lblUsername.Text += $" {tenDangNhap}";
            }
            else
            {
                lblUsername.Text += " (Không có)";
            }

            if (!string.IsNullOrEmpty(email))
            {
                lblEmail.Text += $" {email}";
            }
            else
            {
                lblEmail.Text += " (Chưa cập nhật)";
            }

            if (!string.IsNullOrEmpty(loginTime))
            {
                lblLoginTime.Text += $"\n{loginTime}";
            }
            else
            {
                lblLoginTime.Text += $"\n{DateTime.Now.ToString("dd/MM/yyyy HH:mm")}";
            }

            // Cấu hình phím bấm tắt (AcceptButton / CancelButton)
            if (btnLogout != null)
            {
                this.AcceptButton = btnLogout; // Nhấn Enter sẽ kích hoạt nút Đăng xuất
            }

            // Thiết lập thứ tự phím Tab chuẩn
            SetupTabOrder();
        }

        /// <summary>
        /// Cấu hình thứ tự phím Tab cho giao diện MainForm
        /// </summary>
        private void SetupTabOrder()
        {
            if (btnLogout != null)
            {
                btnLogout.TabStop = true;
                btnLogout.TabIndex = 0;
            }

            // Tắt TabStop đối với các nút điều khiển cửa sổ góc trên để tránh trôi phím Tab
            if (btnMinimize != null) btnMinimize.TabStop = false;
            if (btnMaximize != null) btnMaximize.TabStop = false;
            if (btnExit != null) btnExit.TabStop = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
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

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}