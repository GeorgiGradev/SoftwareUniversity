USE Gringotts

--- 1.Records’ Count ---
SELECT
	COUNT(*)
	FROM Gringotts.dbo.WizzardDeposits

--- 2. Longest Magic Wand ---
SELECT 
	MAX(WizzardDeposits.MagicWandSize) AS LongestMagicWand
	FROM WizzardDeposits

--SELECT TOP (1)
--	WizzardDeposits.MagicWandSize AS LongestMagicWand
--	FROM WizzardDeposits
--	ORDER BY MagicWandSize DESC

--SELECT
--	qwerty.test
--	FROM (SELECT
--		WizzardDeposits.MagicWandSize AS test,
--		ROW_NUMBER () OVER (ORDER BY MagicWandSize DESC) AS [Rank]
--		FROM WizzardDeposits) AS qwerty
--	WHERE [Rank] = 1
	

--- 3.Longest Magic Wand Per Deposit Groups ---
SELECT
	WizzardDeposits.DepositGroup,
	MAX(WizzardDeposits.MagicWandSize) as LongestMagicWand
	FROM WizzardDeposits
	GROUP BY WizzardDeposits.DepositGroup


--- 4. Smallest Deposit Group Per Magic Wand Size ---
SELECT TOP(2)
	DepositGroup
	FROM (SELECT 
		DepositGroup,
		AVG(MagicWandSize) AS AverageSize
		FROM WizzardDeposits
		GROUP BY DepositGroup) AS AverageQuery
   ORDER BY AverageSize

--SELECT TOP(2) 
--	DepositGroup 
--	FROM WizzardDeposits
--	GROUP BY DepositGroup
--	ORDER BY AVG(MagicWandSize) ASC


--- 5.Deposits Sum ---
SELECT
	DepositGroup,
	SUM(DepositAmount) AS TotalSum
	FROM WizzardDeposits
	GROUP BY DepositGroup


--- 6.Deposits Sum for Ollivander Family ---
