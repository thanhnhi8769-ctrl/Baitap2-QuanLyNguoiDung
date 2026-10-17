<div align="center">
  <h1>🚀 Ứng Dụng Quản Lý Người Dùng (User Management)</h1>
  <p>
    <i>Dự án Windows Forms phát triển bằng <b>C#</b> kết hợp cơ sở dữ liệu <b>SQL Server</b>, phục vụ cho việc quản lý tài khoản người dùng, xác thực mật khẩu an toàn và theo dõi lịch sử hoạt động đăng nhập.</i>
  </p>
</div>

---

## 🛠️ Công Nghệ & Công Cụ Sử Dụng

<div align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
  <img src="https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white" alt="Git" />
  <img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub" />
</div>

<br>

- **Cơ sở dữ liệu:** Cấu hình qua thư viện `Microsoft.Data.SqlClient`
- **Kiến trúc phần mềm:** Mô hình 3 lớp (Data Access Layer - DAO, BLL, UI)

---

## ✨ Tính Năng Chính

### 🔐 1. Đăng nhập hệ thống
- [x] **Xác thực an toàn:** Mật khẩu được băm (hashing) bảo mật bằng cách sử dụng **Salt** kết hợp thuật toán **PBKDF2**.
- [x] **Lịch sử truy cập:** Tự động cập nhật trường `LanDangNhapCuoi` (thời gian đăng nhập cuối cùng) vào cơ sở dữ liệu khi đăng nhập thành công.
- [x] **Trải nghiệm người dùng (UX) mượt mà:**
  - Khóa nút bấm (disable button) trong quá trình xử lý đăng nhập để tránh gửi yêu cầu liên tục.
  - Tự động xóa trắng ô nhập mật khẩu và đưa con trỏ chuột (Focus) về lại ô tài khoản nếu nhập sai.

### 👤 2. Quản lý tài khoản *(Thêm các tính năng khác của bạn vào đây)*
- [ ] Thêm, sửa, xóa người dùng.
- [ ] Phân quyền người dùng (Admin, User).
