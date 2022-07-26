use car_rental_database;
-- NATE -----------------------------------
select * from cars
GO
 
create function extra_check_car_status (@lp VARCHAR(100))
returns int
as 
begin
declare @status int 
    set @status = (select car_status from cars where license_plate_no=@lp)
	return @status
end

go


create function [get available vehicles]
	(@id varchar(20))
returns table
as return ( 
	select license_plate_no, car_name, car_type, car_capacity, car_model, car_color, car_condition, price_per_hour, car_branch from cars 
	where (select customer.reputation from customer 
				where customer.login_id = @id)
				>= cars.rep_min_req
		and verification = 'verified'
		and car_status=1
)
go
create function [get rented cars] 
(@cusid varchar(200))
returns table 
as return(
	select cars.car_name, firsttable.* from (
		select rented_cars.license_plate_no, rental.return_date, branch_loc, rented_cars.r_id
		from rented_cars
		inner join rental
		on rental.rent_id = rented_cars.r_id
		where rental.c_login_id = @cusid
	)
	as firsttable
	inner join cars
	on cars.license_plate_no = firsttable.license_plate_no
)


go
create function [generate rentid]
()
returns varchar(5)
as begin
	declare @id varchar(5)
	if (select count(*) from rental) < 1 
		set @id = 'r0001'
	else
		set @id = 'r' + (format((cast(substring((select top 1 rent_id from rental order by rent_id desc), 2, 4) as int) + 1), 'D4'))
	return @id
end

GO

--Nati-----------------------------------
create function return_name(@c_login_id varchar(200))
returns varchar(200)
as

begin
declare @name varchar(200)

select @name=first_name from profile where login_id=@c_login_id 
return @name
	

end
go
--Nati-----------------------------------

alter Function Earnings(@renter_id varchar(200))
returns table
as
return(
select rented_cars_log.license_plate_no, 
		car_name, 
		car_color, 
		car_branch, 
		dbo.return_name(c_login_id) as firstname,
		rental_date,
		return_status,
		paid_amount
		from rental join rented_cars_log on rental.rent_id=rented_cars_log.r_id
		join cars on cars.license_plate_no=rented_cars_log.license_plate_no
		where login_id = @renter_id 
)  

go

--Nati-----------------------------------

create function Total_Earings(@renter_login_id varchar(200))
returns money
as
begin
declare @earnings money
set @earnings=(select SUM(paid_amount) from Earnings(@renter_login_id))
set @earnings=@earnings*0.6


return round(@earnings,2)
end

go


--Nati-----------------------------------
create Function number_of_useraccounts()
returns table
as
return(

select count (*) as [Number of User by Profile type]  from profile  group by profile_type_id 

)


GO


create function [generate admid]
()
returns varchar(5)
as begin
	declare @id varchar(5)
	if (select count(*) from profile where profile_type_id=1) < 1 
		set @id = 'a0001'
	else
		set @id = 'a' + (format((cast(substring((select top 1 login_id from profile order by login_id desc), 2, 4) as int) + 1), 'D4'))
	return @id
end

go

