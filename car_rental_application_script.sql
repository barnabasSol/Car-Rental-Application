create database car_rental_database;


go


use car_rental_database;

GO

create table profile_type(
    prof_id varchar(50) primary key,
    profile_type_name varchar(100) not null
)

create table profile(
    login_id  varchar(200) primary key,
    first_name nvarchar(100) not null, 
    last_name nvarchar(100) not null,
    phone_number varchar(100) not null, 
    home_address nvarchar(100) not null, 
    password varchar(100) not null,
    profile_type_id varchar(50),
    constraint fk_profile_id foreign key (profile_type_id) REFERENCES profile_type(prof_id)
)

create table customer(
    login_id varchar(200),
    reputation varchar(50) not null, 
    constraint fk_c_id foreign key(login_id) REFERENCES profile(login_id)
    )

create table admin(
    login_id varchar(200), 
    salary money
    constraint fk_ad_id foreign key(login_id) REFERENCES profile(login_id)
)

create table branch(
    branch_address nvarchar(100) PRIMARY KEY,
    branch_vehicles_amount int not null,
    branch_rating decimal(2,1)
)

 create table cars(
     license_plate_no varchar(200) primary key, 
     car_name varchar(100) not null, 
     car_type varchar(100) not null,
     car_capacity int not null,
     car_model varchar(100) not null,
     car_color varchar(50) not null,
     car_status TINYINT not null,
     car_rating int default 0,
     price_per_hour money not null,
     car_branch nvarchar(100), 
     renter_login_id varchar(200) default 'company'''+'s',
     CONSTRAINT fk_renter_id FOREIGN KEY(renter_login_id) REFERENCES profile(login_id),
     CONSTRAINT fk_car_branch FOREIGN KEY(car_branch) REFERENCES branch(branch_address)
  )

create table payment(
    payment_id int PRIMARY KEY, 
    payment_type varchar(50) not null
)

create table rental(
    rent_id VARCHAR(200) PRIMARY KEY,
    c_login_id varchar(200),
    rental_date date not null,
    total_vehicles int not null,  /*new column*/
    return_date date not null,
    paid_amount money,
    payment_id int,
    CONSTRAINT fk_cid FOREIGN KEY(c_login_id) REFERENCES profile(login_id),
    CONSTRAINT fk_pmnt_id FOREIGN KEY(payment_id) REFERENCES payment(payment_id)
)


create table rented_cars(
    r_id VARCHAR(200) PRIMARY KEY,
    license_plate_no varchar(200)
    CONSTRAINT fk_r_id FOREIGN KEY(r_id) REFERENCES rental(rent_id),
    CONSTRAINT fk_lp_num FOREIGN KEY(license_plate_no) REFERENCES cars(license_plate_no)
)


GO

