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
Câu 5: ViewBag trong MVC :
  .ViewBag là:
    -Một dynamic object.
    -Dùng để truyền dữ liệu từ Controller → View.
    -Chỉ tồn tại trong 1 request.
  .Đặc điểm:
    -Không cần khai báo kiểu.
    -Dùng nhanh, gọn.
    -Phù hợp với dữ liệu đơn giản (string, number…).

Câu 6: ví dụ về viewbag :
  [CONTROLLER]
    public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.Message = "Xin chào MVC";
        return View();
    }
}

  [VIEW]
    <h2>@ViewBag.Message</h2>

cÂU 7: Gửi nhận dữ liệu giữa View và Controller thông qua Submit form:

  .Nguyên lý hoạt động:
    .Người dùng nhập dữ liệu trên View
            ↓
    .Nhấn nút Submit
            ↓
    .Form gửi dữ liệu (HTTP POST)
            ↓
    .Controller nhận dữ liệu
            ↓
    .Xử lý dữ liệu
            ↓
    .Trả dữ liệu về View
    
