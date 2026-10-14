# COMP1019 -- BUỔI 7: BÀI LAB

## ShopManagerMini -- Ứng dụng quản lý cửa hàng mini nhiều Form

-   **Môn học:** COMP1019 -- Lập trình trên Windows
-   **Chủ đề:** SDI, MDI và ứng dụng nhiều Form trong C# WinForms
-   **Công nghệ:** C# WinForms, .NET
------------------------------------------------------------------------

## 1. Giới thiệu

`ShopManagerMini` là ứng dụng Windows Forms hỗ trợ quản lý cửa hàng
mini. Ứng dụng gồm màn hình đăng nhập, màn hình chính theo mô hình MDI,
màn hình quản lý sản phẩm, màn hình quản lý khách hàng và màn hình giới
thiệu.

Theo phạm vi bài lab, dữ liệu được lưu tạm trong bộ nhớ; chương trình
không yêu cầu kết nối SQL Server.

## 2. Cấu trúc chương trình (tham khảo)

``` text
ShopManagerMini/
├── Models/
│   ├── User.cs
│   ├── Product.cs
│   └── Customer.cs
├── Forms/
│   ├── FrmLogin.cs
│   ├── FrmMain.cs
│   ├── FrmProduct.cs
│   ├── FrmCustomer.cs
│   └── FrmAbout.cs
├── Program.cs
└── README.md
```

### Vai trò các thành phần

-   **`User.cs`:** Lưu tên đăng nhập, họ tên và vai trò người dùng.
-   **`Product.cs`:** Lưu mã sản phẩm, tên sản phẩm, loại sản phẩm, đơn
    giá và số lượng.
-   **`Customer.cs`:** Lưu mã khách hàng, họ tên, số điện thoại và loại
    khách hàng.
-   **`FrmLogin`:** Nhập và kiểm tra tài khoản đăng nhập.
-   **`FrmMain`:** Form chính MDI, chứa MenuStrip và StatusStrip, mở các
    Form con.
-   **`FrmProduct`:** Quản lý danh sách sản phẩm bằng DataGridView.
-   **`FrmCustomer`:** Quản lý danh sách khách hàng bằng DataGridView.
-   **`FrmAbout`:** Hiển thị thông tin ứng dụng, sinh viên và lớp.
-   **`Program.cs`:** Khởi chạy luồng đăng nhập và mở Form chính sau khi
    đăng nhập thành công.

## 3. Mô tả chức năng

### 3.1. Đăng nhập -- `FrmLogin`

-   Nhập username và password.
-   Tài khoản mẫu theo đề:
    -   `admin` / `123`: Quản trị viên, vai trò `Admin`.
    -   `user` / `123`: Nhân viên bán hàng, vai trò `User`.
-   Nếu bỏ trống thông tin, chương trình hiển thị cảnh báo.
-   Nếu tài khoản không đúng, chương trình thông báo lỗi.
-   Nếu đăng nhập thành công, Form trả về `DialogResult.OK` và cung cấp
    thông tin người dùng cho Form chính.

### 3.2. Màn hình chính -- `FrmMain`

-   Thiết lập `IsMdiContainer = true`.
-   Menu **Hệ thống** gồm **Đăng xuất** và **Thoát**.
-   Menu **Danh mục** gồm **Quản lý sản phẩm** và **Quản lý khách
    hàng**.
-   Menu **Trợ giúp** gồm **Giới thiệu**.
-   StatusStrip hiển thị tên người dùng, vai trò và thời gian hiện tại.
-   Các Form con được mở bên trong vùng làm việc của Form chính.
-   Nếu Form cùng loại đã mở, chương trình kích hoạt Form hiện có thay
    vì tạo thêm Form mới.
-   Khi thoát, chương trình hỏi xác nhận.

### 3.3. Quản lý sản phẩm -- `FrmProduct`

Thông tin sản phẩm gồm mã sản phẩm, tên sản phẩm, loại sản phẩm, đơn giá
và số lượng.

-   Hiển thị danh sách sản phẩm bằng DataGridView.
-   Có các chức năng Thêm, Sửa, Xóa, Làm mới và Tìm kiếm.
-   Kiểm tra mã sản phẩm và không cho thêm mã trùng.
-   Đơn giá và số lượng không được âm.
-   Khi xóa sản phẩm, chương trình yêu cầu xác nhận.
-   Dữ liệu được lưu trong `BindingList<Product>` trong thời gian chạy
    chương trình.

### 3.4. Quản lý khách hàng -- `FrmCustomer`

Thông tin khách hàng gồm mã khách hàng, họ tên, số điện thoại và loại
khách hàng.

-   Hiển thị danh sách bằng DataGridView.
-   Có chức năng thêm khách hàng.
-   Kiểm tra mã và họ tên không được bỏ trống; không cho thêm mã khách
    hàng trùng.
-   Có thể chọn một dòng để đưa thông tin lên các ô nhập liệu.
-   Chương trình có bổ sung chức năng sửa, xóa và xác nhận xóa.
-   Dữ liệu được lưu trong `BindingList<Customer>` trong thời gian chạy
    chương trình.

### 3.5. Giới thiệu -- `FrmAbout`

Form giới thiệu cung cấp thông tin ứng dụng và thông tin sinh viên thực
hiện.


## 4. Tài khoản kiểm thử

  Username   Password   Họ tên hiển thị      Vai trò
  ---------- ---------- -------------------- ---------
  `admin`    `123`      Quản trị viên        `Admin`
  `user`     `123`      Nhân viên bán hàng   `User`

## 5.Kiểm tra yêu cầu 

### 5.1 Kiểm thử đăng nhập


Hiển thị Thông tin người dùng trên Form chính

![Ảnh](images/Login.png)

Cảnh báo khi bỏ trống thông tin

![Ảnh](images/NullWarning.png)

Tài khoản hoặc mật khẩu không đúng

![Ảnh](images/TKMKFail.png)

### 5.2. Kiểm thử Form chính và MDI

Form chính, MenuStrip và StatusStrip

![Ảnh](images/login.png)


Kiểm tra không mở trùng Form

![Ảnh](images/OnlyOneForm.png)

Form giới thiệu

![Ảnh](images/FormGioiThieu.png)

 Xác nhận đăng xuất

![Ảnh](images/ConfirmLogOut.png)


### 5.3. Kiểm thử quản lý sản phẩm


 -- Giao diện quản lý sản phẩm và danh sách ban đầu

![Ảnh](images/Product.png)

 -- Thêm sản phẩm thành công

![Ảnh](images/ProductAdd.png)

Không cho thêm mã sản phẩm trùng

![Ảnh](images/SPKhongTrung.png)

Không thể thêm khi thiếu mã và tên sản phẩm
![Ảnh](images/WarningAddSP.png)

Sửa thông tin sản phẩm

![Ảnh](images/SuaSP.png)

Xác nhận xóa sản phẩm

![Ảnh 1](images/XoaSP1.png)
![Ảnh 2](images/XoaSP2.png)

Tìm kiếm sản phẩm

![Ảnh](images/FindSP.png)


### 5.4. Kiểm thử quản lý khách hàng


Giao diện quản lý khách hàng

![Ảnh](images/KH.png)

Thêm khách hàng

![Ảnh](images/addKH.png)

Không thể thêm khi thiếu tên và mã khách hàng

![Ảnh](images/LoiThemKH.png)

Xóa khách hàng

![Ảnh](images/XoaKH1.png)

![Ảnh](images/XoaKH2.png)

Sửa khách hàng

![Ảnh](images/SuaKH.png)



------------------------------------------------------------------------

# 7. Trả lời câu hỏi cuối bài

### Câu 1. SDI và MDI khác nhau như thế nào?

Cách mở:  SDI:Form Mỗi Form là cửa sổ riêng 
          MDI:Form con nằm trong Form cha

Độ phức tạp:  SDI: Dễ hơn 
              MDI:Phức tạp hơn một chút

Phù hợp:  SDI: Ứng dụng nhỏ, ít màn hình 
          MDI:Ứng dụng quản lý nhiều module

Điều hướng:  SDI :Tự do, độc lập 
             MDI:Tập trung trong Form chính

Rủi ro:  SDI:Dễ mở nhiều cửa sổ lộn xộn 
         MDI:Cần kiểm soát Form con


### Câu 2. Vì sao Form đăng nhập nên dùng `ShowDialog()`?

`ShowDialog()` mở Form đăng nhập theo kiểu hộp thoại phương thức
(modal). Người dùng phải xử lý Form đăng nhập trước khi tiếp tục thao
tác với Form gọi nó. Phương thức này còn trả về `DialogResult`, giúp
chương trình xác định đăng nhập thành công (`DialogResult.OK`) hay bị
hủy.

### Câu 3. Trong bài lab này, dữ liệu user được truyền từ `FrmLogin` sang `FrmMain` bằng cách nào?

`FrmLogin` lưu thông tin tài khoản đăng nhập thành công trong thuộc tính
`CurrentUser`. Sau đó, chương trình lấy thuộc tính này và truyền vào
constructor của `FrmMain`:

``` csharp
FrmMain main = new FrmMain(login.CurrentUser);
```

Trong `FrmMain`, constructor nhận đối tượng `User` và lưu vào
`_currentUser`. Form chính dùng đối tượng này để hiển thị họ tên và vai
trò trên StatusStrip.

### Câu 4. Nếu người dùng bấm menu sản phẩm nhiều lần, chương trình xử lý như thế nào để không mở trùng Form?

Chương trình duyệt danh sách `MdiChildren` của `FrmMain` và so sánh kiểu
của từng Form đang mở với kiểu Form cần mở. Nếu đã có Form cùng loại,
chương trình gọi `Activate()` để đưa Form đó lên trước và hủy đối tượng
mới vừa tạo. Nếu chưa có, chương trình gán `MdiParent` rồi gọi `Show()`.

### Câu 5. Khi nào nên dùng constructor, khi nào nên dùng property để truyền dữ liệu giữa các Form?

-   **Dùng constructor:** Khi dữ liệu cần thiết ngay lúc tạo Form, ví dụ
    truyền đối tượng `User` từ `FrmLogin` sang `FrmMain`.
-   **Dùng property:** Khi cần đọc hoặc cập nhật dữ liệu sau khi Form đã
    được tạo, hoặc khi muốn cung cấp dữ liệu thông qua một thuộc tính có
    kiểm soát quyền truy cập.

Trong bài này, constructor `FrmMain(User user)` phù hợp vì Form chính
cần biết người dùng ngay khi khởi tạo để hiển thị đúng thông tin đăng
nhập.

## 8. Kết luận

Ứng dụng được xây dựng theo mô hình Windows Forms nhiều Form. Form chính
sử dụng MDI để quản lý các Form con; dữ liệu sản phẩm và khách hàng được
lưu trong bộ nhớ. Các chức năng đăng nhập, quản lý sản phẩm, quản lý
khách hàng và giới thiệu được kiểm thử theo các trường hợp nêu trên.
