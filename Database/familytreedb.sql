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
