
use std::{fmt::Debug, io::Write, sync::Arc, collections::HashMap, ops::Range};
use rand::Rng;
mod names;

const car_types: [&str; 4] = ["CarType","SEDAN", "TRUCK", "VAN"];
const car_statuses: [&str; 4] = ["Status","IN_REPAIR", "AVAIL", "RESERVED"];
//const car_ids1: [&str; 13] = ["Car_ID"];
//const repair_ids1: [&str; 13] = ["RepairID"];
const res_statues: [&str; 4] = ["Status","RESERVED", "IN PROCESS", "COMPLETED"];
const membership_types: [&str; 3] = ["MembershipType","REG", "GOLD"]; 

const AMT_OF_BRANCHES: usize = 11;

struct A;

impl A {
    fn new() -> Self {
        Self
    
    
    }

    fn do_thing(&self) {
        print!("sdfjsidfisdfjsd");
    }
}

trait Gen {
    fn gen() -> String;
}

struct Name;

impl Gen for Name {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        let mut rng: usize = r.gen_range(0..names::NAMES.len());
        let mut s = String::from(names::NAMES[rng]); 
        s    
    }
}

/// This will work for both CarStatusID and ReservationStatusID
struct StatusID;
impl Gen for StatusID {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        let mut rng: usize = r.gen_range(0..3);
        let mut s = String::from(format!("{}", rng)); 
        s
    }
}

struct FirstName;
static mut FIRSTNAME_IDX: usize = 0;
impl Gen for FirstName {
    fn gen() -> String {
        let s = String::from(names::NAMES[unsafe{FIRSTNAME_IDX}]);
        unsafe {
            FIRSTNAME_IDX += 1;
        };
        s
    }
}

struct LastName;
static mut LASTNAME_IDX: usize = 0;
impl Gen for LastName {
    fn gen() -> String {
        let s = String::from(names::SURNAMES[unsafe{LASTNAME_IDX}]);
        unsafe {
            LASTNAME_IDX += 1;
        };
        s
    }
}

struct Key;
impl Gen for Key {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut key: usize = r.gen_range(0..ROWS);

        let mut s = String::from(format!("{}", key)); 
        s
    }
}

struct BranchID;
impl Gen for BranchID {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut key: usize = r.gen_range(0..AMT_OF_BRANCHES);

        let mut s = String::from(format!("{}", key)); 
        s
    }
}

struct EmployeeID;
impl Gen for EmployeeID {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut key: usize = r.gen_range(0..ROWS);

        let mut s = String::from(format!("{}", key)); 
        s
    }
}

struct MembershipRankID;
impl Gen for MembershipRankID {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut key: usize = r.gen_range(0..3);

        let mut s = String::from(format!("{}", key)); 
        s
    }
}

struct CustomerID;
impl Gen for CustomerID {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut key: usize = r.gen_range(1..10);

        let mut s = String::from(format!("{}", key)); 
        s
    }
}

struct CarType;
impl Gen for CarType {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut t: usize = r.gen_range(1..car_types.len());

        let mut s = String::from(car_types[t]); 
        s
    }
}

struct CarID;

impl CarID {

}

struct RepairID;

impl RepairID {
    fn gen_ordered(rows: usize) -> Vec<String> {
        let mut v = vec![String::from("RepairID")];
        for i in 0..rows {
            v.push(String::from(format!("{}",i)));
        }
        v
    }
}

impl Gen for CarID {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut t: usize = r.gen_range(0..ROWS);

        let mut s = String::from(format!("{}",t)); 
        s
    }
}

struct Day;
impl Gen for Day {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut day: usize = r.gen_range(1..31);
        // let mut month: usize = r.gen_range(1, 13);
        // let mut year: usize = r.gen_range(2018, 2023);

        let mut s = String::from(format!("{}", day)); 
        s
    }
}

struct Month;
impl Gen for Month{
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        // let mut day: usize = r.gen_range(1, 30);
        let mut month: usize = r.gen_range(1..13);
        // let mut year: usize = r.gen_range(2018, 2023);

        let mut s = String::from(format!("{}", month)); 
        s
    }
}

struct Year;
impl Gen for Year {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        // let mut day: usize = r.gen_range(1, 30);
        // let mut month: usize = r.gen_range(1, 13);
        let mut year: usize = r.gen_range(2018..2023);

        let mut s = String::from(format!("{}", year)); 
        s
    }
}

struct DOBYear;
impl Gen for DOBYear {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        // let mut day: usize = r.gen_range(1, 30);
        // let mut month: usize = r.gen_range(1, 13);
        let mut year: usize = r.gen_range(1970..2000);

        let mut s = String::from(format!("{}", year)); 
        s
    }
}

macro_rules! ownall {
    ($a:expr) => {
        $a.map(|x|{
            String::from(x)
        }).to_vec()
    };
}

const ROWS: usize = 300;

fn gen_ordered(header: &str, rows: usize) -> Vec<String> {
    let mut v = vec![String::from(header)];
    for i in 0..ROWS {
        v.push(String::from(format!("{}",i)));
    }
    v
}

/// Repeats a number `max_per_group` amount of times until `v.len()-1 == rows`
fn gen_group_ordered(header: &str, rows: usize, max_per_group: usize) -> Vec<String> {
    let mut v = vec![String::from(header)];
    let mut cur_id = 0;

    while v.len()-1 != rows {
        'makegroup: for _ in 0..max_per_group {
            if v.len()-1 != rows {
                v.push(String::from(format!("{}",cur_id)));
            } else {
                break 'makegroup;
            }
        }
        cur_id += 1;
    }

    v
}

fn gen_date_span(min: usize, max: usize) -> ((Vec<String>,Vec<String>,Vec<String>),(Vec<String>,Vec<String>,Vec<String>)) {
    let mut r = rand::thread_rng();        

    let from_days = gen_col::<Day>("From_Day", ROWS);
    let from_months = gen_col::<Month>("From_Month", ROWS);
    let from_years = gen_col::<Year>("From_Year", ROWS);
    
    let mut to_days = vec![String::from("To_Day")];
    let mut to_months= vec![String::from("To_Month")];
    let mut to_years = vec![String::from("To_Year")];
    
    for i in 1..from_days.len() {
        let mut n_days: usize = r.gen_range(min..max+1);

        let day = from_days[i].parse::<usize>().unwrap() + n_days;
        let mut n_months = 0usize;
        while day > 30 {
            day -= 30;
            n_months += 1;
        }

        let month = from_months[i].parse::<usize>().unwrap() + n_months;

        let mut n_years= 0usize;
        while month > 12 {
            day -= 12;
            n_years += 1;
        }

        to_days.push(String::from(format!("{}",day)));
        to_months.push(String::from(format!("{}",month)));
        to_years.push(String::from(format!("{}",from_years[i].clone())));
        

    }

    (
        (from_days,from_months,from_years),
        (to_days,to_months,to_years)
    )

}


fn gen_emp_branch_pair(emp_ids: &Vec<String>, emp_branchids: &Vec<String>) -> (Vec<String>, Vec<String>) {

    // load the pairs into a hashtable
    let mut branch: HashMap<usize,String> = HashMap::new();
    for i in 1..emp_branchids.len() {
        branch.insert(emp_ids[i].replace(",", "").parse::<usize>().unwrap(), emp_branchids[i].clone());
    }

    let mut branch_of_emp = vec![String::from("Branch_ID")];
    let mut random_emps = gen_col::<EmployeeID>("Employee_ID", ROWS);
    for i in 1..random_emps.len() {
        let empid = random_emps[i].replace(",","").parse::<usize>().unwrap();
        branch_of_emp.push(branch.get(&empid).unwrap().clone());
    }

    (random_emps, branch_of_emp)
}

fn main() {
    println!("=== Table Gen ===");

    // let mut car_ids: [String; ROWS+1] = ["Car_ID"] + [String::from(""); ROWS];
    // for i in 1..(ROWS+1) {
    //     car_ids[i].push_str(format)
    // }


    let mut carid_table = vec![ 
        gen_ordered("Car_ID",ROWS),
        gen_col::<CarType>("Car_Type",ROWS),
        gen_col::<BranchID>("Branch_ID",ROWS),
        gen_col::<StatusID>("CarStatusID",ROWS),
    ];

    gen_write("Cars.csv", carid_table);

    gen_write("CarTypes.csv", vec![ 
        ownall!(car_types),
        ownall!(["daily_rate","40","60","50"]),
        ownall!(["weekly_rate","35","55","45"]),
        ownall!(["monthly_rate","30","50","40"]),
    ]);

    gen_write("CarStatus.csv", vec![ 
        ownall!(["CarStatusID","0","1","2"]),
        ownall!(car_statuses)
    ]);

    // gen_write("RepairLog.csv", vec![
    //     gen_ordered("RepairID",ROWS),
    //     gen_col::<CarID>("Car_ID", ROWS),
    //     gen_col::<Day>("Day", ROWS),
    //     gen_col::<Month>("Month", ROWS),
    //     gen_col::<Year>("Year", ROWS),
    // ]);

    let mut emps = vec![
        gen_ordered("Emp_ID", ROWS),
        gen_col::<FirstName>("FirstName", ROWS),
        gen_col::<LastName>("LastName", ROWS),
        gen_col::<Day>("DOB_Day",ROWS), 
        gen_col::<Month>("DOB_Month",ROWS), 
        gen_col::<DOBYear>("DOB_Year",ROWS), 
        gen_group_ordered("Branch_ID", ROWS, (ROWS as f32 /AMT_OF_BRANCHES as f32).floor() as usize), 
        gen_col::<MembershipRankID>("Rank", ROWS), 
    ];
    let (res_emp_id, res_branch_id) = gen_emp_branch_pair(emps[0].as_ref(), emps[6].as_ref());

    gen_write("Employees.csv", emps);

    // gen_write("MembershipTypes.csv", vec![
    //     ownall!(["MembershipCode","0","1","2"]),
    //     ownall!(membership_types)
    // ]);


    let ((froms),(tos)) = gen_date_span(3, 20);

    gen_write("Reservations.csv", vec![
        gen_ordered("Res_ID", ROWS),
        froms.0,
        froms.1,
        froms.2,
        tos.0,
        tos.1,
        tos.2,
        // gen_col::<Day>("From_Day", ROWS),
        // gen_col::<Month>("From_Month", ROWS),
        // gen_col::<Year>("From_Year", ROWS),
        // gen_col::<Day>("To_Day", ROWS),
        // gen_col::<Month>("To_Month", ROWS),
        // gen_col::<Year>("To_Year", ROWS),
        gen_col::<CarID>("Car_ID", ROWS),
        res_emp_id,
        res_branch_id,
        gen_col::<CustomerID>("Customer_ID", ROWS)
    ]);



}

fn gen_write(path: &str, cols: Vec<Vec<String>>) {
    let mut f = std::fs::File::create(path).unwrap();

    let rows = cols[0].len();

    for row_i in 0..rows {
        for col_i in 0..cols.len() {
            f.write(cols[col_i][row_i].as_bytes());
            f.write(",".as_bytes());
        }
        f.write("\n".as_bytes());
    }

}

fn gen_col<T: Gen>(title: &str,rows: usize) -> Vec<String> {
    let mut col: Vec<String> = vec![String::from(title)];
    for _ in 0..rows {
        col.push(T::gen());
    }
    col
}
