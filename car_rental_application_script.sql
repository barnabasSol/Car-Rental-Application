create database car_rental_database;
GO

use car_rental_database;

GO
--use master
--drop database car_rental_database
create table profile_type(
    prof_id int primary key,
    profile_type_name varchar(100) not null 
)
go


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
select * from profile



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
go

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
	renter_login_id varchar(200),
    rental_date date not null,
    total_vehicles int not null,  /*new column*/
    return_date date not null,
    paid_amount money,
    payment_id int,
    branch_loc NVARCHAR(100),/*new column*/
    CONSTRAINT fk_bloc FOREIGN KEY (branch_loc) REFERENCES branch(branch_address) on update cascade,
    CONSTRAINT fk_cid FOREIGN KEY(c_login_id) REFERENCES profile(login_id) on update cascade,
    CONSTRAINT fk_pmnt_id FOREIGN KEY(payment_id) REFERENCES payment(payment_id) on update CASCADE,

)



  create table car_reviews(
       rent_id VARCHAR(200),
       car_rating decimal(2,1) default 0,
       constraint fk_rnt_id FOREIGN KEY (rent_id) REFERENCES rental(rent_id) on update CASCADE
  )

create table rented_cars(
    r_id varchar(200),
    license_plate_no varchar(200),
	return_status VARCHAR(100) default 'unreturned',
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
                           ('rntr11', 'Abel', 'yohannes', 'M', '0945117271', 'hayat', '0000',3)
insert into profile(login_id, first_name, last_name, sex, phone_number, home_address, [password], profile_type_id)
                           values
                           ('rntr12', 'Kidus', 'paulos', 'M', '0911123456', 'hayat', '0000',3)
insert into profile(login_id, first_name, last_name, sex, phone_number, home_address, [password], profile_type_id)
                           values
                           ('rntr13', 'Nathnael', 'Tsegaye', 'M', '0960017873', 'hayat', '0000',3)
                           
insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                            values ('cus21', 'Ruth', 'Solomon', 'F', '09789786', 'cmc', '2222',2)
 insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                            values('cus10', 'Nathan', 'Dawit', 'M', '092355534', 'summit', '1111',2)
							


insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                            values ('adm21', 'Barnabas', 'Solomon', 'M', '09780786', 'cmc', '2222',1)
                          
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

create proc Edit_renter_Account @login_id varchar(200),@First_Name varchar(100),@Last_Name varchar(100),@phone varchar(100),@homeaddress varchar(100),@sex varchar(3),@currentuserid varchar(200)

as


begin
update profile
set login_id=@login_id,
first_name=@First_Name,
last_name=@Last_Name,
sex=@sex,
phone_number=@phone,
home_address=@homeaddress
where login_id=@currentuserid

end
select * from profile

go
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
create trigger [update branch stats of deleted vehicles tr]
on cars 
for delete 
AS
BEGIN
declare @admid varchar(200) = (select login_id from deleted)
declare @lp varchar(50) = (select license_plate_no from deleted)
declare @branchloc nvarchar(100) = (select car_branch from deleted)
update branch set branch_vehicles_amount-=1 where branch_address=@branchloc
insert into [audit] values (@admid, 'you deleted a vehicle with license plate  -  '+@lp, GETDATE())
END

go

create trigger [limit deleting vehicles]
on cars 
for delete
AS
BEGIN
declare @amount int = (select COUNT(*) from deleted)
if @amount>1
    ROLLBACK TRANSACTION
END

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
select  cars.license_plate_no, car_name, car_type, verification, car_status, c_login_id from

cars
full join (select rental.c_login_id, license_plate_no from rented_cars right join
rental on rental.rent_id = rented_cars.r_id) as firsttable on cars.license_plate_no = firsttable.license_plate_no 

go
create view srch_view
as
select  cars.license_plate_no, car_name, car_type, verification, car_status, c_login_id, cars.price_per_hour, cars.car_condition from
cars
full join (select rental.c_login_id, license_plate_no from rented_cars join
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

go

create proc [search car for admin]
@attribute varchar(200), @filter varchar(100)
as
begin 
if @filter='none'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%')
end

else if @filter='verified'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') and verification='verified'
end

else if @filter='unverified'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') and verification='unverified'
end

else if @filter='car condition (asc)'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by car_condition asc
end

else if @filter='car condition (desc)'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by car_condition desc
end

else if @filter='price (asc)'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by price_per_hour asc
end

else if @filter='price (desc)'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by price_per_hour desc
end
end





select * from vcc_view
select * from vcc_view where (license_plate_no like '%'+'audi'+'%' or
car_name like '%'+'audi'+'%' or car_type='audi')  and (verification='verified')

go

declare @attribute varchar(200) = 'k'
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') and verification='unverified'




go
create function return_name(@c_login_id varchar(200))
returns varchar(200)
as

begin
declare @name varchar(200)

select @name=first_name from profile where login_id=@c_login_id 
return @name
	

end


go

create Function Earnings(@renter_id varchar(200))
returns table
as

return(
select rented_cars.license_plate_no, 
		car_name, 
		car_color, 
		car_branch, 
		dbo.return_name(c_login_id) as firstname,
		rental_date,
		total_vehicles,
		return_date,
		paid_amount
		from rental join rented_cars on rental.rent_id=rented_cars.r_id
		join cars on cars.license_plate_no=rented_cars.license_plate_no
		where renter_login_id = @renter_id 
	
		
)  
go
create function Total_Earings(@renter_login_id varchar(200))
returns money
as
begin
declare @earnings money

set @earnings=(select SUM(paid_amount) from Earnings(@renter_login_id))


return @earnings

end

insert into cars (license_plate_no,
car_name,
car_type,
car_capacity,
car_color,
car_model,
car_condition,
rep_min_req,
price_per_hour,
car_branch,
login_id) values('11111','Pickup','Full-size pickup trucks',5,'Blue','New',10,5,20,'summit','rntr11')

insert into cars (license_plate_no,
car_name,
car_type,
car_capacity,
car_color,
car_model,
car_condition,
rep_min_req,
price_per_hour,
car_branch,
login_id) values('22222','HatchBack','Maruti Alto K10 LXi (Petrol)',4,'Red','New',10,5,15,'hayat','rntr11')


insert into cars (license_plate_no,
car_name,
car_type,
car_capacity,
car_color,
car_model,
car_condition,
rep_min_req,
price_per_hour,
car_branch,
login_id) values('33333','Toyota','Toyota Camry',4,'Red','New',10,5,15,'hayat','rntr12')


insert into cars (license_plate_no,
car_name,
car_type,
car_capacity,
car_color,
car_model,
car_condition,
rep_min_req,
price_per_hour,
car_branch,
login_id) values('44444','BMW',' 3 Series GT',4,'Red','New',10,5,30,'hayat','rntr12')


insert into cars (license_plate_no,
car_name,
car_type,
car_capacity,
car_color,
car_model,
car_condition,
rep_min_req,
price_per_hour,
car_branch,
login_id) values('55555','Ford',' F-350',6,'White','New',10,5,25,'hayat','rntr13')


insert into cars (license_plate_no,
car_name,
car_type,
car_capacity,
car_color,
car_model,
car_condition,
rep_min_req,
price_per_hour,
car_branch,
login_id) values('66666','Chevrolet',' Chevrolet K5 Blazer',4,'Yellow','New',10,5,50,'Summit','rntr13')







insert into rental (rent_id
,c_login_id
,renter_login_id
,rental_date
,total_vehicles
,return_date
,paid_amount
,branch_loc
) values(1,'cus10','rntr13','2001-10-5',2,'2001-10-8',50000,'hayat')

insert into rental (rent_id
,c_login_id
,renter_login_id
,rental_date
,total_vehicles
,return_date
,paid_amount
,branch_loc
) values(2,'cus10','rntr11','2006-10-5',2,'2006-10-7',90000,'hayat')


insert into rental (rent_id
,c_login_id
,renter_login_id
,rental_date
,total_vehicles
,return_date
,paid_amount
,branch_loc
) values(3,'cus10','rntr12','2010-10-5',2,'2010-10-8',10000,'hayat')


insert into rental (rent_id
,c_login_id
,renter_login_id
,rental_date
,total_vehicles
,return_date
,paid_amount
,branch_loc
) values(4,'cus10','rntr12','2011-10-5',2,'2011-10-6',60000,'hayat')

insert into rental (rent_id
,c_login_id
,renter_login_id
,rental_date
,total_vehicles
,return_date
,paid_amount
,branch_loc
) values(5,'cus21','rntr13','2012-09-5',2,'2012-09-6',51000,'hayat')

insert into rental (rent_id
,c_login_id
,renter_login_id
,rental_date
,total_vehicles
,return_date
,paid_amount
,branch_loc
) values(6,'cus21','rntr11','2015-09-5',2,'2015-09-6',51000,'hayat')


insert into rental (rent_id
,c_login_id
,renter_login_id
,rental_date
,total_vehicles
,return_date
,paid_amount
,branch_loc
) values(7,'cus21','rntr11','2022-09-5',2,'2022-09-6',11000,'hayat')

go
select * from cars
create proc insert_car

@license_plate_no varchar(200),
@car_name varchar(100),
@car_type varchar(100),
@car_capacity int,
@car_model varchar(100),
@car_color varchar(50),
@car_condition int,
@car_branch varchar(100),
@price decimal(18,2),
@login_id varchar(200),
@rep_min_req int
as

begin
insert into cars(license_plate_no,car_name,car_type,car_capacity,car_model,car_color,car_condition,
car_branch,price_per_hour,login_id,rep_min_req) values(
@license_plate_no ,
@car_name ,
@car_type ,
@car_capacity ,
@car_model ,
@car_color ,
@car_condition ,
@car_branch ,
@price,
@login_id ,
@rep_min_req)
end
go
insert into  rented_cars (r_id,license_plate_no) values(1,'55555')

insert into  rented_cars (r_id,license_plate_no) values(2,'11111')

insert into  rented_cars (r_id,license_plate_no) values(3,'33333')

insert into  rented_cars (r_id,license_plate_no) values(4,'44444')

insert into  rented_cars (r_id,license_plate_no) values(5,'66666')

insert into  rented_cars (r_id,license_plate_no) values(6,'11111')

insert into  rented_cars (r_id,license_plate_no) values(7,'22222')



select * from rental
select * from admin

select * from branch
select * from car_reviews
select * from customer
select * from payment
 
select * from profile
