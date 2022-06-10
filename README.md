# Car Rental Project
### a.k.a. The Numved Car Rental Agency Digital Experience 

### Goal
- To implement a front-end program that customers and employees can use to successfully book/manage a car rental comapny.

## NOTES FROM MILESTONE 2:
- No need for car status if only available cars are shown.
- Make sure no overlapping reservations on customer cars. 
  - Does not overlap with any current reservation.

### Current Assignments:
- **Dylan**
  - Finish Setting up Design Specs
  - Login and splash screen, redirect to proper screens.
  - Normalizing UI, editing for consistency. Will go over each screen and edit for a consistent flow. 
- **Andrew**
  - Car Queue screen, connected to the DB (for the Demo)
- **Hamza**
  - Employee Menu
  - Side buttons: Home, Logout, Exit
    - -> buttons on home page to change/nagivate to: 
        - Branch (dropdown to change branch setting) - maybe not needed? discuss.
        - Reservations (goes to res menu)
              - Goes to Grant's reservation menu.
    - Car Menu
        - Described below.
    - Customers
    - Reports
- **Grant**
  - Reservation Menu - Employees
  - -> buttons to navigate to:
    - Create a Reservation (both customers and employees have this)
          - Leads to reservation user control, with filters and a table view that will show query results. Described below in Todo.
          - Employees will have an extra field available to select a customer/input a customer id. Perhaps this pops up a customer search?
    - Current Reservations (Employee)
        - Shows table from query on current reservations out for current branch, filter to allow for choosing which branch/all

If you have completed your assignment, message the group chat and we'll assign
the next step. Alternatively, continue to make the screen that the buttons lead to, 
and update the chat so everyone is on the same page.


## Whiteboard Meeting Rundown
### Employee Screens
#### Employee Main Menu
- 


#### Todo
- 
- **Database set up and linked to project by next Wed.**

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


