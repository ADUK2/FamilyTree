-- Tạo cơ sở dữ liệu
CREATE DATABASE FamilyTreeDB;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE FamilyTreeDB;
GO

-- Set format date
SET DATEFORMAT dmy;

CREATE TABLE Hometowns (
    HometownID INT PRIMARY KEY IDENTITY(1,1),
    HometownName NVARCHAR(100) NOT NULL
);

CREATE TABLE Occupations (
    OccupationID INT PRIMARY KEY IDENTITY(1,1),
    OccupationName NVARCHAR(100) NOT NULL
);

CREATE TABLE Achievements (
    AchievementID INT PRIMARY KEY IDENTITY(1,1),
    AchievementName NVARCHAR(100) NOT NULL
);

CREATE TABLE DeathCauses (
    CauseID INT PRIMARY KEY IDENTITY(1,1),
    CauseName NVARCHAR(100) NOT NULL
);

CREATE TABLE BurialPlaces (
    PlaceID INT PRIMARY KEY IDENTITY(1,1),
    PlaceName NVARCHAR(100) NOT NULL
);

CREATE TABLE Members (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10),
    BirthDate DATE,
    Address NVARCHAR(200),
    OccupationID INT,
    HometownID INT,
    isRoot BIT DEFAULT 0,
	Generation INT,
    FOREIGN KEY (OccupationID) REFERENCES Occupations(OccupationID),
    FOREIGN KEY (HometownID) REFERENCES Hometowns(HometownID)
);

CREATE TABLE Relationships (
    RelationshipID INT PRIMARY KEY IDENTITY(1,1),
    RelationshipType NVARCHAR(50) NOT NULL
);

CREATE TABLE MemberRelationships (
    MemberRelationshipID INT PRIMARY KEY IDENTITY(1,1),
    MemberID1 INT,
    MemberID2 INT,
    RelationshipID INT,
    EventDate DATE,
    FOREIGN KEY (MemberID1) REFERENCES Members(MemberID),
    FOREIGN KEY (MemberID2) REFERENCES Members(MemberID),
    FOREIGN KEY (RelationshipID) REFERENCES Relationships(RelationshipID)
);

CREATE TABLE MemberAchievements (
    MemberAchievementID INT PRIMARY KEY IDENTITY(1,1),
    MemberID INT,
    AchievementID INT,
    AchievementDate DATE,
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID),
    FOREIGN KEY (AchievementID) REFERENCES Achievements(AchievementID)
);

CREATE TABLE MemberDeaths (
    MemberDeathID INT PRIMARY KEY IDENTITY(1,1),
    MemberID INT,
    DeathDate DATE,
    CauseID INT,
    BurialPlaceID INT,
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID),
    FOREIGN KEY (CauseID) REFERENCES DeathCauses(CauseID),
    FOREIGN KEY (BurialPlaceID) REFERENCES BurialPlaces(PlaceID)
);

-- Bảng Users
CREATE TABLE Users (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    VerificationCode NVARCHAR(10),
    VerificationExpiry DATETIME
);



--INSERT DATA
-- Thêm dữ liệu cho bảng Hometowns
INSERT INTO Hometowns (HometownName) VALUES
(N'Hà Nội'),
(N'Hải Phòng'),
(N'Đà Nẵng'),
(N'Hồ Chí Minh');

-- Thêm dữ liệu cho bảng Occupations
INSERT INTO Occupations (OccupationName) VALUES
(N'Lập trình viên'),
(N'Kỹ sư xây dựng'),
(N'Giáo viên'),
(N'Y tá'),
(N'Nhân viên văn phòng'),
(N'Bác sĩ'),
(N'Kế toán viên'),
(N'Nhà nghiên cứu'),
(N'Nhà kinh doanh'),
(N'Diễn viên'),
(N'Nhà văn'),
(N'Nghệ sĩ'),
(N'Luật sư'),
(N'Nhà hàng xóm'),
(N'Thợ cơ khí');

-- Thêm dữ liệu cho bảng Achievements
INSERT INTO Achievements (AchievementName) VALUES
(N'Giải Nobel'),
(N'Huy chương vàng Olympic'),
(N'Giải thưởng Oscar'),
(N'Giải thưởng Grammy'),
(N'Đạt học vị tiến sĩ'),
(N'Có công trình nghiên cứu được công nhận quốc tế'),
(N'Sáng tác tác phẩm nghệ thuật nổi tiếng'),
(N'Xuất bản sách bán chạy'),
(N'Thành lập doanh nghiệp thành công'),
(N'Thành tựu trong lĩnh vực từ thiện');

-- Thêm dữ liệu cho bảng DeathCauses
INSERT INTO DeathCauses (CauseName) VALUES
(N'Tai nạn giao thông'),
(N'Tai nạn lao động'),
(N'Bệnh ung thư'),
(N'Tai nạn đuối nước'),
(N'Đột quỵ'),
(N'Bệnh tim mạch'),
(N'Covid-19'),
(N'Tử vong do tuổi già'),
(N'Tai nạn rơi từ độ cao'),
(N'Bệnh đau tim'),
(N'Tai nạn đuối trong bể bơi'),
(N'Bệnh đường hô hấp');

-- Thêm dữ liệu cho bảng BurialPlaces
INSERT INTO BurialPlaces (PlaceName) VALUES
(N'Nghĩa trang Bình Hưng Hòa'),
(N'Nghĩa trang Bà Chiểu'),
(N'Nghĩa trang Láng Hạ');

-- Thêm dữ liệu cho bảng Relationships
INSERT INTO Relationships (RelationshipType) VALUES
(N'Con'),
(N'Vợ/Chồng');

