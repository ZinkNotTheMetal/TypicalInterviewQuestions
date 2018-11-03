-- CSO - Stands for Customer / Salesperson / Orders

-- Q: Return all Salespeople who have had an order with George
SELECT
    sp.[Name]
FROM
    dbo.Salesperson sp
-- INNER JOIN HERE due to HAD an order
INNER JOIN
    Orders o ON sp.SalespersonId = o.SalespersonId
INNER JOIN
    Customer c ON c.CustomerId = o.CustomerId
WHERE
    c.[Name] = N'George'

-- Q: Return all salespeople who have not had an order with George
SELECT DISTINCT
    sp.[Name]
FROM
    Salesperson sp
LEFT JOIN
    Orders o ON o.SalespersonId = sp.SalespersonId
LEFT JOIN
    Customer c ON c.CustomerId = o.CustomerId
WHERE
    -- NEED TO CHECK FOR NULL DUE TO LEFT JOINS AS WELL or it will not be a comprehensive list of all Salespeople
    c.[Name] != N'George' OR c.[Name] IS NULL

-- Q: Return all salespeople who have had two or more orders
SELECT DISTINCT
    sp.[Name]
FROM
    Salesperson sp
INNER JOIN
    Orders o ON o.SalespersonId = sp.SalespersonId
GROUP BY (sp.[Name])
HAVING COUNT(sp.[Name]) >= 2