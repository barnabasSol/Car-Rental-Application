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
