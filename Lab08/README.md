# COMP1019 - Lab 08: Simple Paint

## 1. Thông tin bài lab

- **Học phần:** COMP1019 - Lập trình trên Windows
- **Bài lab:** Buổi 8 - Lab 08
- **Đề tài:** Xây dựng ứng dụng Paint đơn giản bằng WinForms và GDI+


## 2. Mô tả chương trình

Ứng dụng Paint đơn giản cho phép người dùng vẽ trực tiếp trên vùng canvas bằng chuột. Chương trình hỗ trợ vẽ tự do, đường thẳng, hình chữ nhật và hình ellipse; chọn màu, độ dày nét vẽ; hoàn tác nét vẽ gần nhất và xóa toàn bộ vùng vẽ.

Danh sách đối tượng vẽ được lưu trong bộ nhớ và được vẽ lại thông qua sự kiện `Paint`, vì vậy các nét vẽ vẫn được giữ khi cửa sổ bị che, refresh hoặc thay đổi kích thước.

## 3. Chức năng đã thực hiện

### Chức năng bắt buộc

- [x] Vẽ tự do bằng chế độ **Pen**.
- [x] Vẽ đường thẳng bằng chế độ **Line**.
- [x] Vẽ hình chữ nhật bằng chế độ **Rectangle**.
- [x] Vẽ hình ellipse bằng chế độ **Ellipse**.
- [x] Chọn màu nét vẽ bằng `ColorDialog`.
- [x] Chọn độ dày nét vẽ bằng `NumericUpDown` (từ 1 đến 20).
- [x] **Undo:** xóa nét vẽ gần nhất.
- [x] **Clear:** xóa toàn bộ nét vẽ.
- [x] Hiển thị tọa độ chuột trên thanh trạng thái.
- [x] Giữ lại các nét vẽ khi canvas refresh hoặc Form thay đổi kích thước.

### Chức năng nâng cao

- [x] Lưu vùng vẽ ra file PNG.
- [x] Mở ảnh nền để vẽ đè lên ảnh.
- [x] Hỗ trợ phím tắt `Ctrl + Z` để Undo.
- [x] Tô màu hình chữ nhật hoặc ellipse.
- [x] Thay đổi màu nền canvas.



## 4. Giao diện và ảnh minh chứng


### 4.1. Giao diện chính và bốn chế độ vẽ
![Giao diện chính - minh chứng Pen, Line, Rectangle và Ellipse](images/Load.png)

### 4.2. Chọn màu và độ dày nét vẽ
![Minh chứng chọn màu và độ dày nét vẽ](images/ColorAndWidth.png)

![Chọn chế độ vẽ](images/Mode.png)
#### Chế độ vẽ không thể gõ mà chỉ có thể chọn từ các loại có sẵn

![Chọn độ dày 1](images/_Width1.png)
#### Ví dụ chọn độ dày là 300
![Chọn độ dày 2](images/_Width2.png)
#### Khi thoát chọn hoặc vẽ lên canvas thì nó sẽ tự setup lại về 20, tương tự nếu bé hơn 1 thì sẽ tự setup về 1

### 4.3. Undo, Clear và tọa độ chuột,item
#### (Tọa độ chuột và item đã có trong các ảnh minh chứng dưới)

![Minh chứng Undo](images/Undo.png)
#### Ảnh mất đi số 9(màu đỏ) vì nó là cái ghi cuối nên Undo sẽ bị mất

![Minh chứng Clear](images/Clear1.png)
#### Xác nhận xóa hết thứ đã vẽ
![Minh chứng Clear](images/Clear2.png)
#### Không còn gì sau khi đã xóa hết

### 4.4. Minh chứng vẽ mẫu
#### 1. Chế độ pen
![Pen](images/Pen.png)

#### 2. Chế độ line
![Line](images/Line.png)
#### 3. Chế độ rectangle
![rectangle](images/rectangle.png)

#### 4. Chế độ Elipse
![Elipse](images/Elipse.png)


### 4.5. Chức năng nâng cao
#### 1. Mở ảnh từ thư viện
![images](images/OpenImage1.png)
Lúc chọn ảnh
![images](images/OpenImage2.png)
Đã chọn ảnh

#### 2. Lưu ảnh đã vẽ
![Save](images/Sve.png)
![Save](images/Save2.png)

#### 3. Đổi màu nền 
![BgColor](images/BgColor.png)

#### 4. FillRectangle & FillElipse
![Fill](images/Fill.png)

#### 5.Ctrol + Z
```csharp
protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
{
    // Kiểm tra nếu người dùng nhấn tổ hợp phím Ctrl + Z
    if (keyData == (Keys.Control | Keys.Z))
    {
        btnUndo_Click(null, null); 
        return true;               
    }
    return base.ProcessCmdKey(ref msg, keyData);
}
```
## 7. Cấu trúc thư mục tham khảo

```text
COMP1019_Lab08_SimplePaint/
├── COMP1019_Lab08_SimplePaint.sln
├── COMP1019_Lab08_SimplePaint/
│   ├── Program.cs
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   └── ...
├── images/
│   ├── ....png
│   ├── ....png
│   ├── ....png
│   └── ......... png
└── README.md
```

