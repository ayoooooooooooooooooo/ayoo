﻿create database DOAN
use DOAN
GO
create table KHACHHANG
(
	taikhoan VARCHAR(50),
	matkhau VARCHAR(50),
	MAKH VARCHAR(10) NOT NULL PRIMARY KEY,
	TENKH NVARCHAR(50),
	EMAILKH VARCHAR(50),
	DIACHI NVARCHAR(50),
	SDT varchar(20),
	NGAYSINH DATE,
	GIOITINH NVARCHAR(30), 
	
)
create table NHANVIEN
(	
	MANV VARCHAR(10) NOT NULL PRIMARY KEY,
	TENNV  NVARCHAR(50),
	EMAILNV VARCHAR(50),
	DIACHI NVARCHAR(50),
	SDT varchar(20),
	NGAYSINH DATE,
	GIOITINH NVARCHAR(30),
	TAIKHOAN VARCHAR(50),
	MATKHAU VARCHAR(50),
	PHANLOAI VARCHAR(2),
	NGAYVL DATE,
	CMND varchar(20),
	
)
CREATE TABLE NHACUNGCAP
(
	MANCC VARCHAR(10) NOT NULL PRIMARY KEY,
	TENNCC NVARCHAR(50),
	DIACHI NVARCHAR(50),
	EMAILNCC VARCHAR(50),
)

create table SANPHAM
(
	MASP VARCHAR(10) NOT NULL PRIMARY KEY,
	TENSP NVARCHAR(50),
	NHASX NVARCHAR(50),
	NGAYSX DATE,
	NGAYXUATKHAU DATE,
	NAMBH INT,
	LOAISP VARCHAR(10),
	MOTASP NVARCHAR(50),
)
CREATE TABLE HOADONNHAP
(
	MAHD VARCHAR(10) NOT NULL PRIMARY KEY,
	MANV VARCHAR(10),
	SL int,
	MASP VARCHAR(10),
	NGAYBAN DATE,
		CONSTRAINT FK_HDN_NV foreign key (MANV) references NHANVIEN(MANV),
		CONSTRAINT FK_HDN_SP foreign key (MASP) references SANPHAM(MASP),

)
CREATE TABLE HOADONXUAT
(
	MAHD VARCHAR(10) NOT NULL PRIMARY KEY,
	MAKH VARCHAR(10),
	MANV VARCHAR(10),
	MASP VARCHAR(10),
	NGAYBAN DATE,
	CONSTRAINT FK_HDX_KH foreign key (MAKH) references khachhang(MAKH),
	CONSTRAINT FK_HDX_SP foreign key (MASP) references SANPHAM(MASP),
)

CREATE TABLE CHITIETHDXUAT
(
	MAHD VARCHAR(10) NOT NULL PRIMARY KEY,
	MASP VARCHAR(10),
	SL INT,
	DONGIA money,
	THUE FLOAT,
	THANHTIEN MONEY,
	CONSTRAINT FK_HDX_HD foreign key (MAHD) references HOADONXUAT(MAHD),
)
CREATE TABLE CHITIETHDNHAP
(
	MAHD VARCHAR(10) NOT NULL PRIMARY KEY,
	MASP VARCHAR(10),
	SL INT,
	DONGIA money,
	THUE FLOAT,
	THANHTIEN MONEY,
	CONSTRAINT FK_HDN_HD foreign key (MAHD) references HOADONNhap(MAHD) ON DELETE CASCADE ON UPDATE CASCADE,
)
SET DATEFORMAT DMY
INSERT INTO KHACHHANG VALUES('thuydiemn',N'6787','KH01',N'Lê Thị Thúy Diễm',N'thuydiem@gmail.com',N'22 Lê Đức Thọ','093232191','02/03/1994',N'Nữ')
INSERT INTO KHACHHANG VALUES('bichngoc',N'9123','KH02',N'Nguyễn Bích Ngọc',N'bichngoc1112@gmail.com',N'112 Lê Đại Hành','023452129','12/05/1999',N'Nữ')
INSERT INTO KHACHHANG VALUES('vanbach',N'1236','KH03',N'Phạm Văn Bạch',N'bachbk12@gmail.com',N'11/23 Nguyễn Văn Lượng','012235598','23/11/1995',N'Nam')
INSERT INTO KHACHHANG VALUES('thanhtung',N'5667','KH04',N'Lê Thanh Tùng',N'tungthanh@gmail.com',N'42/12 Lê Văn Thọ','016233197','11/09/1991',N'Nam')
INSERT INTO KHACHHANG VALUES('vantan',N'9931','KH05',N'Võ Văn Tần',N'vantu11@gmail.com',N'7/78/1 Tô Ngọc Vân','091255127','01/01/2000',N'Nam')
INSERT INTO KHACHHANG VALUES('giadinh',N'4232','KH06',N'Trương Gia Định',N'gd1178@gmail.com',N'932 Võ Thị Sáu','024168213','19/12/1997',N'Nam')
INSERT INTO KHACHHANG VALUES('vanthanh',N'5527','KH07',N'Nguyễn Văn Thanh',N'thanhthanh998@gmail.com',N'1399 Hai Bà Trưng','093438564','30/10/1992',N'Nữ')
INSERT INTO KHACHHANG VALUES('ngocanh',N'6697','KH08',N'Nguyễn Ngọc Anh',N'NA32@gmail.com',N'572 Trương Bằng','084436195','01/07/1993',N'Nữ')
INSERT INTO KHACHHANG VALUES('huudanh',N'8887','KH09',N'Phùng Hữu Danh',N'danhnek67@gmail.com',N'89 Hoàng Sa','093277191','12/12/2001',N'Nam')
INSERT INTO KHACHHANG VALUES('dinhphat',N'3319','KH10',N'Tô Đính Phát',N'phathuy29@gmail.com',N'67 Trường Sa','012884132','09/09/2003',N'Nam')

SET DATEFORMAT DMY
INSERT INTO NHANVIEN VALUES ('NV01',N'Trịnh Lê Phan Quỳnh',N'phanquynh23@gmail.com',N'1932 Lý Chính Thắng','0957341182','05/01/1984',N'Nữ','phanquynh','ql84','ql','12/02/2004','0112938131')
INSERT INTO NHANVIEN VALUES ('NV02',N'Nguyễn Văn Lý',N'vanly12@gmail.com',N'11/56 Nguyễn Bính','0912343561','12/09/1990',N'Nam','vanly','ql92','ql','22/06/2006','0119863284')
INSERT INTO NHANVIEN VALUES ('NV03',N'Trương Gia Phúc',N'giaphuc32@gmail.com',N'671 Lũy Bán Bích','0123571216','31/12/1980',N'Nam','giaphuc','ql93','ql','13/07/2006','0111293851')
INSERT INTO NHANVIEN VALUES ('NV04',N'Lê Hữu Danh',N'huydanh78@gmail.com',N'19 Nguyễn Thái Sơn','0812757127','01/09/1996',N'Nam','huudanh','nv03','nv','29/08/2015','0114892345')
INSERT INTO NHANVIEN VALUES ('NV05',N'Nguyễn Thị Trang',N'nguyentrang09@gmail.com',N'90/32 Đào Duy Anh','0162417812','09/01/1995',N'Nữ','nguyentrang','nv19','nv','09/10/2015','0119381903')
INSERT INTO NHANVIEN VALUES ('NV06',N'Lê Tuyết Hương',N'tuyettrangne12@gmail.com',N'78/37 Lê Thánh Tông','0211238127','27/07/1997',N'Nữ','tuyethuong','nv29','nv','10/10/2016','0111200850')
INSERT INTO NHANVIEN VALUES ('NV07',N'Phan Văn Nam',N'vannam98@gmail.com',N'91 Gia Định','0921379191','26/08/1994',N'Nam','vannam','nv30','nv','29/11/2016','0115879421')
INSERT INTO NHANVIEN VALUES ('NV08',N'Trịnh Công Đức',N'congduc54@gmail.com',N'83/17 Nguyễn Trãi','0127494511','29/11/1993',N'Nam','congduc','nv35','nv','30/01/2017','0118975894')
INSERT INTO NHANVIEN VALUES ('NV09',N'Nguyễn Đức Khiêm',N'duckhiem67@gmail.com',N'29 Lê Lợi','0825129271','11/02/1995',N'Nam','duckhiem','nv39','nv','09/02/2017','0112210193')
INSERT INTO NHANVIEN VALUES ('NV10',N'Võ Thị Huyền Trang',N'huyentrang29@gmail.com',N'981 Nguyễn Huệ','0928312875','19/06/1996',N'Nữ','huyentrang','nv41','nv','18/09/2017','0113527817')

INSERT INTO NHACUNGCAP VALUES('NCC01',N'YAMAHA',N'190 Hai Bà Trưng','yamaha@gmail.com')
INSERT INTO NHACUNGCAP VALUES('NCC02',N'SUZUKI',N'239 Lý Chính Thắng','suzuki@gmail.com')
INSERT INTO NHACUNGCAP VALUES('NCC03',N'HONDA',N'605 Lũy Bán Bích','honda@gmail.com')
INSERT INTO NHACUNGCAP VALUES('NCC04',N'DUCATI',N'1901 Hậu Giang','ducati@gmail.com')

SET DATEFORMAT DMY
INSERT INTO SANPHAM VALUES('SP01',N'WAVE',N'HONDA','12/09/1995','01/12/1995',2,'xs',N'Bền bỉ,lâu dài')
INSERT INTO SANPHAM VALUES('SP02',N'JUPITER',N'YAMAHA','29/10/2001','01/01/2002',2,'xs',N'Đẹp mắt,bền bỉ')
INSERT INTO SANPHAM VALUES('SP03',N'RAIDER',N'SUZUKI','23/01/2004','01/02/2004',2,'xs',N'thể thao,chất lượng')
INSERT INTO SANPHAM VALUES('SP04',N'GSX R150',N'SUZUKI','30/05/2005','14/06/2005',2,'xs',N'Nhỏ gọn, bền bỉ')
INSERT INTO SANPHAM VALUES('SP05',N'IMPULSE',N'SUZUKI','29/12/2008','01/01/2008',3,'xtg',N'thể thao,chất lượng')
INSERT INTO SANPHAM VALUES('SP06',N'JANUS',N'YAMAHA','01/02/2007','01/03/2007',3,'xtg',N'Đẹp mắt,bền bỉ')
INSERT INTO SANPHAM VALUES('SP07',N'AIR BLADE',N'HONDA','31/07/2004','15/08/2004',3,'xtg',N'Bền bỉ,lâu dài' )
INSERT INTO SANPHAM VALUES('SP08',N'Z1000',N'DUCATI','12/12/2010','01/01/2011',5,'pkl',N'thể thao,chất lượng')
INSERT INTO SANPHAM VALUES('SP09',N'CB1000R',N'HONDA','06/07/2010','01/08/2010',5,'pkl',N'Bền bỉ,lâu dài')
INSERT INTO SANPHAM VALUES('SP10',N'BOLT',N'YAHAMA','19/09/2015','10/10/2015',5,'pkl',N'Đẹp mắt,bền bỉ')

SET DATEFORMAT DMY
INSERT INTO HOADONNHAP VALUES('HDN01','NV04',20,'SP01','19/01/2014')
INSERT INTO HOADONNHAP VALUES('HDN02','NV05',15,'SP02','20/09/2015')
INSERT INTO HOADONNHAP VALUES('HDN03','NV09',20,'SP03','11/02/2014')
INSERT INTO HOADONNHAP VALUES('HDN04','NV07',10,'SP04','07/08/2016')
INSERT INTO HOADONNHAP VALUES('HDN05','NV08',15,'SP05','29/10/2015')
INSERT INTO HOADONNHAP VALUES('HDN06','NV07',25,'SP06','09/01/2017')
INSERT INTO HOADONNHAP VALUES('HDN07','NV06',30,'SP07','30/12/2014')
INSERT INTO HOADONNHAP VALUES('HDN08','NV05',15,'SP08','11/01/2018')
INSERT INTO HOADONNHAP VALUES('HDN09','NV06',15,'SP09','10/10/2019')
INSERT INTO HOADONNHAP VALUES('HDN10','NV09',15,'SP10','27/05/2018')

SET DATEFORMAT DMY
INSERT INTO HOADONXUAT VALUES('HDX01','KH01','NV04','SP01','19/01/2014')
INSERT INTO HOADONXUAT VALUES('HDX02','KH02','NV05','SP02','20/09/2015')
INSERT INTO HOADONXUAT VALUES('HDX03','KH03','NV09','SP03','11/02/2014')
INSERT INTO HOADONXUAT VALUES('HDX04','KH04','NV07','SP04','07/08/2016')
INSERT INTO HOADONXUAT VALUES('HDX05','KH05','NV08','SP05','29/10/2015')
INSERT INTO HOADONXUAT VALUES('HDX06','KH06','NV07','SP06','09/01/2017')
INSERT INTO HOADONXUAT VALUES('HDX07','KH07','NV06','SP07','30/12/2014')
INSERT INTO HOADONXUAT VALUES('HDX08','KH08','NV05','SP08','11/01/2018')
INSERT INTO HOADONXUAT VALUES('HDX09','KH09','NV06','SP09','10/10/2019')
INSERT INTO HOADONXUAT VALUES('HDX10','KH10','NV09','SP10','27/05/2018')

INSERT INTO CHITIETHDXUAT VALUES('HDX01','SP01',1,17790000,0.05,18769000)
INSERT INTO CHITIETHDXUAT VALUES('HDX02','SP02',2,30000000,0.05,67132000)
INSERT INTO CHITIETHDXUAT VALUES('HDX03','SP03',1,49190000,0.05,55715500)
INSERT INTO CHITIETHDXUAT VALUES('HDX04','SP04',1,15790000,0.05,16779500)
INSERT INTO CHITIETHDXUAT VALUES('HDX05','SP05',2,31990000,0.05,71311000)
INSERT INTO CHITIETHDXUAT VALUES('HDX06','SP06',1,27500000,0.05,28875000)
INSERT INTO CHITIETHDXUAT VALUES('HDX07','SP07',2,52600000,0.05,110460000)
INSERT INTO CHITIETHDXUAT VALUES('HDX08','SP08',2,74990000,0.05,165611000)
INSERT INTO CHITIETHDXUAT VALUES('HDX09','SP09',1,468000000,0.05,495466000)
INSERT INTO CHITIETHDXUAT VALUES('HDX10','SP10',1,420000000,0.05,445100000)

INSERT INTO CHITIETHDNHAP VALUES('HDN01','SP01',20,16790000,0.05,352590000)
INSERT INTO CHITIETHDNHAP VALUES('HDN02','SP02',15,25000000,0.05,393750000)
INSERT INTO CHITIETHDNHAP VALUES('HDN03','SP03',20,42000000,0.05,882000000)
INSERT INTO CHITIETHDNHAP VALUES('HDN04','SP04',10,10790000,0.05,113295000)
INSERT INTO CHITIETHDNHAP VALUES('HDN05','SP05',15,25990000,0.05,409342500)
INSERT INTO CHITIETHDNHAP VALUES('HDN06','SP06',25,20500000,0.05,538125000)
INSERT INTO CHITIETHDNHAP VALUES('HDN07','SP07',30,45600000,0.05,1436400000)
INSERT INTO CHITIETHDNHAP VALUES('HDN08','SP08',15,65990000,0.05,1039342500)
INSERT INTO CHITIETHDNHAP VALUES('HDN09','SP09',15,380000000,0.05,5985000000)