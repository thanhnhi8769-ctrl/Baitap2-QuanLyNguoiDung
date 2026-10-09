Ứng Dụng Quản Lý Người Dùng (User Management)

Dự án Windows Forms phát triển bằng C# kết hợp cơ sở dữ liệu SQL Server, phục vụ cho việc quản lý tài khoản người dùng, xác thực mật khẩu an toàn và theo dõi lịch sử hoạt động đăng nhập.

🛠️ Công Nghệ & Công Cụ Sử Dụng

Ngôn ngữ: C# (.NET Framework / .NET Core)

Giao diện: Windows Forms

Cơ sở dữ liệu: SQL Server (Microsoft.Data.SqlClient)

Kiến trúc: Mô hình 3 lớp (Data Access Layer - DAO, UI)

Quản lý phiên bản: Git & GitHub

✨ Tính Năng Chính

Đăng nhập hệ thống:

Xác thực tài khoản với mật khẩu được băm an toàn (sử dụng Salt và PBKDF2).

Tự động cập nhật thời gian đăng nhập cuối (LanDangNhapCuoi) vào cơ sở dữ liệu khi đăng nhập thành công.

Xử lý giao diện mượt mà: khóa nút khi đang xử lý, tự động xóa trắng ô mật khẩu và đưa con trỏ chuột (Focus) về ô nhập liệu khi thông tin đăng nhập không chính xác.

Đăng ký tài khoản mới:

Kiểm tra định dạng dữ liệu đầu vào chi tiết (độ dài tên đăng nhập, độ phức tạp của mật khẩu, khớp mật khẩu xác nhận, định dạng email chuẩn).

Thông báo lỗi trực quan ngay tại từng trường nhập liệu mà không làm dịch chuyển bố cục form.

Quản lý giao diện & Trải nghiệm (UI/UX):

Thiết kế cửa sổ tùy chỉnh (không viền truyền thống, hỗ trợ kéo thả, thu nhỏ/phóng to/thoát linh hoạt).

Cố định nhãn thông báo lỗi ở trạng thái rỗng để giữ ổn định bố cục giao diện.

📂 Cấu Trúc Thư Mục

Baitap2-QuanLyNguoiDung/
│
├── database/          # Script tạo cơ sở dữ liệu và bảng dữ liệu SQL
├── docs/              # Tài liệu hướng dẫn và thiết kế giao diện
└── src/               # Mã nguồn chính của dự án C# Windows Forms


🚀 Hướng Dẫn Cài Đặt & Chạy Dự Án

Clone dự án về máy:

git clone https://github.com/thanhnhi8769-ctrl/Baitap2-QuanLyNguoiDung.git


Cấu hình Cơ sở Dữ liệu:

Mở SQL Server Management Studio (SSMS).

Chạy script tạo cơ sở dữ liệu nằm trong thư mục database/.

Cập nhật chuỗi kết nối (ChuoiKetNoi) trong file UserDAO.cs sao cho khớp với thông tin server SQL của bạn.

Chạy ứng dụng:

Mở file solution (.sln) bằng Visual Studio.

Nhấn Ctrl + Shift + B để build lại toàn bộ project.

Nhấn nút Start (hoặc F5) để chạy ứng dụng.
