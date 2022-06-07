
use std::fmt::Debug;
use rand::Rng;
mod names;


trait Gen {
    fn gen() -> Self;
    fn st(&self) -> String;
}

#[derive(Debug)]
struct Name {
    s: String
}

impl Gen for Name {
    fn gen() -> Self {
        let mut r = rand::thread_rng();
        let mut rng: usize = r.gen_range(0, names::NAMES.len());
        let mut s = String::from(names::NAMES[rng]);
        Name {
            s 
        }
    }

    fn st(&self) -> String {
        String::from(self.s.as_str())
    }
}

struct Num {
    n: usize
}

struct Date {
    day: usize,

}

fn main() {
    println!("=== Table Gen ===");

    let car_types = ["SEDAN", "TRUCK", "VAN"];
    let car_statuses = ["IN_REPAIR"];
    let res_statues = [""];
    let membership_types = [""]; 

    let mut car_ids: Vec<usize> = vec![];
    let mut car_statuses: Vec<usize> = vec![];

    println!("{:?}",gen_col::<Name>(5));

}

fn gen_col<T: Gen + Debug>(rows: usize) -> Vec<T> {
    let mut col: Vec<T> = vec![];
    for _ in 0..rows {
        col.push(T::gen());
    }
    col
}
