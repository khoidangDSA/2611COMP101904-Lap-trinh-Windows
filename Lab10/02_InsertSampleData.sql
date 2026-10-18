USE EduManagerDB;
GO

INSERT INTO KHOA (MaKhoa, TenKhoa, DienThoai) VALUES 
('FIT', N'Khoa Công nghệ Thông tin', '0281234567'), 
('MATH', N'Khoa Toán - Tin học', '0287654321'); 

INSERT INTO LOP (MaLop, TenLop, MaKhoa) VALUES 
('CNTT01', N'Công nghệ thông tin 01', 'FIT'), 
('CNTT02', N'Công nghệ thông tin 02', 'FIT'), 
('SPTIN01', N'Sư phạm Tin học 01', 'MATH'); 

INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, GioiTinh, MaLop) VALUES 
('SV001', N'Hoàng Khánh Minh', '2005-12-10', N'Nam', 'CNTT01'), 
('SV002', N'Trần Hữu Minh Thư', '2005-08-23', N'Nữ', 'CNTT01'), 
('SV003', N'Đặng Ngọc Huyền', '2004-01-02', N'Nữ', 'CNTT02'), 
('SV004', N'Nguyễn Quỳnh Anh', '2005-03-09', N'Nữ', 'CNTT02'), 
('SV005', N'Hoàng Lam Anh', '2005-05-22', N'Nữ', 'SPTIN01'), 
('SV006', N'Nguyễn Đình Bảo', '2004-11-08', N'Nam', 'SPTIN01'),
('SV007', N'Lê Văn Thắng', '2005-07-15', N'Nam', 'CNTT01'); -- Sinh viên này KHÔNG nhập điểm

INSERT INTO MONHOC (MaMH, TenMH, SoTinChi) VALUES 
('COMP1019', N'Lập trình trên Windows', 3), 
('COMP1800', N'Cơ sở toán trong CNTT', 4), 
('COMP1020', N'Cơ sở dữ liệu', 3), 
('COMP1044', N'Nhập môn Công nghệ phần mềm', 3); 

INSERT INTO KETQUA (MaSV, MaMH, Diem) VALUES 
('SV001', 'COMP1800', 8.5), 
('SV001', 'COMP1020', 7.5), 
('SV002', 'COMP1019', 9.0), 
('SV002', 'COMP1020', 8.0), 
('SV003', 'COMP1019', 6.5), 
('SV004', 'COMP1019', 7.0), 
('SV005', 'COMP1800', 8.0), 
('SV006', 'COMP1044', 7.8); 

INSERT INTO TAIKHOAN (TenDangNhap, MatKhau, HoTen, VaiTro) VALUES 
('admin', '123456', N'Quản trị viên', 'Admin'), 
('gv01', '123456', N'Giảng viên demo', 'User');