CREATE DATABASE QLNGUOIDUNG;
USE QLNGUOIDUNG;
GO

--Tạo bảng Users
--IDENTITY tự động tăng lên 1 đơn vị khi qua UserID mới
CREATE TABLE Users (
	UserID INT PRIMARY KEY IDENTITY,
    Phone NVARCHAR(10) NOT NULL,
    Username NVARCHAR(255) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Name NVARCHAR(25) NOT NULL,
	Money BIGINT NOT NULL,
	constraint Phone_UQ UNIQUE (Phone),
	constraint Username_UQ UNIQUE (Username),
    Time DATETIME DEFAULT GETDATE()
);

--Tạo bảng lịch sử truy cập
CREATE TABLE AccessHistory (
    AccessID INT PRIMARY KEY IDENTITY,
    UserID INT,
    Timestamp DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

--Bật chế độ IDENTITY_INSERT
SET IDENTITY_INSERT Users ON;

--Tắt chế độ IDENTITY_INSERT
SET IDENTITY_INSERT Users OFF;

--Thêm dữ liệu bảng Users
INSERT INTO Users (Phone, Username, Password, Name, Money) VALUES
    ('1234567890', 'user0', 'pass0', N'User 0', 10000),
	('1234567891', 'user1', 'pass1', N'User 1', 20000),
    ('1234567892', 'user2', 'pass2', N'User 2', 25000),
    ('1234567893', 'user3', 'pass3', N'User 3', 30000),
    ('1234567894', 'user4', 'pass4', N'User 4', 35000),
    ('1234567895', 'user5', 'pass5', N'User 5', 40000),
    ('1234567896', 'user6', 'pass6', N'User 6', 45000),
    ('1234567897', 'user7', 'pass7', N'User 7', 50000),
    ('1234567898', 'user8', 'pass8', N'User 8', 55000),
    ('1234567899', 'user9', 'pass9', N'User 9', 60000),
    ('9876543210', 'user10', 'pass10', N'User 10', 15000),
    ('9876543211', 'user11', 'pass11', N'User 11', 20000),
    ('9876543212', 'user12', 'pass12', N'User 12', 15000),
    ('9876543213', 'user13', 'pass13', N'User 13', 26000),
    ('9876543214', 'user14', 'pass14', N'User 14', 27000),
    ('9876543215', 'user15', 'pass15', N'User 15', 32000),
    ('9876543216', 'user16', 'pass16', N'User 16', 17000),
    ('9876543217', 'user17', 'pass17', N'User 17', 45000),
    ('9876543218', 'user18', 'pass18', N'User 18', 55000),
    ('9876543219', 'user19', 'pass19', N'User 19', 43000);

--Đổi tên cột trong bảng Users
EXEC sp_rename 'Users.Time', 'Timestamp', 'COLUMN';

-- Thêm cột Status vào bảng Users
ALTER TABLE Users
ADD Status NVARCHAR(10) DEFAULT 'Offline'	; -- Giả sử mặc định là Offline

-- Update tất cả các hàng để giá trị Status không bị NULL
UPDATE Users
SET Status = 'Offline'
WHERE Status IS NULL;

-- Update tình trạng cho người dùng đang online
UPDATE Users
SET Status = 'Online'
WHERE UserID IN (3, 6, 8, 4, 13, 11, 15, 18, 19, 20, 17);

--Đổi tên cột trong bảng AccessHistory
EXEC sp_rename 'AccessHistory.Timestamp', 'TimeAccess', 'COLUMN';

--Thêm dữ liệu bảng AccessHistory
INSERT INTO AccessHistory (UserID)
SELECT UserID
FROM Users;

SELECT
*FROM Users

