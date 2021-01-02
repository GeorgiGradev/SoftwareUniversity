USE SoftUni
SELECT * FROM Employees

--- 13.Departments Total Salaries ---
SELECT
	e.DepartmentID,
	SUM(e.Salary) AS TotalSalary
	FROM Employees as e
	GROUP BY e.DepartmentID
	ORDER BY DepartmentID ASC


--- 14.Employees Minimum Salaries ---
SELECT 
	e.DepartmentID,
	MIN(e.Salary) AS MinimumSalary 
	FROM Employees AS e
	WHERE e.DepartmentID IN (2,5,7) AND e.HireDate > '01.01.2000'
	GROUP BY e.DepartmentID


--- 15.Employees Average Salaries ---
SELECT * 
INTO EmployeesWithSalaryMoreThan30000
FROM Employees
WHERE Salary > 30000

DELETE FROM EmployeesWithSalaryMoreThan30000
WHERE ManagerID = 42

UPDATE EmployeesWithSalaryMoreThan30000
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID,
       AVG(Salary) AS AverageSalary
FROM EmployeesWithSalaryMoreThan30000
GROUP BY DepartmentID


--- 16. Employees Maximum Salaries