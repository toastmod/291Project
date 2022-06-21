
SELECT TOP 1 E.Emp_ID, C.Branch_ID FROM Employees E, Cars C WHERE C.Car_ID = 2 AND C.Branch_ID = E.Branch_ID
ORDER BY NEWID()