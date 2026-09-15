LAB 01 - ỨNG DỤNG THÔNG TIN CÁ NHÂN


1. Mô tả bài tập

Xây dựng ứng dụng Windows Forms cho phép người dùng nhập và hiển thị
thông tin cá nhân của sinh viên.

Thông tin cần nhập gồm: - Họ và tên - Năm sinh - Email - Giới tính -
Khoa/Lớp

Sau khi nhấn nút Hiển thị, chương trình kiểm tra dữ liệu đầu vào.
Nếu dữ liệu hợp lệ, chương trình tính tuổi và hiển thị thông tin sinh
viên.

2. Giao diện chương trình

Giao diện gồm các control: - Label tiêu đề - TextBox nhập họ tên -
TextBox nhập năm sinh - TextBox nhập email - RadioButton chọn giới tính
Nam/Nữ - ComboBox chọn Khoa/Lớp - Button Hiển thị - Button Xóa - Button
Thoát - TextBox hiển thị kết quả

3. Chức năng chương trình

Nút Hiển thị

Chương trình kiểm tra: - Họ tên không được để trống. - Năm sinh không
được để trống. - Năm sinh phải là số nguyên. - Năm sinh phải từ 1900 đến
năm hiện tại. - Email không được để trống. - Phải chọn giới tính. - Phải
chọn Khoa/Lớp.

Nếu dữ liệu hợp lệ, chương trình tính tuổi theo công thức:

Tuổi = Năm hiện tại - Năm sinh

Sau đó hiển thị thông tin sinh viên.

Nút Xóa

Xóa các thông tin đã nhập: - Họ tên - Năm sinh - Email - Kết quả

Đồng thời bỏ chọn giới tính và đưa ComboBox về lựa chọn đầu tiên.

Nút Thoát

Hiển thị hộp thoại xác nhận trước khi đóng chương trình.

4. Kết quả thực hiện

Ví dụ nhập:

Họ tên: Nguyễn Văn A

Năm sinh: 2005

Email: vana@example.com

Giới tính: Nam

Khoa/Lớp: Khoa CNTT

Kết quả hiển thị:

THÔNG TIN SINH VIÊN
Họ tên: Nguyễn Văn A
Tuổi: 21
Email: vana@example.com
Giới tính: Nam
Khoa/Lớp: Khoa CNTT

5. Kiểm tra dữ liệu đầu vào

Chương trình đã kiểm tra các trường hợp dữ liệu không hợp lệ:

Trường hợp                 Kết quả

Bỏ trống họ tên            Hiển thị thông báo lỗi
Bỏ trống năm sinh          Hiển thị thông báo lỗi
Nhập chữ vào năm sinh      Hiển thị thông báo lỗi
Năm sinh < 1900           Hiển thị thông báo lỗi
Năm sinh > năm hiện tại   Hiển thị thông báo lỗi
Bỏ trống email             Hiển thị thông báo lỗi
Không chọn giới tính       Hiển thị thông báo lỗi
Không chọn Khoa/Lớp        Hiển thị thông báo lỗi

6. Công nghệ sử dụng

C#

Windows Forms

.NET

Visual Studio

7. Các Hình ảnh mô tả trực quan

### a) Giao diện và kết quả chạy ứng dụng

#### Hình ảnh giao diện
![Giao diện ứng dụng](./images/GiaoDien.png)

#### Kết quả chạy ứng dụng
![Kết quả ứng dụng](./images/KetQua.png)

### b) Các yêu cầu chức năng

#### Ảnh 3 lựa chọn khoa/lớp
![3 lựa chọn](./images/BaLuaChonKhoa.png)

#### Ảnh xác nhận thoát
![Xác nhận thoát](./images/XacNhanOut.png)

### c) Kiểm tra dữ liệu đầu vào

#### Ảnh kiểm tra họ tên
![Kiểm tra họ tên](./images/KiemTraHoTen.png)

#### Ảnh kiểm tra năm sinh
![Kiểm tra năm sinh rỗng](./images/KtNamSinhRong.png)
![Kiểm tra năm sinh](./images/KtNamSinh.png)

#### Ảnh kiểm tra email
![Kiểm tra email](./images/KiemTraEmail.png)

#### Ảnh kiểm tra giới tính
![Kiểm tra giới tính](./images/KiemTraGioiTinh.png)

#### Ảnh kiểm tra Khoa/Lớp
![Kiểm tra Khoa/Lớp](./images/KiemTraKhoaLop.png)
