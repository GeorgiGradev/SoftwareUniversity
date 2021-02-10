--- 02.Insert ---
INSERT INTO Employees(FirstName, LastName, Birthdate, DepartmentId)
	VALUES
	('Marlo', 'O''Malley', '1958-9-21', 1),
	('Niki', 'Stanaghan', '1969-11-26', 4),
	('Ayrton', 'Senna', '1960-03-21', 9),
	('Ronnie', 'Peterso', '1944-02-14',	9),
	('Giovanna', 'Amati', '1959-07-20',	5)

INSERT INTO Reports(CategoryId, StatusId, OpenDate, CloseDate, Description, UserId, EmployeeId)
	VALUES
(1, 1, '2017-04-13', NULL,	'Stuck Road on Str.133', 6,	2),
(6, 3, '2015-09-05', '2015-12-06',	'Charity trail running', 3,	5),
(1, 2, '2015-09-07', NULL,	'Falling bricks on Str.58',	5, 2),
(4, 3, '2017-07-03', '2017-07-06',	'Cut off streetlight on Str.11', 1,	1)

--- 03.Update ---
UPDATE Reports
	SET CloseDate = GETDATE()
	WHERE CloseDate is Null

--- 04.Delete ---
DELETE
	FROM Reports
	WHERE StatusId = 4;

--- 05.Unassigned Reports---
SELECT
	Description,
	FORMAT(OpenDate,'dd-MM-yyy') as OpenDate
	FROM Reports
	WHERE EmployeeId IS NULL
	ORDER BY Reports.[OpenDate], Description

--- 06.Reports & Categories ---
SELECT
	r.Description,
	c.Name
	FROM Reports as r
	JOIN Categories as c ON c.Id = r.CategoryId
	ORDER BY r.Description, c.Name

--- 07.Most Reported Category ---
SELECT TOP(5)
	Name,
	COUNT(*) as ReportsNumber
	FROM Categories as c
	JOIN Reports as r ON r.CategoryId = c.Id
	GROUP BY Name
	ORDER BY ReportsNumber DESC, Name

SELECT TOP(5)
	temp.Name,
	Count(temp.Name) as ReportsNumber
	FROM (SELECT
			c.Name
			FROM Reports as r
			JOIN Categories as c ON r.CategoryId = c.Id) as temp
	GROUP BY temp.Name
	ORDER BY ReportsNumber DESC, temp.Name

--- 08.Birthday Report ---
SELECT 
	u.Username,
	c.Name as CategoryName
	FROM Reports as r
	JOIN Users as u ON r.UserId = u.Id
	JOIN Categories as c ON r.CategoryId = c.Id
	WHERE DATEPART(MONTH, u.Birthdate) = DATEPART(MONTH, r.OpenDate) AND DATEPART(DAY, u.Birthdate) = DATEPART(DAY, r.OpenDate)
	ORDER BY u.Username, c.Name

--- 08.Birthday Report ---

SELECT 
	u.Username,
	c.Name as CategoryName
	FROM Reports as r
	JOIN Users as u ON r.UserId = u.Id
	JOIN Categories as c ON r.CategoryId = c.Id
	WHERE FORMAT(r.Opendate, 'MM-dd') = FORMAT(u.Birthdate, 'MM-dd')
	ORDER BY u.Username, c.Name

--- 09.Users per Employee ---
SELECT 
	FullName,
	COUNT(*) as count
	FROM (SELECT
			CONCAT(e.FirstName, ' ', e.LastName) AS FullName,
			r.UserId
			FROM Employees as e
			JOIN Reports as r ON e.Id = r.EmployeeId) as temp
	GROUP BY FullName
	ORDER BY count DESC, FullName
	

SELECT
	CONCAT(FirstName, ' ', LastName) AS FullName,
	COUNT(r.UserId)
	FROM Reports AS r
	JOIN Employees AS e ON e.Id = r.EmployeeId
	GROUP BY CONCAT(FirstName, ' ', LastName) 
	ORDER BY COUNT(r.UserId) DESC, FullName


--- 10.Full Info ---
SELECT 
	ISNULL(e.FirstName + ' ' + e.LastName, 'None') AS Employee,
	ISNULL(d.Name, 'None') AS Department,
	ISNULL(c.Name, 'None') AS Category,
	r.Description,
	FORMAT(r.OpenDate, 'dd.MM.yyyy') AS OpenDate,
	s.Label AS Status,
	u.Name AS [User]
	FROM Reports as r
	LEFT JOIN Employees as e ON e.Id = r.EmployeeId
	LEFT JOIN Users AS u ON u.Id = r.UserId
	LEFT JOIN Status AS s ON r.StatusId = s.Id
	LEFT JOIN Categories as c ON r.CategoryId = c.Id
	LEFT JOIN Departments as d ON d.Id = e.DepartmentId
	ORDER BY e.FirstName DESC, e.LastName DESC, d.Name, c.Name, r.Description, r.OpenDate, s.Label, u.Name

SELECT 
	IIF(e.FirstName IS NULL OR e.LastName IS NULL, 'None', CONCAT(e.FirstName, ' ', e.LastName)) AS Employee,
	ISNULL(d.Name, 'None') AS Department,
	ISNULL(c.Name, 'None') AS Category,
	r.Description,
	FORMAT(r.OpenDate, 'dd.MM.yyyy') AS OpenDate,
	s.Label AS Status,
	u.Name AS [User]
	FROM Reports as r
	LEFT JOIN Employees as e ON e.Id = r.EmployeeId
	LEFT JOIN Users AS u ON u.Id = r.UserId
	LEFT JOIN Status AS s ON r.StatusId = s.Id
	LEFT JOIN Categories as c ON r.CategoryId = c.Id
	LEFT JOIN Departments as d ON d.Id = e.DepartmentId
	ORDER BY e.FirstName DESC, e.LastName DESC, d.Name, c.Name, r.Description, r.OpenDate, s.Label, u.Name

--- 11.Hours to Complete ---
GO
CREATE FUNCTION udf_HoursToComplete(@StartDate DATETIME, @EndDate DATETIME)
RETURNS INT
AS
BEGIN
DECLARE @HoursToComplete INT
	IF @StartDate IS NULL
		RETURN 0;
	ELSE IF @EndDate IS NULL
		RETURN 0;
	ELSE 
		SET @HoursToComplete = DATEDIFF(hour, @StartDate, @EndDate);

RETURN @HoursToComplete
END
GO

SELECT dbo.udf_HoursToComplete(OpenDate, CloseDate) AS TotalHours
   FROM Reports


--- 12.Assign Employee ---
GO
CREATE PROCEDURE usp_AssignEmployeeToReport(@EmployeeId INT, @ReportId INT)
AS 
	DECLARE @EmployeeDepartmentId INT;
	SET @EmployeeDepartmentId =(
		SELECT
			DepartmentId
			FROM Employees
			WHERE Id = @EmployeeId)
	DECLARE @ReportsCategoryId INT;
	SET @ReportsCategoryId =(
		SELECT	
			DepartmentId
			FROM Categories as C
			JOIN Reports as r ON c.Id = r.CategoryId
			WHERE r.Id = @ReportId)

	IF (@EmployeeDepartmentId = @ReportsCategoryId)
		UPDATE
			Reports
			SET EmployeeId = @EmployeeId
			WHERE Id = @ReportId;
	ELSE
		THROW 50001, 'Employee doesn''t belong to the appropriate department', 1

