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
--EXECUTE usp_AssignProject 263, 50
--SELECT * FROM EmployeesProjects WHERE EmployeeID = 263
