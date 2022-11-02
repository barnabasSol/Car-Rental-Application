create database car_rental_database;

GO

use car_rental_database;

GO

create table profile_type(
    prof_id int primary key,
    profile_type_name varchar(100) not null 
)

GO

create table profile(
    login_id  varchar(200) primary key,
    first_name nvarchar(100) not null, 
    last_name nvarchar(100) not null,
    sex varchar(3) not null,
    phone_number varchar(100) not null UNIQUE, 
    home_address nvarchar(100) not null, 
    [password] varchar(100) not null,
    profile_type_id int,
    activity tinyint default 1,
    constraint fk_profile_id foreign key (profile_type_id) REFERENCES profile_type(prof_id) on update cascade
)
GO

create table customer(
    login_id varchar(200),
    reputation int DEFAULT 5, 
    constraint fk_cc_id foreign key(login_id) REFERENCES profile(login_id) on update CASCADE
)

GO

create table branch(
    branch_address nvarchar(100) primary key,
    branch_vehicles_amount int,
    branch_rating decimal(2,1)
)

GO

create table [admin](
    login_id varchar(200), 
    salary_per_month money,
    branch_loc nvarchar(100),
    CONSTRAINT fk_br_adm FOREIGN KEY(branch_loc) REFERENCES branch(branch_address) on update cascade,
    constraint fk_ad_id foreign key(login_id) REFERENCES profile(login_id) on UPDATE cascade
)

 
GO
  
 create table cars(
     license_plate_no varchar(200) primary key, 
     verification varchar(20) DEFAULT 'unverified',
     car_name varchar(100) not null, 
     car_type varchar(100) not null,
     car_capacity int not null,
     car_model varchar(100) not null,
     car_color varchar(50) not null,
     car_status TINYINT,
     car_condition int not null, /*new column*/
     rep_min_req int not null,
     price_per_hour Decimal(18, 2) not null,
     car_branch nvarchar(100), 
     login_id varchar(200),
     CONSTRAINT fk_renter_id FOREIGN KEY(login_id) REFERENCES profile(login_id) on update cascade,
     CONSTRAINT fk_car_branch FOREIGN KEY(car_branch) REFERENCES branch(branch_address) on update CASCADE
  )

  
GO

create table payment(
    payment_id int PRIMARY KEY, 
    payment_type varchar(50) not null
)

GO

create table rental(
    rent_id VARCHAR(200) PRIMARY KEY,
    c_login_id varchar(200),
    rental_date datetime not null,
    total_vehicles int not null,  /*new column*/
    return_date datetime not null,
    paid_amount money,
    payment_id int,
    branch_loc NVARCHAR(100),  /*new column*/
    CONSTRAINT fk_bloc FOREIGN KEY (branch_loc) REFERENCES branch(branch_address) on update cascade,
    CONSTRAINT fk_cid FOREIGN KEY(c_login_id) REFERENCES profile(login_id) on update cascade,
    CONSTRAINT fk_pmnt_id FOREIGN KEY(payment_id) REFERENCES payment(payment_id) on update CASCADE
)

GO

create table car_reviews(
       rent_id VARCHAR(200),
       car_rating decimal(2,1) default 0,
       constraint fk_rnt_id FOREIGN KEY (rent_id) REFERENCES rental(rent_id) on update CASCADE
)

GO

create table rented_cars(
    r_id VARCHAR(200),
    license_plate_no varchar(200),
    return_status VARCHAR(100) default 'unreturned',
    CONSTRAINT fk_r_id FOREIGN KEY(r_id) REFERENCES rental(rent_id),
    CONSTRAINT fk_lp_num FOREIGN KEY(license_plate_no) REFERENCES cars(license_plate_no) on update cascade,
)

GO

create table rented_cars_log(
    r_id VARCHAR(200),
    license_plate_no varchar(200),
    return_status VARCHAR(100) default 'unreturned',
    CONSTRAINT fk_r2_id FOREIGN KEY(r_id) REFERENCES rental(rent_id),
    CONSTRAINT fk_lp2_num FOREIGN KEY(license_plate_no) REFERENCES cars(license_plate_no) on update cascade,
)

GO

create table [audit] (
    admin_id varchar(200),
    task varchar(1000),
    done_date DATETIME
)

GO


create view vcc_view 
as
select  cars.license_plate_no, car_name, car_type, verification, car_status, c_login_id, return_status, login_id, car_branch, r_id 
from cars
full join (
        select r_id, rental.c_login_id, license_plate_no, return_status 
        from rented_cars 
        full join rental 
        on rental.rent_id = rented_cars.r_id
    ) 
    as firsttable 
on cars.license_plate_no = firsttable.license_plate_no 


go

create view srch_view
as
select  cars.license_plate_no, car_name, car_type, verification, car_status, c_login_id, cars.price_per_hour, cars.car_condition, firsttable.return_status, login_id, car_branch 
from cars
full join
     (
        select rental.c_login_id, license_plate_no, return_status 
        from rented_cars 
        join rental 
        on rental.rent_id = rented_cars.r_id
    ) 
    as firsttable on cars.license_plate_no = firsttable.license_plate_no

GO
create view customer_rep as
select profile.login_id, first_name+' '+last_name as full_name, sex, phone_number, home_address, activity, reputation from profile
join customer on profile.login_id=customer.login_id

GO


