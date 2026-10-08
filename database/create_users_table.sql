USE QuanLyNguoiDung;

DROP TABLE IF EXISTS Users;

CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(20) NOT NULL UNIQUE,
    MatKhauBam NVARCHAR(64) NOT NULL,
    Salt NVARCHAR(32) NOT NULL,
    HoTen NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NULL,
    NgayTao DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    LanDangNhapCuoi DATETIME2 NULL
);

INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email)
VALUES ('admin', 'dummy_hash_string_for_testing', 'dummy_salt_string', N'Quan Tri Vien', 'admin@uit.edu.vn');

SELECT * FROM Users;