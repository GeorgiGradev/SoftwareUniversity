USE Geography

--- 12.Highest Peaks in Bulgaria ---
SELECT 
	mc.[CountryCode],
	m.[MountainRange],
	p.[PeakName],
	p.[Elevation]
	FROM Mountains as m
	JOIN MountainsCountries as mc ON m.Id = mc.MountainId AND mc.[CountryCode] = 'BG'
	JOIN Peaks as p ON mc.MountainId = p.MountainId AND p.[Elevation] > 2835
	ORDER BY p.[Elevation] DESC

--SELECT c.CountryCode,
--	   m.MountainRange,
--	   p.PeakName,
--	   p.Elevation
--FROM Countries AS c
--INNER JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
--INNER JOIN Mountains AS m ON mc.MountainId = m.Id
--INNER JOIN Peaks AS p ON m.Id = p.MountainId
--WHERE c.CountryName = 'Bulgaria' AND p.Elevation > 2835
--ORDER BY p.Elevation DESC


--- 13.Count Mountain Ranges ---
SELECT 
	[CountryCode], 
	COUNT(MountainId) AS [MouintainRanges]
	FROM MountainsCountries
	WHERE CountryCode IN ('BG','RU','US')
	GROUP BY CountryCode


--- 14.Countries with Rivers ---
SELECT TOP(5)
	c.CountryName,
	r.RiverName
	FROM Rivers as r
	JOIN CountriesRivers as cr ON r.Id = cr.RiverId
	RIGHT JOIN Countries as c ON cr.CountryCode = c.CountryCode
	WHERE c.ContinentCode = 'AF'
	ORDER BY c.CountryName

--SELECT TOP(5) 
-- 	c.CountryName,
--	r.RiverName
--	FROM Countries AS c
--	LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
--	LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
--	WHERE c.ContinentCode = 'AF'
--	ORDER BY c.CountryName


--- 15.*Continents and Currencies ---
SELECT 
	ContinentCode, --a
	CurrencyCode, -- b
	CurrencyCount AS CurrencyUsage -- c
	FROM (SELECT
		ContinentCode, -- a
		CurrencyCode,  -- b
		CurrencyCount, -- c
		DENSE_RANK() OVER (PARTITION BY ContinentCode ORDER BY CurrencyCount DESC) AS CurrencyRank -- d
		FROM (SELECT
			ContinentCode, -- a
			CurrencyCode,  -- b
			COUNT(CurrencyCode) AS CurrencyCount -- c 
			FROM Countries 
			GROUP BY ContinentCode, CurrencyCode) AS CurrencyCountQuery 
		WHERE CurrencyCount > 1) AS CurrencyRankingQuery
	WHERE CurrencyRank = 1 -- d
	ORDER BY ContinentCode -- a

--- 16.Countries without Any Mountains ---

SELECT
	COUNT(qwerty.CountryCode) AS [Count]
	FROM (SELECT 
	Countries.CountryCode,
	Mountains.Id
	FROM Countries 
	LEFT JOIN MountainsCountries ON Countries.CountryCode = MountainsCountries.CountryCode
	LEFT JOIN Mountains ON MountainsCountries.MountainId = Mountains.Id
	WHERE Mountains.Id IS NULL) as qwerty


