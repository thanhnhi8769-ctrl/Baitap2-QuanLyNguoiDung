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

### 👤 Đăng ký tài khoản trên ứng dụng

#### 📝 Thông tin đăng ký
| Thông tin | Yêu cầu |
|---|---|
| Tên đăng nhập | Từ 3-20 ký tự, chỉ gồm chữ cái, chữ số và dấu gạch dưới '_'. |
| Mật khẩu | Tối thiểu 8 ký tự, có ít nhất một chữ cái và một chữ số. |
| Xác nhận mật khẩu | Phải trùng với mật khẩu đã nhập. |
| Họ và tên | Từ 2-50 ký tự, không được để trống. |
| Email | - Không được để trống, bắt buộc nhập địa chỉ email có định dạng hợp lệ. <br>- Sử dụng `MailAddress` để phân tích địa chỉ email. Nếu không hợp lệ, chương trình hiển thị “Email không đúng định dạng” và đưa con trỏ về ô Email. <br>- Kết quả `addr.Address` phải trùng với chuỗi email đã nhập. <br>- Chương trình chưa xác minh email có tồn tại, chưa gửi mã xác nhận và chưa kiểm tra email đã được tài khoản khác sử dụng. (Phạm vi kiểm tra) |

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

#### 🛡️ Lưu trữ mật khẩu
✦ Gọi `MatKhau.Tao` để tạo Salt và mật khẩu băm.
✦ Lưu kết quả vào hai cột `MatKhauBam` và `Salt`, không lưu mật khẩu gốc trong câu lệnh thêm tài khoản.
<br>✦ Xác nhận mật khẩu chỉ dùng để kiểm tra trên giao diện, không được lưu vào cơ sở dữ liệu.
<br>✦ Kiểm tra email chỉ xác định định dạng, không xác minh hộp thư có tồn tại.
> [!IMPORTANT]
> - Mỗi lần nhấn Đăng ký, chương trình hiển thị lỗi đầu tiên phát hiện được.
> - Khoảng trắng ở đầu và cuối các trường, bao gồm mật khẩu, được loại bỏ trước khi xử lý.
> - Email chưa kiểm tra trùng

#### 💬 Thông báo kiểm tra dữ liệu
| Trường hợp | Thông báo |
|---|---|
| Thiếu thông tin bắt buộc | Không được để trống |
| Tên đăng nhập quá ngắn hoặc quá dài | Tên đăng nhập từ 3-20 ký tự |
| Tên đăng nhập có ký tự không được phép | Chỉ gồm chữ, số và gạch dưới |
| Mật khẩu dưới 8 ký tự | Mật khẩu tối thiểu 8 ký tự |
| Mật khẩu thiếu chữ hoặc số | Mật khẩu phải có cả chữ và số |
| Xác nhận mật khẩu khác mật khẩu | Mật khẩu xác nhận không khớp |
| Họ tên không nằm trong khoảng quy định | Họ tên từ 2-50 ký tự |
| Email không vượt qua kiểm tra | Email không đúng định dạng |

---
### 👤 Đăng nhập tài khoản trên ứng dụng
#### 📝 Thông tin đăng nhập
| Thông tin | Yêu cầu |
|---|---|
| **Tên đăng nhập** | - Không được để trống. <br> - Sử dụng tên tài khoản đã đăng ký. |
| **Mật khẩu** | - Không được để trống. <br> - Phải khớp với mật khẩu của tài khoản. |

#### 📖 Cách sử dụng
1. Mở màn hình đăng nhập.
2. Nhập tên đăng nhập và mật khẩu đã đăng ký.
3. Nhấn **Đăng nhập** hoặc nhấn **Enter**.
4. Khi xuất hiện thông báo **“Đăng nhập thành công!”**, nhấn **OK** để vào trang chính.
5. Nếu thông tin không chính xác, nhập lại Tên đăng nhập hoặc mật khẩu và thử lại.
Chọn **Đăng ký** nếu chưa có tài khoản.
Chọn **Thoát** để đóng ứng dụng.

#### 🛠️ Quy trình xử lý
1. **Xoá thông báo cũ:** Làm trống nhãn lỗi trên giao diện.
2. **Tiếp nhận dữ liệu:** Lấy tên đăng nhập và mật khẩu, loại bỏ khoảng trắng ở đầu và cuối.
3. **Kiểm tra ô trống:** Nếu thiếu thông tin, hiển thị lỗi và đưa con trỏ đến ô cần nhập.
4. **Khoá nút đăng nhập:** Tạm khóa nút Đăng nhập và đổi nội dung thành **“Đang xử lý...”**.
5. **Tra cứu tài khoản:** Gọi `KiemTraDangNhap` để tìm `MatKhauBam` và `Salt` trong bảng `Users` theo tên đăng nhập.
6. **Kiểm tra mật khẩu:** Gọi `MatKhau.KiemTra` để đối chiếu mật khẩu vừa nhập với dữ liệu đã lưu.
7. **Nếu xác thực thành công:**
   - Gọi `CapNhatLanDangNhapCuoi` để cập nhật thời gian vào database.
   - Truy xuất họ tên và email bằng `LayThongTinUser`.
   - Tạo chuỗi thời gian đăng nhập theo định dạng `dd/MM/yyyy HH:mm`.
   - Hiển thị thông báo thành công.
   - Truyền tên đăng nhập, họ tên, email và thời gian sang trang chính.
8. **Nếu xác thực thất bại:**
   - Hiển thị **“Sai tên đăng nhập hoặc mật khẩu!”** bằng màu đỏ.
   - Giữ nguyên tên đăng nhập.
   - Xóa ô mật khẩu và đưa con trỏ về ô mật khẩu.
9. **Khôi phục nút:** Bật lại nút và khôi phục nội dung khi luồng xử lý kết thúc.

#### 💬 Thông báo kiểm tra dữ liệu đăng nhập
| Trường hợp | Thông báo |
|---|---|
| Chưa nhập tên đăng nhập | Vui lòng nhập tên đăng nhập! |
| Chưa nhập mật khẩu | Vui lòng nhập mật khẩu! |
| Xác thực không thành công | Sai tên đăng nhập hoặc mật khẩu! |
| Xác thực thành công | Đăng nhập thành công! |



---
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

