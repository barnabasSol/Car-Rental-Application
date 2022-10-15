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
