INSERT dbo.KHACHANG( HoTen, GioiTinh, SDT, DiaChi, SoCMND )
VALUES  ( N'Hồ Đắc Thắng',1,'0984612620',N'Thái Bình','152268008'),
		( N'Trần Hùng Phong',1,'0954852542',N'Hà Nội','456412854'),
		( N'Lương Tuấn Minh',1,'0945285642',N'Hà Nội','84525445'),
		( N'Phan Thùy Dương',0,'0899399888',N'Thành Phố Hồ Chí Minh','752447566'),
		( N'Nguyễn Minh Thông',1,'095685542',N'Hà Nội','8554156254');


INSERT dbo.NHANVIEN( TenNV ,NgaySinh ,GioiTinh ,DiaChi ,SDT , Luong ,TaiKhoan ,MatKhau , Quyen)
VALUES  ( N'Hồ Đắc Thắng' ,'1999-07-24',1,N'Thái Bình' ,'0984612620' ,99999999,'thang' ,'123' ,1),
		( N'Nguyễn Quý Thái' ,'1999-10-22','1',N'Hà Nội' ,'0852542620' , 8888888,'thai' ,'123' ,0),
		( N'Nguễn Sơn Tùng' ,'1999-02-12','1',N'Bắc Ninh' ,'0956852452' ,988888 ,'tung' ,'123' ,0),
		( N'Phạm Văn Hiếu' ,'1999-06-12','1',N'Thái Bình' ,'0984862154' ,999999 ,'hieu' ,'123', 0),
		( N'Hồ Đức Duy' ,'1999-04-10','1',N'Hải Dương' ,'0982846250', 888888 ,'duy' ,'123' ,0);

INSERT dbo.DICHVU( TenDV, DonGia )
VALUES  ( N'Phở Bò',50000),
		( N'Bún Bò Huế',80000),
		( N'Bún Chả',50000),
		( N'Bò Kobe',500000),
		( N'Tôm Hùm',100000),
		( N'Cua Alaska',150000),
		( N'Chival 18',200000),
		( N'Rượu Vang',30000),
		( N'Vi Cá Mập',300000),
		( N'Trứng Cá Hồi',100000),
		( N'Bò Sốt Vang',300000),
		( N'Chival 21',3000000),
		( N'Bún Hải Sản',600000),
		( N'Cua Hoàng Đế',30000000);

INSERT dbo.DODUNG( TenDD )
VALUES  ( N'Máy sấy tóc'),
		( N'Tivi'),
		( N'Tủ Lạnh'),
		( N'Điều Hòa'),
		( N'Quạt'),
		( N'Ghế Sofa'),
		( N'Giường'),
		( N'Đệm'),
		( N'Gối');
		
INSERT dbo.KHACHHANG_DICHVU
        ( MaKH, MaDV, SoLuong )
VALUES  ( 1,1,5),
		( 1,2,5),
		( 1,6,5),
		( 2,3,1),
		( 2,7,3),
		( 3,8,4),
		( 3,4,2),
		( 4,1,2),
		( 4,3,6),
		( 5,6,6),
		( 5,8,2),
		( 5,5,5);

INSERT dbo.PHONG
        ( TenP, DonGiaPhong, TrangThai )
VALUES  ( N'Phòng Vip',1000000,N'Đã Sử Dụng'),
		( N'Phòng Siêu Vip',2000000,N'Đã Sử Dụng'),
		( N'Phòng Vip',1500000,N'Chưa Sử Dụng'),
		( N'Phòng Thường',400000,N'Chưa Sử Dụng'),
		( N'Phòng Đơn',5000000,N'Đã Sử Dụng'),
		( N'Phòng Đôi',800000,N'Đã Sử Dụng'),
		( N'Phòng Vip',1000000,N'Đã Sử Dụng'),
		( N'Phòng Siêu Vip',2500000,N'Chưa Sử Dụng'),
		( N'Phòng Thường',5000000,N'Chưa Sử Dụng')

INSERT dbo.KHACHHANG_PHONG
        ( MaKH, MaP )
VALUES  ( 1,1),
		( 1,2),
		( 1,3),
		( 2,4),
		( 2,6),
		( 3,7),
		( 3,8),
		( 4,9),
		( 4,1),
		( 5,5),
		( 5,6),
		( 5,9);

INSERT dbo.CHITIETPHONG
        ( MaP, MaDD, SoLuongDD )
VALUES  ( 1,1,2),
		( 1,2,3),
		( 1,4,1),
		( 1,1,2),
		( 2,3,1),
		( 2,5,4),
		( 3,6,1),
		( 3,7,1),
		( 4,2,2),
		( 4,2,4),
		( 5,8,2),
		( 5,9,1),
		( 5,3,2),
		( 5,6,2);

INSERT dbo.HOADON( MaNV ,MaKH ,NgayVao ,NgayDi ,TongTien ,TongTienDV, TongTienPhong )
VALUES  ( 1 ,1 ,'2019-4-22' ,'2019-6-24' ,2500000 ,1500000 ,1000000),
		( 2 ,1 ,'2019-4-26' ,'2019-4-28' ,35000000 ,1500000 ,2000000),
		( 3 ,2 ,'2020-2-12' ,'2020-2-16' ,5000000 ,2000000 ,3000000),
		( 4 ,3 ,'2019-8-06' ,'2019-8-09' ,6000000 ,200000 ,4000000),
		( 5 ,4 ,'2020-9-17' ,'2020-9-20' ,4500000 ,1500000 ,3000000),
		( 1 ,5 ,'2019-7-24' ,'2019-7-30' ,9000000 ,3000000 ,6000000);