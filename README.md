# Car Rental Project
### a.k.a. The Numved Car Rental Agency Digital Experience 

### Goal
- To implement a front-end program that customers and employees can use to successfully book/manage a car rental comapny.

### Current Assignments:
- **Dylan**
  - Customer Login Screen -> Reservation Screen(Table of all avail cars + rates)
- **Andrew**
  - Set up DB and connect it to project, either hosted or local (whatever is easier to do and work with)
- **Hamza**
  - Employee Menu
    - -> buttons to nagivate to: 
    - Branch (dropdown that changes branch)
    - Reservations (goes to res menu)
    - Car Menu
    - Customers
    - Reports
- **Grant**
  - Reservation Menu
  - -> buttons to navigate to:
    - Create a Reservation
    - Current Reservations 

If you have completed your assignment, message the group chat and we'll assign
the next step. Alternatively, continue to make the screen that the buttons lead to, and update the chat so everyone is on the same page.

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
        - How many transactions after gold member
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


