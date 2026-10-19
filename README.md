<div align="center">
  <h1>🚀 Ứng Dụng Quản Lý Người Dùng (User Management)</h1>
  <p>
    <i>Dự án Windows Forms phát triển bằng <b>C#</b> kết hợp cơ sở dữ liệu <b>SQL Server</b>, phục vụ cho việc quản lý tài khoản người dùng, xác thực mật khẩu an toàn và theo dõi lịch sử hoạt động đăng nhập.</i>
  </p>
</div>

---

## 🛠️ Công Nghệ & Công Cụ Sử Dụng

<div align="center">
  <a href ="https://learn.microsoft.com/vi-vn/dotnet/csharp/" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  </a>
  <a href ="https://dotnet.microsoft.com/" target="_blank" rel="noopener noreferrer">
     <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
  </a>
  <a href ="https://learn.microsoft.com/vi-vn/dotnet/desktop/winforms/" target="_blank" rel="noopener noreferrer">
     <img src="https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" />
  </a>
  <a href ="https://www.microsoft.com/vi-vn/sql-server/" target="_blank" rel="noopener noreferrer">
     <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
  </a>
  <a href ="https://git-scm.com/" target="_blank" rel="noopener noreferrer">
     <img src="https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white" alt="Git" />
  </a>
  <a href ="https://github.com/thanhnhi8769-ctrl/Baitap2-QuanLyNguoiDung.git" target="_blank" rel="noopener noreferrer">
     <img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub" />
  </a>
</div>

<br>

- **Cơ sở dữ liệu:** Cấu hình qua thư viện `Microsoft.Data.SqlClient`
- **Kiến trúc phần mềm:** Mô hình 3 lớp (Data Access Layer - DAO, BLL, UI)

---
<div align ="center">
    <img src="./anh.gif" width="100%">
</div>

---

## 📂 Cấu Trúc Thư Mục
```text
Baitap2-QuanLyNguoiDung/
│
├── database/      # Script tạo cơ sở dữ liệu và bảng dữ liệu SQL
├── docs/          # Tài liệu hướng dẫn và thiết kế giao diện
└── src/           # Mã nguồn chính của dự án C# Windows Forms
```
## 🚀 Hướng Dẫn Cài Đặt & Chạy Dự Án

### 1. Clone dự án về máy

Mở Terminal (hoặc Git Bash) và chạy các lệnh sau để tải mã nguồn về:

```bash
git clone https://github.com/thanhnhi8769-ctrl/Baitap2-QuanLyNguoiDung.git
```


### 2. Cấu hình Cơ sở Dữ liệu:

Dự án sử dụng SQL Server, cần thiết lập Database trước khi chạy code:

**Bước 1:** Mở phần mềm SQL Server Management Studio (SSMS) và kết nối vào Server máy bạn.

**Bước 2:** Mở file script SQL nằm trong thư mục database/ (của mã nguồn vừa tải) và nhấn Execute (F5) để tự động khởi tạo cơ sở dữ liệu và các bảng.

**Bước 3:** Mở file UserDAO.cs trong Visual Studio.

**Bước 4:** Cập nhật lại biến chuỗi kết nối (ChuoiKetNoi) sao cho khớp với Server SQL của bạn.
Ví dụ minh họa:
```bash
  private const string ChuoiKetNoi = @"Server=localhost,1433;Database=QuanLyNguoiDung;" + @"User Id=sa;Password=Thu031207; TrustServerCertificate = True;"
```

### 3. Chạy ứng dụng:

**Bước 1:** Mở file solution (.slnx hoặc .sln) của dự án bằng Visual Studio.

**Bước 2:** (Tùy chọn) Nhấn chuột phải vào Solution trong cửa sổ Solution Explorer chọn Restore NuGet Packages để đảm bảo các thư viện (như Microsoft.Data.SqlClient) đã được tải đầy đủ.

**Bước 3:** Nhấn tổ hợp phím Ctrl + Shift + B (hoặc vào menu Build > Build Solution) để biên dịch toàn bộ project.

**Bước 4:** Nhấn nút Start trên thanh công cụ (hoặc phím F5) để khởi chạy ứng dụng.

>[!NOTE]
>Rất nhiều trường hợp clone code C# về bị lỗi do thiếu thư viện, nên việc khôi phục các gói NuGet (như `SqlClient`) là rất cần thiết.


## 🧩 Chức năng chính
✦ Đăng ký tài khoản
<br>✦ Đăng nhập tài khoản
<br>✦ Trang chính


## 🧩 Tính năng chính
✦ Đăng ký tài khoản và kiểm tra thông tin nhập.
<br>✦ Xác thực tên đăng nhập và mật khẩu
<br>✦ Lưu mật khẩu dưới dạng băm cùng salt.
<br>✦ Hiển thị thông tin người dùng trên trang chính.
<br>✦ Cập nhập thời gian đăng nhập gần nhất khi đăng nhập thành công.
<br>✦ Đăng ký, đăng nhập và đăng xuất đều có hộp thoại xác nhận.

## ✨ Giới thiệu chức năng chính

### 👤 Đăng ký tài khoản

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
<br>✦ Lưu kết quả vào hai cột `MatKhauBam` và `Salt`, không lưu mật khẩu gốc trong câu lệnh thêm tài khoản.
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
### 🔐 Đăng nhập tài khoản

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
- [x] **Xoá thông báo cũ:** Làm trống nhãn lỗi trên giao diện.
- [x] **Tiếp nhận dữ liệu:** Lấy tên đăng nhập và mật khẩu, loại bỏ khoảng trắng ở đầu và cuối.
- [x] **Kiểm tra ô trống:** Nếu thiếu thông tin, hiển thị lỗi và đưa con trỏ đến ô cần nhập.
- [x] **Khoá nút đăng nhập:** Tạm khóa nút Đăng nhập và đổi nội dung thành **“Đang xử lý...”**.
- [x] **Tra cứu tài khoản:** Gọi `KiemTraDangNhap` để tìm `MatKhauBam` và `Salt` trong bảng `Users` theo tên đăng nhập.
- [x] **Kiểm tra mật khẩu:** Gọi `MatKhau.KiemTra` để đối chiếu mật khẩu vừa nhập với dữ liệu đã lưu.
- [x] **Nếu xác thực thành công:**
   - Gọi `CapNhatLanDangNhapCuoi` để cập nhật thời gian vào database.
   - Truy xuất họ tên và email bằng `LayThongTinUser`.
   - Tạo chuỗi thời gian đăng nhập theo định dạng `dd/MM/yyyy HH:mm`.
   - Hiển thị thông báo thành công.
   - Truyền tên đăng nhập, họ tên, email và thời gian sang trang chính.
- [x] **Nếu xác thực thất bại:**
   - Hiển thị **“Sai tên đăng nhập hoặc mật khẩu!”** bằng màu đỏ.
   - Giữ nguyên tên đăng nhập.
   - Xóa ô mật khẩu và đưa con trỏ về ô mật khẩu.
- [x] **Khôi phục nút:** Bật lại nút và khôi phục nội dung khi luồng xử lý kết thúc.

#### 💬 Thông báo kiểm tra dữ liệu đăng nhập
| Trường hợp | Thông báo |
|---|---|
| Chưa nhập tên đăng nhập | Vui lòng nhập tên đăng nhập! |
| Chưa nhập mật khẩu | Vui lòng nhập mật khẩu! |
| Xác thực không thành công | Sai tên đăng nhập hoặc mật khẩu! |
| Xác thực thành công | Đăng nhập thành công! |

#### 🕒 Theo dõi lần đăng nhập gần nhất
✦ Sau khi xác thực thành công, chương trình cập nhật trường `LanDangNhapCuoi` trong bảng `Users`.
<br>✦ Thời gian cập nhật được lấy từ `DateTime.Now` trên máy chạy ứng dụng.
<br>✦ Giá trị được ghi đè sau mỗi lần đăng nhập thành công; không lưu danh sách lịch sử của tất cả các lần đăng nhập.

---
### 🖥️ Trang chính
✦ Trang chính hiển thị thông tin của tài khoản vừa đăng nhập.

#### 📋 Thông tin hiển thị
| Nội dung | Khi có thông tin | Khi thiếu thông tin |
|---|---|---|
| **Lời chào** 'Xin chào' | Hiển thị họ tên người dùng | Hiển thị “Khách!” |
| **Tên đăng nhập** | Hiển thị tên tài khoản đang đăng nhập | Hiển thị “(Không có)” |
| **Email** | Hiển thị địa chỉ email | Hiển thị “(Chưa cập nhật)” |
| **Thời gian đăng nhập** | Hiển thị thời gian được truyền từ trang đăng nhập | Sử dụng thời gian hiện tại |

#### 📖 Cách sử dụng
1. Đăng nhập thành công để truy cập trang chính.
2. Xem lời chào và thông tin tài khoản.
3. Kiểm tra tên đăng nhập, email và thời điểm đăng nhập.
4. Nhấn **Đăng xuất** khi muốn quay về màn hình đăng nhập.
5. Trong hộp thoại xác nhận:
   - Chọn **Có** để xác nhận đăng xuất
   - Chọn **Không** để tiếp tục sử dụng trang chính.
> [!NOTE]
> Nhấn Enter trên trang chính sẽ kích hoạt nút Đăng xuất và mở hộp thoại xác nhận.

#### 🛠️ Quy trình hiển thị thông tin
- [x] Nhận bốn giá trị từ `LoginForm`: tên đăng nhập, họ tên, email và thời gian.
- [x] Lưu dữ liệu vào các biến của `MainForm`.
- [x] Khi form tải, kiểm tra từng giá trị.
- [x] Hiển thị thông tin lên các nhãn tương ứng.
- [x] Sử dụng nội dung thay thế khi thông tin bị thiếu.
> [!NOTE]
> - Trang chính sử dụng dữ liệu được truyền từ `LoginForm`, không tự truy vấn database.
> - Thời gian hiển thị là thời điểm đăng nhập hiện tại được truyền sang, không phải thời gian của phiên đăng nhập trước.

#### 🚪 Quy trình đăng xuất
1. Tạm khóa nút Đăng xuất và đổi chữ hiển thị thành **“Đang xử lý...”**.
2. Mở hộp thoại xác nhận **“Bạn có chắc chắn muốn đăng xuất không?”**.
3. Nếu chọn **Có**, ẩn trang chính và mở một màn hình đăng nhập mới.
4. Nếu chọn **Không**, giữ nguyên trang chính và khôi phục nút.
> [!TIP]
> Đăng xuất không xóa tài khoản hoặc thông tin đã lưu trong database.

---
### ⌨️ Hỗ trợ bàn phím

| Màn hình | Phím | Chức năng |
|---|---|---|
| Đăng ký | Enter | Thực hiện đăng ký |
| Đăng ký | Tab | Tên đăng nhập → Mật khẩu → Xác nhận mật khẩu → Họ tên → Email → Đăng ký → Hủy |
| Đăng nhập | Enter | Thực hiện đăng nhập |
| Đăng nhập | Tab | Tên đăng nhập → Mật khẩu → Đăng nhập → Thoát → Đăng ký |
| Trang chính | Enter | Kích hoạt Đăng xuất và mở hộp thoại xác nhận |
| Trang chính | Tab | Chuyển đến nút Đăng xuất |

---
## 🔄 Luồng xử lý và truy xuất dữ liệu

Ứng dụng thực hiện xử lý dữ liệu theo trình tự từ giao diện người dùng đến lớp truy cập dữ liệu, sau đó trả kết quả về để cập nhật giao diện.

### 📌 Quy trình xử lý

1. **Tiếp nhận dữ liệu:** Giao diện tiếp nhận thông tin do người dùng nhập và chuyển đến phương thức xử lý tương ứng.
2. **Truy xuất dữ liệu:** Lớp `UserDAO` thiết lập kết nối và thực thi câu lệnh SQL phù hợp.
3. **Xử lý kết quả:** Kết quả truy vấn được đọc và chuyển thành giá trị trả về cho thành phần gọi.
4. **Phản hồi giao diện:** Giao diện dựa trên kết quả nhận được để hiển thị thông tin hoặc thông báo trạng thái tương ứng.

### 🗄️ Các thành phần truy xuất dữ liệu

| Thành phần | Vai trò |
|---|---|
| `SqlConnection` | Thiết lập kết nối đến SQL Server. |
| `SqlCommand` | Thực thi các câu lệnh SQL. |
| `ExecuteReader()` | Đọc dữ liệu trả về từ truy vấn. |
| `ExecuteNonQuery()` | Thực thi các câu lệnh thêm hoặc cập nhật dữ liệu. |

### ♻️ Quản lý tài nguyên

Các đối tượng kết nối, câu lệnh SQL và bộ đọc dữ liệu được quản lý bằng `using` để tự động giải phóng tài nguyên sau khi sử dụng, kể cả khi xảy ra ngoại lệ.
