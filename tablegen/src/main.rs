
use std::{fmt::Debug, io::Write};
use rand::Rng;
mod names;

const car_types: [&str; 4] = ["CarType","SEDAN", "TRUCK", "VAN"];
const car_statuses: [&str; 4] = ["Status","IN_REPAIR", "AVAIL", "RESERVED"];
const car_ids: [&str; 13] = ["Car_ID","0","1","2","3","4","5","6","7","8","9","10","11"];
const repair_ids: [&str; 13] = ["RepairID","0","1","2","3","4","5","6","7","8","9","10","11"];
const res_statues: [&str; 4] = ["Status","RESERVED", "IN PROCESS", "COMPLETED"];
const membership_types: [&str; 3] = ["MembershipType","REG", "GOLD"]; 



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
        
        let mut key: usize = r.gen_range(0..12);

        let mut s = String::from(format!("{}", key)); 
        s
    }
}

struct CarType;
impl Gen for CarType {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut t: usize = r.gen_range(1..4);

        let mut s = String::from(car_types[t]); 
        s
    }
}

struct CarID;
impl Gen for CarID {
    fn gen() -> String {
        let mut r = rand::thread_rng();
        
        let mut t: usize = r.gen_range(1..13);

        let mut s = String::from(car_ids[t]); 
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

fn main() {
    println!("=== Table Gen ===");

    gen_write("Cars.csv", vec![ 
        ownall!(car_ids),
        gen_col::<CarType>("Car_Type",12),
        gen_col::<Key>("Branch_ID",12),
        gen_col::<StatusID>("CarStatusID",12),
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
        ownall!(repair_ids),
        gen_col::<CarID>("Car_ID", 12),
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
