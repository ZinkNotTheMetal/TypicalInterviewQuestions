-- CSO - Stands for Customer / Salesperson / Orders

-- Initialize Sales person table
CREATE TABLE dbo.Salesperson(
    SalespersonId INT,
    [Name] NVARCHAR(255),
    Age INT,
    Salary BIGINT,
)

-- Insert seed data into Salesperson table
INSERT INTO dbo.Salesperson(SalespersonId, [Name], Age, Salary) VALUES
(1, N'Alice', 61, 140000),
(2, N'Bob', 34, 44000),
(6, N'Chris', 34, 40000),
(8, N'Derek', 41, 52000),
(11, N'Emmit', 57, 115000),
(16, N'Fred', 38, 38000)
GO

CREATE TABLE dbo.Customer (
    CustomerId INT,
    [Name] NVARCHAR(255)
)
-- Insert seed data into Customer table
INSERT INTO dbo.Customer (CustomerId, [Name]) VALUES
(4, N'George'),
(6, N'Harry'),
(7, N'Ingrid'),
(11, N'Jerry')

CREATE TABLE dbo.Orders(
    OrderId INT,
    OrderDate DATE,
    CustomerId INT,
    SalespersonId INT,
    NumberOfUnits BIGINT,
    CostOfUnit BIGINT
)

-- Insert seed data into Orders table
INSERT INTO dbo.Orders (OrderId, OrderDate, CustomerId, SalespersonId, NumberOfUnits, CostOfUnit) VALUES
(3, '2013-01-17', 4, 2, 4, 400),
(6, '2013-02-07', 4, 1, 1, 600),
(10, '2013-03-04', 7, 6, 2, 300),
(17, '2013-03-15', 6, 1, 5, 300),
(25, '2013-04-19', 11, 11, 7, 300),
(34, '2013-04-22', 11, 11, 100, 26),
(57, '2013-07-12', 7, 11, 14, 11)


-- ONLY Part of question 5
CREATE TABLE dbo.BigOrders(
    CustomerId INT,
    TotalOrderValue BIGINT
)