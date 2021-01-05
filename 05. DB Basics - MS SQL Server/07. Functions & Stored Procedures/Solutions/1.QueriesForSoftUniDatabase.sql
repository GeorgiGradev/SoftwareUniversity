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
- EXEC dbo.usp_GetEmployeesSalaryAboveNumber 48100


--- 3.Town Names Starting With ---
GO
CREATE OR ALTER PROC usp_GetTownsStartingWith (@StartString NVARCHAR(20))
AS
BEGIN
	SELECT 
	[Name]
	FROM Towns
	WHERE [Name] LIKE @StartString + '%'
END
GO
--EXEC usp_GetTownsStartingWith 'be'


--- 4.Employees from Town ---
GO 
CREATE OR ALTER PROC usp_GetEmployeesFromTown(@TownName NVARCHAR(MAX))
AS
BEGIN
	SELECT 
		e.FirstName,
		e.LastName
		FROM Employees AS e
		JOIN Addresses AS a ON e.AddressID = a.AddressID
		JOIN Towns AS t ON a.TownID = t.TownID
		WHERE t.[Name] = @TownName
END
GO
--EXEC usp_GetEmployeesFromTown 'Sofia'


--- 5.Salary Level Function ---
GO 
CREATE OR ALTER FUNCTION ufn_GetSalaryLevel(@Salary DECIMAL(18,4)) 
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @SalaryLevel NVARCHAR(10)
		IF @Salary < 30000
			BEGIN
			SET @SalaryLevel = 'Low'
			END
		ELSE IF @Salary >= 30000 AND @Salary <= 50000
			BEGIN
			SET @SalaryLevel = 'Average'
			END
		ELSE
			BEGIN
			SET @SalaryLevel = 'High'
			END
RETURN @SalaryLevel
END
GO
SELECT dbo.ufn_GetSalaryLevel (50001)


--- 6.Employees by Salary Level ---
GO
CREATE OR ALTER PROC usp_EmployeesBySalaryLevel (@SalaryLevel NVARCHAR(8))
AS
BEGIN 
	IF @SalaryLevel = 'Low'
		SELECT 
			FirstName AS [First Name],
			LastName AS [Last Name]
			FROM Employees
			WHERE dbo.ufn_GetSalaryLevel ([Salary]) = 'Low'
	ELSE IF @SalaryLevel = 'Average'
		SELECT 
			FirstName AS [First Name],
			LastName AS [Last Name]
			FROM Employees
			WHERE dbo.ufn_GetSalaryLevel ([Salary]) = 'Average'
	ELSE
			SELECT 
			FirstName AS [First Name],
			LastName AS [Last Name]
			FROM Employees
			WHERE dbo.ufn_GetSalaryLevel ([Salary]) = 'High'
END
--EXECUTE dbo.usp_EmployeesBySalaryLevel 'High'
 

--GO
--CREATE OR ALTER PROCEDURE usp_EmployeesBySalaryLevel @salaryLevel VARCHAR(7)
--AS
--BEGIN
--	SELECT FirstName, LastName FROM Employees
--	WHERE dbo.ufn_GetSalaryLevel (Salary) = @salaryLevel
--END
--EXECUTE dbo.usp_EmployeesBySalaryLevel 'Low'
--GO


