-- NATE -----------------------------------
GO
CREATE function [get available vehicles]
	(@id varchar(20))
returns table
as return ( 
	select license_plate_no, car_name, car_type, car_capacity, car_model, car_color, car_condition, price_per_hour from cars 
	where (select customer.reputation from customer 
				where customer.login_id = @id)
				> cars.rep_min_req
		and verification = 'verified'
)
go

create function [change password]
(
	@cusid varchar(200),
	@oldp varchar(100),
	@newp varchar(100),
	@conp varchar(100)
)
returns varchar(MAX)
as begin
	declare @message varchar(MAX)
	if(@newp != @conp)
		set @message = 'Passwords do not match'
	else if (@oldp = @newp)
		set @message = 'Old password can not be new password'
	else
		begin
		update profile 
		set profile.password = @newp
		where profile.login_id = @cusid
		set @message = 'Password successfuly changed'
	end
	return @message
end 

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
--Nati-----------------------------------

create function Total_Earings(@renter_login_id varchar(200))
returns money
as
begin
declare @earnings money

set @earnings=(select SUM(paid_amount) from Earnings(@renter_login_id))
set @earnings=@earnings*0.6


return @earnings

end
go

--Nati-----------------------------------
create Function number_of_useraccounts()
returns table
as
return(


select count (*) as [Number of User by Profile type]  from profile  group by profile_type_id 

)
go
