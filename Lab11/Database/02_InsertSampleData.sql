/* COMP1019 - Buoi 10: EduManagerDB
   Tao database va 6 bang.
   Script nay KHONG xoa database neu da ton tai.
*/
IF DB_ID(N'EduManagerDB') IS NULL
BEGIN
    CREATE DATABASE EduManagerDB;
END;
GO

USE EduManagerDB;
GO

IF OBJECT_ID(N'dbo.KHOA', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KHOA
    (
        MaKhoa  VARCHAR(10)    NOT NULL,
        TenKhoa NVARCHAR(100)  NOT NULL,
        CONSTRAINT PK_KHOA PRIMARY KEY (MaKhoa),
        CONSTRAINT UQ_KHOA_TenKhoa UNIQUE (TenKhoa)
    );
END;
GO

IF OBJECT_ID(N'dbo.LOP', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.LOP
    (
        MaLop  VARCHAR(10)    NOT NULL,
        TenLop NVARCHAR(100)  NOT NULL,
        MaKhoa VARCHAR(10)    NULL,
        CONSTRAINT PK_LOP PRIMARY KEY (MaLop),
        CONSTRAINT FK_LOP_KHOA FOREIGN KEY (MaKhoa)
            REFERENCES dbo.KHOA(MaKhoa)
    );
END;
GO

IF OBJECT_ID(N'dbo.SINHVIEN', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.SINHVIEN
    (
        MaSV     VARCHAR(10)    NOT NULL,
        HoTen    NVARCHAR(100)  NOT NULL,
        NgaySinh DATE           NULL,
        GioiTinh NVARCHAR(3)    NOT NULL,
        MaLop    VARCHAR(10)    NOT NULL,
        CONSTRAINT PK_SINHVIEN PRIMARY KEY (MaSV),
        CONSTRAINT FK_SINHVIEN_LOP FOREIGN KEY (MaLop)
            REFERENCES dbo.LOP(MaLop),
        CONSTRAINT CK_SINHVIEN_GioiTinh CHECK (GioiTinh IN (N'Nam', N'Nữ'))
    );
END;
GO

IF OBJECT_ID(N'dbo.MONHOC', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.MONHOC
    (
        MaMH      VARCHAR(10)    NOT NULL,
        TenMH     NVARCHAR(100)  NOT NULL,
        SoTinChi  INT            NOT NULL,
        CONSTRAINT PK_MONHOC PRIMARY KEY (MaMH),
        CONSTRAINT CK_MONHOC_SoTinChi CHECK (SoTinChi > 0)
    );
END;
GO

IF OBJECT_ID(N'dbo.KETQUA', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KETQUA
    (
        MaSV VARCHAR(10) NOT NULL,
        MaMH VARCHAR(10) NOT NULL,
        Diem DECIMAL(4,2) NOT NULL,
        CONSTRAINT PK_KETQUA PRIMARY KEY (MaSV, MaMH),
        CONSTRAINT FK_KETQUA_SINHVIEN FOREIGN KEY (MaSV)
            REFERENCES dbo.SINHVIEN(MaSV),
        CONSTRAINT FK_KETQUA_MONHOC FOREIGN KEY (MaMH)
            REFERENCES dbo.MONHOC(MaMH),
        CONSTRAINT CK_KETQUA_Diem CHECK (Diem >= 0 AND Diem <= 10)
    );
END;
GO

IF OBJECT_ID(N'dbo.TAIKHOAN', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TAIKHOAN
    (
        TenDangNhap VARCHAR(50)    NOT NULL,
        MatKhau     VARCHAR(255)   NOT NULL,
        VaiTro      NVARCHAR(30)   NOT NULL,
        CONSTRAINT PK_TAIKHOAN PRIMARY KEY (TenDangNhap)
    );
END;
GO
