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



```SQL
CREATE TABLE IF NOT EXISTS Customers (
	customer_ID INT NOT NULL PRIMARY KEY,
	first_name VARCHAR(255) NOT NULL,
	last_name VARCHAR(255) NOT NULL,
	email VARCHAR(255) NOT NULL,
	dob DATE NOT NULL,
	membership_type int FOREIGN KEY REFERENCES MembershipType(Membership_ID)
	gender VARCHAR(255),
	driver_license_no VARCHAR(255),
	phone_number VARCHAR(15) NOT NULL,
	address_1 VARCHAR(255) NOT NULL,
	address_2 VARCHAR(255),
	city VARCHAR(255) NOT NULL,
	postal_code VARCHAR(10) NOT NULL,
	province VARCHAR(2) NOT NULL)
	
	
INSERT INTO Customer (customer_ID, membership_type, first_name, last_name, email, dob, gender, driver_license_no, phone_number, address_1, address_2, city, postal_code, province, ) VALUES
(
1,
0,
'Wayne', 
'Fire', 
'waynefire@gmail.com', 
'1991-08-22',
'Female',
'12139748',
'2041249022',
'4506 Gillian Rue',
'unit 204', 
'Lake Norberto',
'E2G 8X2',
'NB'
);

(2, 0, 
'Paavo',
'Nurmi', 
 'paavonurmi@gmail.com', 
 '1985-07-26', 
 'Male', 
 '97632345', 
 '3947842912', 
 'Casper Mountain Road', 
 '738',
 'New Glen', 
 'E2S 0E5',
 'ON'); 


(3, 0, 
 'Todd', 
 'Howells', 
 'toddhowells@gmail.com', 
 '1995-04-11', 
 'Male', 
 '30275392', 
 '8202699593', 
 '5792 Mohr Grove St', 
 'New Aida', 
 'P1P 7Z0',
 'BC');
 ```



 ```
 --For requesting reservations

   String query = "SELECT DISTINCT c.Car_ID as \"ID\", c.Car_Type, b.City, b.Province, FORMAT(ct.daily_rate, 'C') as \"Day Rate\", FORMAT(ct.weekly_rate, 'C') as \"Weekly Rate\", FORMAT(ct.monthly_rate, 'C') as \"Monthly Rate\" FROM Cars c, CarTypes ct, Branches b, CarStatus cs WHERE c.Car_Type = ct.CarType AND b.Branch_ID = c.Branch_ID AND c.CarStatusID = 1";
            if (province_filter)
            {
                query += $" AND b.Province LIKE '{Provinces.SelectedItem.ToString()}'";
            }
            if (branch_filter)
            {
                query += $" AND b.branch_ID = {Program.ExtractLeadingNumbers(Branches.SelectedItem.ToString())}";
            }
            if (cartype_filter)
            {
                query += $" AND c.Car_Type LIKE '{cartypes.SelectedItem.ToString()}'";
            }
            if (rate_filter)
            {
                query += $" AND ct.monthly_rate <= '{Program.ExtractLeadingNumbers(rates.Text)}'";
            }



  String query = "SELECT DISTINCT c.Car_ID as \"ID\", c.Car_Type, b.City, b.Province, FORMAT(ct.daily_rate, 'C') as \"Day Rate\", FORMAT(ct.weekly_rate, 'C') as \"Weekly Rate\", FORMAT(ct.monthly_rate, 'C') as \"Monthly Rate\" " +
                "FROM Cars c, CarTypes ct, Branches b, CarStatus cs, Reservations r " +
                "WHERE c.Car_Type = ct.CarType AND b.Branch_ID = c.Branch_ID AND c.CarStatusID = 1" +
                "AND r.Car_ID = c.Car_ID" +
                $"AND (" +
                        // from/to reserved is ahead of requested from/to
                        $"(" +
                            $"(DATEFROMPARTS(r.From_Year, r.From_Month, r.From_Day) > DATEFROMPARTS({from_year}, {from_month}, {from_day}))" +
                            $"AND" +
                            $"(DATEFROMPARTS(r.To_Year, r.To_Month, r.To_Day) > DATEFROMPARTS({to_year}, {to_month}, {to_day}))" +
                        $"(" +
                    $"XOR" +
                        // from/to reserved is behind requested from/to
                        "(" +
                            $"(DATEFROMPARTS(r.From_Year, r.From_Month, r.From_Day) < DATEFROMPARTS({from_year}, {from_month}, {from_day}))" +
                            $"AND" +
                            $"(DATEFROMPARTS(r.To_Year, r.To_Month, r.To_Day) < DATEFROMPARTS({to_year} ,{to_month}, {to_day}))" +
                        ")" +
                    $")";

```

```
--For Customer management
        private string GenQueryStr()
        {
            string query = "select c.customer_id, concat(first_name, ' ', last_name) as \"name\", mt.rank as \"membership\", c.phone_number, c.driver_license_no, c.gender, c.address_1, c.city, c.postal_code, c.province  from customers c, membershiptype mt WHERE c.membership_type = mt.membership_id";

            // Check filter bools and apply proper text to base query if true.
            if (customer_id_filter)
            {
                query += $" AND c.customer_id = {Program.ExtractLeadingNumbers(CustomerIDFilter.Text)}";
            }
            if (!terminated_member_view)
            {
                query += " AND c.membership_type != 0";
            }
            if (c_name_filter)
            {
                query += $" AND (first_name LIKE '%{Program.SanitizeTextInput(CusNameFilter.Text)}%' OR last_name LIKE '%{Program.SanitizeTextInput(CusNameFilter.Text)}%')";
            }

            return query;
        }

```

