use master
go

create database VPP
go

use VPP
go

create table QuanLi
(
	maQL int not null IDENTITY(1,1) primary key,
	hoten nvarchar(100) not null,
	ngaySinh date,
	taiKhoan varchar(100) not null,
	matKhau varchar(100) not null,
)
go

create table DanhMucSP
(
	maDM int not null IDENTITY(1,1) primary key,
	tenDM nvarchar(200) not null,
)
go

create table NhomSP
(
	maNhomSP int not null,
	tenNhomSP nvarchar(200) not null,
	maDM int not null FOREIGN KEY REFERENCES DanhMucSP(maDM),
	CONSTRAINT PK_NSP PRIMARY KEY (maNhomSP, maDM),
)
go

create table SanPham
(
	maSP int not null IDENTITY(1,1) primary key,
	tenSP nvarchar(200) not null,
	giaBan float,
	chiTiet nvarchar(500),
	anhSP varchar(50),
	maNhomSP int not null,
	maDM int not null FOREIGN KEY REFERENCES DanhMucSP(maDM),
	constraint FK_SPNSP FOREIGN KEY (maNhomSP, maDM) references NhomSP(maNhomSP, maDM)
)
go

create table DonHang
(
	maDH int not null IDENTITY(1,1) primary key,
	ngayLap date default GETDATE(),
	tinhTrang int default 0,
	hoTen nvarchar(50) not null,
	dienThoai varchar(15) not null,
	email varchar(50),
	diaChi nvarchar(500) not null
)
go

create table ChiTietDonHang
(
	maCTDH int not null IDENTITY(1,1) PRIMARY KEY,
	soLuong int not null,
	maSP int not null FOREIGN KEY REFERENCES SanPham(maSP),
	maDH int not null FOREIGN KEY REFERENCES DonHang(maDH),
)
go

create table LienHe
(
	maLH int not null IDENTITY(1,1) primary key,
	hoTen nvarchar(50) not null,
	dienThoai varchar(15) not null,
	email varchar(50),
	noiDung nvarchar(500),
	ngayLap date default GETDATE(),
	tinhTrang bit default 0
)
go


insert into DanhMucSP values(N'BÚT CÁC LOẠI')
insert into DanhMucSP values(N'DỤNG CỤ VĂN PHÒNG')
insert into DanhMucSP values(N'FILE HỒ SƠ')
insert into DanhMucSP values(N'GIẤY CÁC LOẠI')
insert into DanhMucSP values(N'MÁY VĂN PHÒNG')
insert into DanhMucSP values(N'SỔ CÁC LOẠI')
insert into DanhMucSP values(N'TẠP HÓA PHẨM')

insert into NhomSP values(1, N'Bút Bi – Bút Kim – Bút Ký Cao Cấp', 1)
insert into NhomSP values(2, N'Bút Chì – Gọt Chì – Tẩy', 1)
insert into NhomSP values(3, N'Bút Dạ Dầu/Mực – Bút Ghi Đĩa', 1)
insert into NhomSP values(4, N'Bút Nhớ Dòng', 1)
insert into NhomSP values(5, N'Bút Viết Bảng – Bông Xóa Bảng', 1)
insert into NhomSP values(6, N'Bút Xóa – Băng Xóa', 1)

insert into NhomSP values(1,N'Băng Dính – Cắt Băng Dính – Hồ/Keo Dán', 2)
insert into NhomSP values(2,N'Bảng Từ – Bảng Foocmica', 2)
insert into NhomSP values(3,N'Cardcase – Menu Mica – Bìa Mica', 2)
insert into NhomSP values(4,N'Chun Vòng – Mút/Sáp Đếm Tiền', 2)
insert into NhomSP values(5,N'Dao Rọc Giấy – Lưỡi Dao – Kéo', 2)
insert into NhomSP values(6,N'Dập Ghim – Dập Lỗ – Gỡ Ghim', 2)
insert into NhomSP values(7,N'Dấu – Mực Dấu – Bàn Dấu', 2)
insert into NhomSP values(8,N'Ghim Cài – Ghim Mũ – Ghim Từ', 2)
insert into NhomSP values(9,N'Ghim Dập', 2)
insert into NhomSP values(10,N'Kẹp Bướm', 2)
insert into NhomSP values(11,N'Khay Cắm Bút – Thước Kẻ', 2)
insert into NhomSP values(12,N'Thanh Cài Acco', 2)
insert into NhomSP values(13,N'Thẻ – Dây Thẻ – Đĩa CD – Pin', 2)
insert into NhomSP values(14,N'USB – Bàn Phím – Chuột Máy Tính', 2)

insert into NhomSP values(1,N'Cặp Tài Liệu', 3)
insert into NhomSP values(2,N'Chia File', 3)
insert into NhomSP values(3,N'Clear Bag – File Mở Góc', 3)
insert into NhomSP values(4,N'File Còng Bật – File Còng Ống', 3)
insert into NhomSP values(5,N'File Còng Nhẫn – File Lồng', 3)
insert into NhomSP values(6,N'File Hồ Sơ – Khay Hồ Sơ', 3)
insert into NhomSP values(7,N'File Hộp Gấp', 3)
insert into NhomSP values(8,N'File Lá – Sơ Mi Lỗ', 3)
insert into NhomSP values(9,N'File Rút Gáy – File Acco', 3)
insert into NhomSP values(10,N'File Trình Ký – Khóa Trình Ký', 3)
insert into NhomSP values(11,N'Tủ Hồ Sơ', 3)

insert into NhomSP values(1,N'Giấy Dán Nhãn – Giấy Đề Can', 4)
insert into NhomSP values(2,N'Giấy Fax – Film Fax – Giấy Than', 4)
insert into NhomSP values(3,N'Giấy In Ảnh, In Phun Màu', 4)
insert into NhomSP values(4,N'Giấy Nhắn – Giấy Đánh Dấu Trang', 4)
insert into NhomSP values(5,N'Giấy Photo – Bìa Màu', 4)

insert into NhomSP values(1,N'Máy Fax', 5)
insert into NhomSP values(2,N'Máy In', 5)
insert into NhomSP values(3,N'Máy In Nhãn', 5)
insert into NhomSP values(4,N'Máy Photocopy', 5)
insert into NhomSP values(5,N'Máy Scan', 5)
insert into NhomSP values(6,N'Máy Tính Casio', 5)
insert into NhomSP values(7,N'Máy Tính Tiền', 5)
insert into NhomSP values(8,N'Máy Hủy Tài Liệu', 5)

insert into NhomSP values(1,N'Chứng Từ Kế Toán', 6)
insert into NhomSP values(2,N'Phong Bì – Túi Hồ Sơ', 6)
insert into NhomSP values(3,N'Sổ Bìa Cứng – Sổ Đầu Thừa', 6)
insert into NhomSP values(4,N'Sổ Công Văn – Sổ Kế Toán', 6)
insert into NhomSP values(5,N'Sổ Da', 6)
insert into NhomSP values(6,N'Sổ Lò Xo – Sổ Xé', 6)
insert into NhomSP values(7,N'Sổ Name Card – Hộp Card', 6)
insert into NhomSP values(8,N'Vở Học Sinh', 6)

insert into NhomSP values(1,N'Chất Tẩy Rửa', 7)
insert into NhomSP values(2,N'Giấy Ăn – Giấy Vệ Sinh', 7)
insert into NhomSP values(3,N'Đồ Dùng Vệ Sinh', 7)
insert into NhomSP values(4,N'Đồ Uống', 7)

insert into SanPham values(N'Ruột bút bi Pentel BL 57 xanh', 2000, N'', 'but11.jpg', 1,1)
insert into SanPham values(N'Mực bút máy Queen đen', 10000, N'', 'but12.jpg', 1,1)
insert into SanPham values(N'Bút Nhớ Dòng Deli S600', 6000, N'', 'but21.jpg', 4,1)
insert into SanPham values(N'Bút nhớ dòng Today', 8000, N'', 'but21.jpg', 4,1)
insert into SanPham values(N'Tẩy chì Sunwood', 3000, N'', 'but31.jpg', 2,1)
insert into SanPham values(N'Tẩy chì hoa quả', 3000, N'', 'but32.jpg', 2,1)
insert into SanPham values(N'Bút Xóa Classmate', 5000, N'', 'but41.jpg', 6,1)
insert into SanPham values(N'Bút Xóa Batos', 5000, N'', 'but42.jpg', 6,1)
insert into SanPham values(N'Bút lông dầu Artline 100 các màu', 5000, N'', 'but51.jpg', 3,1)
insert into SanPham values(N'Mực bút Artline các màu', 5000, N'', 'but52.jpg', 3,1)
insert into SanPham values(N'Phấn Mic trắng 215', 5000, N'', 'but61.jpg', 2,1)
insert into SanPham values(N'Mực bút viết bảng TL đỏ', 5000, N'', 'but62.jpg', 2,1)



insert into SanPham values(N'Hồ nước Mic', 3000, N'', 'dung11.jpg', 1,2)
insert into SanPham values(N'Băng dính giấy 5F', 6000, N'', 'dung12.jpg', 1,2)
insert into SanPham values(N'Bảng Fooc Mica', 20000, N'', 'dung21.jpg', 2,2)
insert into SanPham values(N'Bảng ghim', 160000, N'', 'dung22.jpg', 2,2)
insert into SanPham values(N'Bìa Mica A4 dày', 4000, N'', 'dung31.jpg', 3,2)
insert into SanPham values(N'Bìa Mica A4 trung', 4000, N'', 'dung32.jpg', 3,2)
insert into SanPham values(N'Chun đỏ', 13000, N'', 'dung41.jpg', 4,2)
insert into SanPham values(N'Chun vòng to', 15000, N'', 'dung42.jpg', 4,2)
insert into SanPham values(N'Lưỡi dao trổ Deli to 2011', 10000, N'', 'dung51.jpg', 5,2)
insert into SanPham values(N'Lưỡi dao trổ Comix nhỏ B2851', 10000, N'', 'dung52.jpg', 5,2)
insert into SanPham values(N'Đục lỗ Deli 0104 35 tờ', 9000, N'', 'dung61.jpg', 6,2)
insert into SanPham values(N'Đục lỗ Comix B2915N 25 tờ', 8000, N'', 'dung62.jpg', 6,2)
insert into SanPham values(N'Khay mực dấu tròn Deli 9863', 13000, N'', 'dung71.jpg', 7,2)
insert into SanPham values(N'Khay mực dấu Shinny SM1', 16000, N'', 'dung72.jpg', 7,2)
insert into SanPham values(N'Đinh ghim mũi nhựa Comix B3547', 15000, N'', 'dung81.jpg', 8,2)
insert into SanPham values(N'Kẹp từ tính gắn bảng Plus lớn', 8000, N'', 'dung82.jpg', 8,2)
insert into SanPham values(N'Ghim dập Max T310MB', 21000, N'', 'dung91.jpg', 9,2)
insert into SanPham values(N'Ghim dập Deli 23/10', 16000, N'', 'dung92.jpg', 9,2)
insert into SanPham values(N'kẹp bướm màu 50mm', 24000, N'', 'dung101.jpg', 10,2)
insert into SanPham values(N'kẹp bướm màu 32mm', 20000, N'', 'dung102.jpg', 10,2)
insert into SanPham values(N'Hộp cắm bút Sunwood', 23000, N'', 'dung111.jpg', 11,2)
insert into SanPham values(N'Hộp cắm bút tháp xoáy', 25000, N'', 'dung112.jpg', 11,2)
insert into SanPham values(N'Thanh cài Acco inox', 32000, N'', 'dung121.jpg', 12,2)
insert into SanPham values(N'Thanh cài acco nhựa', 19000, N'', 'dung122.jpg', 12,2)
insert into SanPham values(N'Vỏ đựng đĩa giấy', 3000, N'', 'dung131.jpg', 13,2)
insert into SanPham values(N'Pin Panasonic AAA', 6000, N'', 'dung132.jpg', 13,2)
insert into SanPham values(N'Chuột máy tính không dây Genius Eco 8100', 130000, N'', 'dung141.jpg', 14,2)
insert into SanPham values(N'Chuột máy tính có dây Genius', 160000, N'', 'dung142.jpg', 14,2)





insert into SanPham values(N'Cặp ba dây giấy SaoViet', 11000, N'', 'file11.jpg', 1 ,3)
insert into SanPham values(N'Cặp ba dây nhựa SaoViet', 15000, N'', 'file12.jpg', 1 ,3)
insert into SanPham values(N'Phân trang Kava 5 màu nhựa', 20000, N'', 'file21.jpg', 2 ,3)
insert into SanPham values(N'Phân trang Deli 5 màu nhựa A102', 16000, N'', 'file22.jpg', 2 ,3)
insert into SanPham values(N'Clear Bag khổ F', 4000, N'', 'file31.jpg', 3 ,3)
insert into SanPham values(N'Clear Bag A khổ dầy', 6000, N'', 'file32.jpg', 3 ,3)
insert into SanPham values(N'File còng ống Kingjim 3515-15F', 35000, N'', 'file41.jpg', 4 ,3)
insert into SanPham values(N'File còng ống Kingjim 3513-13F', 40000, N'', 'file42.jpg', 4 ,3)
insert into SanPham values(N'File còng ống Kingjim 1473-3F', 23000, N'', 'file51.jpg', 5 ,3)
insert into SanPham values(N'File còng nhẫn TL FO-ORB 03-35mm', 18000, N'', 'file52.jpg', 5 ,3)
insert into SanPham values(N'File nan 4 ngăn Sunwood', 19000, N'', 'file61.jpg', 6 ,3)
insert into SanPham values(N'File nan 4 ngăn Deli 9846', 18000, N'', 'file62.jpg', 6 ,3)
insert into SanPham values(N'File hộp giấy A3 10F', 13000, N'', 'file71.jpg', 7 ,3)
insert into SanPham values(N'File Hộp gấp 5F', 16000, N'', 'file72.jpg', 7 ,3)
insert into SanPham values(N'Fila lá Wang Bo 30 lá', 15000, N'', 'file81.jpg', 8 ,3)
insert into SanPham values(N'File lá TL FO DB05 100 lán', 28000, N'', 'file82.jpg', 8 ,3)
insert into SanPham values(N'File rút gáy bé dày Q310', 11000, N'', 'file91.jpg', 9 ,3)
insert into SanPham values(N'File rút gáy hình bán nguyệt', 6000, N'', 'file92.jpg', 9 ,3)
insert into SanPham values(N'Trình ký Sao Việt 2 mặt 2 mặt da', 14000, N'', 'file101.jpg', 10 ,3)
insert into SanPham values(N'Trình ký nhựa 1 mặt A5', 10000, N'', 'file102.jpg', 10 ,3)
insert into SanPham values(N'Tủ đựng tài liệu Deli 8855', 120000, N'', 'file111.jpg', 11 ,3)
insert into SanPham values(N'Tủ đựng tài liệu Deli 8877', 250000, N'', 'file112.jpg', 11 ,3)





insert into SanPham values(N'Nhãn dán Tommy A5 120', 13000, N'', 'giay11.jpg', 1 ,4)
insert into SanPham values(N'Nhãn dán Tommy A5 101', 16000, N'', 'giay12.jpg', 1 ,4)
insert into SanPham values(N'Giấy than G star', 20000, N'', 'giay21.jpg', 2 ,4)
insert into SanPham values(N'Giấy than HOURSE A4', 16000, N'', 'giay22.jpg', 2 ,4)
insert into SanPham values(N'Giấy in nhiệt', 44000, N'', 'giay31.jpg', 3 ,4)
insert into SanPham values(N'Giấy in Card Kim Mai A4 ĐL 250', 54000, N'', 'giay32.jpg', 3 ,4)
insert into SanPham values(N'Giấy nhớ Pronoti 5 màu giấy', 13000, N'', 'giay41.jpg', 4 ,4)
insert into SanPham values(N'Giấy nhớ Please Sign Pronoti', 15000, N'', 'giay42.jpg', 4 ,4)
insert into SanPham values(N'Giấy Pagi A4 ĐL 70', 60000, N'', 'giay51.jpg', 5 ,4)
insert into SanPham values(N'Giấy Double A5 ĐL 70', 50000, N'', 'giay52.jpg', 5 ,4)




insert into SanPham values(N'Máy Fax Canon Laser L140', 2100000, N'', 'may11.jpg', 1 ,5)
insert into SanPham values(N'Máy Fax Canon Laser L160', 2500000, N'', 'may12.jpg', 1 ,5)
insert into SanPham values(N'Máy in laser Sam sung ML 2240', 5300000, N'', 'may21.jpg', 2 ,5)
insert into SanPham values(N'Máy in phun epson stylus 1390', 6100000, N'', 'may22.jpg', 2 ,5)
insert into SanPham values(N'Máy in nhãn CASIO KL-60', 410000, N'', 'may31.jpg', 3 ,5)
insert into SanPham values(N'Máy in nhãn CASIO KL-820', 650000, N'', 'may32.jpg', 3 ,5)
insert into SanPham values(N'Máy Photocopy Canon IR 2000', 13500000, N'', 'may41.jpeg', 4 ,5)
insert into SanPham values(N'Máy Photocopy Canon IR 2525', 18000000, N'', 'may42.jpeg', 4 ,5)
insert into SanPham values(N'Máy Scan Epson V30', 2300000, N'', 'may51.jpg', 5 ,5)
insert into SanPham values(N'Máy Scan Epson V300', 1800000, N'', 'may52.jpg', 5 ,5)
insert into SanPham values(N'Máy tính Casio HL-815L', 290000, N'', 'may61.jpg', 6 ,5)
insert into SanPham values(N'Máy tính Casio FX 500MS', 180000, N'', 'may62.jpg', 6 ,5)
insert into SanPham values(N'Máy đếm tiền silicon MC-2550', 1300000, N'', 'may71.jpg', 7 ,5)
insert into SanPham values(N'Máy đếm tiền silicon MC-B528', 1600000, N'', 'may72.jpg', 7 ,5)



insert into SanPham values(N'Số Kế Toán 260tr', 30000, N'', 'so11.jpg', 1 ,6)
insert into SanPham values(N'Sổ kho', 15000, N'', 'so12.jpg', 1 ,6)
insert into SanPham values(N'Túi hồ sơ xi măng không dây', 8000, N'', 'so21.jpg', 2 ,6)
insert into SanPham values(N'Túi đựng hồ sơ xin việc dày', 10000, N'', 'so22.jpg', 2 ,6)
insert into SanPham values(N'Sổ bìa cứng A4 ngang đầu thừa', 34000, N'', 'so31.jpg', 3 ,6)
insert into SanPham values(N'Sổ bìa cứng A4 dọc 200 trang', 60000, N'', 'so32.jpg', 3 ,6)
insert into SanPham values(N'Sổ quỹ tiền mặt', 35000, N'', 'so41.jpg', 4 ,6)
insert into SanPham values(N'Phiếu xuất kho A5 3 liên dày', 40000, N'', 'so42.jpg', 4 ,6)
insert into SanPham values(N'Sổ da Notebook B5 1868', 45000, N'', 'so51.jpg', 5 ,6)
insert into SanPham values(N'Sổ da New Era’s', 53000, N'', 'so52.jpg', 5 ,6)
insert into SanPham values(N'Sổ xé A4 Pgrand', 19000, N'', 'so61.jpg', 6 ,6)
insert into SanPham values(N'Sổ lò xo B5', 18000, N'', 'so62.jpg', 6 ,6)
insert into SanPham values(N'Sổ card B6 300 card', 33000, N'', 'so71.jpg', 7 ,6)
insert into SanPham values(N'Sổ card B5 còng sắt chứa 480 card', 56000, N'', 'so72.jpg', 7 ,6)
insert into SanPham values(N'Vở ô ly Tuổi Ngọc 1336 48tr', 15000, N'', 'so81.jpg', 8 ,6)
insert into SanPham values(N'Vở ô ly Hồng Hà 0563 48tr', 18000, N'', 'so82.jpg', 8 ,6)


insert into SanPham values(N'Nước rửa tay Lifebuoy 500ml', 30000, N'', 'tap11.jpg', 1 ,7)
insert into SanPham values(N'Rửa chén Sunlight 3.8L', 35000, N'', 'tap12.jpg', 1 ,7)
insert into SanPham values(N'Khăn giấy ăn watersilk 200 tờ', 18000, N'', 'tap21.jpg', 2 ,7)
insert into SanPham values(N'Khăn giấy gói vuông Hà Nội', 21000, N'', 'tap22.jpg', 2 ,7)
insert into SanPham values(N'Găng tay y tế', 3000, N'', 'tap31.jpg', 3 ,7)
insert into SanPham values(N'Cọ toilet nhựa vuông', 16000, N'', 'tap32.jpg', 3 ,7)
insert into SanPham values(N'Trà nhài', 35000, N'', 'tap41.jpg', 4 ,7)
insert into SanPham values(N'Trà lipton nhúng chanh 25 gói', 40000, N'', 'tap42.jpg', 4 ,7)
