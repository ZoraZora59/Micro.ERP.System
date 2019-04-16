use MicroERP;
CREATE TABLE GoodsResourceInfo
(
    GoodsID INT PRIMARY KEY IDENTITY (1,1),
    GoodsName VARCHAR(32) NOT NULL ,/*商品名*/
    GoodsQuantity BIGINT NOT NULL ,/*进货量*/
    GoodsCountingUnit VARCHAR(16) NOT NULL ,/*计数单位，如'克','升','加仑'等*/
    GoodsUnitPrice INT NOT NULL ,/*进货单价*/
    GoodsFrom VARCHAR(32) NOT NULL/*进货公司*/
)
CREATE TABLE GoodsConfirmInfo
(
    ConfirmID INT PRIMARY KEY IDENTITY (1,1),
    ConfirmOrderID INT NOT NULL,/*确定的订单号*/
    ConfirmUserID INT NOT NULL FOREIGN KEY REFERENCES UserSelfInfo(UserID),
    ConfirmType VARCHAR(16) NOT NULL ,/*确认类型，如'采购','信息','发货','收货','收款'*/
    ConfirmNote VARCHAR(512),
    ConfirmDate DATE DEFAULT GETDATE(),
)
CREATE TABLE GoodsOrderInfo
(
    OrderID INT PRIMARY KEY IDENTITY (1,1),
    GoodsID INT FOREIGN KEY REFERENCES GoodsResourceInfo(GoodsID),
    GoodsQuantity BIGINT NOT NULL ,/*进出货量*/
    GoodsTarget VARCHAR(32) NOT NULL ,/*货物目标*/
    GoodsUnitPrice INT NOT NULL ,/*进出货单价*/
    GoodsSellerID INT NOT NULL FOREIGN KEY REFERENCES UserSelfInfo(UserID),/*采购员/销售员ID*/
    OrderTime DATE DEFAULT GETDATE(),/*下单时间*/
    GoodsConfirmID INT FOREIGN KEY REFERENCES GoodsConfirmInfo(ConfirmID),/*当前确认单ID*/
    SaleNote VARCHAR(512)/*备注*/
)
CREATE TABLE GoodsRejectedOrderInfo
(
    RejectID INT PRIMARY KEY IDENTITY (1,1),
    RejectOrderID INT NOT NULL FOREIGN KEY REFERENCES GoodsOrderInfo(OrderID),/*驳回的订单号*/
    RejectBy INT NOT NULL FOREIGN KEY REFERENCES GoodsConfirmInfo(ConfirmID),/*发起驳回的确认单号*/
    RejectState VARCHAR(16) NOT NULL ,/*驳回状态，如'待处理','待批复','已完成','已取消'*/
    RejectUserID INT NOT NULL FOREIGN KEY REFERENCES UserSelfInfo(UserID),
    RejectNote VARCHAR(512) NOT NULL
)
ALTER TABLE GoodsConfirmInfo ADD FOREIGN KEY (ConfirmOrderID) REFERENCES GoodsOrderInfo(OrderID)

