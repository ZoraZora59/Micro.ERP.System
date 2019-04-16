USE MicroERP;
CREATE TABLE UserSelfInfo
(
    UserID INT PRIMARY KEY IDENTITY (1000,1),
    UserName VARCHAR(12) NOT NULL ,
    UserPhoneNumber VARCHAR(14) NOT NULL ,
    UserAddress VARCHAR(128),
    SelfIntroduction VARCHAR(512) DEFAULT '很高兴认识大家',
    ProfilePictureAddress VARCHAR(512),
    UserPassword VARCHAR(32) NOT NULL,
    UserEmail VARCHAR(64)  DEFAULT '@.com',
    UserDepartment VARCHAR(24) NOT NULL ,
    UserPosition VARCHAR(24) NOT NULL ,
    UserSalary DECIMAL(19,4) NOT NULL ,
    UserStatus VARCHAR(24) NOT NULL ,
)
CREATE TABLE UserUpdateInfo
(
    UpdateID INT PRIMARY KEY IDENTITY (5000,1),
    UserID INT NOT NULL FOREIGN KEY REFERENCES UserSelfInfo(UserID) ,
    UpdateTime DATE default GETDATE(),
    UpdateType VARCHAR(24) NOT NULL ,
    UpdateFrom VARCHAR(24) NOT NULL ,
    UpdateInto VARCHAR(24) NOT NULL ,
    UpdateInformation VARCHAR(512)
)
