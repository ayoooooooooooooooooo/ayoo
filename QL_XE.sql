create database QL_XE
use QL_XE
GO
create table KHACHHANG
(
	MAKH VARCHAR(10) NOT NULL PRIMARY KEY,
	TENKH NVARCHAR(50),
	EMAILKH NVARCHAR(50),
	DIACHI NVARCHAR(50),
	SDT INT,
	NGAYSINH DATE,
	GIOITINH NVARCHAR(30), 
)
create table NHANVIEN
(	
	MANV VARCHAR(10) NOT NULL PRIMARY KEY,
	TENNV  NVARCHAR(50),
	EMAILNV NVARCHAR(50),
	GIOITINH NVARCHAR(30), 
	SDT INT,
	NGAYSINH DATE,
	DIACHI NVARCHAR(50),
	NGAYVL DATE,
	CMND INT,
	LUONG MONEY,
	PHANLOAI NVARCHAR(30),
)
CREATE TABLE NHACUNGCAP
(
	MANCC VARCHAR(10) NOT NULL PRIMARY KEY,
	TENNCC NVARCHAR(50),
	DIACHI NVARCHAR(50),
	EMAILNCC NVARCHAR(50),
)

create table SANPHAM
(
	MASP VARCHAR(10) NOT NULL PRIMARY KEY,
	TENSP NVARCHAR(50),
	NHASX NVARCHAR(50),
	NGAYSX DATE,
	NGAYXUATKHAU DATE,
	NAMBH INT,
	LOAISP NVARCHAR(50),
	MOTASP NVARCHAR(50),
)
CREATE TABLE HOADONNHAP
(
	MAHD VARCHAR(10) NOT NULL PRIMARY KEY,
	MAKH VARCHAR(10),
	MANV VARCHAR(10),
	MANCC VARCHAR(10),
	NGAYBAN DATE,
)
CREATE TABLE HOADONXUAT
(
	MAHD VARCHAR(10) NOT NULL PRIMARY KEY,
	MAKH VARCHAR(10),
	MANCC VARCHAR(10),
	NGAYBAN DATE,
)
CREATE TABLE CHITIETHD
(
	MAHD VARCHAR(10) NOT NULL PRIMARY KEY,
	MASP VARCHAR(10),
	SL INT,
	THANHTIEN MONEY,
	THUE FLOAT,
)