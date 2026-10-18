<div align="center">
  <h1>🚀 Ứng Dụng Quản Lý Người Dùng (User Management)</h1>
  <p>
    <i>Dự án Windows Forms phát triển bằng <b>C#</b> kết hợp cơ sở dữ liệu <b>SQL Server</b>, phục vụ cho việc quản lý tài khoản người dùng, xác thực mật khẩu an toàn và theo dõi lịch sử hoạt động đăng nhập.</i>
  </p>
</div>

---

## 🛠️ Công Nghệ & Công Cụ Sử Dụng

<div align="center">
  <a href ="https://vi.wikipedia.org/wiki/C_Sharp_(ng%C3%B4n_ng%E1%BB%AF_l%E1%BA%ADp_tr%C3%ACnh)">
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  </a>
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
  <img src="https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white" alt="Git" />
  <img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub" />
</div>

<br>

- **Cơ sở dữ liệu:** Cấu hình qua thư viện `Microsoft.Data.SqlClient`
- **Kiến trúc phần mềm:** Mô hình 3 lớp (Data Access Layer - DAO, BLL, UI)



<div align ="center">
    <img src="gemini_generated_video_cba1c5e7 (1)" autoplay loop muted playsinline width="100%">
</div>


## 🧩 Chức năng chính
✦ Đăng ký tài khoản và kiểm tra thông tin nhập.
<br>✦ Xác thực tên đăng nhập và mật khẩu
<br>✦ Lưu mật khẩu dưới dạng băm cùng salt.
<br>✦ Hiển thị thông tin người dùng trên trang chính.
<br>✦ Cập nhập thời gian đăng nhập gần nhất khi đăng nhập thành công.
<br>✦ Đăng ký, đăng nhập và đăng xuất đều có hộp thoại xác nhận.

## ✨ Tính Năng Chính

### 👤 Đăng ký tài khoản trên hệ thống

#### 📝 Thông tin đăng ký
| Thông tin | Yêu cầu |
|---|---|
| Tên đăng nhập | Từ 3-20 ký tự, chỉ gồm chữ cái, chữ số và dấu gạch dưới '_'. |
| Mật khẩu | Tối thiểu 8 ký tự, có ít nhất một chữ cái và một chữ số. |
| Xác nhận mật khẩu | Phải trùng với mật khẩu đã nhập. |
| Họ và tên | Từ 2-50 ký tự, không được để trống. |
| Email | - Không được để trống, bắt buộc nhập địa chỉ email có định dạng hợp lệ. <br>- Sử dụng `MailAddress` để phân tích địa chỉ email. Nếu không hợp lệ, chương trình hiển thị “Email không đúng định dạng” và đưa con trỏ về ô Email. <br>- Kết quả `addr.Address` phải trùng với chuỗi email đã nhập. <br>- Chương trình chưa xác minh email có tồn tại, chưa gửi mã xác nhận và chưa kiểm tra email đã được tài khoản khác sử dụng. (Phạm vi kiểm tra) |

#### 🎯 Xử lý đăng ký
- **Tạo tài khoản:** Nhập tên đăng nhập, mật khẩu, họ tên và email.
- **Kiểm tra thông tin:** Kiểm tra dữ liệu nhập và xác nhận mật khẩu.
- **Lưu tài khoản:** Lưu thông tin đăng ký vào cơ sở dữ liệu SQL Server.

#### 📖 Cách sử dụng
1. Tại màn hình đăng nhập, chọn **Đăng ký**.
2. Nhập đầy đủ các thông tin: tên đăng nhập, mật khẩu, xác nhận mật khẩu, họ tên và email.
3. Nhấn **Đăng ký** hoặc nhấn **Enter** khi nhập xong thông tin.
4. Nếu có thông báo lỗi, sửa thông tin tại ô được chỉ định rồi thử lại.
5. Sau khi đăng ký thành công, nhận thông báo **“Đăng ký tài khoản thành công!”**, nhấn **OK**.
6. Chương trình chuyển về màn hình đăng nhập.
7. Sử dụng tài khoản vừa tạo để đăng nhập.
Chọn **Huỷ** để quay lại màn hình đăng nhập.

#### 🛠️ Quy trình xử lý
- [x] **Tiếp nhận thông tin:** Đọc dữ liệu từ các ô nhập và loại bỏ khoảng trắng ở đầu, cuối bằng `Trim()`.
- [x] **Xoá lỗi cũ:** Làm trống các nhãn thông báo lỗi.
- [x] **Kiểm tra dữ liệu:** Kiểm tra lần lượt tên đăng nhập, mật khẩu, xác nhận mật khẩu, họ tên và email.
- [x] **Xử lý thông tin không hợp lệ:** Hiển thị lỗi, đưa con trỏ về ô cần sửa và dừng xử lý.
- [x] **Khoá nút:** Khi thông tin hợp lệ, tạm khóa nút Đăng ký và đổi chữ thành **“Đang xử lý...”**.
- [x] **Tạo dữ liệu mật khẩu:** Gọi `MatKhau.Tao` để tạo Salt và mật khẩu băm.
- [x] **Lưu tài khoản:** Gọi `UserDAO.DangKyUser` để thêm dữ liệu vào bảng `Users`.
- [x] **Thông báo kết quả:** Nếu lưu thành công, thông báo và chuyển về đăng nhập; nếu thất bại, hiển thị lỗi.
- [x] **Khôi phục nút:** Cho phép nhấn nút trở lại và đổi chữ “Đang xử lý...” về nội dung ban đầu khi kết thúc xử lý.

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

