create database DB_PTUD_QLTV_V2
go
use DB_PTUD_QLTV_V2

/*	======================================
	Bảng thực thể
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

create table DauSach
(
	MaSach int identity(1,1),
	TenSach nvarchar(200),
	BiaSach nvarchar(200),
	TacGia nvarchar(100),
	MaTheLoai int,
	MaNXB int,
	NamXB datetime,
	constraint PK_DauSach primary key (MaSach)
)

create table BanIn
(
	MaBanIn int identity(1,1),
	MaSach int,
	TrangThai bit,
	constraint PK_BanIn primary key (MaBanIn)
)

create table DocGia
(
	MaDocGia int identity(1,1),
	TenDocGia nvarchar(100),
	NgaySinh datetime, 
	CMND varchar(12),
	constraint PK_DocGia primary key (MaDocGia)
)

create table TheThuVien
(
	MaThe int identity(1,1),
	MaDocGia int,
	NgayLap datetime,
	NgayHetHan datetime,
	GhiChu nvarchar(100),
	TinhTrang bit,
	constraint PK_TheThuVien primary key (MaThe)
)

create table NhanVien
(
	MaNhanVien int identity(1,1),
	TenNhanVien nvarchar(100),
	NgaySinh datetime, 
	constraint PK_NhanVien primary key (MaNhanVien)
)

create table PhieuMuon
(
	MaPhieuMuon int identity(1,1),
	MaNhanVien int,
	MaThe int,
	NgayMuon datetime,
	TinhTrang bit,
	constraint PK_PhieuMuon primary key (MaPhieuMuon)
)

create table ChiTietPhieuMuon
(
	MaPhieuMuon int,
	MaBanIn int,
	NgayTra datetime,
	DaTra bit,
	constraint PK_ChiTietMuonTra primary key (MaPhieuMuon, MaBanIn)
)

/*	======================================
	Khóa ngoại
	======================================	*/

alter table DauSach add
constraint FK_DauSach_TheLoai foreign key (MaTheLoai) references TheLoai(MaTheLoai),
constraint FK_DauSach_NhaXuatBan foreign key (MaNXB) references NhaXuatBan(MaNXB)

alter table BanIn add
constraint FK_BanIn_DauSach foreign key (MaSach) references DauSach(MaSach)

alter table TheThuVien add
constraint FK_TheThuVien_DocGia foreign key (MaDocGia) references DocGia(MaDocGia)

alter table PhieuMuon add
constraint FK_PhieuMuon_DocGia foreign key (MaNhanVien) references NhanVien(MaNhanVien),
constraint FK_PhieuMuon_TheThuVien foreign key (MaThe) references TheThuVien(MaThe)

alter table ChiTietPhieuMuon add
constraint FK_CTPM_PhieuMuon foreign key (MaPhieuMuon) references PhieuMuon(MaPhieuMuon),
constraint FK_CTPM_BanIn foreign key (MaBanIn) references BanIn(MaBanIn)


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
(N'Nhà xuất bản Đại Học Kinh Tế Quốc Dân', N'Hà Nội', '02436282487'),
(N'Nhà xuất bản Dân Trí', N'Hà Nội', '02466860751'),
(N'Nhà xuất bản Trẻ', N'Thành phố Hồ Chí Minh', '02839316289'),
(N'Nhà xuất bản Lao Động Xã Hội', N'Thành phố Hồ Chí Minh', '02838279414'),
(N'Nhà xuất bản Hồng Đức', N'Hà Nội', '02439260024'),
(N'Nhà xuất bản Văn Học', N'Thành phố Hồ Chí Minh', '02838469858'),
(N'Nhà xuất bản đại học Thái Nguyên', N'Thái Nguyên', '02083840023')

insert into DauSach values
(N'Bàn về tự do', N'Ban-ve-tu-do.jpg', N'John Stuart Mill', 1, 1, '2012-1-1'),
(N'Bộ luật hình sự', N'Bo-luat-hinh-su.jpg', N'Quốc hội Việt Nam', 1, 2, '2017-1-1'),
(N'Bộ luật lao động', N'Bo-luat-lao-dong-2019.jpg', N'Quốc hội Việt Nam', 1, 3, '2019-1-1'),
(N'Bộ luật tố tụng hình sự', N'Bo-luat-to-tung-hinh-su-2015.jpg', N'Quốc hội Việt Nam', 1, 2, '2015-1-1'),
(N'Luật hôn nhân và gia đình', N'Luat-hon-nhan-va-gia-dinh.jpg', N'Quốc hội Việt Nam', 1, 2, '2015-1-1'),
(N'Luật kinh doanh bất động sản', N'Luat-kinh-doanh-bat-dong-san.jpg', N'Quốc hội Việt Nam', 1, 2, '2020-1-1'),
(N'Luật thương mại', N'Luat-thuong-mai.jpg', N'Quốc hội Việt Nam', 1, 2, '2017-1-1'),
(N'Bộ luật tố tụng dân sự', N'Luat-to-tung-dan-su.jpg', N'Quốc hội Việt Nam', 1, 2, '2019-1-1'),
(N'Luật tố tụng hành chính', N'Luat-to-tung-hanh-chinh.jpg', N'Quốc hội Việt Nam', 1, 2, '2019-1-1'),
(N'Thừa kế tài sản, nhà đất', N'Thua-ke-tai-san-nha-dat.jpg', N'Đỗ Đăng Khoa', 1, 1, '2020-1-1'),
(N'6 phát minh làm nên Thời Đại', N'sach-6-phat-minh-lam-nen-thoi-da.png', N'Steven Johnson', 2, 4, '2020-1-1'),
(N'12 xu hướng công nghệ trong thời đại 4.0', N'sach-12-xu-huong-cong-nghe-trong-thoi-dai-4.0.png', N'Kevin Kelly', 2, 5, '2019-1-1'),
(N'Cuộc chiến công nghệ số', N'sach-cuoc-chien-cong-nghe-so.png', N'Charles Arthur', 2, 7, '2019-1-1'),
(N'Cuộc đời bất tử của Henrietta Lacks', N'sach-cuoc-doi-bat-tu-cua-henrietta-lacks.png', N'Rebecca Skloot', 2, 3, '2018-1-1'),
(N'Thuyết minh trực quan nhất về khoa học', N'sach-dk-thuyet-minh-truc-quan-nhat-ve-khoa-hoc.png', N'Adam Hard-Davis', 2, 7, '2019-1-1'),
(N'Elon Musk', N'sach-elon-musk-tesla.png', N'Quang Thiệu', 2, 4, '2020-1-1'),
(N'Fintech 4.0', N'sach-fintech-4.0.png', N'Kitao Yoshitaka', 2, 4, '2018-1-1'),
(N'Lược sử thời gian', N'sach-luoc-su-thoi-gian.png', N'Stephen Hawking', 2, 7, '2018-1-1'),
(N'Thành phố thông minh', N'sach-thanh-pho-thong-minh-nen-tang-nguyen-ly.png', N'Ngô Thành Nhân', 2, 2, '2017-1-1'),
(N'Vật liệu và thiết bị Nano', N'sach-vat-lieu-va-thiet-bi-nano.png', N'', 2, 1, '2018-1-1'),
(N'Bản chất của dối trá', N'Ban-chat-cua-doi-tra.jpg', N'Dan Ariely', 3, 8, '2019-1-1'),
(N'Chúng ta quyết định như thế nào?', N'Chung-ta-quyet-dinh-nhu-the-nao.jpg', N'Tonah Lehrer', 3, 8, '2018-1-1'),
(N'Điểm bùng phát', N'Diem-bung-phat.jpg', N'Malcolm Gladwell', 3, 4, '2017-1-1'),
(N'Đi tìm lẽ sống', N'di-tim-le-song.jpg', N'Viktor E.Frankl', 3, 1, '2019-1-1'),
(N'Đọc vị bất kì ái', N'Doc-vi-bat-ki-ai.jpg', N'Ts. David J.Lieberman', 3, 1, '2020-1-1'),
(N'Nghịch lý của sự lựa chọn', N'Nghich-ly-cua-su-lua-chon.jpg', N'Barry Schwartz', 3, 8, '2018-1-1'),
(N'Những đòn tâm lý trong thuyết phục', N'Nhung-don-tam-lý-trong-thuyet-phuc.jpg', N'Robert B.Cialdini', 3, 3, '2022-1-1'),
(N'Sức mạnh của tiềm thức', N'Suc-manh-tiem-thuc.jpg', N'Joseph Murphy', 3, 1, '2018-1-1'),
(N'Tâm lý học', N'Tam-li-hoc.jpg', N'Nguyễn Thảo Trang', 3, 1, '2016-1-1'),
(N'Tâm lý học hài hước', N'Tam-ly-hoc-hai-huoc.jpg', N'Richard Wiseman', 3, 3, '2018-1-1'),
(N'Bồ câu bay đi tìm bà', N'Bo-cau-di-tim-ba.jpg', N'Walter Macken', 4, 2, '2021-1-1'),
(N'Búp sen xanh', N'Bup-sen-xanh.jpg', N'Sơn Tùng', 4, 1, '2018-1-1'),
(N'Charlotte và Wilbur', N'Charlotte-va-wilbur.jpg', N'E.B.White', 4, 1, '2020-1-1'),
(N'Chú bé mang pyjama sọc', N'Chu-be-mang-pyjama-soc-2018.jpg', N'John Boyne', 4, 1, '2020-1-1'),
(N'Con mèo dạy hải âu bay', N'Con-meo-day-hai-au-bay.jpg', N'Luis Sepúlveda', 4, 1, '2021-1-1'),
(N'Con yêu bố chừng nào', N'Con-yeu-bo.jpg', N'Sam McBratney', 4, 3, '2019-1-1'),
(N'Dế mèn phiêu lưu ký', N'De-men-phieu-luu-ky-2019.jpg', N'Ô Hoài', 4, 1, '2018-1-1'),
(N'Hoàng tử bé', N'Hoang-tu-be-2019.jpg', N'Antoine De Saint Exupery', 4, 3, '2018-1-1'),
(N'Pippy tất dài', N'pippy-tat-dai.jpg', N'Astrid Lindgren', 4, 3, '2017-1-1'),
(N'Ruột ơi là ruột', N'Ruot-oi-la-ruot.jpg', N'Giulia Enders', 4, 1, '2021-1-1'),
(N'Bên rặng tuyết sơn', N'Ben-rang-tuyet-son.jpg', N'Swami Amar Jyoti', 5, 4, '2017-1-1'),
(N'Dấu chân trên cát', N'Dau-chan-tren-cat-2020.jpg', N'Nguyễn Phong', 5, 1, '2015-1-1'),
(N'Không diệt không sinh đừng sợ hãi', N'Khong-diet-khong-sinh-dung-so-hai.jpg', N'Thích Nhất Hạnh', 5, 1, '2017-1-1'),
(N'Muốn an được an', N'Muon-an-duoc-an.jpg', N'Thích Nhất Hạnh', 5, 3, '2019-1-1'),
(N'Muôn kiếp nhân sinh', N'Muon-kiep-nhan-sinh.jpg', N'Nguyễn Phong', 5, 1, '2020-1-1'),
(N'Năng đoạn kim cương', N'Nang-doan-kim-cuong-2020.jpg', N'Geshe Michael Roach', 5, 1, '2021-1-1'),
(N'Osho ươm mầm', N'Osho-uom-mam.jpg', N'Osho', 5, 1, '2018-1-1'),
(N'Thiền Osho', N'Thien-osho.jpg', N'Osho', 5, 1, '2018-1-1'),
(N'Thực hành thiền định', N'Thuc-hanh-thien-dinh.jpg', N'Matthieu Ricard', 5, 3, '2021-1-1'),
(N'Vô ngã luân hồi', N'Vo-nga-va-luan-hoi.jpg', N'Hoàng Tuấn Oai', 5, 3, '2017-1-1'),
(N'Calling you', N'Calling-you.jpg', N'Otsuichi', 6, 9, '2015-1-1'),
(N'Chuyện này chuyện kia', N'Chuyen-nay-chuyen-kia.jpg', N'Đốm Đốm', 6, 9, '2019-1-1'),
(N'Dang dở', N'Dang-do.jpg', N'Yuu Nagira', 6, 1, '2016-1-1'),
(N'Housemates', N'Housemates.jpg', N'Zen', 6, 6, '2018-1-1'),
(N'Khó khăn như chăn mèo', N'Kho-khan-nhu-chan-meo.jpg', N'Sarah Andersen', 6, 9, '2019-1-1'),
(N'Nhật ký của một cô nàng tự lập', N'Nhat-ky-cua-mot-co-nang-tu-lap.jpg', N'Sen Xàm Xí', 6, 9, '2021-1-1'),
(N'Những nỗi sợ sâu thẳm', N'Nhung-noi-so-sau-tham.jpg', N'Fran Krause', 6, 6, '2018-1-1'),
(N'Poco ở thế giới Udon', N'Pocco-o-the-gioi-udon-chap1.jpg', N'Nodoka Shinomaru', 6, 9, '2017-1-1'),
(N'ReLIFE', N'ReLife-chap13.jpg', N'YayoiSo', 6, 9, '2019-1-1'),
(N'Truyện cổ tích của anh em Grim', N'Truyen-co-tich-cua-anh-em-grim.jpg', N'Jacob', 6, 6, '2021-1-1'),
(N'Vùng đất Nam Bộ', N'bo-sach-vung-dat-nam-bo-qua-trinh-hinh-thanh-va-phat-trien.jpg', N'Phan Huy Lê', 7, 2, '2021-1-1'),
(N'Văn minh Trung Hoa', N'cuon-sach-van-minh-trung-hoa.jpg', N'Lưu Đồng', 7, 2, '2021-1-1'),
(N'Cẩm nang lễ hội truyền thống Việt Nam', N'sach-cam-nang-le-hoi-truyen-thong-viet-nam.jpg', N'Phạm Trình', 7, 9, '2018-1-1'),
(N'Danh ngôn của Chủ tịch Hồ Chí Minh', N'sach-danh-ngon-cua-chu-tich-ho-chi-minh.jpg', N'Tần Phú', 7, 9, '2016-1-1'),
(N'Dấu ấn lịch sử của Việt Nam trên Biển Đông', N'sach-dau-an-lich-su-cua-viet-nam-tren-bien-dong.jpg', N'Tần Phú', 7, 9, '2021-1-1'),
(N'Di sản văn hóa dòng họ Nguyễn', N'sach-di-san-van-hoa-dong-ho-nhung-den-tho-lang-va-cung-dien-ho-nguyen-viet-nam.jpg', N'Nguyễn Văn Kiệm', 7, 9, '2019-1-1'),
(N'Kỳ tích đường Hồ Chí Minh trên biển', N'sach-ky-tich-duong-ho-chi-minh-tren-bien.jpg', N'Quí Lâm', 7, 9, '2020-1-1'),
(N'Lịch sử quân sự Việt Nam', N'sach-lich-su-quan-su-viet-nam-.jpg', N'Bộ quốc phòng', 7, 2, '2019-1-1'),
(N'Nghi lễ thờ cúng cổ truyền của người Việt', N'sach-nghi-le-tho-cung-co-truyen-cua-nguoi-viet.jpg', N'Ngọc Tuyên', 7, 9, '2019-1-1'),
(N'Tìm hiểu di tích lịch sử các nhà tù trong cuộc kháng chiến chống Pháp và Mỹ', N'tim-hieu-di-tich-lich-su-cac-nha-tu-trong-cuoc-khang-chien-chong-phap-va-my.jpg', N'Hoàng Lan', 7, 9, '2021-1-1'),
(N'Cánh đồng bất tận', N'canh-dong-bat-tan.jpg', N'Nguyễn Ngọc Tư', 8, 7, '2021-1-1'),
(N'Đất rừng Phương Nam', N'Dat-rung-phuong-nam.jpg', N'Đoàn Giỏi', 8, 7, '2019-1-1'),
(N'Hà Nội băm sáu phố phường', N'ha-noi-bam-sau-pho-phuong.jpg', N'Thạch Lâm', 8, 10, '2019-1-1'),
(N'Nhớ câu hát lượn', N'Nho-cau-hat-luon.jpg', N'Quang Tiều', 8, 11, '2017-1-1'),
(N'Những ngày thơ ấu', N'nhung-ngay-tho-au.jpg', N'Nguyên Hồng', 8, 10, '2016-1-1'),
(N'Rừng hương', N'Rung-huong.jpg', N'Lê Khắc Phấn', 8, 11, '2015-1-1'),
(N'Số Đỏ', N'So-do.jpg', N'Vũ Trọng Phụng', 8, 10, '2018-1-1'),
(N'Thương nhớ mười hai', N'Thuong_nho_muoi_hai.jpg', N'Vũ Bằng', 8, 9, '2019-1-1'),
(N'Tình chiều', N'Tinh-chieu.jpg', N'Chu Thành', 8, 11, '2021-1-1'),
(N'Tuyển tập Triệu Kim Vân', N'Tuyen-tap-trieu-kim-van.jpg', N'Triệu Kim Vân', 8, 11, '2015-1-1')

/*	======================================
	Tạo view ở đây và tạo view bằng script
	Lưu ý ghi chú lại view dùng để làm gì
	======================================	*/

create view view_DSDauSach as
SELECT dbo.DauSach.MaSach, dbo.DauSach.TenSach, dbo.DauSach.BiaSach, dbo.DauSach.TacGia, dbo.TheLoai.TenTheLoai, dbo.NhaXuatBan.TenNXB, dbo.DauSach.NamXB
FROM dbo.DauSach INNER JOIN
dbo.NhaXuatBan ON dbo.DauSach.MaNXB = dbo.NhaXuatBan.MaNXB INNER JOIN
dbo.TheLoai ON dbo.DauSach.MaTheLoai = dbo.TheLoai.MaTheLoai

select * from view_DSDauSach

create view view_DSPhieuMuon as
SELECT dbo.PhieuMuon.MaPhieuMuon, dbo.NhanVien.TenNhanVien, dbo.TheThuVien.MaThe, dbo.DocGia.TenDocGia, dbo.PhieuMuon.NgayMuon, dbo.PhieuMuon.TinhTrang
FROM dbo.PhieuMuon INNER JOIN
dbo.NhanVien ON dbo.PhieuMuon.MaNhanVien = dbo.NhanVien.MaNhanVien INNER JOIN
dbo.TheThuVien ON dbo.PhieuMuon.MaThe = dbo.TheThuVien.MaThe INNER JOIN
dbo.DocGia ON dbo.TheThuVien.MaDocGia = dbo.DocGia.MaDocGia

select * from view_DSDauSach

/*	======================================
	Trigger
	======================================	*/

/*	======================================
	Các chỉnh sửa
	======================================	*/

-- Thêm cột NgayHenTra và GhiChu vào bảng ChiTietPhieuMuon
alter table ChiTietPhieuMuon drop column NgayTra, DaTra

alter table ChiTietPhieuMuon add 
NgayHenTra datetime,
NgayTra datetime,
GhiChu nvarchar(100)

-- Thêm bảng PhieuTra và ChiTietPhieuTra
create table PhieuTra
(
	MaPhieuTra int identity(1,1),
	MaPhieuMuon int,
	MaNhanVien int,
	MaThe int,
	NgayTra datetime,
	constraint PK_PhieuTra primary key (MaPhieuTra)
)

alter table PhieuTra add
constraint FK_PhieuTra_PhieuMuon foreign key (MaPhieuMuon) references PhieuMuon(MaPhieuMuon),
constraint FK_PhieuTra_DocGia foreign key (MaNhanVien) references NhanVien(MaNhanVien),
constraint FK_PhieuTra_TheThuVien foreign key (MaThe) references TheThuVien(MaThe)

create table ChiTietPhieuTra
(
	MaPhieuTra int,
	MaBanIn int,
	DaTra bit,
	constraint PK_ChiTietPhieuTra primary key (MaPhieuTra, MaBanIn)
)

alter table ChiTietPhieuTra add
constraint FK_CTPT_PhieuTra foreign key (MaPhieuTra) references PhieuTra(MaPhieuTra),
constraint FK_CTPT_BanIn foreign key (MaBanIn) references BanIn(MaBanIn)

-- Rename khóa chính của bảng ChiTietPhieuMuon
sp_rename @objname = N'[ChiTietPhieuMuon].[PK_ChiTietMuonTra]', @newname = N'PK_ChiTietPhieuMuon'

-- Thêm dữ liệu bảng DocGia, TheThuVien và NhanVien
set dateformat DMY
insert into DocGia values
(N'Nguyễn Văn A', '22/11/2001', 'CMND-001'),
(N'Nguyễn Văn B', '15/1/1998', 'CMND-002'),
(N'Nguyễn Văn C', '28/3/2000', 'CMND-003'),
(N'Nguyễn Văn D', '1/12/1999', 'CMND-004'),
(N'Nguyễn Thị E', '6/6/1999', 'CMND-005'),
(N'Nguyễn Thị F', '21/12/2003', 'CMND-006'),
(N'Nguyễn Thị G', '3/5/2000', 'CMND-007'),
(N'Nguyễn Thị H', '5/7/1998', 'CMND-008')

set dateformat DMY
insert into TheThuVien values
(1, '20/5/2022', '20/11/2022', N'Đang hoạt động', 1),
(2, '10/5/2022', '10/11/2022', N'Đang hoạt động', 1),
(3, '1/1/2022', '1/7/2022', N'Đang hoạt động', 1),
(4, '15/12/2021', '15/5/2022', N'Hết hạn', 0),
(5, '20/1/2022', '20/7/2022', N'Đang hoạt động', 1),
(6, '20/5/2022', '20/11/2022', N'Đang hoạt động', 1),
(7, '3/3/2021', '3/9/2021', N'Hết hạn', 0),
(8, '12/6/2022', '12/12/2022', N'Đang hoạt động', 1)

set dateformat DMY
insert into NhanVien values
(N'Trí Em', '3/9/2001'),
(N'Lộc Ú', '29/12/2001')

/*	======================================
	Bãi thử
	======================================	*/

SELECT IDENT_CURRENT('BanIn')

select * from PhieuMuon where MaPhieuMuon = 1
select * from ChiTietPhieuMuon where MaPhieuMuon = 1
select * from BanIn where TrangThai = 1 

