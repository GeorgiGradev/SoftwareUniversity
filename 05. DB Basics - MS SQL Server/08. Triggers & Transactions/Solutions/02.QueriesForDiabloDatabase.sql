USE Diablo


--- 6.Trigger ---
GO

--create trigger
CREATE OR ALTER TRIGGER trg_UsersShouldByItemsOnTheirLeverOrLower
ON UserGameItems INSTEAD OF INSERT
AS
BEGIN
	DECLARE @UserGameId INT = (SELECT TOP(1) i.UserGameId FROM inserted AS i)
	DECLARE @ItemId INT = (SELECT TOP(1) i.ItemId FROM inserted AS i)

	DECLARE @UserLevel INT = (SELECT ug.[Level] 
		                      FROM UsersGames AS ug
							  JOIN Games AS g ON ug.GameId = g.Id
							  WHERE ug.Id = @UserGameId
							  )
	DECLARE @ItemLevel INT = (SELECT MinLevel FROM Items WHERE Id = @ItemId )

	IF @UserLevel >= @ItemLevel
		BEGIN
		INSERT INTO UserGameItems(ItemId, UserGameId)
			VALUES (@ItemId, @UserGameId)
		END
END

--give cash to users
UPDATE UsersGames
SET Cash += 50000
FROM UsersGames AS ug
JOIN Games AS g ON ug.GameId = g.Id
JOIN Users AS u ON ug.UserId = u.Id
WHERE u.Username IN ('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos')
	AND g.[Name] = 'Bali'

--buy items for users 
DECLARE @FirstGroupCurrItemNum INT = 251
DECLARE @FirstGroupLastItemNum INT = 299

DECLARE @SecondGroupCurrItemNum INT = 501
DECLARE @SecondGroupLastItemNum INT = 539

WHILE 1 = 1
BEGIN
	IF @FirstGroupCurrItemNum <= @FirstGroupLastItemNum
		BEGIN
		BEGIN TRAN
			INSERT INTO UserGameItems(ItemId, UserGameId)
				SELECT @FirstGroupCurrItemNum,
					   ug.Id
				FROM UsersGames AS ug
				JOIN Games AS g ON ug.GameId = g.Id
				JOIN Users AS u ON ug.UserId = u.Id
				WHERE u.Username IN ('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos')
				AND g.[Name] = 'Bali'

			UPDATE UsersGames
				SET Cash -= (SELECT Price FROM Items WHERE id = @FirstGroupCurrItemNum)
				FROM UsersGames AS ug
				JOIN Games AS g ON ug.GameId = g.Id
				JOIN Users AS u ON ug.UserId = u.Id
				WHERE u.Username IN ('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos')
					AND g.[Name] = 'Bali'
        COMMIT
		END

	IF @SecondGroupCurrItemNum <= @SecondGroupCurrItemNum
		BEGIN
		BEGIN TRAN
			INSERT INTO UserGameItems(ItemId, UserGameId)
				SELECT @SecondGroupCurrItemNum,
					   ug.Id
				FROM UsersGames AS ug
				JOIN Games AS g ON ug.GameId = g.Id
				JOIN Users AS u ON ug.Id = u.Id
				WHERE u.Username IN ('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos')
				AND g.[Name] = 'Bali'

			UPDATE UsersGames
				SET Cash -= (SELECT Price FROM Items WHERE id = @SecondGroupCurrItemNum)
				FROM UsersGames AS ug
				JOIN Games AS g ON ug.GameId = g.Id
				JOIN Users AS u ON ug.Id = u.Id
				WHERE u.Username IN ('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos')
					AND g.[Name] = 'Bali'
		COMMIT
		END

		IF @FirstGroupCurrItemNum >= @FirstGroupLastItemNum
		AND @SecondGroupCurrItemNum >= @SecondGroupLastItemNum
		BEGIN
			BREAK;
		END

		SET @FirstGroupCurrItemNum += 1
		SET @SecondGroupCurrItemNum += 1
END

--Display results


