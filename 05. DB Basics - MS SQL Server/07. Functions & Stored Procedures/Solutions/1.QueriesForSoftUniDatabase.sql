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
GO
EXEC dbo.usp_GetEmployeesSalaryAbove35000

--- 2.Employees with Salary Above Number ---