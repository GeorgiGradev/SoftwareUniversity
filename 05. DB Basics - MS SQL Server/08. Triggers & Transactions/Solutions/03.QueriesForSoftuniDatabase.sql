USE SoftUni

--- 8.Employees with Three Projects ---
GO
CREATE OR ALTER PROCEDURE usp_AssignProject(@employeeId INT, @projectID INT)
AS
BEGIN TRANSACTION
	INSERT INTO EmployeesProjects
    VALUES (@employeeId, @projectID)
    IF (SELECT 
			COUNT(ProjectID)
			FROM EmployeesProjects
			WHERE EmployeeID = @employeeId
	   ) > 3
      BEGIN
	    RAISERROR ('The employee has too many projects!', 16, 1)
        ROLLBACK
        RETURN
      END
COMMIT
GO

--GO
--CREATE OR ALTER PROCEDURE usp_AssignProject(@employeeId INT, @projectID INT)
--AS
--BEGIN
--BEGIN TRANSACTION
--	DECLARE @existingEmployeeId INT 
--	= (SELECT TOP(1) EmployeeID FROM EmployeesProjects WHERE EmployeeID = @employeeId)
--	DECLARE @existingProjectId INT 
--	= (SELECT  TOP(1) ProjectID FROM EmployeesProjects WHERE ProjectID = @projectID)

--	IF (@existingEmployeeId IS NULL OR @existingProjectId IS NULL)
--	BEGIN
--		ROLLBACK
--		RAISERROR ('Not existing project', 16, 1)
--		RETURN
--	END

--	ELSE IF (SELECT COUNT(*) FROM EmployeesProjects WHERE EmployeeID = @existingEmployeeId) >= 10
--	BEGIN
--		ROLLBACK
--		RAISERROR ('The employee has too many projects!', 16, 1)
--		RETURN
--	END

--	ELSE
--	BEGIN
--		INSERT INTO EmployeesProjects (EmployeeID, ProjectID)
--		VALUES (@existingEmployeeId, @existingProjectId)
--	END
--COMMIT
--END
--GO

--EXECUTE usp_AssignProject 1, 128
--SELECT * FROM EmployeesProjects WHERE EmployeeID = 1



--- 9.Delete Employees ---
CREATE TABLE Deleted_Employees
(
	EmployeeId INT PRIMARY KEY IDENTITY, 
	FirstName NVARCHAR(50), 
	LastName NVARCHAR (50), 
	MiddleName NVARCHAR(50), 
	JobTitle NVARCHAR(50), 
	DepartmentId INT, 
	Salary DECIMAL(18,2)
) 

GO
CREATE OR ALTER TRIGGER tr_DeletedEmployeesTrigger ON Employees INSTEAD OF DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees
	(FirstName,LastName,MiddleName,JobTitle,DepartmentId,Salary)
	SELECT 
		d.FirstName,
		d.LastName,
		d.MiddleName,
		d.JobTitle,
		d.DepartmentID,
		d.Salary
		FROM deleted as d
		JOIN Employees as e ON d.EmployeeID = e.EmployeeID
END

DELETE 
	FROM Employees
	WHERE EmployeeID = 1

SELECT * FROM Deleted_Employees