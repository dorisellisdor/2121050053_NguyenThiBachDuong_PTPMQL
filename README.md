Câu 1: Cấu trúc thư mục của dự án .Net MVC :

  .Controllers:	Xử lý request.
  .Models:	Dữ liệu + logic.
  .Views:	Giao diện.
  .wwwroot:	CSS, JS, Image.
  .Data:	Kết nối CSDL.
  .Migrations:	Quản lý CSDL.
  .Program.cs:	Cấu hình app.

Câu 2: Định tuyến (Route) trong .Net MVC :

  .Route (định tuyến) là cơ chế ánh xạ URL → Controller → Action.
  .Cấu trúc URL mặc định :  /{Home}/{Index}/{id}  .

Câu 3: Namespace trong C# :

  .Namespace là không gian tên, dùng để: Nhóm các class / interface / enum liên quan
  .Tránh trùng tên
  .Giúp code gọn gàng, dễ quản lý
  .Hiểu đơn giản: Namespace = “họ”, còn class = “tên”.

Câu 4: 
  .Controller : là nơi xử lý request từ người dùng.
      .Nhiệm vụ chính:
        -Nhận request (URL).
        -Gọi Model xử lý dữ liệu.
        -Trả về View hoặc dữ liệu.
  .View : là giao diện người dùng (UI)
      -File .cshtml dùng Razor.
      -View hiển thị dữ liệu do Controller gửi sang.
    
