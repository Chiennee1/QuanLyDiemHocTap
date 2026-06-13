# Phân công nhiệm vụ dự án Quản lý điểm học tập

Cập nhật: 13/06/2026  
Dự án: `QuanLyDiemHocTap`  
Công nghệ: C# WinForms, .NET 8, SQL Server  
Mô hình triển khai: `GUI` -> `BUS` -> `DAL` -> `DTO`

## 1. Tổng quan dự án

Dự án `QuanLyDiemHocTap` là ứng dụng Windows Forms quản lý điểm học tập cho học sinh THCS. Hệ thống hỗ trợ quản lý dữ liệu học sinh, giáo viên, lớp học, môn học, phân lớp, phân công giảng dạy, nhập điểm, xem điểm, tổng kết học kỳ và báo cáo kết quả học tập.

Các nhóm chức năng chính:

- Đăng nhập, phân quyền, đổi mật khẩu, quản lý tài khoản.
- Quản lý học sinh, giáo viên, lớp học, môn học.
- Phân học sinh vào lớp theo học kỳ.
- Phân công giáo viên giảng dạy theo lớp, môn học, học kỳ.
- Nhập điểm, sửa điểm, xóa điểm.
- Xem điểm chi tiết và điểm trung bình.
- Tổng kết học kỳ, đánh giá hạnh kiểm, xếp loại học lực.
- Báo cáo kết quả theo lớp và theo học sinh.
- Xuất báo cáo CSV mở được bằng Excel.

## 2. Cấu trúc dự án

```text
QuanLyDiemHocTap/
├── Program.cs
├── QuanLyDiemHocTap.csproj
├── DTO/
├── BUS/
├── DAL/
├── GUI/
└── docs/
```

Vai trò các tầng:

- `DTO`: chứa các lớp truyền dữ liệu.
- `DAL`: truy vấn SQL Server, thêm/sửa/xóa/lấy dữ liệu.
- `BUS`: xử lý nghiệp vụ, kiểm tra dữ liệu trước khi gọi DAL.
- `GUI`: giao diện Windows Forms và xử lý thao tác người dùng.

## 3. Phân công nhiệm vụ cho 5 thành viên

## Thành viên 1 - Trưởng nhóm, cơ sở dữ liệu, hệ thống lõi và nhập điểm

### Vai trò

Thành viên 1 phụ trách điều phối toàn bộ dự án, thiết kế cơ sở dữ liệu, tích hợp hệ thống, xử lý đăng nhập/phân quyền và module nhập điểm.

### Phạm vi phụ trách

- Thiết kế cơ sở dữ liệu SQL Server.
- Cấu hình dự án, kiểm tra build.
- Module đăng nhập.
- Module phân quyền menu.
- Module đổi mật khẩu.
- Module quản lý tài khoản.
- Module nhập điểm.
- Xử lý loại điểm và tính điểm trung bình môn.
- Tích hợp toàn bộ dự án trước khi bàn giao.

### File phụ trách chính

```text
Program.cs
QuanLyDiemHocTap.csproj
GUI/frmDangNhap.cs
GUI/frmMain.cs
GUI/frmDoiMatKhau.cs
GUI/frmQuanLyTaiKhoan.cs
GUI/frmNhapDiem.cs
BUS/TaiKhoanBUS.cs
BUS/DiemBUS.cs
BUS/LoaiDiemBUS.cs
DAL/TaiKhoanDAL.cs
DAL/DiemDAL.cs
DAL/LoaiDiemDAL.cs
DTO/TaiKhoanDTO.cs
DTO/DiemDTO.cs
DTO/LoaiDiemDTO.cs
```

### Nhiệm vụ chi tiết

- Thiết kế database `QuanLyDiemTHCS`.
- Tạo script tạo bảng, khóa chính, khóa ngoại và dữ liệu mẫu.
- Tạo tài khoản mẫu cho Admin, giáo viên và học sinh.
- Xây dựng luồng đăng nhập:
  - Nhập tên đăng nhập và mật khẩu.
  - Kiểm tra tài khoản đang hoạt động.
  - Lưu thông tin người dùng hiện tại vào `CurrentUser`.
  - Mở form chính sau khi đăng nhập thành công.
- Xây dựng phân quyền:
  - Admin xem được toàn bộ menu.
  - Tài khoản không phải Admin bị ẩn menu hệ thống.
- Xây dựng đổi mật khẩu:
  - Nhập mật khẩu cũ.
  - Nhập mật khẩu mới.
  - Xác nhận mật khẩu mới.
  - Kiểm tra mật khẩu tối thiểu 6 ký tự.
- Xây dựng quản lý tài khoản:
  - Thêm tài khoản.
  - Sửa loại tài khoản, người dùng liên kết, trạng thái.
  - Xóa mềm tài khoản.
  - Tìm kiếm tài khoản.
  - Không cho trùng tên đăng nhập.
  - Không cho một giáo viên/học sinh có nhiều tài khoản active.
- Xây dựng nhập điểm:
  - Chọn năm học.
  - Chọn học kỳ.
  - Chọn lớp.
  - Chọn môn học.
  - Tải danh sách học sinh trong lớp.
  - Thêm điểm.
  - Sửa điểm.
  - Xóa điểm.
  - Ghi chú điểm.
- Xử lý loại điểm:
  - Điểm miệng.
  - Điểm 15 phút.
  - Điểm 1 tiết.
  - Điểm thi học kỳ.
  - Hệ số từng loại điểm.
- Kiểm tra điểm hợp lệ trong khoảng `0-10`.
- Tính điểm trung bình môn theo công thức:

```text
Điểm TB môn = Tổng(Điểm số * Hệ số) / Tổng(Hệ số)
```

- Chạy `dotnet build` sau khi tích hợp.
- Tổng hợp lỗi và phân công sửa lỗi.
- Chuẩn bị kịch bản demo cuối cùng.

### Đầu ra cần bàn giao

- Script database hoàn chỉnh.
- Dữ liệu mẫu phục vụ demo.
- Module đăng nhập hoạt động.
- Module đổi mật khẩu hoạt động.
- Module quản lý tài khoản hoạt động.
- Module nhập điểm hoạt động.
- Bản build cuối cùng không có lỗi biên dịch.
- Tài liệu hướng dẫn chạy dự án.

### Tiêu chí hoàn thành

- Đăng nhập Admin thành công.
- Đăng nhập sai hiển thị thông báo lỗi.
- Phân quyền menu đúng theo loại tài khoản.
- Thêm/sửa/xóa điểm thành công.
- Không nhập được điểm âm hoặc lớn hơn 10.
- Điểm trung bình môn tính đúng theo hệ số.
- Toàn bộ dự án build được.

## Thành viên 2 - DTO, quản lý học sinh và quản lý giáo viên

### Vai trò

Thành viên 2 phụ trách các lớp dữ liệu trung gian DTO và hai module danh mục quan trọng: học sinh, giáo viên.

### Phạm vi phụ trách

- Toàn bộ lớp DTO.
- Module quản lý học sinh.
- Module quản lý giáo viên.
- Tìm kiếm học sinh, giáo viên.
- Kiểm tra dữ liệu nhập cho học sinh và giáo viên.

### File phụ trách chính

```text
DTO/DiemDTO.cs
DTO/GiaoVienDTO.cs
DTO/HanhKiemDTO.cs
DTO/HocKyDTO.cs
DTO/HocSinhDTO.cs
DTO/KetQuaHocTapDTO.cs
DTO/KhoiDTO.cs
DTO/LoaiDiemDTO.cs
DTO/LopDTO.cs
DTO/MonHocDTO.cs
DTO/NamHocDTO.cs
DTO/PhanCongDTO.cs
DTO/PhanLopDTO.cs
DTO/TaiKhoanDTO.cs
DTO/XepLoaiHocLucDTO.cs
GUI/frmHocSinh.cs
GUI/frmGiaoVien.cs
BUS/HocSinhBUS.cs
BUS/GiaoVienBUS.cs
DAL/HocSinhDAL.cs
DAL/GiaoVienDAL.cs
```

### Nhiệm vụ chi tiết

- Rà soát toàn bộ DTO để bảo đảm thuộc tính khớp với cột trong database.
- Xây dựng DTO cho các đối tượng:
  - Học sinh.
  - Giáo viên.
  - Tài khoản.
  - Lớp.
  - Môn học.
  - Điểm.
  - Loại điểm.
  - Phân lớp.
  - Phân công.
  - Năm học.
  - Học kỳ.
  - Hạnh kiểm.
  - Kết quả học tập.
  - Xếp loại học lực.
- Xây dựng quản lý học sinh:
  - Hiển thị danh sách học sinh.
  - Thêm học sinh.
  - Sửa thông tin học sinh.
  - Xóa mềm học sinh.
  - Tìm kiếm học sinh theo họ tên hoặc số điện thoại.
- Xây dựng quản lý giáo viên:
  - Hiển thị danh sách giáo viên.
  - Thêm giáo viên.
  - Sửa thông tin giáo viên.
  - Xóa mềm giáo viên.
  - Tìm kiếm giáo viên theo họ tên, số điện thoại hoặc chuyên môn.
- Kiểm tra dữ liệu học sinh:
  - Họ tên không được để trống.
  - Ngày sinh phải nhỏ hơn ngày hiện tại.
  - Giới tính phải được chọn.
- Kiểm tra dữ liệu giáo viên:
  - Họ tên không được để trống.
  - Giáo viên phải từ 18 tuổi trở lên.
  - Email đúng định dạng nếu có nhập.
  - Số điện thoại chỉ gồm chữ số nếu có nhập.
- Chuẩn hóa `DataGridView`:
  - Đổi tên cột sang tiếng Việt.
  - Ẩn cột kỹ thuật như `TrangThai`.
  - Định dạng ngày sinh.
  - Hiển thị tổng số bản ghi.
- Cung cấp dữ liệu học sinh cho module phân lớp.
- Cung cấp dữ liệu giáo viên cho module lớp chủ nhiệm, phân công và tài khoản.

### Đầu ra cần bàn giao

- Bộ DTO đầy đủ.
- Form quản lý học sinh.
- Form quản lý giáo viên.
- BUS/DAL học sinh.
- BUS/DAL giáo viên.
- Dữ liệu mẫu học sinh, giáo viên.

### Tiêu chí hoàn thành

- Thêm học sinh thành công.
- Sửa học sinh thành công.
- Xóa mềm học sinh thành công.
- Tìm kiếm học sinh đúng.
- Thêm giáo viên thành công.
- Sửa giáo viên thành công.
- Xóa mềm giáo viên thành công.
- Tìm kiếm giáo viên đúng.
- Các form khác lấy được danh sách học sinh, giáo viên qua BUS.

## Thành viên 3 - Quản lý lớp, môn học và phân lớp

### Vai trò

Thành viên 3 phụ trách các chức năng tạo nền dữ liệu học tập: lớp học, môn học và phân học sinh vào lớp theo học kỳ.

### Phạm vi phụ trách

- Module quản lý lớp.
- Module quản lý môn học.
- Module phân lớp.
- Kết nối dữ liệu khối, năm học, học kỳ, giáo viên và học sinh.

### File phụ trách chính

```text
GUI/frmLop.cs
GUI/frmMonHoc.cs
GUI/frmPhanLop.cs
BUS/LopBUS.cs
BUS/MonHocBUS.cs
BUS/PhanLopBUS.cs
DAL/LopDAL.cs
DAL/MonHocDAL.cs
DAL/PhanLopDAL.cs
DTO/LopDTO.cs
DTO/MonHocDTO.cs
DTO/PhanLopDTO.cs
```

### Nhiệm vụ chi tiết

- Xây dựng quản lý lớp:
  - Hiển thị danh sách lớp.
  - Thêm lớp.
  - Sửa lớp.
  - Xóa lớp.
  - Chọn khối.
  - Chọn năm học.
  - Chọn giáo viên chủ nhiệm.
  - Hiển thị sĩ số.
- Xây dựng quản lý môn học:
  - Hiển thị danh sách môn học.
  - Thêm môn học.
  - Sửa môn học.
  - Xóa mềm môn học.
  - Gắn môn học với khối.
  - Nhập số tiết lý thuyết.
  - Nhập số tiết thực hành.
  - Nhập hệ số môn học.
- Xây dựng phân lớp:
  - Chọn năm học.
  - Chọn học kỳ theo năm học.
  - Chọn lớp.
  - Hiển thị danh sách học sinh đang ở trong lớp.
  - Hiển thị danh sách tất cả học sinh.
  - Thêm học sinh vào lớp.
  - Xóa học sinh khỏi lớp.
  - Không cho thêm trùng học sinh vào cùng lớp và học kỳ.
- Bảo đảm dữ liệu phân lớp phục vụ được cho:
  - Nhập điểm.
  - Xem điểm.
  - Tổng kết học kỳ.
  - Báo cáo lớp.
- Kiểm tra trường hợp dữ liệu rỗng:
  - Chưa có năm học.
  - Chưa có học kỳ.
  - Chưa có lớp.
  - Lớp chưa có học sinh.
  - Khối chưa có môn học.
- Phối hợp với Thành viên 1 để nhập điểm load đúng học sinh theo lớp.
- Phối hợp với Thành viên 4 để phân công load đúng môn học theo khối của lớp.

### Đầu ra cần bàn giao

- Form quản lý lớp.
- Form quản lý môn học.
- Form phân lớp.
- BUS/DAL/DTO liên quan đến lớp, môn học, phân lớp.
- Dữ liệu lớp, môn học, phân lớp mẫu.

### Tiêu chí hoàn thành

- Tạo được lớp theo khối và năm học.
- Tạo được môn học theo khối.
- Phân được học sinh vào lớp theo học kỳ.
- Không thêm trùng học sinh vào cùng lớp/học kỳ.
- Module nhập điểm load đúng danh sách học sinh trong lớp.
- Module phân công load đúng môn học theo khối.

## Thành viên 4 - Xem điểm, tổng kết học kỳ và phân công giảng dạy

### Vai trò

Thành viên 4 phụ trách các nghiệp vụ sau khi đã có dữ liệu lớp, môn và điểm: xem điểm, tổng kết học kỳ, xếp loại học lực và phân công giảng dạy.

### Phạm vi phụ trách

- Module xem điểm.
- Module tổng kết học kỳ.
- Module phân công giáo viên giảng dạy.
- Xử lý kết quả học tập.
- Xử lý xếp loại học lực.

### File phụ trách chính

```text
GUI/frmXemDiem.cs
GUI/frmTongKet.cs
GUI/frmPhanCong.cs
BUS/KetQuaHocTapBUS.cs
BUS/PhanCongBUS.cs
DAL/KetQuaHocTapDAL.cs
DAL/PhanCongDAL.cs
DAL/XepLoaiHocLucDAL.cs
DTO/KetQuaHocTapDTO.cs
DTO/PhanCongDTO.cs
DTO/XepLoaiHocLucDTO.cs
```

### Nhiệm vụ chi tiết

- Xây dựng xem điểm:
  - Chọn năm học.
  - Chọn học kỳ.
  - Chọn lớp.
  - Chọn học sinh.
  - Hiển thị điểm chi tiết theo môn học và loại điểm.
  - Hiển thị điểm trung bình từng môn.
  - Hiển thị điểm trung bình học kỳ.
  - Hiển thị hạnh kiểm và xếp loại nếu đã tổng kết.
- Đổi màu điểm trung bình học kỳ:
  - Từ 8.0 trở lên: giỏi.
  - Từ 6.5 đến dưới 8.0: khá.
  - Từ 5.0 đến dưới 6.5: trung bình.
  - Dưới 5.0: yếu.
- Xây dựng tổng kết học kỳ:
  - Chọn năm học.
  - Chọn học kỳ.
  - Chọn lớp.
  - Tải danh sách học sinh.
  - Tính điểm trung bình học kỳ.
  - Chọn hạnh kiểm.
  - Xác định xếp loại học lực.
  - Lưu kết quả tổng kết cho một học sinh.
  - Tổng kết toàn bộ lớp.
  - Hiển thị thống kê số lượng học sinh giỏi, khá, trung bình, yếu.
  - Xuất kết quả tổng kết ra CSV.
- Xử lý công thức điểm trung bình học kỳ:

```text
Điểm TB học kỳ = Trung bình cộng điểm TB của các môn học
```

- Xếp loại học lực dựa trên bảng `XepLoaiHocLuc`.
- Xây dựng phân công giảng dạy:
  - Chọn năm học.
  - Chọn học kỳ.
  - Chọn lớp.
  - Load môn học theo khối của lớp.
  - Chọn giáo viên.
  - Thêm phân công.
  - Xóa phân công.
  - Chặn phân công trùng giáo viên, lớp, môn học, học kỳ.
- Phối hợp với Thành viên 5 để báo cáo lấy đúng dữ liệu tổng kết.

### Đầu ra cần bàn giao

- Form xem điểm.
- Form tổng kết học kỳ.
- Form phân công giảng dạy.
- BUS/DAL kết quả học tập.
- BUS/DAL phân công.
- Thuật toán tính điểm trung bình và xếp loại.

### Tiêu chí hoàn thành

- Xem được điểm chi tiết của học sinh.
- Học sinh chưa có điểm được thông báo rõ.
- Tính đúng điểm trung bình môn và học kỳ.
- Tổng kết một học sinh thành công.
- Tổng kết toàn bộ lớp thành công.
- Phân công giảng dạy thành công.
- Không thêm được phân công trùng.
- CSV tổng kết mở được bằng Excel.

## Thành viên 5 - Kết nối dữ liệu, danh mục dùng chung, báo cáo và UI/UX

### Vai trò

Thành viên 5 phụ trách lớp kết nối dữ liệu dùng chung, các danh mục hệ thống, báo cáo thống kê và kiểm tra giao diện tổng thể.

### Phạm vi phụ trách

- `DataProvider`.
- Danh mục năm học.
- Danh mục học kỳ.
- Danh mục khối.
- Danh mục hạnh kiểm.
- Danh mục xếp loại học lực.
- Báo cáo lớp.
- Báo cáo học sinh.
- Xuất CSV.
- Kiểm tra UI/UX toàn hệ thống.

### File phụ trách chính

```text
DAL/DataProvider.cs
DAL/NamHocDAL.cs
DAL/HocKyDAL.cs
DAL/KhoiDAL.cs
DAL/HanhKiemDAL.cs
DAL/XepLoaiHocLucDAL.cs
BUS/NamHocBUS.cs
BUS/HocKyBUS.cs
BUS/HanhKiemBUS.cs
BUS/XepLoaiHocLucBUS.cs
GUI/frmBaoCaoLop.cs
GUI/frmBaoCaoHocSinh.cs
DTO/NamHocDTO.cs
DTO/HocKyDTO.cs
DTO/KhoiDTO.cs
DTO/HanhKiemDTO.cs
DTO/XepLoaiHocLucDTO.cs
```

### Nhiệm vụ chi tiết

- Xây dựng và kiểm tra `DataProvider`:
  - Kết nối SQL Server.
  - Thực thi `SELECT`.
  - Thực thi `INSERT`, `UPDATE`, `DELETE`.
  - Thực thi truy vấn trả về một giá trị.
  - Truyền parameter an toàn.
- Chuẩn hóa connection string để dễ chạy trên nhiều máy.
- Xây dựng danh mục năm học:
  - Lấy danh sách năm học.
  - Lấy năm học hiện tại.
  - Thêm năm học.
  - Sửa năm học.
- Xây dựng danh mục học kỳ:
  - Lấy tất cả học kỳ.
  - Lấy học kỳ theo năm học.
  - Thêm học kỳ.
- Xây dựng danh mục khối:
  - Lấy danh sách khối.
  - Sắp xếp theo khối số.
- Xây dựng danh mục hạnh kiểm:
  - Lấy danh sách hạnh kiểm.
  - Phục vụ tổng kết học kỳ.
- Xây dựng danh mục xếp loại học lực:
  - Lấy danh sách xếp loại.
  - Lấy xếp loại theo điểm trung bình.
- Xây dựng báo cáo lớp:
  - Chọn năm học.
  - Chọn học kỳ.
  - Chọn lớp.
  - Hiển thị danh sách học sinh trong lớp.
  - Hiển thị điểm trung bình.
  - Hiển thị hạnh kiểm.
  - Hiển thị xếp loại.
  - Thống kê số lượng và tỷ lệ giỏi, khá, trung bình, yếu.
  - Tính điểm trung bình lớp.
  - Xuất báo cáo CSV.
- Xây dựng báo cáo học sinh:
  - Chọn học sinh.
  - Hiển thị thông tin cá nhân.
  - Hiển thị kết quả học tập qua các học kỳ.
  - Hiển thị điểm trung bình, hạnh kiểm, xếp loại.
- Kiểm tra UI/UX:
  - Bố cục form rõ ràng.
  - Label, button thống nhất tiếng Việt.
  - Bảng dữ liệu có header dễ hiểu.
  - Ẩn cột ID không cần thiết.
  - Thông báo lỗi rõ ràng.
  - CSV mở bằng Excel không lỗi tiếng Việt.

### Đầu ra cần bàn giao

- `DataProvider` hoạt động ổn định.
- Các danh mục dùng chung.
- Form báo cáo lớp.
- Form báo cáo học sinh.
- Chức năng xuất CSV.
- Checklist kiểm tra giao diện.

### Tiêu chí hoàn thành

- Các combobox năm học, học kỳ, khối, hạnh kiểm load đúng dữ liệu.
- Báo cáo lớp hiển thị đúng dữ liệu sau tổng kết.
- Báo cáo học sinh hiển thị đúng kết quả theo từng học kỳ.
- Thống kê tỷ lệ xếp loại chính xác.
- CSV mở bằng Excel hiển thị đúng tiếng Việt.

## 4. Kế hoạch thực hiện

| Giai đoạn | Thời gian | Nội dung | Thành viên phụ trách | Kết quả |
|---|---:|---|---|---|
| 1 | Ngày 1 | Chốt yêu cầu, phân công, chuẩn hóa cấu trúc dự án | Thành viên 1 | Danh sách chức năng, kế hoạch triển khai |
| 2 | Ngày 1-2 | Thiết kế database, tạo dữ liệu mẫu, kiểm tra kết nối | Thành viên 1, 5 | Database chạy được |
| 3 | Ngày 2-3 | Hoàn thiện DTO, học sinh, giáo viên, danh mục dùng chung | Thành viên 2, 5 | Dữ liệu nền sẵn sàng |
| 4 | Ngày 3-5 | Hoàn thiện lớp, môn học, phân lớp | Thành viên 3 | Có lớp, môn, học sinh trong lớp |
| 5 | Ngày 5-7 | Hoàn thiện đăng nhập, tài khoản, nhập điểm | Thành viên 1 | Có dữ liệu điểm |
| 6 | Ngày 7-9 | Hoàn thiện xem điểm, tổng kết, phân công | Thành viên 4 | Có kết quả tổng kết |
| 7 | Ngày 9-10 | Hoàn thiện báo cáo lớp, báo cáo học sinh, xuất CSV | Thành viên 5 | Có báo cáo |
| 8 | Ngày 10-11 | Tích hợp, kiểm thử, sửa lỗi | Cả nhóm | Bản chạy ổn định |
| 9 | Ngày 12 | Hoàn thiện tài liệu, chuẩn bị demo, bàn giao | Cả nhóm | Bản nộp hoàn chỉnh |

## 5. Phụ thuộc giữa các thành viên

| Thành viên | Phụ thuộc vào | Lý do |
|---|---|---|
| Thành viên 1 | Thành viên 2, 3, 5 | Cần học sinh, lớp, môn, danh mục để nhập điểm |
| Thành viên 2 | Thành viên 1 | Cần schema database để DTO khớp cột |
| Thành viên 3 | Thành viên 2, 5 | Cần học sinh, giáo viên, năm học, học kỳ, khối |
| Thành viên 4 | Thành viên 1, 3, 5 | Cần điểm, lớp, môn, phân lớp, hạnh kiểm, xếp loại |
| Thành viên 5 | Thành viên 1, 4 | Cần dữ liệu tổng kết để báo cáo |

## 6. Quy trình kiểm thử

### 6.1. Kiểm thử từng module

| Module | Người kiểm thử chính | Nội dung kiểm thử |
|---|---|---|
| Đăng nhập, phân quyền | Thành viên 1 | Đăng nhập đúng/sai, phân quyền Admin/non-Admin |
| Đổi mật khẩu | Thành viên 1 | Mật khẩu rỗng, mật khẩu ngắn, xác nhận không khớp |
| Quản lý tài khoản | Thành viên 1 | Thêm, sửa, xóa mềm, tìm kiếm, kiểm tra trùng |
| Quản lý học sinh | Thành viên 2 | Thêm, sửa, xóa, tìm kiếm, ngày sinh sai |
| Quản lý giáo viên | Thành viên 2 | Thêm, sửa, xóa, tìm kiếm, tuổi/email/số điện thoại sai |
| Quản lý lớp | Thành viên 3 | Thêm, sửa, xóa, chọn khối/năm học/GVCN |
| Quản lý môn học | Thành viên 3 | Thêm, sửa, xóa mềm, môn theo khối |
| Phân lớp | Thành viên 3 | Thêm học sinh vào lớp, chống trùng, xóa khỏi lớp |
| Nhập điểm | Thành viên 1 | Thêm, sửa, xóa điểm, điểm ngoài khoảng 0-10 |
| Xem điểm | Thành viên 4 | Học sinh có điểm, chưa có điểm, điểm trung bình |
| Tổng kết | Thành viên 4 | Tổng kết một học sinh, tổng kết cả lớp, học sinh chưa có điểm |
| Phân công | Thành viên 4 | Thêm phân công, xóa phân công, chống trùng |
| Báo cáo | Thành viên 5 | Báo cáo lớp, báo cáo học sinh, thống kê, xuất CSV |

### 6.2. Kiểm thử tích hợp

Luồng kiểm thử tích hợp bắt buộc:

1. Đăng nhập bằng tài khoản Admin.
2. Thêm giáo viên.
3. Thêm học sinh.
4. Tạo lớp học.
5. Tạo môn học theo khối.
6. Phân học sinh vào lớp.
7. Phân công giáo viên dạy môn cho lớp.
8. Nhập điểm cho học sinh.
9. Xem điểm học sinh.
10. Tổng kết học kỳ cho một học sinh.
11. Tổng kết học kỳ cho toàn bộ lớp.
12. Xem báo cáo lớp.
13. Xem báo cáo học sinh.
14. Xuất CSV.
15. Đăng xuất.
16. Đăng nhập bằng tài khoản không phải Admin để kiểm tra phân quyền.
