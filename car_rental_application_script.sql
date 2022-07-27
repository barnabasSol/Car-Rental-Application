create database car_rental_database;
use car_rental_database;

go

create table profile_type(
    prof_id varchar(50) primary key,
    profile_type_name varchar(100) not null
)

create table profile(login_id  varchar(200) primary key,
                     first_name nvarchar(100) not null, 
                     last_name nvarchar(100) not null,
                     phone_number varchar(100) not null, 
                     home_address nvarchar(100) not null, 
                     password varchar(100) not null,
                     profile_type_id varchar(50),
                     constraint fk_profile_id foreign key (profile_type_id) REFERENCES profile_type(prof_id))

create table customer(
    login_id varchar(200),
    reputation varchar(50) not null, 
    constraint fk_c_id foreign key(login_id) REFERENCES profile(login_id))

create table admin(
    login_id varchar(200), 
    salary money
)

