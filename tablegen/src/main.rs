
use std::{fmt::Debug, io::Write, sync::Arc};
use rand::Rng;
mod names;

const car_types: [&str; 4] = ["CarType","SEDAN", "TRUCK", "VAN"];
const car_statuses: [&str; 4] = ["Status","IN_REPAIR", "AVAIL", "RESERVED"];
//const car_ids1: [&str; 13] = ["Car_ID"];
//const repair_ids1: [&str; 13] = ["RepairID"];
const res_statues: [&str; 4] = ["Status","RESERVED", "IN PROCESS", "COMPLETED"];
const membership_types: [&str; 3] = ["MembershipType","REG", "GOLD"]; 

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
        
        let mut key: usize = r.gen_range(0..12);

        let mut s = String::from(format!("{}", key)); 
        s
    }
}

struct CarType;
impl Gen for CarType {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut t: usize = r.gen_range(1..(car_types.len()-1));

        let mut s = String::from(car_types[t]); 
        s
    }
}

struct CarID;

impl CarID {
    fn gen_ordered(rows: usize) -> Vec<String> {
        let mut v = vec![String::from("Car_ID")];
        for i in 0..ROWS {
            v.push(String::from(format!("{}",i)));
        }
        v
    }
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
        
        let mut day: usize = r.gen_range(1..30);
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

macro_rules! ownall {
    ($a:expr) => {
        $a.map(|x|{
            String::from(x)
        }).to_vec()
    };
}

const ROWS: usize = 300;
fn main() {
    println!("=== Table Gen ===");

    // let mut car_ids: [String; ROWS+1] = ["Car_ID"] + [String::from(""); ROWS];
    // for i in 1..(ROWS+1) {
    //     car_ids[i].push_str(format)
    // }

    gen_write("Cars.csv", vec![ 
        CarID::gen_ordered(ROWS),
        gen_col::<CarType>("Car_Type",ROWS),
        gen_col::<BranchID>("Branch_ID",ROWS),
        gen_col::<StatusID>("CarStatusID",ROWS),
    ]);

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

    gen_write("RepairLog.csv", vec![
        RepairID::gen_ordered(ROWS),
        gen_col::<CarID>("Car_ID", ROWS),
        gen_col::<Day>("Day", ROWS),
        gen_col::<Month>("Month", ROWS),
        gen_col::<Year>("Year", ROWS),
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
