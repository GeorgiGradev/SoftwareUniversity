 USE Bank


--- 01.Create Table Logs ---
--CREATE TABLE Logs
--(
--	LogId INT PRIMARY KEY IDENTITY NOT NULL,
--	AccountId INT FOREIGN KEY REFERENCES Accounts(Id),
--	OldSum Money,
--	NewSum Money
--)

GO
CREATE OR ALTER TRIGGER tr_AccountChange 
ON Accounts FOR UPDATE
AS
BEGIN
	INSERT INTO Logs (AccountId, OldSum, NewSum)
	SELECT  i.AccountHolderId, d.Balance, i.Balance
		FROM inserted as i
		JOIN deleted AS d ON i.Id = d.Id
END
GO
 

--- 2.Create Table Emails ---
--CREATE TABLE NotificationEmail
--(
--	Id INT PRIMARY KEY IDENTITY,
--	Recipient INT FOREIGN KEY REFERENCES Accounts(Id),
--	[Subject] NVARCHAR(50),
--	Body NVARCHAR(MAX)
--)

GO
CREATE OR ALTER TRIGGER tr_SendEmailOnUpdate
ON Logs FOR INSERT
AS
BEGIN
	INSERT INTO NotificationEmail (Recipient, [Subject], Body)
	SELECT 
	i.AccountId, 
		CONCAT(
			'Balance change for account: ',
			i.AccountId),
		CONCAT(
			'On ',
			FORMAT(GETDATE(),
			'MMM dd yyyy HH:mmtt'),
			' your balance was changed from ',
			i.OldSum, ' to ',
			i.NewSum,
			'.')
	FROM inserted AS i
END
GO

--UPDATE Accounts
--SET Balance += 100
--WHERE Id = 1;

--SELECT * FROM Logs
--SELECT * FROM NotificationEmail



--- 3.Deposit Money ---