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

create proc auto_Generate  @AdmID char(6) = 'adm000'
as
begin
DECLARE @nextNumber int =0 
SELECT @nextNumber = CAST( SubString( @AdmID, 4, 3) AS INT )
SET @nextNumber = @nextNumber + 1
SELECT CONCAT ('adm'
, CASE
WHEN @nextNumber < 10 THEN '00'
WHEN @nextNumber < 100 THEN '0'
ELSE ''
END
, CAST( @nextNumber AS char(3)) )

End

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
                                order by fullname

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


create table branch(
    branch_address nvarchar(100) primary key,
    branch_vehicles_amount int,
    branch_rating decimal(2,1)
)

create table [admin](
    login_id varchar(200), 
    salary_per_month money,
    branch_loc nvarchar(100),
    CONSTRAINT fk_br_adm FOREIGN KEY(branch_loc) REFERENCES branch(branch_address) on update cascade,
    constraint fk_ad_id foreign key(login_id) REFERENCES profile(login_id) on UPDATE cascade
)

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
   create proc [insert cars by admin]
   @lp VARCHAR(200), @cname varchar(100), @ctype varchar(100), @ccapacity int,
   @cmodel varchar(100), @ccolor VARCHAR(20), @ccondition int, @rep int, @pph Decimal(18,8), @admid varchar(50) 
   as 
   BEGIN
   declare @cbranch NVARCHAR(100)
   select @cbranch = branch_loc from admin where login_id = @admid
   insert into cars values (@lp,'verified', @cname, @ctype, @ccapacity, @cmodel, @ccolor,1 ,@ccondition, @rep, @pph, @cbranch, @admid)
   END


  GO

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
    branch_loc NVARCHAR(100),  /*new column*/
    CONSTRAINT fk_bloc FOREIGN KEY (branch_loc) REFERENCES branch(branch_address) on update cascade,
    CONSTRAINT fk_cid FOREIGN KEY(c_login_id) REFERENCES profile(login_id) on update cascade,
    CONSTRAINT fk_pmnt_id FOREIGN KEY(payment_id) REFERENCES payment(payment_id) on update CASCADE
)


  create table car_reviews(
       rent_id VARCHAR(200),
       car_rating decimal(2,1) default 0,
       constraint fk_rnt_id FOREIGN KEY (rent_id) REFERENCES rental(rent_id) on update CASCADE
  )

create table rented_cars(
    r_id VARCHAR(200),
    license_plate_no varchar(200)
    CONSTRAINT fk_r_id FOREIGN KEY(r_id) REFERENCES rental(rent_id),
    CONSTRAINT fk_lp_num FOREIGN KEY(license_plate_no) REFERENCES cars(license_plate_no) on update cascade
)
create table [audit] (
    admin_id varchar(200),
    task varchar(1000),
    done_date DATETIME
)


go

create proc [search audit]
@item varchar(1000), @adminid varchar(100) 
as 
begin
select task, done_date from [audit] where task LIKE '%'+@item+'%' or done_date LIKE '%'+@item+'%'
end


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

insert into branch values ('summit', 0, null), ('cmc', 0, null), ('hayat', 0, null)

insert into profile_type values(1, 'admin'),
                               (2, 'customer'),
                               (3, 'renter')
insert into profile(login_id, first_name, last_name, sex, phone_number, home_address, [password], profile_type_id)
                           values
                           ('rntr10', 'Nathnael', 'lastname', 'M', '097426534', 'hayat', '0000',3),
                           ('adm10', 'Barnabas', 'Solomon', 'M', '09093664', 'cmc', '2222',1)
						   
insert into admin values('adm10', 10000, 'cmc')

insert into payment values(1, 'credit card')

go

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

 go

 insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                            values ('cus21', 'Ruth', 'Solomon', 'F', '09789786', 'cmc', '2222',2)
 insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                            values('cus10', 'Nathan', 'Dawit', 'M', '092355534', 'summit', '1111',2)
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

GO


create proc [reset_renter_password]
@login_id varchar(200),@new_password  varchar(100)
as
begin
Update profile
set password=@new_password
where login_id=@login_id

end
GO

create PROC [undo added vehicle]
@lp VARCHAR(200)
AS
BEGIN
DELETE from cars where license_plate_no=@lp
END

go

------trigger to keep track of the stats of the brances
create trigger [update branch stats] on cars
for insert 
as 
begin
declare @branch varchar(200)
set @branch = (select car_branch FROM inserted)
update branch set branch_vehicles_amount+=1 where branch_address=@branch
end

go

create trigger [update reviews on branches] on car_reviews
for insert 
AS
BEGIN
declare @branch nvarchar(100)
declare @newrating Decimal(18, 8)
declare @temp_table table(
		average_rating Decimal(18,8),
		b_location nvarchar(100)
)
declare cur_branches cursor 
for select branch_address from branch
open cur_branches
fetch next from cur_branches into @branch
insert @temp_table
	select avg(car_reviews.car_rating) as avgrating, rental.branch_loc as [location] from
	rental join car_reviews on rental.rent_id = car_reviews.rent_id where branch_loc=@branch group by branch_loc
while @@FETCH_STATUS=0
	begin
		set @newrating = (select average_rating from @temp_table)
		update branch set branch_rating = @newrating where branch_address=@branch
		fetch next from cur_branches into @branch
		delete from @temp_table
		insert @temp_table
			select avg(car_reviews.car_rating) as avgrating, rental.branch_loc as [location] from
			rental join car_reviews on rental.rent_id = car_reviews.rent_id where branch_loc=@branch group by branch_loc
	end
	close cur_branches
	deallocate cur_branches
END

GO
create view vcc_view 
as
select  cars.license_plate_no, car_name, car_type, verification, car_status, car_condition c_login_id from
cars
full join (select rental.c_login_id, license_plate_no from rented_cars right join
rental on rental.rent_id = rented_cars.r_id) as firsttable on cars.license_plate_no = firsttable.license_plate_no 

go

create proc [vehicle card content] 
AS
begin 
select * from vcc_view
END

GO

create PROC [disable car]
@lp varchar(200)
AS
BEGIN
update cars set car_status=0 where license_plate_no=@lp;
END

GO

create PROC [enable car]
@lp varchar(200)
AS
BEGIN
update cars set car_status=1 where license_plate_no=@lp;
END

GO

create proc [delete car]
@lp VARCHAR(200)
AS
BEGIN
    delete from cars where license_plate_no = @lp
END




 --use master
 --drop database car_rental_database

-- insert into admin values('adm10', 10000.00, 'cmc');

-- insert into branch values ('cmc', 0, 0);
select * from cars

