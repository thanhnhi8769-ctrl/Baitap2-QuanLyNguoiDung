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
                            string storedHash = reader["MatKhauBam"].ToString();
                            string salt = reader["Salt"].ToString();

                            // Băm lại mật khẩu người dùng nhập vào cùng với salt lấy từ DB
                            string enteredHash = PasswordHelper.HashPassword(matKhau, salt);

                            // So sánh chuỗi băm
                            return enteredHash == storedHash;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Bắt lỗi kỹ thuật và chuyển thành thông báo thân thiện, không làm treo chương trình
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại hệ thống!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public bool DangKyUser(string tenDangNhap, string matKhauBam, string salt, string hoTen, string email)
        {
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
    }
}