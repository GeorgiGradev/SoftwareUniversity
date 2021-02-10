---01.Number of Users for Email Provider---
SELECT a.[Email Provider], COUNT(a.[Email Provider])
FROM (SELECT RIGHT(u.Email, LEN(u.Email) - CHARINDEX('@', u.Email)) AS 'Email Provider'
FROM Users AS u) AS a
GROUP BY a.[Email Provider] ORDER BY COUNT(a.[Email Provider]) DESC, a.[Email Provider]


---02.All Users in Games---
SELECT DISTINCT g.Name AS 'Game', gt.Name AS 'Game Type', u.Username, ug.Level, ug.Cash, ch.Name AS 'Character'
FROM Games AS g, UsersGames AS ug, UserGameItems AS ugi, Users AS u,
GameTypes AS gt, Characters AS ch
WHERE u.Id = ug.UserId AND ug.GameId = ugi.UserGameId
AND ug.GameId = g.Id AND g.GameTypeId = gt.Id
AND ug.CharacterId = ch.Id
ORDER BY ug.Level DESC, u.Username, g.Name


---03.Users in Games with Their Items---
SELECT u.Username, g.Name AS Game, COUNT(ugi.ItemId) AS 'Items Count', SUM(i.Price) AS 'Items Price'
FROM Users AS u
JOIN UsersGames AS ug ON u.Id = ug.UserId
JOIN Games AS g ON g.Id = ug.GameId
JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
JOIN Items AS i ON ugi.ItemId = i.Id
GROUP BY u.Username, g.Name 
HAVING COUNT(ugi.ItemId) >= 10
ORDER BY COUNT(ugi.ItemId) DESC, SUM(i.Price) DESC, u.Username


---04.User in Games with Their Statistics---
SELECT u.Username AS Username,
		g.[Name] AS Game,
		MAX(ch.[Name]) AS Character,
		SUM(sta.Strength) + MAX(gtst.Strength) + MAX(chst.Strength) AS Strength,
		SUM(sta.Defence) + MAX(gtst.Defence) + MAX(chst.Defence) AS Defence,
		SUM(sta.Speed) + MAX(gtst.Speed) + MAX(chst.Speed) AS Speed,
		SUM(sta.Mind) + MAX(gtst.Mind) + MAX(chst.Mind) AS Mind,
		SUM(sta.Luck) + MAX(gtst.Luck) + MAX(chst.Luck) AS Luck
	FROM Users AS u
	JOIN UsersGames AS ug ON u.Id = ug.UserId
	JOIN Games AS g ON ug.GameId = g.Id
	JOIN Characters AS ch ON ug.CharacterId = ch.Id
	JOIN UserGameItems AS ugi ON ug.Id = ugi.UserGameId
    JOIN Items AS i ON ugi.ItemId = i.Id
    JOIN [Statistics] AS sta ON i.StatisticId = sta.Id
    JOIN GameTypes AS gt ON g.GameTypeId = gt.Id
    JOIN [Statistics] AS chst ON ch.StatisticId = chst.Id
    JOIN [Statistics] AS gtst ON gt.BonusStatsId = gtst.Id
		GROUP BY u.Username, g.Name
		ORDER BY Strength DESC, Defence DESC, Speed DESC, Mind DESC, Luck DESC


---05.All Items with Greater than Average Statistics---
SELECT i.Name, i.Price, i.MinLevel, stat.Strength, stat.Defence, stat.Speed, stat.Luck, stat.Mind
FROM Items AS i, [Statistics] AS stat, 
(SELECT AVG(stat.Mind) AS AVGMind, AVG(stat.Luck) AS AVGLuck, AVG(stat.Speed) AS AVGSpeed
FROM [Statistics] AS stat) AS a
WHERE stat.Mind > a.AVGMind AND stat.Luck > a.AVGLuck
AND stat.Speed > a.AVGSpeed AND i.StatisticId = stat.Id


---06.Display All Items about Forbidden Game Type---
SELECT i.Name AS Item, i.Price, i.MinLevel, gt.Name AS 'Forbidden Game Type'
FROM Items AS i
LEFT OUTER JOIN GameTypeForbiddenItems AS gtfi ON i.Id = gtfi.ItemId
LEFT OUTER JOIN GameTypes AS gt ON gt.Id = gtfi.GameTypeId
ORDER BY gt.Name DESC, i.Name


---07.Buy Items for User in Game---
DECLARE @AlexUserGameId  INT = (SELECT Id 
									FROM UsersGames
										WHERE GameId = (SELECT Id FROM Games WHERE [Name] = 'Edinburgh') AND
											  UserId = (SELECT Id FROM Users WHERE Username = 'Alex'))

DECLARE @AlexItemsPrice MONEY = (SELECT SUM(Price) 
									FROM Items
										WHERE [Name] IN ('Blackguard', 
														 'Bottomless Potion of Amplification', 
														 'Eye of Etlich (Diablo III)', 
														 'Gem of Efficacious Toxin', 
													     'Golden Gorget of Leoric', 
														 'Hellfire Amulet'))

DECLARE @GameID INT = (Select GameId 
						FROM UsersGames 
						  WHERE Id = @AlexUserGameId)

INSERT UserGameItems
	SELECT Id, @AlexUserGameId
		FROM Items
			WHERE [Name] IN ('Blackguard', 
							 'Bottomless Potion of Amplification', 
							 'Eye of Etlich (Diablo III)', 
						     'Gem of Efficacious Toxin', 
							 'Golden Gorget of Leoric', 
							 'Hellfire Amulet')

UPDATE UsersGames
	SET Cash = Cash - @AlexItemsPrice
		WHERE Id = @AlexUserGameId

SELECT u.Username, 
	   g.Name, 
	   ug.Cash, 
	   i.Name AS [Item Name]
	FROM Users AS u
	JOIN UsersGames AS ug ON ug.UserId = u.Id
	JOIN Games AS g ON g.Id = ug.GameId
    JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
    JOIN Items AS i ON i.Id = ugi.ItemId
		WHERE ug.GameId = @GameID
			ORDER BY [Item Name]


---08.Peaks and Mountains---
SELECT p.PeakName, m.MountainRange AS [Mountain], p.Elevation
FROM Peaks AS p
JOIN Mountains AS m
	ON p.MountainId = m.Id
ORDER BY p.Elevation DESC, p.PeakName