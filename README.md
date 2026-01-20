Cấu trúc thư mục của dự án :
    .Model: Data Access Layer và tầng Business Logic Layer là hai tầng tương đương với tầng model trong mô hình MVC.
    .View: là tầng giao diện, hiển thị dữ liệu được truy xuất từ tầng model. Tầng này tương đương với tầng Presentation Layer trong cấu trúc Three – Tier.
    .Controller: đây là tầng giúp kết nối giữa tầng model và tầng view trong mô hình MVC, có nghĩa là nếu phía client yêu cầu hiển thị dữ liệu thì controller gọi giữ liệu từ model và trả về cho view vì view tương tác trực tiếp với client

Định tuyến (route) trong dự án :
    -Routing có 2 trách nhiệm chính:
      .Nó chỉ dẫn request đến vào Controller Action.
      .Tạo ra URL đầu ra tương ứng với Controller action.
    -Khi request đến thì Routing Middleware sẽ làm những việc sau đây:
      .Phân tích URL
      .Tìm kiếm xem có cái Route nào match trong RouteCollection
      .Nếu Route tìm thấy thì đẩy nó sang RouteHandler
      .Nếu không tìm thấy Route nào thì bỏ qua và gọi middleware tiếp theo
Namespace trong dự án :
    -Namespace là cách tổ chức nhóm code (các lớp, giao diện, cấu trúc, …) thành những nhóm, tạo ra phạm vi hoạt động của các thành phần trong nhóm.
    -Các namespace cũng có thể khai báo lồng nhau, nhiều cấp sau đó, dùng ký hiệu dấu chấm để truy cập đến namespace mong muốn.
    -Để sử dụng một lớp, cấu trúc, interface, … khai báo trong một namespace nào đó, phải viết tên đầy đủ của namespace và dẫn đến tên lớp muốn sử dụng, các cấp phân cách nhau bởi dấu chấm.
