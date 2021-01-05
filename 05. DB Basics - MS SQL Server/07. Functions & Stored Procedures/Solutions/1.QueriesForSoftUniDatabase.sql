USE SoftUni 

--- 1.Employees with Salary Above 35000 ---
 GO
 CREATE OR ALTER PROCEDURE usp_GetEmployeesSalaryAbove35000 
 AS
 BEGIN
	SELECT 
		FirstName AS [First Name],
		LastName AS [Last Name]
		FROM Employees
		WHERE Salary > 35000
END
--EXEC dbo.usp_GetEmployeesSalaryAbove35000


--- 2.Employees with Salary Above Number ---
GO
CREATE OR ALTER PROC usp_GetEmployeesSalaryAboveNumber (@MinSalary DECIMAL(18,4))
AS 
BEGIN
	SELECT
		FirstName AS [First Name],
		LastName AS [LastName]
		FROM Employees
		WHERE Salary >= @MinSalary
END
GO 

EXEC dbo.usp_GetEmployeesSalaryAboveNumber 48100
