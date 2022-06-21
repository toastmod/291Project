SELECT
    CONCAT(Branch_ID, ' - ', City) as 'Branch'
FROM
    Branches
SELECT
    *
FROM
    Customers
SELECT
    c.customer_ID,
    CONCAT(first_name, ' ', last_name) as "Name",
    mt.rank as "Membership",
    c.phone_number,
    c.driver_license_no,
    c.gender,
    c.address_1,
    c.city,
    c.postal_code,
    c.province
FROM
    Customers c,
    MembershipType mt
WHERE
    c.membership_type = mt.Membership_ID -- if filter set, add a "AND FIELD = FILTER"
SELECT
    DISTINCT c.Car_ID,
    c.Car_Type,
    b.City,
    b.Province,
    FORMAT(ct.daily_rate, 'C') as "Day Rate",
    FORMAT(ct.weekly_rate, 'C') as "Weekly Rate",
    FORMAT(ct.monthly_rate, 'C') as "Monthly Rate"
FROM
    Cars c,
    CarTypes ct,
    Branches b,
    CarStatus cs
WHERE
    c.Car_Type = ct.CarType
    AND b.Branch_ID = c.Branch_ID
    AND c.CarStatusID = 1
    AND b.province LIKE '%Alberta%'
    AND c.CarType LIKE '%SEDAN%'
SELECT
    DISTINCT city
FROM
    Branches
SELECT
    *
FROM
    Reservations R
WHERE
    DATEFROMPARTS(2000, 4, 19) > DATEFROMPARTS(
        CAST(R.From_Year as int),
        CAST(R.From_Month as int),
        CAST(R.From_Day as int)
    )
SELECT
    *
FROM
    Reservations R
SELECT
    *
FROM
    (
        SELECT
            (
                DATEFROMPARTS((R.From_Year), (R.From_Month), (R.From_Day))
            ) AS DATES
        FROM
            Reservations R
    ) AS R1
WHERE
    DATES > DATEFROMPARTS(2000, 4, 19)
SELECT
    *
FROM
    carstatus




SELECT
    c.Car_ID,
    c.Car_Type,
    c.Branch_ID,
    b.City,
    cs.Status
FROM
    Cars c,
    CarStatus cs,
    Branches b,
    CarTypes ct
WHERE
    b.Branch_ID = c.Branch_ID
    AND c.CarStatusID = cs.CarStatusID
    AND ct.CarType = c.car_type


SELECT Cars.Car_ID, Cars.Car_Type, Cars.Branch_ID, Branches.City, Branches.Province, CarStatus.Status, ct.daily_rate, ct.weekly_rate, ct.monthly_rate FROM Cars, CarStatus, Branches, CarTypes ct WHERE Branches.Branch_ID = Cars.Branch_ID AND Cars.CarStatusID = CarStatus.CarStatusID AND Cars.Car_Type = ct.CarType


