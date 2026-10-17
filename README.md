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
### 🔐 Đăng nhập hệ thống

### 🔐 1. Đăng nhập hệ thống
- [x] **Xác thực an toàn:** Mật khẩu được băm (hashing) bảo mật bằng cách sử dụng **Salt** kết hợp thuật toán **PBKDF2**.
- [x] **Lịch sử truy cập:** Tự động cập nhật trường `LanDangNhapCuoi` (thời gian đăng nhập cuối cùng) vào cơ sở dữ liệu khi đăng nhập thành công.
- [x] **Trải nghiệm người dùng (UX) mượt mà:**
  - Khóa nút bấm (disable button) trong quá trình xử lý đăng nhập để tránh gửi yêu cầu liên tục.
  - Tự động xóa trắng ô nhập mật khẩu và đưa con trỏ chuột (Focus) về lại ô tài khoản nếu nhập sai.

### 👤 2. Quản lý tài khoản *(Thêm các tính năng khác của bạn vào đây)*
- [ ] Thêm, sửa, xóa người dùng.
- [ ] Phân quyền người dùng (Admin, User).

> [!IMPORTANT]
> - **Xác thực tài khoản** với mật khẩu được băm an toàn (sử dụng Salt và PBKDF2).
> - **Tự động cập nhật** thời gian đăng nhập cuối (LanDangNhapCuoi) vào cơ sở dữ liệu khi đăng nhập thành công.
> - **Xử lý giao diện mượt mà:** Khóa nút khi đang xử lý, tự động xóa trắng ô mật khẩu và đưa con trỏ chuột về ô tài khoản nếu nhập sai.
> [!NOTE]
> 🔵 **Ghi chú:** Khối này sẽ có viền và màu nền xanh dương nhạt. Rất hợp để viết lời giới thiệu.

> [!TIP]
> 🟢 **Mẹo:** Khối này có màu xanh lá cây.

> [!IMPORTANT]
> 🟣 **Quan trọng:** Khối này màu tím, dùng để nhấn mạnh tính năng cốt lõi.

> [!WARNING]
> 🟡 **Cảnh báo:** Khối này màu vàng, thu hút sự chú ý.

> [!CAUTION]
> 🔴 **Lưu ý:** Khối này màu đỏ.

<div align="center">
  <img src="D:\NT106\lab2\git.jpg" alt="Banner Dự Án" width="100%" />
</div>
