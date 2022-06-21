SELECT CONCAT(Branch_ID, ' - ', City) as 'Branch' FROM Branches

SELECT * FROM Customers

SELECT c.customer_ID, CONCAT(first_name, ' ', last_name) as "Name", mt.rank as "Membership", c.phone_number, c.driver_license_no, c.gender, c.address_1, c.city, c.postal_code, c.province  FROM Customers c, MembershipType mt
WHERE c.membership_type = mt.Membership_ID

-- if filter set, add a "AND FIELD = FILTER"

SELECT * FROM MembershipType

SELECT membership_type FROM Customers WHERE customer_ID = 7;

SELECT * FROM Customers
SELECT * FROM Employees

SELECT MAX(Res_ID) FROM Reservations

SELECT * FROM CarStatus
SELECT * FROM Cars
SELECT * FROM CarTypes
SELECT c.Car_Type, b.City, b.Province, FORMAT(ct.daily_rate, 'C') as "Day Rate", FORMAT(ct.weekly_rate, 'C') as "Weekly Rate", FORMAT(ct.monthly_rate, 'C') as "Monthly Rate" FROM Cars c, CarTypes ct, Branches b
WHERE c.Car_Type = ct.CarType
AND b.Branch_ID = c.Branch_ID
AND c.Status = 2