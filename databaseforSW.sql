CREATE DATABASE QuanLyBanHangThoiTrang
GO

USE QuanLyBanHangThoiTrang
GO

-- NhanVien
-- HangHoa
-- KhachHang
-- Chi tiet hoa don
-- Hoa don ban hang
-- Tai khoan

CREATE TABLE NHANVIEN
(
	MaNV int not null Primary Key, --SDT lam ma nhan vien
	HoTenNV nvarchar(100) not null,
	GioiTinh nvarchar(3) not null, -- 1 la Nam , 2 la Nu
	DiaChi nvarchar(100) not null,
	ChucVu nvarchar(50) not null,
	KieuCV nvarchar(10) not null -- 1 la Full time,2 la Part time
)
GO

CREATE TABLE HANGHOA
(
	MaHH nvarchar(10) not null Primary Key, 
	TenHH nvarchar(100) not null UNIQUE,
	XuatXu nvarchar(50) not null,
	SoLuongHHTon int not null CHECK ( SoLuongHHTon >=0),
	DonGiaNhap int,
	DonGiaBan int, 
	DanhMuc nvarchar(50) not null
)
GO

CREATE TABLE KHACHHANG
(
	MaKH varchar(15) not null Primary Key, 
	HoTenKH varchar(100) not null, 
	DiaChi nvarchar(100),
	NgaySinh date not null, 
	GioiTinh nvarchar(3) not null,
	DiemThanThiet int not null,
	SDTKH char(10) not null CHECK (LEN(SDTKH) = 10) UNIQUE
)
GO

CREATE TABLE CHITIET_HOADONBANHANG
(
	MaHDBH nvarchar(15) not null Primary Key,
	MaHH nvarchar(10) not null,
	SoLuongBan int not null CHECK (SoLuongBan > 0),
	ThanhTien int
)
GO

CREATE TABLE HOADONBANHANG
(
	MaHDBH nvarchar(15) not null Primary Key,
	MaNV int  not null,
	MaKH varchar(15) not null,						    
	NgayBan date not null,
	GiamGia int DEFAULT 0,
	TongTien int,
	HinhThucThanhToan nvarchar(20) not null
)
GO

CREATE TABLE TAIKHOAN
(
    TenHienThi nvarchar (30) not null,
	TenDangNhap nvarchar(20) primary key not null, 
	MatKhau nvarchar (8) not null	
)
GO

--Khoá ngoại
ALTER TABLE HOADONBANHANG
ADD CONSTRAINT FK_KhachHang Foreign Key (MaKH) references KHACHHANG(MaKH)

ALTER TABLE HOADONBANHANG
ADD CONSTRAINT FK_NhanVien Foreign Key (MaNV) references NHANVIEN(MaNV)

ALTER TABLE CHITIET_HOADONBANHANG
ADD CONSTRAINT FK_HangHoa Foreign Key (MaHH) references HANGHOA(MaHH) 

ALTER TABLE CHITIET_HOADONBANHANG
ADD CONSTRAINT FK_Banhang Foreign Key (MaHDBH) references HOADONBANHANG(MaHDBH)
GO


CREATE TRIGGER UpThanhTien --Tính Thành tiền - Trong Bảng CHI TIẾT HÓA ĐƠN
ON CHITIET_HOADONBANHANG
FOR INSERT, UPDATE
As
BEGIN
	BEGIN TRANSACTION 
	UPDATE CHITIET_HOADONBANHANG
	SET ThanhTien = (CHITIET_HOADONBANHANG.SoLuongBan * HANGHOA.DonGiaBan)
	FROM dbo.CHITIET_HOADONBANHANG JOIN dbo.HANGHOA on HANGHOA.MaHH = CHITIET_HOADONBANHANG.MaHH
	IF @@ROWCOUNT < 1 --nếu không có hàng nào được cập nhật
    ROLLBACK TRANSACTION -- ngược lại nếu k thành công thì trả về csdl ban đầu trc khi update/insert
	COMMIT TRANSACTION --Lưu vào csdl các thay đổi
	END
GO

CREATE TRIGGER UpTongTien--Tính tổng tiền
ON HOADONBANHANG
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @TinhTong TABLE (MaHDBH char(8), TongChiTietHoaDon int)
	INSERT INTO @TinhTong SELECT MaHDBH = CHITIET_HOADONBANHANG.MaHDBH, TongChiTietHoaDon = SUM(CHITIET_HOADONBANHANG.ThanhTien) --dùng hàm sum tính tổng thành tiền gán cho TongChiTietHoaDon
							  FROM HOADONBANHANG join CHITIET_HOADONBANHANG ON CHITIET_HOADONBANHANG.MaHDBH = HOADONBANHANG.MaHDBH
							  GROUP BY CHITIET_HOADONBANHANG.MaHDBH
	UPDATE HOADONBANHANG
	SET TongTien = [@TinhTong].TongChiTietHoaDon --Cho TongTien = TongChiTietHoaDon
	FROM dbo.HOADONBANHANG join @TinhTong ON [@TinhTong].MaHDBH = HOADONBANHANG.MaHDBH --ĐK Mã HDBH phải trùng khớp 
	IF @@ROWCOUNT < 1
		ROLLBACK 
	UPDATE dbo.HOADONBANHANG
	Set TongTien = TongTien - TongTien* (GiamGia / 100)
	If @@ROWCOUNT < 1
		ROLLBACK
END
GO

INSERT INTO dbo.NHANVIEN (MaNV, HoTenNV, GioiTinh, DiaChi, ChucVu, KieuCV)
        
VALUES  ('0907544597', N'Nguyễn Thị Minh Thảo',	N'Nữ', N'220 No Trang Long, Bình Thạnh, TP Hồ Chí Minh',N'Quản lý cửa hàng', 'Fulltime'),
        ('0908487435', N'Võ Chí Tâm', N'Nam', N'48 Tân Hòa, quan 1,TP Hồ Chí Minh', N'Nhân viên bán hàng', 'Fulltime'),
        ('0903973289', N'Tạ Thị Kim Hoa', N'Nữ', N'300 Nguyễn Thị Thập, quận 7, TP Hồ Chí Minh', N'Nhân viên bán hàng', 'Fulltime'),
        ('0903808095', N'Huỳnh Thị Diễm Ny', N'Nữ', N'75 Hoà An, Tân Hóa, Đô Lương, Nghệ An',N'Nhân viên bán hàng', 'Fulltime'),
        ('0126669918', N'Võ Thị Bích Phương', N'Nữ', N'139/50 Thế Hiển, quận 8, TP Hồ Chí Minh',N'Nhân viên bán hàng', 'Fulltime'),
        ('0906519537', N'Trần Thị Thanh Trúc', N'Nữ', N'Hẻm 46 Phú Đinh, quận 6, TP Hồ Chí Minh',N'Nhân viên bán hàng', 'Partime'),
        ('0909623752', N'Phạm Thị Dao', N'Nữ', N'09 Lạc Long Quân, Tân Bình, TP Hồ Chí Minh', N'Nhân viên bán hàng', 'Partime'),
        ('0904443262', N'Trần Vương', N'Nam', N'Nghĩa Tru, huyện Vân Giang, Hưng Yên',N'Nhân viên kho', 'Partime'),
        ('0913668804', N'Nguyễn Yến', N'Nữ', N'07 Tôn Đản, Vân Hành, Hà Nội',N'Nhân viên bán hàng', 'Partime'),
        ('0905057845', N'Lê Hải', N'Nam', N'45 Gò Cát, huyện Xuyên Mộc, Vũng Tàu',N'Nhân viên bán hàng', 'Partime')
GO

INSERT INTO dbo.HANGHOA (MaHH, TenHH, XuatXu, SoLuongHHTon, DonGiaNhap, DonGiaBan, DanhMuc)         
VALUES  ('HH001', N'Áo Croptop', N'Trung Quốc', '20', '120000', '130000', N'Áo thun'),																		
	    ('HH002', N'Áo Hoodie', N'Trung Quốc', '25', '125000', '135000', N'Áo khoác'),															
	    ('HH003', N'Quần jeans ống suông', N'Hàn Quốc', '30', '130000', '140000', N'Quần jeans'),																	
	    ('HH004', N'Nước hoa', N'Mỹ', '35', '80000', '90000', N'Phụ kiện'),																		
	    ('HH005', N'Thắt lưng', N'Việt Nam',  '40', '110000', '120000', N'Phụ kiện'),																		
	    ('HH006', N'Nón kiểu', N'Việt Nam', '45', '75000', '85000', N'Mũ'),																		
	    ('HH007', N'Balo unisex', N'Việt Nam', '50', '340000', '350000', N'Balo'),																		
	    ('HH008', N'Tote bag', N'Việt Nam',  '55', '330000', '355000', N'Túi'),																	
	    ('HH009', N'Tất cổ thấp', N'Việt Nam', '60', '8000', '15000', N'Tất vớ'),																		
	    ('HH010', N'Tất cổ cao', N'Việt Nam', '65', '12000', '20000', N'Tất vớ')	
GO

INSERT INTO dbo.KHACHHANG ( MaKH, HoTenKH, DiaChi, NgaySinh, GioiTinh, DiemThanThiet, SDTKH)
VALUES  ('KH001', N'Nguyen Ngoc Thu', N'09 Mỹ Thái 2A, quận 7, TP Hồ Chí Minh', N'1995/03/03', N'Nữ', '100','0578965423'),
        ('KH002', N'Tran Ngoc Hung', N'50/7 Bến Chương Dương, quận 1, TP Hồ Chí Minh', N'2004/02/11', N'Nam', '105','0657865412'),
		('KH003', N'Tran Thi Ha', N'326A, Bến Chương Dương, thị xã Gò Công, Tiền Giang', N'1992/11/15', N'Nữ', '95','0657586412'),
	    ('KH004', N'Nguyen Thi Van', N'666/15B Trần Phú, Vũng Tàu', N'1999/06/06', N'Nữ', '80','0786541235'),																			
	    ('KH005', N'Le Mai Thu', N'Trà Cói A, huyện Mỹ Tứ, Sóc Trăng', N'1999/01/29', N'Nữ', '110','0456358415'),																	
	    ('KH006', N'Nguyen Thanh Thao', N'16BD2 Lê Duẩn, Huyện An Dương, Hải Phòng', N'2003/02/25', N'Nữ', '115','0781531452'),																			
	    ('KH007', N'Tran Quynh Anh', N'49H5 xã Phú An, Cái Lậy, Tiền Giang', N'1995/04/21', N'Nữ', '150','0478532114'),																			
	    ('KH008', N'Nguyen Thi Oanh', N'Ấp 3, huyện Thanh Quan, Bình Phước', N'2001/08/09', N'Nữ', '140','0225566778'),																			
	    ('KH009', N'Ha Van Anh', N'15 Phan Anh, quận Hải Châu, TP Đà Nẵng', N'1990/05/20', N'Nữ', '135','0457878453'),																			
	    ('KH010', N'Doan Minh Nguyet', N'03/D Minh Khai, huyện Tháp Mười, Đồng Tháp', N'1996/07/08',N'Nữ', '125','0223364789')	
GO

INSERT INTO dbo.CHITIET_HOADONBANHANG ( MaHDBH, MaHH, SoLuongBan)
VALUES  ('HDBH0001', 'HH001', '1'),
        ('HDBH0002', 'HH002', '2'),
        ('HDBH0003', 'HH003', '2'),
        ('HDBH0004', 'HH004', '1'),
        ('HDBH0005', 'HH005', '2'),
        ('HDBH0006', 'HH006', '3'),
        ('HDBH0007', 'HH007', '4'),
        ('HDBH0008', 'HH008', '2'),
        ('HDBH0009', 'HH009', '3'),
        ('HDBH0010', 'HH010', '4')       
GO

INSERT INTO dbo.HOADONBANHANG (MaHDBH, MaNV, MaKH, NgayBan, GiamGia, HinhThucThanhToan)
VALUES  ('HDBH0001', '0907544597', 'KH001', '2021/08/27', '0', N'Chuyển khoản'),
        ('HDBH0002', '0908487435', 'KH002', '2021/08/27','50', N'Chuyển khoản'),
		('HDBH0003', '0903973289', 'KH003', '2021/08/27', '0', N'Chuyển khoản'),
        ('HDBH0004', '0903808095', 'KH004', '2021/08/27', '0', N'Chuyển khoản'),
        ('HDBH0005', '0126669918','KH005', '2021/08/27', '0', N'Chuyển khoản'),
        ('HDBH0006', '0906519537', 'KH006', '2021/09/02', '0', N'Trả tiền mặt'),
        ('HDBH0007', '0909623752', 'KH007', '2021/09/02', '30',N'Trả tiền mặt'),
        ('HDBH0008', '0904443262', 'KH008', '2021/09/02', '20', N'Trả tiền mặt'),
        ('HDBH0009', '0913668804', 'KH009', '2021/09/02', '0', N'Trả tiền mặt'),
        ('HDBH0010', '0905057845', 'KH010', '2021/09/02', '0', N'Trả tiền mặt')
GO

INSERT INTO dbo.TAIKHOAN (TenHienThi,TenDangNhap, MatKhau)
VALUES  ('ADMIN','Admin', '21052001'),
        ('NHANVIEN1','Nguyen Thi Minh Thao', '22052001'),
        ('NHANVIEN2','Vo Chi Tam' ,'22052001')
GO








--NHANVIEN

--Thêm
CREATE PROC spInNV (@HoTenNV nvarchar(100), @GioiTinh nvarchar(3), @DiaChi nvarchar(100), @ChucVu nvarchar(50), @KieuCV nvarchar(10))
AS
BEGIN
	DECLARE @MaNVmoi int 
	INSERT INTO NHANVIEN 
	VALUES (@MaNVmoi, @HoTenNV , @GioiTinh, @DiaChi, @ChucVu, @KieuCV)
END
GO

--Tìm
CREATE PROC spTimTenNV @HoTenNV nvarchar(100)
AS
BEGIN
	SELECT * FROM NHANVIEN WHERE HoTenNV like N'%' + @HoTenNV + '%'
END
SELECT * FROM NHANVIEN
GO

CREATE PROC spUpNV @MaNV varchar(15),
                   @HoTenNV nvarchar(100),
				   @GioiTinh nvarchar(3),
				   @DiaChi nvarchar(100),
				   @ChucVu nvarchar(50),
				   @KieuCV nvarchar(10)--Sửa
AS
BEGIN
	UPDATE NHANVIEN 
	SET MaNV = @MaNV, HoTenNV = @HoTenNV,GioiTinh= @GioiTinh, DiaChi  = @DiaChi, ChucVu = @ChucVu, KieuCV = @KieuCV
	WhERE MaNV = @MaNV
END
GO

--Xoá
CREATE PROC spDeNV  @MaNV int
AS
BEGIN
	DELETE NHANVIEN 
	WHERE MaNV = @MaNV
END
GO









--HANGHOA

--Tìm
CREATE PROC spTimTenHH @TenHH nvarchar(100)
AS
BEGIN
	SELECT * FROM HANGHOA WHERE TenHH like N'%' + @TenHH + '%'
END
GO
--Xoá
CREATE PROC spDeHH  @MaHH nvarchar(10)
AS
BEGIN
	DELETE HANGHOA
	WHERE MaHH = @MaHH
END
GO
--Cập nhật
CREATE PROC spInHH (@MaHH nvarchar(10), @TenHH nvarchar(100),@XuatXu nvarchar(50),  @SoLuongHHTon int, @DonGiaNhap int, @DonGiaBan int, @DanhMuc nvarchar(50) )
AS
BEGIN
UPDATE HANGHOA
SET TenHH = @TenHH, XuatXu = @XuatXu, SoLuongHHTon = @SoLuongHHTon,DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan, DanhMuc = @DanhMuc
WHERE MaHH = @MaHH
END
GO







--KHACHHANG

--Tìm
CREATE PROC spTimTenKH @HoTenKH nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.KHACHHANG Where HoTenKH like N'%' + @HoTenKH + '%'
END
GO

--Sửa
CREATE PROC spUpKH  @MaKH varchar(15), @HoTenKH nvarchar(50), @DiaChi nvarchar(50), @NgaySinh date, @GioiTinh nvarchar(3), @SDTKH char (10), @DiemThanThiet int
AS
BEGIN
	UPDATE KHACHHANG 
	SET MaKH = @MaKH, HoTenKH = @HoTenKH,  DiaChi = @DiaChi, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SDTKH = @SDTKH, DiemThanThiet = @DiemThanThiet
	WHERE MaKH = @MaKH
END
GO

--Xoá
CREATE PROC spDeKH  @MaKH varchar(15)
AS
BEGIN
	DELETE KHACHHANG 
	WHERE MaKH = @MaKH
End
GO








--CHITIET_HOADONBANHANG

-- Trừ SoLuongHHTon (HANGHOA) khi thêm SoLuongBan (CHITIET_HOADONBANHANG)
--TH1:INSERT
CREATE TRIGGER tInCTHD
ON CHITIET_HOADONBANHANG
FOR INSERT
AS
BEGIN
	BEGIN TRANSACTION
	UPDATE HANGHOA
	SET SoLuongHHTon = SoLuongHHTon - inserted.SoLuongBan
	FROM HANGHOA join inserted on HANGHOA.MaHH = inserted.MaHH
	IF @@ROWCOUNT < 1
		ROLLBACK TRANSACTION
	COMMIT TRANSACTION
END
GO

--TH2:UPDATE
CREATE TRIGGER tUpCTHD
ON CHITIET_HOADONBANHANG
FOR UPDATE 
AS
BEGIN
	BEGIN TRANSACTION
	UPDATE HANGHOA
	SET SoLuongHHTon= (SoLuongHHTon + deleted.SoLuongBan) - inserted.SoLuongBan 
	FROM HANGHOA	join deleted on HANGHOA.MaHH = deleted.MaHH --bảng ảo
					join inserted on HANGHOA.MaHH = inserted.MaHH --bảng ảo
	IF @@ROWCOUNT < 1
		ROLLBACK TRANSACTION
	COMMIT TRANSACTION
End
GO

-- Xoá hóa đơn và chi tiết hóa đơn
 CREATE PROC spDeHD (@MaHH nvarchar(10), @MaHDBH nvarchar(15))
AS
BEGIN
	BEGIN TRANSACTION
	DELETE FROM dbo.CHITIET_HOADONBANHANG Where MaHH = @MaHH
	IF @@ERROR <= 0
	BEGIN
		DELETE FROM dbo.HOADONBANHANG Where MaHDBH = @MaHDBH
		IF @@ROWCOUNT <= 0 
		BEGIN
			ROLLBACK 
			RETURN
		END
	END
	ELSE 
	BEGIN
		ROLLBACK
		RETURN
	END
	COMMIT TRANSACTION -- lưu dữ liệu vào data nếu giao dịch thành công
END
GO

-- Xóa 1 chi tiết hóa đơn
CREATE PROC spDeCTHD @MaHDBH nvarchar(15), @MaHH nvarchar(10)
AS
BEGIN 
	DELETE FROM dbo.CHITIET_HOADONBANHANG Where MaHDBH = @MaHDBH AND MaHH = @MaHH
END
GO

-- Tìm chi tiết hóa đơn bán hàng
CREATE PROC spTimChiTietHD @MaHDBH char(8)
AS
BEGIN
	SELECT * FROM CHITIET_HOADONBANHANG Where MaHDBH = @MaHDBH
END
GO

-- Thêm chi tiết hóa đơn
CREATE PROC spInCTHD (@MaHDBH nvarchar(15), @MaHH nvarchar(10), @SoLuongBan int)
AS
BEGIN
	IF (SELECT COUNT(*) FROM dbo.HOADONBANHANG WHERE MaHDBH = @MaHDBH) < 1
		BEGIN
			RETURN
		END
	ELSE IF (SELECT COUNT(*) From dbo.HANGHOA Where MaHH = @MaHH) < 1
		BEGIN
			RETURN 
		END
	ELSE IF (SELECT SoLuongHHTon From dbo.HANGHOA WHERE MaHH = @MaHH) < @SoLuongBan
		BEGIN
			Return 
		END
    ELSE
		BEGIN
			INSERT INTO CHITIET_HOADONBANHANG (MaHDBH, MaHH, SoLuongBan)
			VALUES (@MaHDBH, @MaHH, @SoLuongBan)
			IF @@ROWCOUNT > 0 
			BEGIN
				Return 
			END
			ELSE
			BEGIN
				RETURN 
			END
		END
END
GO







--HOADONBANHANG

--Tìm
CREATE PROC spTimHD @MaHDBH nvarchar(15)
AS
BEGIN
	SELECT * FROM HOADONBANHANG WHERE MaHDBH = @MaHDBH
END
GO

--Thêm
CREATE PROC spInHD (@MaKH varchar(15), @MaNV varchar(15), @GiamGia int, @HinhThucThanhToan nvarchar(20))
AS
BEGIN
	DECLARE @MaMoi nvarchar(15)
	INSERT INTO HOADONBANHANG (MaHDBH, MaNV, MaKH, NgayBan, GiamGia, HinhThucThanhToan)
	VALUES (@MaMoi, @MaNV, @MaKH, CONVERT(date, GETDATE()), @GiamGia, @HinhThucThanhToan)
END
GO
DROP PROC spDeHDBH
GO
--Xoá
CREATE PROC spDeHDBH @MaHDBH nvarchar(15)
AS
BEGIN 
	DELETE FROM dbo.HOADONBANHANG Where MaHDBH = @MaHDBH
END
GO









--TAIKHOAN
-- Tìm tài khoản
CREATE PROC spTimTK @TenHienThi nvarchar (30)
AS
BEGIN
	SELECT * FROM TAIKHOAN Where TenHienThi = @TenHienThi
END
GO
DROP TRIGGER tInTK
GO
SELECT * FROM  HOADONBANHANG
SELECT * FROM  KHACHHANG
SELECT * FROM  HANGHOA
SELECT * FROM  TAIKHOAN
SELECT * FROM  CHITIET_HOADONBANHANG
SELECT * FROM  NHANVIEN
GO
 
