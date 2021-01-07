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


--- 11.Future Value Function ---
GO
CREATE OR ALTER FUNCTION ufn_CalculateFutureValue 
	(@InitialSum DECIMAL(18,4),
	@YearlyInterestRate FLOAT, 
	@NumberOfYears INT)
RETURNS DECIMAL(18,4)
BEGIN
	DECLARE @Output DECIMAL(18,4);
	SET @Output = 
	@InitialSum 
	* 
	(POWER(1 + (@YearlyInterestRate), @NumberOfYears))
RETURN @Output 
END
GO

SELECT dbo.ufn_CalculateFutureValue (1000, 0.1, 5)