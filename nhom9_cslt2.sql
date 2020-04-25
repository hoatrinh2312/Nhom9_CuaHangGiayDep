create database nhom9_CuaHangGiayDep;
create table TheLoai(
MaLoai nvarchar(20) primary key,
TenLoai nvarchar(50),
)
create table Co(
MaCo nvarchar(20) primary key,
TenCo nvarchar(50),
)
create table ChatLieu(
MaCL nvarchar(20) primary key,
TenCL nvarchar(50),
)
create table Mau(
MaMau nvarchar(20) primary key,
TenMau nvarchar(50),
)
create table DoiTuong(
MaDT nvarchar(20) primary key,
TenDT nvarchar(50),
)
create table Mua(
MaMua nvarchar(20) primary key,
TenMua nvarchar(50),
)
create table NuocSX(
MaNSX nvarchar(20) primary key,
TenNSX nvarchar(50),
)
create table SanPham(
MaGD nvarchar(50) primary key,
TenGD nvarchar(50),
MaLoai nvarchar(20),
MaCo nvarchar(20),
MaCL nvarchar(20),
MaMau nvarchar(20),
MaDT nvarchar(20),
MaMua nvarchar(20),
MaNSX nvarchar (20),
SoLuong int,
Anh nvarchar(100),
DonGiaNhap float,
DonGiaBan float,
 CONSTRAINT fk_sp_loai FOREIGN KEY (MaLoai) REFERENCES TheLoai (MaLoai) on delete cascade,
 CONSTRAINT fk_sp_co FOREIGN KEY (MaCo) REFERENCES Co (MaCo) on delete cascade,
 CONSTRAINT fk_sp_CL FOREIGN KEY (MaCL) REFERENCES ChatLieu (MaCL) on delete cascade,
 CONSTRAINT fk_sp_Mau FOREIGN KEY (MaMau) REFERENCES Mau (MaMau) on delete cascade,
 CONSTRAINT fk_sp_DT FOREIGN KEY (MaDT) REFERENCES DoiTuong (MaDT) on delete cascade,
 CONSTRAINT fk_sp_Mua FOREIGN KEY (MaMua) REFERENCES Mua (MaMua) on delete cascade,
 CONSTRAINT fk_sp_NSX FOREIGN KEY (MaNSX) REFERENCES NuocSX (MaNSX) on delete cascade
 
)
create table CongViec(
MaCV nvarchar(20) primary key,
TenCV nvarchar(50),
)
create table NhanVien(
MaNV nvarchar(20) primary key,
TenNV nvarchar(50),
GioiTinh nvarchar(50),
NgaySinh datetime,
DienThoai nvarchar(15),
DiaChi nvarchar(100),
MaCV nvarchar(20),
CONSTRAINT fk_NV_CV FOREIGN KEY (MaCV) REFERENCES CongViec (MaCV) on delete cascade

)
create table Khach(
MaKhach nvarchar(20) primary key,
TenKhach nvarchar(50),
DiaChi nvarchar(70),
DienThoai nvarchar(15),
)
create table HoaDonBan(
SoHDB nvarchar(50) primary key,
MaNV nvarchar(20),
NgayBan datetime,
MaKhach nvarchar(20),
TongTien float,
CONSTRAINT fk_HDB_NV FOREIGN KEY (MaNV) REFERENCES NhanVien (MaNV) on delete cascade,
CONSTRAINT fk_HDB_K FOREIGN KEY (MaKhach) REFERENCES Khach (MaKhach) on delete cascade

)
create table NhaCungCap(
MaNCC nvarchar(20) primary key,
TenNCC nvarchar(50),
DiaChi nvarchar(70),
DienThoai nvarchar(15),
)
create table HoaDonNhap(
SoHDN nvarchar(50)primary key,
MaNV nvarchar(20),
NgayNhap datetime,
MaNCC nvarchar(20),
TongTien float,
CONSTRAINT fk_HDN_NV FOREIGN KEY (MaNV) REFERENCES NhanVien (MaNV) on delete cascade,
CONSTRAINT fk_HDN_NCC FOREIGN KEY (MaNCC) REFERENCES NhaCungCap (MaNCC) on delete cascade

)

create table ChiTietHDB(
SoHDB nvarchar(50) ,
MaGD nvarchar(50) ,
SoLuong int,
GiamGia float,
ThanhTien float,
PRIMARY KEY( SoHDB, MaGD),
)

create table ChiTietHDN(
SoHDN nvarchar(50),
MaGD nvarchar(50),
SoLuong int,
DonGia float,
GiamGia float,
ThanhTien float,
PRIMARY KEY(SoHDN, MaGD),
)
insert into TheLoai(MaLoai,TenLoai) values('L01','giay')
insert into TheLoai(MaLoai,TenLoai) values('L02','dep')
insert into Co(MaCo,TenCo) values ('C01','39')
insert into Co(MaCo,TenCo) values ('C02','37')
insert into Co(MaCo,TenCo) values ('C03','38')
insert into ChatLieu(MaCL,TenCL) values('CL01','vai')
insert into ChatLieu(MaCL,TenCL) values('CL02','cotton')
insert into Mau(MaMau,TenMau) values('M01','trang')
insert into Mau(MaMau,TenMau) values('M02','đen')
insert into DoiTuong(MaDT,TenDT) values('DT01','nu')
insert into DoiTuong(MaDT,TenDT) values('DT02','nam')
insert into DoiTuong(MaDT,TenDT) values('DT03','nam & nữ')
insert into Mua(MaMua,TenMua) values('MU01','mua xuan')
insert into Mua(MaMua,TenMua) values('MU02','mua he')
insert into CongViec(MaCV,TenCV) values('CV01','ban hang')
insert into CongViec(MaCV,TenCV) values('CV02','nhan vien kho')
insert into CongViec(MaCV,TenCV) values('CV03,'ship hàng')
insert into NuocSX(MaNSX,TenNSX) values ('N01','korea')
insert into NuocSX(MaNSX,TenNSX) values ('N02','germany')
insert into NhanVien(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCV)
values('NV01','loan','nu','04/04/1997','0986783654','ninh binh','CV01')
insert into NhanVien(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCV)
values('NV02','chinh','nam','03/04/2000','0986783751','hung yen','CV02')
insert into NhanVien(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCV)
values('NV03','hoan','nam','10/04/2001','0351783751','bình định','CV03')
insert into NhanVien(MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCV)
values('NV04','thúy','nữ','07/26/1998','0351783751','nha trang','CV02')

insert into Khach(MaKhach,TenKhach,DiaChi,DienThoai)
values('K03','hiền','bắc ninh','0346483167')
insert into Khach(MaKhach,TenKhach,DiaChi,DienThoai)
values('K04','trường','hà nam','082955118')
insert into Khach(MaKhach,TenKhach,DiaChi,DienThoai)
values('K01','linh','ha noi','064957318')
insert into Khach(MaKhach,TenKhach,DiaChi,DienThoai)
values('K02','nam','khanh hoa','06387318')
insert into Khach(MaKhach,TenKhach,DiaChi,DienThoai)
values('K05','bình','nam định','08367509')
insert into Khach(MaKhach,TenKhach,DiaChi,DienThoai)
values('K06','khánh','lào cai','03497509')
insert into Khach(MaKhach,TenKhach,DiaChi,DienThoai)
values('K07','trang','quảng ninh','09427509')
insert into Khach(MaKhach,TenKhach,DiaChi,DienThoai)
values('K08','tươi','hà nội','08648509')

insert into NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai)
values('NCC01','cong ty hai dang','hung yen','034975647')
insert into NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai)
values('NCC02','cong ty thanh cong','ha noi','034976477')
insert SanPham(MaGD,TenGD,MaLoai,MaCo,MaCL,MaMau,MaMua,MaNSX,Anh,MaDT,Soluong,DonGiaNhap,DonGiaBan)
values('GD01','giay the thao','L01','C01','CL01','M01','MU01','N01','giayEQT','DT03','4','150000','170000')
insert SanPham(MaGD,TenGD,MaLoai,MaCo,MaCL,MaMau,MaMua,MaNSX,Anh,MaDT,Soluong,DonGiaNhap,DonGiaBan)
values('GD02','giay nike air max','L02','C02','CL02','M02','MU02','N02','giaynike','DT02','3','220000','235000')
insert SanPham(MaGD,TenGD,MaLoai,MaCo,MaCL,MaMau,MaMua,MaNSX,Anh,MaDT,Soluong,DonGiaNhap,DonGiaBan)
values('GD03','giay adidas','L01','C01','CL01','M02','MU01','N02','giayAdidas','DT03','6','750000','760000')
insert SanPham(MaGD,TenGD,MaLoai,MaCo,MaCL,MaMau,MaMua,MaNSX,Anh,MaDT,Soluong,DonGiaNhap,DonGiaBan)
values('GD04','dep bitis','L02','C01','CL02','M01','MU01','N02','depbitis','DT02','7','245000','250000')
insert SanPham(MaGD,TenGD,MaLoai,MaCo,MaCL,MaMau,MaMua,MaNSX,Anh,MaDT,Soluong,DonGiaNhap,DonGiaBan)
values('GD05','giay bitis','L01','C01','CL01','M01','MU01','N02','giaybitis','DT02','7','860000','865000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('001','GD02','2','0','470000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('001','GD03','1','0','760000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('003','GD04','2','5','475000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('003','GD01','1','5','161500')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('001','GD01','1','10','153000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('002','GD02','2','0','470000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('004','GD03','2','10','1368000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('004','GD01','1','0','170000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('004','GD02','1','5','223250')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('005','GD04','2','15','425000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('006','GD05','1','0','865000')
insert into ChiTietHDB(SoHDB,MaGD,SoLuong,GiamGia,ThanhTien)
values('007','GD05','2','5','1643500')

insert into HoaDonBan(SoHDB,MaNV,NgayBan,MaKhach,TongTien)
values('001','NV01','03/04/2020','K01','1383000')
insert into HoaDonBan(SoHDB,MaNV,NgayBan,MaKhach,TongTien)
values('002','NV02','11/12/2019','K02','470000')
insert into HoaDonBan(SoHDB,MaNV,NgayBan,MaKhach,TongTien)
values('003','NV01','05/08/2019','K01','636500')
insert into HoaDonBan(SoHDB,MaNV,NgayBan,MaKhach,TongTien)
values('004','NV03','07/18/2019','K03','1761250')
insert into HoaDonBan(SoHDB,MaNV,NgayBan,MaKhach,TongTien)
values('005','NV01','06/21/2019','K02','425000')
insert into HoaDonBan(SoHDB,MaNV,NgayBan,MaKhach,TongTien)
values('006','NV03','04/11/2019','K04','865000')
insert into HoaDonBan(SoHDB,MaNV,NgayBan,MaKhach,TongTien)
values('007','NV01','05/06/2019','K06','1643500')

insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('110','GD01','8','150000','10','1080000')
insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('110','GD02','8','220000','10','1584000')
insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('111','GD02','7','220000','0','1540000')
insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('112','GD04','10','245000','0','2450000')
insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('113','GD05','12','860000','0','10320000')
insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('113','GD01','5','150000','0','750000')
insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('114','GD04','10','245000','0','2450000')
insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('115','GD03','10','750000','0','7500000')
insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('116','GD02','10','220000','0','2200000')
insert into ChiTietHDN(SoHDN,MaGD,SoLuong,DonGia,GiamGia,ThanhTien)
values('117','GD04','5','245000','0','1225000')

insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values('110','NV01','06/03/2019','NCC01','2664000')
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values('111','NV02','05/12/2019','NCC02','1540000')
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values('112','NV03','07/25/2019','NCC02','2450000')
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values('113','NV03','08/18/2019','NCC01','11070000')
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values('116','NV02','12/05/2019','NCC01','2200000')
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values('117','NV02','01/05/2019','NCC01','1225000')
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values('114','NV03','02/06/2020','NCC01','2450000')
insert into HoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC,TongTien)
values('115','NV01','01/26/2020','NCC01','7500000')


