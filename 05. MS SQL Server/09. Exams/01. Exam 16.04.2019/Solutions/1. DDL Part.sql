CREATE DATABASE Airport
GO
USE Airport

CREATE TABLE Planes
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30) NOT NULL,
	Seats INT NOT NULL,
	[Range] INT NOT NULL
)

CREATE TABLE Flights
(
	Id INT PRIMARY KEY IDENTITY,
	DepartureTime DATETIME2,
	ArrivalTime DATETIME2,
	Origin VARCHAR(50) NOT NULL,
	Destination VARCHAR(50) NOT NULL,
	PlaneId INT FOREIGN KEY REFERENCES Planes(Id) NOT NULL 
)

CREATE TABLE Passengers
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(30) NOT NULL,
	LastName VARCHAR(30) NOT NULL,
	Age INT NOT NULL,
	[Address] VARCHAR(30) NOT NULL,
	PassportId CHAR(11) NOT NULL
	--CHECK (LEN (PassportId) = 11) ??
)

CREATE TABLE LuggageTypes 
(
	Id INT PRIMARY KEY IDENTITY,
	[Type] VARCHAR(30) NOT NULL
)

CREATE TABLE Luggages
(
	Id INT PRIMARY KEY IDENTITY,
	LuggageTypeId INT NOT NULL FOREIGN KEY REFERENCES LuggageTypes(Id),
	PassengerId INT NOT NULL FOREIGN KEY REFERENCES Passengers(Id) 
)

CREATE TABLE Tickets
(
	Id INT PRIMARY KEY IDENTITY,
	PassengerId INT NOT NULL FOREIGN KEY REFERENCES Passengers(Id),
	FlightId INT NOT NULL FOREIGN KEY REFERENCES Flights(Id),
	LuggageId INT NOT NULL FOREIGN KEY REFERENCES Luggages(Id),
	Price DECIMAL(15,2) NOT NULL
)