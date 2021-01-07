USE Bank


--- 9.Find Full Name ---
GO
CREATE OR ALTER PROC usp_GetHoldersFullName 
AS
BEGIN
	SELECT 
		CONCAT([FirstName],' ', [LastName]) AS [Full Name]
		FROM AccountHolders
END
--EXEC dbo.usp_GetHoldersFullName


--- 10.People with Balance Higher Than ---
GO
CREATE OR ALTER PROC usp_GetHoldersWithBalanceHigherThan (@MinBalance DECIMAL (18,4))
AS
BEGIN
	SELECT
		ah.FirstName AS [First Name],
		ah.LastName AS [Last Name]
		FROM AccountHolders AS ah
		JOIN Accounts as a  ON ah.Id = a.AccountHolderId
		GROUP BY ah.FirstName, ah.LastName
		HAVING SUM(a.Balance) > @MinBalance
		ORDER BY ah.FirstName, ah.LastName
END
--EXEC dbo.usp_GetHoldersWithBalanceHigherThan 20000