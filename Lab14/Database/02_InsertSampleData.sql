USE EduManagerDB_V2;
GO

INSERT INTO dbo.MONHOC
    (MaMonHoc, TenMonHoc, SoTinChi, TrangThai)
VALUES
    (N'COMP1019', N'Lập trình trên Windows', 3, 1),
    (N'COMP1802', N'Thiết kế web', 2, 1),
    (N'COMP1018', N'Cơ sở dữ liệu', 3, 1),
    (N'COMP1016', N'Cấu trúc dữ liệu', 3, 1),
    (N'COMP1800', N'Cơ sở Toán trong Công nghệ thông tin', 4, 1),
    (N'COMP101105', N'Kiến trúc máy tính và hợp ngữ', 3, 1),
    (N'2121COMP', N'Lập trình hướng đối tượng', 3, 1),
    (N'2611COMP', N'Xác suất thống kê và ứng dụng', 3, 0);
GO

SELECT * FROM dbo.MONHOC;
GO