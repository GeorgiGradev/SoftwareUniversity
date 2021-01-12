USE Airport

--- 2.Insert ---
INSERT INTO Planes(Name, Seats, Range)
	VALUES 
	('Airbus 336', 112, 5132),
	('Airbus 330', 432, 5325),
	('Boeing 369', 231, 2355),
	('Stelt 297', 254, 2143),
	('Boeing 338', 165, 5111),
	('Airbus 558', 387, 1342),
	('Boeing 128', 345, 5541)

INSERT INTO LuggageTypes(Type)
	VALUES
	('Crossbody Bag'),
	('School Backpack'),
	('Shoulder Bag')


--- 3.Update ---
--> A - Subquery
UPDATE Tickets
SET Price += Price * 1.3
WHERE FlightId IN (SELECT	
						Id 
						FROM Flights
						WHERE Flights.Destination = 'Carlsbad')
--> B - Join
UPDATE Tickets
SET Price *= 1.13 
FROM Tickets AS t
JOIN Flights AS f ON t.FlightId = f.Id
WHERE f.Destination = 'Carlsbad'

	 
--- 4.Delete ---
DELETE  --> Трием таблица, от която зависим
	FROM Tickets
	WHERE FlightId IN (
		SELECT
		Id
		FROM Flights
		WHERE Destination = 'Ayn Halagim')

DELETE --> Трием зависимата таблица 
	FROM Flights 
	WHERE Destination = 'Ayn Halagim'


---  5.The "Tr" Planes ---
SELECT
	*
	FROM Planes
	WHERE [Name] LIKE '%tr%'
	ORDER BY Id, Name, Seats, Range


--- 6.Flight Profits ---  
SELECT
	FlightId,
	SUM(Price) as Price
	FROM Tickets
	GROUP BY FlightId
	ORDER BY Price DESC, FlightId


 --- 7.Passenger Trips ---
 SELECT
	CONCAT(p.FirstName, ' ',p.LastName) AS [Full Name],
	f.Origin,
	f.Destination
	FROM Passengers as p
	JOIN Tickets as t ON p.Id = t.PassengerId
	JOIN Flights as f ON t.FlightId = f.Id
	ORDER BY [Full Name], Origin, Destination


--- 8.Non Adventures People ---
SELECT 
	p.FirstName as [First Name],
	p.LastName as [Last Name],
	p.Age
	FROM Passengers AS p
	LEFT JOIN Tickets as t ON p.Id = t.PassengerId
	WHERE t.Id IS NULL
	ORDER BY p.Age DESC, p.FirstName, p.LastName


--- 9.Full Info ---
SELECT 
	CONCAT(p.FirstName, ' ', p.LastName) AS [Full Name],
	pl.Name AS [Plane Name],
	CONCAT(f.Origin, ' - ', f.Destination) AS Trip,
	lt.Type AS [Luggage Type]
	FROM Passengers AS p
	JOIN Tickets AS t ON p.Id = t.PassengerId
	JOIN Flights AS f ON t.FlightId = f.Id
	JOIN Planes as pl ON f.PlaneId = pl.Id
	JOIN Luggages as l ON t.LuggageId = l.Id
	JOIN LuggageTypes as lt ON l.LuggageTypeId = lt.Id
	ORDER BY [Full Name], [Plane Name], f.Origin, f.Destination, [Luggage Type]


--- 10.PSP --- 
SELECT 
	p.[Name], 
	p.Seats,
	COUNT(t.PassengerId) AS [Passenger Count]
	FROM Planes AS p
	LEFT JOIN Flights AS f ON p.Id = f.PlaneId
	LEFT JOIN Tickets AS t ON f.Id = t.FlightId
	GROUP BY p.[Name], p.Seats
	ORDER BY [Passenger Count] DESC, p.[Name], p.Seats 
