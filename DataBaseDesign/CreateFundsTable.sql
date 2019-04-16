use MicroERP
CREATE TABLE TotalAssetsInfo
(
    AssetsUpdateID INT PRIMARY KEY IDENTITY (1,1),
    TotalAssets DECIMAL(19,4) NOT NULL,
    UpdateTime DATETIME DEFAULT GETDATE(),
    AttachedType VARCHAR(16) NOT NULL ,
    AttachedID INT,
)
CREATE TABLE EmployeeViolationInfo
(
    RecordID INT PRIMARY KEY IDENTITY(1,1) ,
    ViolateUserID INT NOT NULL FOREIGN KEY REFERENCES UserSelfInfo(UserID),
    ViolateFor VARCHAR(512) NOT NULL ,
    FundsPunish DECIMAL(19,4) NOT NULL DEFAULT 0,
    RecordDate DATE DEFAULT GETDATE()
)
CREATE TABLE FundsSalaryInfo
(
    SalaryID INT PRIMARY KEY IDENTITY (1,1),
    EmployeeID INT NOT NULL FOREIGN KEY REFERENCES UserSelfInfo(UserID),
    BaseSalary DECIMAL(19,4) NOT NULL ,
    PerformanceBonus DECIMAL(19,4) NOT NULL ,
    ViolationRecordID INT FOREIGN KEY REFERENCES EmployeeViolationInfo(RecordID),
    RealWage DECIMAL(19,4) NOT NULL ,
    PayWagesDate DATETIME DEFAULT GETDATE()
)
CREATE TABLE FundsGoodsInfo
(
    FundsForGoodsID INT PRIMARY KEY IDENTITY (1000,1),
    GoodsOrderID INT NOT NULL FOREIGN KEY REFERENCES GoodsOrderInfo(OrderID),
    ConfirmUserID INT FOREIGN KEY REFERENCES UserSelfInfo(UserID),
    FundsState VARCHAR(16) NOT NULL ,
    FundsUpdate DECIMAL(19,4) NOT NULL,
    ConfirmDate DATE DEFAULT GETDATE(),
    FundsNote VARCHAR(512)
)

