# ProductManager – Lab 06: Windows Forms nâng cao và DataGridView

**Môn học:** COMP1019 – Lập trình trên Windows  
**Tên ứng dụng:** ProductManager  
**Form chính:** `FrmProduct`  
**Tiêu đề cửa sổ:** Quản lý sản phẩm

## 1. Mục tiêu

Ứng dụng quản lý danh sách sản phẩm bằng Windows Forms. Dữ liệu được lưu trong bộ nhớ bằng `BindingList<Product>` và `BindingSource`, không sử dụng SQL Server.

Các chức năng theo yêu cầu:
- Hiển thị danh sách sản phẩm trên `DataGridView`.
- Thêm, sửa, xóa, tìm kiếm và làm mới dữ liệu.
- Kiểm tra dữ liệu nhập bằng `ErrorProvider` và thông báo phù hợp.
- Chọn ảnh sản phẩm bằng `OpenFileDialog` và hiển thị trên `PictureBox`.
- Hỗ trợ thao tác qua `MenuStrip`, `ToolStrip`, `StatusStrip` và `ContextMenuStrip`.

## 2. Các trường dữ liệu và điều kiện kiểm tra

| Trường | Kiểu dữ liệu | Điều kiện |
|---|---|---|
| `MaSP` | `string` | Không được để trống và không được trùng |
| `TenSP` | `string` | Không được để trống |
| `LoaiSP` | `string` | Chọn một trong: Điện tử, Văn phòng, Gia dụng, Thời trang |
| `DonGia` | `decimal` | Phải lớn hơn 0 |
| `SoLuong` | `int` | Phải lớn hơn hoặc bằng 0 |
| `NgayNhap` | `DateTime` | Không được lớn hơn ngày hiện tại |
| `ConKinhDoanh` | `bool` | Đánh dấu còn kinh doanh hoặc ngừng kinh doanh |
| `DuongDanAnh` | `string` | Có thể để trống; nếu chọn ảnh thì lưu đường dẫn ảnh |

## 3. Ảnh giao diện

![Giao diện chính ProductManager](images/GiaoDien.png)


## 4. Kiểm chứng chức năng

1. Mở Form

Kết quả: Có 3 sản phẩm mẫu, đủ 4 loại sản phẩm
![Load Form](images/LoadForm.png)


2. Thêm sản phẩm

Kết quả: Thêm thành công, số lượng sản phẩm được cập nhật.
![Thêm sản phẩm](images/Them.png)


3. Mã sản phẩm trống

Kết quả: Báo lỗi, không thêm sản phẩm.
![Mã sản phẩm trống](images/MaSPNull.png)


4. Tên sản phẩm trống

Kết quả: Báo lỗi, không thêm sản phẩm.
![Tên sản phẩm trống](images/TenSPNull.png)


5. Mã sản phẩm trùng

Kết quả: Báo lỗi, không thêm sản phẩm.
![Mã sản phẩm trùng](images/MaSPTrung.png)


6. Đơn giá bằng 0

Kết quả: Báo lỗi, không cho thêm sản phẩm.
![Đơn giá bằng 0](images/Price0.png)


7. Số lượng âm

Kết quả: Báo lỗi, không cho nhập số âm.
![Số lượng âm](images/SoLuongAm.png)


8. Ngày nhập tương lai

Kết quả: Báo lỗi, không thêm sản phẩm.
![Ngày nhập tương lai](images/FutureDays.png)


9. Sửa sản phẩm

Kết quả: Thông tin sản phẩm được cập nhật thành công (Không sửa được mã sản phẩm)
![Trước khi sửa sản phẩm](images/TruocSua.png)
![Sau khi sửa sản phẩm](images/SauSua.png)

10. Xóa sản phẩm

Kết quả: Có hộp thoại xác nhận trước khi xóa.
![Xác nhận xóa sản phẩm](images/XacNhanXoa.png)
![Xóa sản phẩm](images/XoaThanhCong.png)

11. Tìm theo mã

Kết quả: Hiển thị sản phẩm phù hợp với nội dung tìm kiếm.
![Tìm theo mã](images/TimSP.png)


12. Tìm theo tên

Kết quả: Hiển thị sản phẩm phù hợp với nội dung tìm kiếm.
![Tìm theo tên](images/TimSP2.png)


13. Làm mới khi không cần tìm kiếm thêm (Hiện lại danh sách)

Kết quả: Hiển thị lại toàn bộ danh sách sản phẩm.
![Làm mới](images/LamMoi.png)


14. Chọn ảnh

Kết quả: Ảnh được hiển thị trên Form.
![Chọn ảnh](images/ChonAnh.png)


15. Menu chuột phải (ContextMenuScript1)

Kết quả: Hiển thị các chức năng Sửa, Xóa và Xem chi tiết.
![Menu chuột phải](images/MenuChuotPhai.png)


16. StatusStrip

Kết quả: Trạng thái thao tác và số lượng sản phẩm được cập nhật.
![StatusStrip](images/Status.png)

17. Xem chi tiết 

Kết quả: Khi nhấn chuột phải và chọn Xem chi tiết, kết quả trả là một (MessageBox), hiển thị toàn bộ thuộc tính chi tiết của sản phẩm đó.
![StatusStrip](images/XemChiTiet.png)


18. Chưa chọn dòng
Khi chưa chọn sản phẩm ở dưới DataGridView thì sẽ không cho thực hiện StatusStrip(Sửa, Xóa, Xem chi tiết) 

Kết quả: Hiển thị thông báo yêu cầu chọn sản phẩm, ứng dụng không bị crash.
![Chưa chọn dòng](images/NotChoose.png)


## 5. Kết luận

Ứng dụng ProductManager được xây dựng nhằm hỗ trợ quản lý danh sách sản phẩm của cửa hàng trên Windows Forms. Ứng dụng cung cấp các chức năng thêm, sửa, xóa, tìm kiếm và làm mới sản phẩm; kiểm tra dữ liệu nhập bằng ErrorProvider; hiển thị danh sách sản phẩm bằng DataGridView; đồng thời hỗ trợ thao tác nhanh thông qua MenuStrip, ToolStrip và ContextMenuStrip.

Ngoài ra, ứng dụng cho phép chọn ảnh sản phẩm bằng OpenFileDialog và hiển thị trạng thái thao tác cùng số lượng sản phẩm trên StatusStrip. Dữ liệu được lưu trong bộ nhớ trong quá trình chạy chương trình, chưa sử dụng cơ sở dữ liệu SQL Server.

Qua bài thực hành, em vận dụng được kiến thức Windows Forms để xây dựng giao diện quản lý dữ liệu, xử lý các thao tác CRUD và kiểm tra tính hợp lệ của dữ liệu đầu vào.
