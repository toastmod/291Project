# Car Rental Project
### a.k.a. The Numved Car Rental Agency Digital Experience 

### Goal
- To implement a front-end program that customers and employees can use to successfully book/manage a car rental comapny.

## NOTES FROM MILESTONE 2:
- No need for car status if only available cars are shown.
- Make sure no overlapping reservations on customer cars. 
  - Does not overlap with any current reservation.

### Current Assignments:
Dylan:


Hamza:
Andrew:
Generate rest of the schemas
Query filters for employee cars available screen
Employee reports graph
Grant:
Customer screen database connection/tables
Employee Reservation Management (same as customer, with additional CID filter)
Filters for the Customer side

- **Dylan**
  - Customer management system.
  - Car Returning and branch functions
- **Andrew**
  - Get ID - City in branch selector
  - Generate rest of the schemas
  - Query filters for employee cars available screen
  - Employee reports graph
- **Hamza**
  - Reports
- **Grant**
  - Linking filters to reservation search.
  - Customer screen database connection/tables
  - Employee Reservation Management (same as customer, with additional CID filter)
  - Filters for the Customer side



If you have completed your assignment, message the group chat and we'll assign
the next step. Alternatively, continue to make the screen that the buttons lead to, 
and update the chat so everyone is on the same page.


## Whiteboard Meeting Rundown
---
### Employee Screens
#### Employee Main Menu
- 4 Navigational Buttons:
  - Car Menu      -> Car Sub-Menu   
  - Customer      -> Emp_Customer UC
  - Reservations  -> Reservations Sub-Menu
  - Reports       -> Reports UC
---
#### Car Sub-Menu
##### Car Sub-Menu - Add Car
  - **Add Car UC**
  - Form to fill for car. On submission car will be checked to see if already exists in DB.
    - Status (Default: Available)
    - Province (Default: correlates working Branch for Emp)
    - Branch (Default: Branch that Emp works at)
    - License - Must be Letter or Number
    - Colour - Dropdown
    - Car Type - Dropdown
    - Car Make - Dropdown
    - Year - Dropdown
##### Car Sub-Menu -  Car Search
  -  **Car Search UC**. 
    - Table Grid view for viewing results
    - Two buttons below table grid: **Update** and **Filter**
    - **Filter**
      - Status (Default: all)
      - Province (Default: correlates working Branch for Emp)
      - Branch (Default: Branch that Emp works at)
      - License (Default: all)
      - Colour (Default: all)
      - Car Type (Default: all)
      - Car Make (Default: all)
      - Year (Default: All) 
    - **Update** 
      - (Greyed until entry selected from Table Grid View)
      - Brings up form similar to Add Car, will values corresponding to current car values. 

##### Car Sub-Menu - Cars Available
  - **Car Search UC** with the filters preapplied:
    - (Status: Avail)
##### Car Sub-Menu -  Cars Due
  - (Being Rented or Past Rent date?)
  - **Car Search UC** with the filters preapplied:
    -  (Status: Rented)
    - If we're doing Past Rent Date add filter: (Date To < Today)
---
#### Customers 
- Table Grid of all Customer Data
- Filter button brings up filter window ->
  - Customer ID
  - Membership Status
  - Date Range (for either customer created or last reservation?)
---
#### Reservations Sub-Menu (Employee Side)
- **Emp_Res_Submenu UC**
- Three Navigational Buttons:
  - Create
  - Current
  - Past

##### Reservation Sub-Menu UC - Create
- **Emp_Reservation_Creation UC**
  - Very similar to customer side, except a CID entrybox is added.
  - Table Grid view to view Query results
    - Cols:
      - CarID
      - Branch
      - Car Type
      - Car Make
      - Rate
  - Filters - opens Filters WF
    - Date From
    - Date To (Maybe we can put these into one Date Range)
    - Car Type
    - Car Make
    - Branch
  - Submit
    - Submits to Reservations Table

##### Reservation Sub-Menu UC - Current
- **Emp_Reservation_View_Cur UC**
  - Table Grid View for Reservations/Cars currently active.
  - Cols
    - CID, Cname, Date From, Date To, Car Type, CarID, Branch From, Branch Returned
  - Two Buttons: **Filter** & **Update**
  - **Filter**
    - Province
    - Branch
    - CustomerID
    - Date range
    - Car type
    - Make
    - Membership Status (?)
  - **Update**
    - Opens Reservation entry in new window, with fields prefilled from entry
      - Status
      - Date From
      - Date To
      - Car
        - Maybe this can display CarID with a button to bring up the car search, to find an available/suitable car? Since the logic/filtering will be built, we can reuse that code. Lets chat about this one.,
      - Two buttons for finalization - Update and Cancel
        - Update - Checks for validity, then updates reservation
        - Cancel - Cancels operation, entry is not changed.

##### Reservation Sub-Menu UC - Past
- **Emp_Reservation_View_Past UC**
  - Table Grid View for reservations that have been completed.
  - Cols
    - CID, Cname, Date From, Date To, Car Type, CarID, Branch From, Branch Returned
  - One Button: **Filter** 
  - One checkbox - View Cancelled Reservations
    - Changes query to where 
  >Res_Status in [Complete, Cancelled]
  - **Filter**
    - Province
    - Branch
    - CustomerID
    - Date range
    - Car type
    - Make
    - Membership Status (?)
---
#### Reports UC
- Opens **Emp_Reports UC**
  - Table grid view that changes dynamically based on report chosen.
    - Ideally, this gets changed to a dynamic graph portion
  - One long dropdown for \[Reports...]
    - Sales Data
    - Most Popular Car/Car type
    - number of Gold Members
    - Average number of transactions after Gold Member upgrade.
  - **Filters** Button to bring up Filters WF
    - NOTE: Filters will be enabled/disabled based on Report chosen.
    - Date Range
    - Province (Default: Emp)
    - Branch (Default: Emp)
    - Car Type
    - Car make
---

### Customer Screens
#### Customer Main Menu
- Make Reservation
- View Current Reservation
- View Past Reservations
---
##### Make Reservation
- **Cus_Reserv** UC
- Table grid view to view query results
- Two drop down selectors
  - Province (Default: Cus)
  - Branch (Default: Cus)
- Filters
  - Car Type
  - Car Make
  - Car Color
  - Max Rate/day
- Submit
  - Checks validity
  - If passes, adds to reservations table.

##### View Current Reservation
- **Cus_Res_cur** UC
- Single page
- If no current reservation (Res Status: Reserved (or something, forgot the statuses))
  - "No Current Reservation"
- If current reservation
  - Res# ___
  - Date Range ___
  - Branch ___
  - Car Type ___
  - Car Make ___
  - Car Year ___
  - Car Color ___
  - Rate ___

##### View Past Reservations (low priority)
- **Past_Res_cur** UC
- Table grid view for past reservations where Cus_ID = Current Customer's ID
- Show Cancelled
  - Checkbox
  - Changes query to 
>where Res_Status in [Complete, Cancelled]
---



#### Todo
- **Customer Screens**
  - Customer Rental Request Screen
    - Shows a table of all available cars along with rates.
    - A filter button can filter these results
        - CarType, Branch, Date
    - Once a car is selected, a price field is 
  - Customer Login Screen
  - Gold member notification/badge (?)


- **Employee Screens**
    - First screen is a menu with the following options (**H**)
      - Branch (change Branch) -> Popup with dropdown, along with change/cancel buttons
      - Reservation Queue -> Reservation Queue Screen
        - Approve/Cancel/Change
      - Reservations Menu 
        - Create a Reservation
        - Current Reservations -> Screen showing all "out" reservations in a table.
          - Past Due Reservations -> Screen showing all "out" reservations past the due date. (Not essential)
      - Cars Menu
        - Add Car
        - Update Car
            - Search for car, with filters. License/color/type -> or delete car **change fields screen.** 
        - Cars Available -> Screen for table showing all avail cars at branch.
        - Car Search (if in other branches)
        - Cars due
      - Customer data
        - All customer data
      - Reports Screen (Parameterized, every provnce every branch) 4 Different questions.
        - Sales Data
        - Most popular Car Type
        - Top end car types for rental income in specific province/specific branch.
          - Parameterized
        - How many gold member per year
        - How many transactions after gold member (Average)
        - Sales
        - **The more complex the query, the higher the grade**




#### From Spec:
- Each branch maintains a queue of all existing cars and car types.
- The car rental agency maintains a list of all its customers
- Reservation can be done at any branch. 
- Each customer can rent a car and return it to the same branch or any other branch in Canada for an additional fee.
- If a car is returned to another branch, it will be included in the returned branch queue of available cars.
- Car rental can be done on a daily, weekly or monthly basis. Each rental category has its own pricing based on the car type.
- If a customer has a Gold star membership with the rental agency, they will be eligible for free upgrades if the car type selected is not available. 
- Returning cars to different branches will be free of charge for gold membership customers.
- Gold membership is granted automatically if a user rent at least three times in the same year.
- A late fee is applied if a customer returns a car later than the reservation return date.




### Notes and Guidelines
#### UI
  - The UI must remain consistent. Currently it's set at a minimal UI, smaller sized fonts, no clutter. This was done to normalize the UI, and can be temporary.
  - We can vote on the direction we want to take the design, but it must remain consistent between screens.
  - 

### Automate as much as possible, the employee simply manages the system.
> - Scenario 1 - Car is requested and available
> - Scenario 2 - Gold Member, car requested and not available, replacement given for free.
>   - System handles finding a replacement and sending out a message to customer.
> - Scenario 3 - Non-Gold, car requested and not available, replacement offered for fee.
>    - System notifies customer about a replacement 
- Employees can make and manage reservations, Customers can make reservations.
- Flat rate for returning to different branch.


    Search Stage 1: 
#### Development
  - Documentation is necessary. Explain what each function does, and its place in the program. No need to go overboard, but give enough so we don't have to dig around to figure out why a function/button is there.
  - Descriptive variable names are necessary, e.g. no functions or variables named '`f`' with no notes on what they are or what they do.
  - Tasks will be assigned/announced so every team member knows what to do and they their teammates are doing. 


