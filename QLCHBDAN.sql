-- Tạo bảng Tài Khoản
CREATE TABLE TaiKhoan (
    IDTaiKhoan INT PRIMARY KEY,  -- Bỏ IDENTITY, nhập thủ công
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,
    MatKhau NVARCHAR(100) NOT NULL,
    LoaiTaiKhoan NVARCHAR(20) CHECK (LoaiTaiKhoan IN ('Admin', 'NhanVien')) NOT NULL
);

-- Tạo bảng Nhân Viên
CREATE TABLE NhanVien (
    IDNhanVien INT PRIMARY KEY,  -- Bỏ IDENTITY
    HoTen NVARCHAR(100) NOT NULL,
    SDT NVARCHAR(15) UNIQUE NOT NULL,
    DiaChi NVARCHAR(255),
    IDTaiKhoan INT UNIQUE,  
    FOREIGN KEY (IDTaiKhoan) REFERENCES TaiKhoan(IDTaiKhoan) ON DELETE SET NULL
);

-- Tạo bảng Khách Hàng
CREATE TABLE KhachHang (
    IDKhachHang INT PRIMARY KEY,  -- Bỏ IDENTITY
    HoTen NVARCHAR(100) NOT NULL,
    SDT NVARCHAR(15) UNIQUE NOT NULL,
    DiemTichLuy INT DEFAULT 0
);


-- Tạo bảng Khuyến Mãi
CREATE TABLE KhuyenMai (
    IDKhuyenMai INT PRIMARY KEY,  -- Bỏ IDENTITY
    MaKhuyenMai NVARCHAR(50) UNIQUE NOT NULL,
    PhanTramGiam DECIMAL(5,2) CHECK (PhanTramGiam BETWEEN 0 AND 100) NOT NULL,
    NgayBatDau DATETIME NOT NULL,
    NgayKetThuc DATETIME NOT NULL
);

-- Tạo bảng Đơn Hàng
CREATE TABLE DonHang (
    IDDonHang INT PRIMARY KEY,  -- Bỏ IDENTITY
    IDKhachHang INT NULL,
    IDNhanVien INT NOT NULL,
    IDKhuyenMai INT NULL,
    NgayTao DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(20) CHECK (TrangThai IN ('Chưa thanh toán', 'Đã thanh toán')) NOT NULL,
    FOREIGN KEY (IDKhachHang) REFERENCES KhachHang(IDKhachHang) ON DELETE SET NULL,
    FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(IDNhanVien) ON DELETE CASCADE,
    FOREIGN KEY (IDKhuyenMai) REFERENCES KhuyenMai(IDKhuyenMai) ON DELETE SET NULL
);

-- Tạo bảng Chi Tiết Đơn Hàng
CREATE TABLE ChiTietDonHang (
    IDChiTiet INT PRIMARY KEY,  -- Bỏ IDENTITY
    IDDonHang INT NOT NULL,
    IDSanPham INT NOT NULL,
    SoLuong INT CHECK (SoLuong > 0) NOT NULL,
    Gia DECIMAL(18,2) NOT NULL DEFAULT 0,
    TongTien AS (SoLuong * Gia) PERSISTED,
    FOREIGN KEY (IDDonHang) REFERENCES DonHang(IDDonHang) ON DELETE CASCADE,
    FOREIGN KEY (IDSanPham) REFERENCES SanPham(IDSanPham) ON DELETE CASCADE
);

-- Tạo bảng Hóa Đơn
CREATE TABLE HoaDon (
    IDHoaDon INT PRIMARY KEY,  -- Bỏ IDENTITY
    IDDonHang INT UNIQUE NOT NULL,
    NgayThanhToan DATETIME DEFAULT GETDATE(),
    TongTien DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (IDDonHang) REFERENCES DonHang(IDDonHang) ON DELETE CASCADE
);

-- Tạo bảng Lịch Sử Tích Điểm Khách Hàng
CREATE TABLE LichSuTichDiem (
    IDLichSu INT PRIMARY KEY,  -- Bỏ IDENTITY
    IDKhachHang INT NOT NULL,
    DiemCong INT NOT NULL,
    NgayGiaoDich DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IDKhachHang) REFERENCES KhachHang(IDKhachHang) ON DELETE CASCADE
);

CREATE TABLE DoanhThu (
    ID INT IDENTITY(1,1) PRIMARY KEY,  
    IDDonHang INT NOT NULL,  -- Liên kết với Đơn Hàng
    Ngay DATE NOT NULL,  
    TongTien DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (IDDonHang) REFERENCES DonHang(IDDonHang)  -- Khóa ngoại
);
ALTER TABLE DoanhThu 
ADD Thang INT NOT NULL, 
    DoanhThu DECIMAL(18,2) NOT NULL;
