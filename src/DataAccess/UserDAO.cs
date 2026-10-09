using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace UserManagement.DataAccess
{
    public class UserDAO
    {
        private const string ChuoiKetNoi =
     @"Server=localhost,1433;Database=QuanLyNguoiDung;" +
     @"User Id=sa;Password=Abc12345@;TrustServerCertificate=True;";

        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            const string sql = "SELECT MatKhauBam, Salt FROM Users WHERE TenDangNhap = @ten";

            try
            {
                using (var conn = new SqlConnection(ChuoiKetNoi))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["MatKhauBam"]?.ToString() ?? string.Empty;
                            string salt = reader["Salt"]?.ToString() ?? string.Empty;

                            // Đối chiếu mật khẩu bằng thuật toán PBKDF2
                            return MatKhau.KiemTra(matKhau, salt, storedHash);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại hệ thống!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public bool LayThongTinUser(string tenDangNhap, out string hoTen, out string email)
        {
            hoTen = string.Empty;
            email = string.Empty;
            const string sql = "SELECT HoTen, Email FROM Users WHERE TenDangNhap = @ten";

            try
            {
                using (var conn = new SqlConnection(ChuoiKetNoi))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hoTen = reader["HoTen"]?.ToString() ?? string.Empty;
                            email = reader["Email"]?.ToString() ?? string.Empty;
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Bắt lỗi ngầm
            }
            return false;
        }

        public bool DangKyUser(string tenDangNhap, string matKhauThuan, string hoTen, string email)
        {
            var (salt, matKhauBam) = MatKhau.Tao(matKhauThuan);

            const string sql = @"INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email) 
                                 VALUES (@ten, @mkBam, @salt, @hoTen, @email)";

            try
            {
                using var conn = new SqlConnection(ChuoiKetNoi);
                using var cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
                cmd.Parameters.Add("@mkBam", SqlDbType.NVarChar, 64).Value = matKhauBam;
                cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50).Value = hoTen;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = (object)email ?? DBNull.Value;

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng ký tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void CapNhatLanDangNhapCuoi(string tenDangNhap)
        {
            string sql = "UPDATE Users SET LanDangNhapCuoi = @thoiGian WHERE TenDangNhap = @ten";

            using (var conn = new SqlConnection(ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@thoiGian", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = tenDangNhap;

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                // Bật dòng này lên để xem khi đăng nhập xong nó có báo cập nhật thành công không
            }
        }
    }
}