====================================================================
DỰ ÁN: QUẢN LÝ LỚP HỌC (CLASS MANAGER) - MÔ HÌNH MVP
Học phần: COMP1019 - Buổi 15 (Lab 15)
====================================================================

1. MÔ TẢ HỆ THỐNG:
- Module quản lý lớp học áp dụng kiến trúc Model-View-Presenter (MVP).
- Phân tách rõ ràng giao diện (FrmLop), xử lý nghiệp vụ (LopPresenter) và lưu trữ dữ liệu (LopRepository).

2. YÊU CẦU CẤU HÌNH & MÔI TRƯỜNG:
- IDE: Visual Studio 2026 (.NET 10.0 Windows Desktop SDK).
- DBMS: Microsoft SQL Server 2022 chạy trong Docker Desktop Container.
- Công cụ quản lý CSDL: SQL Server Management Studio 22 (SSMS).
- Cơ sở dữ liệu: EduManagerDB (Bảng LOP, SINHVIEN).
- Chuỗi kết nối: Server=localhost,1433;Database=EduManagerDB;User Id=sa;Password=YourPassword123!;TrustServerCertificate=True

3. HƯỚNG DẪN CHẠY CHƯƠNG TRÌNH:
- Bước 1: Khởi động Docker Desktop và bật Container chứa SQL Server 2022 (Port 1433).
- Bước 2: Kiểm tra kết nối và dữ liệu EduManagerDB bằng SSMS.
- Bước 3: Mở tệp giải pháp ClassManager.sln trong Visual Studio 2026.
- Bước 4: Nhấn Ctrl + Shift + B để Build Solution và F5 để chạy ứng dụng.

4. BÀN GIAO & TÀI KHOẢN DEMO:
- Chạy trực tiếp giao diện FrmLop (không bắt buộc đăng nhập).
- GitHub Repository: https://github.com/khoidangDSA/2611COMP101904-Lap-trinh-Windows.git
