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

-- Thêm dữ liệu vào bảng Members
INSERT INTO Members (FullName, Gender, BirthDate, Address, OccupationID, HometownID, isRoot, Generation) VALUES
(N'Nguyễn Văn A', N'Nam', '1980-01-01', N'Số 1, Đường A, Quận B, Hà Nội', 1, 1, 1, 1),
(N'Trần Thị B', N'Nữ', '1990-02-15', N'Số 2, Đường B, Quận C, Hải Phòng', 2, 2, 0, 2),
(N'Lê Văn C', N'Nam', '1985-05-20', N'Số 3, Đường C, Quận D, Đà Nẵng', 3, 3, 0, 2),
(N'Phạm Thị D', N'Nữ', '1992-07-30', N'Số 4, Đường D, Quận E, Hồ Chí Minh', 4, 4, 0, 2),
(N'Hoàng Văn E', N'Nam', '1975-06-05', N'Số 5, Đường E, Quận F, Hà Nội', 5, 1, 1, 1),
(N'Nguyễn Thị F', N'Nữ', '1983-09-12', N'Số 6, Đường F, Quận G, Hải Phòng', 6, 2, 0, 2),
(N'Trần Văn G', N'Nam', '1988-12-25', N'Số 7, Đường G, Quận H, Đà Nẵng', 7, 3, 0, 2),
(N'Lê Thị H', N'Nữ', '1995-11-14', N'Số 8, Đường H, Quận I, Hồ Chí Minh', 8, 4, 0, 2);
-- Thêm dữ liệu vào bảng MemberRelationships
INSERT INTO MemberRelationships (MemberID1, MemberID2, RelationshipID, EventDate) VALUES
(1, 2, 2, '01/06/2010'), -- Nguyễn Văn A và Trần Thị B kết hôn
(3, 4, 2, '15/08/2015'), -- Lê Văn C và Phạm Thị D kết hôn
(5, 6, 2, '20/12/2005'), -- Hoàng Văn E và Nguyễn Thị F kết hôn
(7, 8, 2, '30/04/2020'), -- Trần Văn G và Lê Thị H kết hôn
(1, 3, 1, '01/06/2005'), -- Nguyễn Văn A là con của Lê Văn C
(5, 7, 1, '01/06/2010'); -- Hoàng Văn E là con của Trần Văn G

-- Thêm dữ liệu vào bảng MemberDeaths
INSERT INTO MemberDeaths (MemberID, DeathDate, CauseID, BurialPlaceID) VALUES
(1, '01/01/2070', 8, 1), -- Nguyễn Văn A tử vong do tuổi già và được chôn cất tại Nghĩa trang Bình Hưng Hòa
(2, '15/03/2060', 6, 2), -- Trần Thị B tử vong do bệnh tim mạch và được chôn cất tại Nghĩa trang Bà Chiểu
(3, '20/05/2065', 3, 3), -- Lê Văn C tử vong do bệnh ung thư và được chôn cất tại Nghĩa trang Láng Hạ
(4, '30/07/2055', 10, 1); -- Phạm Thị D tử vong do bệnh đau tim và được chôn cất tại Nghĩa trang Bình Hưng Hòa

-- Thêm dữ liệu vào bảng MemberAchievements
INSERT INTO MemberAchievements (MemberID, AchievementID, AchievementDate) VALUES
(1, 5, '15/05/2005'), -- Nguyễn Văn A đạt học vị tiến sĩ vào năm 2005
(2, 7, '20/10/2012'), -- Trần Thị B sáng tác tác phẩm nghệ thuật nổi tiếng vào năm 2012
(3, 1, '10/12/2015'), -- Lê Văn C giành giải Nobel vào năm 2015
(4, 4, '25/02/2018'), -- Phạm Thị D giành giải Grammy vào năm 2018
(5, 9, '01/01/2020'), -- Hoàng Văn E thành lập doanh nghiệp thành công vào năm 2020
(6, 3, '05/06/2021'); -- Nguyễn Thị F giành giải Oscar vào năm 2021


