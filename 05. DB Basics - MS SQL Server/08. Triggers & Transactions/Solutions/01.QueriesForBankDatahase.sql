USE Bank


--- 01.Create Table Logs ---
CREATE TABLE Logs
(
	LogId INT PRIMARY KEY IDENTITY NOT NULL,
	AccountId INT FOREIGN KEY REFERENCES Accounts(Id),
	OldSum Money,
	NewSum Money
)

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


