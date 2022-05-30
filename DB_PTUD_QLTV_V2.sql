create database DB_PTUD_QLTV_V2
go
use DB_PTUD_QLTV_V2

/*	======================================
	Các bảng thực thể và khóa ngoại
	======================================	*/

create table TheLoai
(
	MaTheLoai int identity(1,1),
	TenTheLoai nvarchar(100),
	constraint PK_TheLoai primary key (MaTheLoai)
)

create table NhaXuatBan
(
	MaNXB int identity(1,1),
	TenNXB nvarchar(100),
	DiaChiNXB nvarchar(100),
	DienThoaiNXB varchar(15),
	constraint PK_NhaXuatBan primary key (MaNXB)
)

/*	======================================
	Dữ liệu
	======================================	*/

insert into TheLoai values
(N'Chính trị - pháp luật'),
(N'Khoa học công nghệ - kinh tế'),
(N'Tâm lý'),
(N'Thiếu nhi'),
(N'Tôn giáo'),
(N'Tiểu thuyết - truyện ngắn'),
(N'Văn hóa xã hội - lịch sử'),
(N'Văn học nghệ thuật')

insert into NhaXuatBan values
(N'Nhà xuất bản Tổng hợp Thành phố Hồ Chí Minh', N'Thành phố Hồ Chí Minh', '02838225340'),
(N'Nhà xuất bản Chính trị Quốc gia Sự Thật', N'Thành phố Hồ Chí Minh', '02839325400'),
(N'Nhà xuất bản Lao Động', N'Hà Nội', '0438515380'),
(N'Nhà xuất bản Thế Giới', N'Thành phố Hồ Chí Minh', '02838220102'),
(N'Nhà Xuất Bản Đại Học Kinh Tế Quốc Dân', N'Hà Nội', '02436282487'),
(N'Nhà xuất bản Dân Trí', N'Hà Nội', '02466860751'),
(N'', N'', ''),
(N'', N'', ''),
(N'', N'', ''),
(N'', N'', ''),
(N'', N'', ''),
(N'', N'', ''),
(N'', N'', '')

/*	======================================
	Tạo view ở đây và tạo view bằng script
	Lưu ý ghi chú lại view dùng để làm gì
	======================================	*/

