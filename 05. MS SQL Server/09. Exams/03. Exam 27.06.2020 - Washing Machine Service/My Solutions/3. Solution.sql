USE WMS

---02.Insert ---
INSERT INTO Clients(FirstName, LastName, Phone)
	VALUES
	('Teri'  , 'Ennaco', '570-889-5187'),
	('Merlyn', 'Lawler', '201-588-7810'),
    ('Georgene', 'Montezuma','925-615-5185'),
	('Jettie', 'Mconnell','908-802-3564'),
	('Lemuel', 'Latzke','631-748-6479'),
	('Melodie', 'Knipp','805-690-1682'),
	('Candida', 'Corbley','908-275-8357')

INSERT INTO Parts(SerialNumber, [Description], Price, VendorId)
	VALUES
	('WP8182119', 'Door Boot Seal', 117.86,	2),
	('W10780048', 'Suspension Rod', 42.81,	1),
	('W10841140', 'Silicone Adhesive',	6.77, 4),
	('WPY055980', 'High Temperature Adhesive',13.94, 3)


---03.Update---
UPDATE
	Jobs
	SET MechanicId = 3,
	[Status] = 'In Progress'
	WHERE Status = 'Pending'


---04.Delete---
DELETE 
	FROM OrderParts
	WHERE OrderId = 19

DELETE
	FROM Orders
	WHERE OrderId = 19


---05.Mechanic Assignments---
SELECT 
	CONCAT(m.FirstName, ' ', m.LastName) as Mechanic,
	j.Status,
	j.IssueDate
	FROM Mechanics as m
	JOIN Jobs as j ON m.MechanicId = j.MechanicId
	ORDER BY m.MechanicId, IssueDate, JobId


---06.Current Clients---
SELECT 
	CONCAT(c.FirstName, ' ', c.LastName) as Client,
	DATEDIFF(DAY, j.IssueDate,'2017-04-24') as [Days going],
	j.Status
	FROM Clients as c
	JOIN Jobs  as j ON c.ClientId = j.ClientId
	WHERE j.Status <> 'Finished'
	ORDER BY [Days going] DESC, c.ClientId


---7.Mechanic Performance---
SELECT
	Mechanic,
	[Average Days]
	FROM (SELECT 
		CONCAT(m.FirstName, ' ', m.LastName) as Mechanic,
		m.MechanicId,
		AVG(DATEDIFF(DAY, IssueDate, FinishDate)) as [Average Days]
		FROM Mechanics as m
		JOIN Jobs as j ON m.MechanicId = j.MechanicId
		WHERE j.Status = 'Finished'
		GROUP BY CONCAT(m.FirstName, ' ', m.LastName), m.MechanicId
		) as temp
	ORDER BY MechanicId


---08.Available Mechanics---
SELECT
	Available
	FROM (SELECT 
		CONCAT(m.FirstName, ' ', m.LastName) as Available,
		m.MechanicId
		FROM Mechanics as m
		LEFT JOIN Jobs as j ON m.MechanicId = j.MechanicId
		WHERE j.Status  = 'Finished' OR j.Status IS NULL
		GROUP BY CONCAT(m.FirstName, ' ', m.LastName), m.MechanicId) as temp
	ORDER BY MechanicId


---09.Past Expenses---
SELECT	
	j.JobId,
	ISNULL(SUM(p.Price * op.Quantity), 0) as Total
	FROM Jobs as j
	LEFT JOIN Orders as o ON j.JobId = o.JobId
	LEFT JOIN OrderParts as op ON o.OrderId = op.OrderId
	LEFT JOIN Parts as p ON op.PartId = p.PartId
	WHERE j.Status LIKE 'Finished'
	GROUP BY j.JobId
	ORDER BY Total DESC, j.JobId


---10.Missing Parts---
SELECT 
	p.PartId,
	p.Description,
	ISNULL(pn.Quantity, 0) AS Required,
	ISNULL(p.StockQty, 0) AS [In Stock],
	ISNULL(CASE
           WHEN o.Delivered = 0
           THEN op.Quantity
           ELSE 0
           END, 0) AS Ordered
	FROM Parts AS p
    LEFT JOIN PartsNeeded AS pn ON pn.PartId = p.PartId
    LEFT JOIN OrderParts AS op ON op.PartId = p.PartId
    LEFT JOIN Jobs AS j ON j.JobId = pn.JobId
    LEFT JOIN Orders AS o ON o.JobId = j.JobId
	WHERE pn.Quantity > ISNULL(
								(p.StockQty + CASE
                                            WHEN o.Delivered = 0
                                            THEN op.Quantity
                                            ELSE 0
											END)
								, 0)
    AND j.Status != 'Finished'
	ORDER BY p.PartId




---11.Place Order--- 
GO
CREATE OR ALTER PROC usp_PlaceOrder(@JobsId INT, @PartSerial VARCHAR(50), @Quantity INT)
AS
BEGIN
	IF @Quantity<=0
		THROW 50012, 'Part quantity must be more than zero!', 1
	ELSE IF NOT EXISTS(SELECT * FROM Jobs AS j WHERE j.JobId = @JobsId)
		THROW 50013, 'Job not found!', 1
	ELSE IF EXISTS(SELECT * FROM Jobs AS j WHERE j.JobId = @JobsId AND j.Status = 'Finished')
		THROW 50011, 'This job is not active!', 1
	ELSE IF NOT EXISTS(SELECT * FROM Parts AS p WHERE p.SerialNumber = @PartSerial)
		THROW 50014, 'Part not found!', 1

	DECLARE @PartId INT
					SELECT
						@PartId = p.PartId 
						FROM Parts AS p
						WHERE p.SerialNumber= @PartSerial

	DECLARE @ExistingOrderId INT
					SELECT 
						@ExistingOrderId = o.OrderId 
						FROM Orders AS o
						JOIN Jobs AS j ON j.JobId = o.JobId
						JOIN OrderParts AS op ON op.OrderId = o.OrderId
						WHERE o.IssueDate IS NULL AND j.JobId = @JobsId AND op.PartId = @PartId

	IF (@ExistingOrderId IS NULL)
				BEGIN
					INSERT INTO Orders(JobId, IssueDate)
						VALUES
							(
							@JobsId, 
							NULL
							)

					SELECT 
						@ExistingOrderId = o.OrderId 
						FROM Orders AS o 
						JOIN Jobs AS j ON j.JobId = o.JobId
						WHERE o.IssueDate IS NULL AND j.JobId = @JobsId

					INSERT INTO OrderParts(OrderId,PartId,Quantity)
						VALUES
						(
						@ExistingOrderId, 
						@PartId,
						@Quantity
						)
				END
	ELSE
			BEGIN
				UPDATE OrderParts
					SET Quantity+=@Quantity
					WHERE OrderId=@ExistingOrderId
			END
END



---12.Cost Of Order---
GO
CREATE FUNCTION udf_GetCost(@JobsId INT)
RETURNS DECIMAL(18,2)
AS
BEGIN
	DECLARE @TotalCost DECIMAL(18,2);

	SET @TotalCost = ISNULL((SELECT 
		SUM(p.Price) as Result
		FROM Orders as o
		JOIN OrderParts as op ON o.OrderId = op.OrderId
		JOIN Parts as p ON op.PartId = p.PartId
		WHERE o.JobId = @JobsId),0)
			
RETURN @TotalCost
END
GO

SELECT dbo.udf_GetCost(1)

