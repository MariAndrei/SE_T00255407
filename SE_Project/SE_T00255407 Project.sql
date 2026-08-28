DROP TABLE Revenue CASCADE CONSTRAINTS;
DROP TABLE Sales CASCADE CONSTRAINTS;
DROP TABLE Stock CASCADE CONSTRAINTS;
DROP TABLE Suppliers CASCADE CONSTRAINTS;


CREATE TABLE Suppliers
(
    SuppID NUMBER(4),
    Name VARCHAR2(100),
    PhoneNo VARCHAR2(20),
    Address VARCHAR2(50),
    Manufacturer VARCHAR2(30),

    CONSTRAINT pk_Suppliers PRIMARY KEY (SuppID)
);

CREATE TABLE Stock
(
    StockID NUMBER(4),
    Description VARCHAR2(150),
    Price NUMBER(8,2),
    StockQty NUMBER(5),
    SuppID NUMBER(4),

    CONSTRAINT pk_Stock PRIMARY KEY (StockID),

    CONSTRAINT fk_Stock_Suppliers
        FOREIGN KEY (SuppID)
        REFERENCES Suppliers(SuppID)
);

CREATE TABLE Sales
(
    SaleID NUMBER(4),
    StockID NUMBER(4),
    QtySold NUMBER(4),
    SaleDate DATE,
    Total NUMBER(8,2),

    CONSTRAINT pk_Sales PRIMARY KEY (SaleID),

    CONSTRAINT fk_Sales_Stock
        FOREIGN KEY (StockID)
        REFERENCES Stock(StockID)
);

CREATE TABLE Revenue
(
    RevenueID NUMBER(4),
    SaleID NUMBER(4),
    RevenueAmount NUMBER(8,2),
    RevenueDate DATE,

    CONSTRAINT pk_Revenue PRIMARY KEY (RevenueID),

    CONSTRAINT fk_Revenue_Sales
        FOREIGN KEY (SaleID)
        REFERENCES Sales(SaleID)
);