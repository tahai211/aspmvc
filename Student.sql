CREATE DATABASE Student
GO
USE Student
GO
Create Table Sinhvien
(
 MaSV varchar(20) primary key,
 TenSV Nvarchar(30) not null,
 gioitinh NVarchar (5) default 'Unknown',
 Ngaysinh Date check (Ngaysinh<getdate()),
 Que Nvarchar(50) not null,
 Lop Nvarchar (10)
 )
 GO
 INSERT Into Sinhvien VALUES('1',N'Trần bảo trọng',N'Nam','1995-12-14',N'Hà Giang','L02');
INSERT Into Sinhvien VALUES('2',N'Lê Thuỳ Dương',N'Nữ','1997-12-14',N'Hà Nội','L03');
INSERT Into Sinhvien VALUES('3',N'Trần Phương THảo ',N'Nam','1996-12-14',N'quảng Ninh','L01');
INSERT Into Sinhvien VALUES('4',N'Lê trường an',N'Nam','1995-12-14',N'Ninh Bình','L04');
INSERT Into Sinhvien VALUES('5',N'Phạm thị hương giang',N'Nữ','1999-12-14',N'Hoà Bình','L02');
INSERT Into Sinhvien VALUES('6',N'Trần anh bảo','Nam','1995-12-14',N'Hà Giang','L02');
INSERT Into Sinhvien VALUES('7',N'Lê Thuỳ Dung',N'Nữ','1997-12-14',N'Hà Nội','L03');
INSERT Into Sinhvien VALUES('8',N'Phạm Trung Tính','Nam','1996-12-14',N'quảng Ninh','L01');
INSERT Into Sinhvien VALUES('9',N'Lê An Hải','Nam','1995-12-14',N'Ninh Bình','L04');
INSERT Into Sinhvien VALUES('10',N'Phạm thị hương giang',N'Nữ','1999-12-14',N'Hà Giang','L02');
INSERT Into Sinhvien VALUES('11',N'Đoàn Duy Thức','Nam','1994-12-14',N'Hoà Bình','L01');
INSERT Into Sinhvien VALUES('12',N'Dương Tuấn Thông','Nam','1991-12-14',N'Hà Nội','L03');
INSERT Into Sinhvien VALUES('13',N'Lê thành đạt','Nam','1993-12-14',N'Nam Định','L04');
INSERT Into Sinhvien VALUES('14',N'Nguyễn Hằng Nga',N'Nữ','1993-12-14',N'Phú Thọ','L01');
INSERT Into Sinhvien VALUES('15',N'Trần Thanh Nga',N'Nữ','1994-12-14',N'Hà Nội','L03');
INSERT Into Sinhvien VALUES('16',N'Trần Trọng Hoàng','Nam','1995-12-14',N'Phú Thọ','L02');
INSERT Into Sinhvien VALUES('17',N'Nguyên Mai Hoa',N'Nữ','1997-12-14',N'Hà Giang','L03');
INSERT Into Sinhvien VALUES('18',N'Lê Thuý An','Nam','1998-12-14',N'Hà Nội','L01');
INSERT Into Sinhvien VALUES('19',N'Lê Au','Nam','1990-2-14',N'Hà Giang','L01');

SELECT * FROM Sinhvien