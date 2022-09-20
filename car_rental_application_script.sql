create database car_rental_database;

GO

use car_rental_database;

GO

create table profile_type(
    prof_id int primary key,
    profile_type_name varchar(100) not null 
)

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

create table customer(
    login_id varchar(200),
    reputation int DEFAULT 5, 
    constraint fk_cc_id foreign key(login_id) REFERENCES profile(login_id) on update CASCADE
)

GO


create proc [search customer]
@searchby varchar(100)
AS
BEGIN
select login_id, fullname, sex, phone_number, home_address, activity, reputation from
             customer_rep WHERE fullname like '%'+@searchby+'%'
                                or login_id like '%'+@searchby+'%'
                                or phone_number like '%'+@searchby+'%'
                                or home_address like '%'+@searchby+'%'

END
GO



create proc[update customer change by admin]
@customerid varchar(100), @activity int, @rep int
as 
BEGIN
update profile set activity=@activity where login_id=@customerid
update customer set reputation=@rep where login_id=@customerid
END

go
----------------customer view-------------------------------------
create view customer_rep as 
    select profile.login_id, concat(first_name,' ',last_name) as fullname, sex, phone_number, home_address, activity, reputation from profile
    join customer on profile.login_id = customer.login_id where profile_type_id = 2
    ----------------------------------------------------------

GO
create trigger [set customer rep trigger]
on profile 
for insert 
as 
begin
declare @cusid varchar(100)
set @cusid = (select login_id from inserted)
if exists (select profile_type_id from inserted where profile_type_id=2)
        insert into customer(login_id) values (@cusid)
END

GO


create table branch(
    branch_address nvarchar(100) primary key,
    branch_vehicles_amount int not null,
    branch_rating decimal(2,1)
)

create table [admin](
    login_id varchar(200), 
    salary money,
    branch_loc nvarchar(100),
    CONSTRAINT fk_br_adm FOREIGN KEY(branch_loc) REFERENCES branch(branch_address),
    constraint fk_ad_id foreign key(login_id) REFERENCES profile(login_id)
)

 create table cars(
     license_plate_no varchar(200) primary key, 
     verification varchar(20) DEFAULT 'unverified',
     car_name varchar(100) not null, 
     car_type varchar(100) not null,
     car_capacity int not null,
     car_model varchar(100) not null,
     car_color varchar(50) not null,
     car_status TINYINT not null,
     car_condition int not null, /*new column*/
     rep_min_req int not null,
     price_per_hour money not null,
     car_branch nvarchar(100), 
     login_id varchar(200),
     CONSTRAINT fk_renter_id FOREIGN KEY(login_id) REFERENCES profile(login_id) on update cascade,
     CONSTRAINT fk_car_branch FOREIGN KEY(car_branch) REFERENCES branch(branch_address) on update CASCADE
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
    vehicle_return_status int,   /*new column*/
    CONSTRAINT fk_cid FOREIGN KEY(c_login_id) REFERENCES profile(login_id) on update cascade,
    CONSTRAINT fk_pmnt_id FOREIGN KEY(payment_id) REFERENCES payment(payment_id) on update CASCADE
)


  create table car_reviews(
       rent_id VARCHAR(200),
       car_rating int default 0,
       constraint fk_rnt_id FOREIGN KEY (rent_id) REFERENCES rental(rent_id) on update CASCADE
  )

create table rented_cars(
    r_id VARCHAR(200) PRIMARY KEY,
    license_plate_no varchar(200)
    CONSTRAINT fk_r_id FOREIGN KEY(r_id) REFERENCES rental(rent_id),
    CONSTRAINT fk_lp_num FOREIGN KEY(license_plate_no) REFERENCES cars(license_plate_no) on update cascade
)
create table [audit] (
    admin_id varchar(200),
    task varchar(1000),
    done_date DATETIME
)



GO

/****************** admin proc ************************/
create proc [reset_admin_password]
@admid varchar(100), @newpsw varchar(100)
as 
BEGIN
update [profile] set [password]=@newpsw where login_id = @admid
END

go

create proc [deactivate_admin_account]
@admid varchar(100), @newpsw varchar(100)
as 
BEGIN
update [profile] set [activity]=0 where login_id = @admid
END

go


insert into [audit] values
                        ('adm10', 'deleted something', CURRENT_TIMESTAMP),
                        ('adm10', 'updated something', CURRENT_TIMESTAMP)


insert into profile_type values(1, 'admin'),
                               (2, 'customer'),
                               (3, 'renter')
insert into profile(login_id, first_name, last_name, sex, phone_number, home_address, [password], profile_type_id)
                           values
                           ('rntr10', 'Nathnael', 'lastname', 'M', '097426534', 'hayat', '0000',3),('cus10', 'Nathan', 'Dawit', 'M', '092355534', 'summit', '1111',2),
                           ('adm10', 'Barnabas', 'Solomon', 'M', '09093664', 'cmc', '2222',1)
						   
						 

insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                           values ('cus21', 'Ruth', 'Solomon', 'F', '09789786', 'cmc', '2222',2)

-- use master
-- drop database car_rental_database

--Procedure to insert new Profile
go
CREATE PROCEDURE Insert_Profile
    @login_id  varchar(200),
    @first_name varchar(100), 
    @last_name varchar(100),
    @sex varchar(2),
    @phone_number varchar(100), 
    @home_address varchar(100) , 
    @password varchar(100) ,
    @profile_type_id int,
	@Activity int
as
begin
insert into profile(login_id, first_name, last_name, sex, phone_number, home_address, [password], profile_type_id,activity)
                           values (@login_id,@first_name,@last_name,@sex,@phone_number,@home_address,@password ,@profile_type_id,@Activity )
end

create proc [reset_renter_password]
@login_id varchar(200),@new_password  varchar(100)
as
begin
Update profile
set password=@new_password
where login_id=@login_id

end
--drop proc reset_renter_password


go

