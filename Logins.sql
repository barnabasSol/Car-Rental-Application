
/* 1) Created Login to Access the server
	2) Created User on the car rental database
	3) Created a role to group the user 
	4) granted specific permission to the roles*/



/*
To do list:-
Step 1:Execute "create Login SuperAdmin with password='Super'"  this  Query 
step 2: check if sql server and windows authentication is on
step 3: go to services then restart sql sever
step 4: execute the script begining from use car rental database


Note:
then To make SuperAdmin sysAdmin go to security=>Logins => SuperAdmin => properties => ServerRoles => SysAdmin
*/


create Login Car_RentalAdmin with password='Super'

use car_rental_database

/* Logins,user, and roles for the renter       */

create Login Renter with password='Renter'

create user user_renter for login Renter

CREATE ROLE renters 
EXEC sp_addrolemember 'renters ' , 'user_renter'

/* Logins,user, and roles for the customer        */
create Login Customer with password='Customer'

create user user_customer for login Customer

CREATE ROLE Customers
EXEC sp_addrolemember 'Customers' , 'user_customer'

--grant permission for the renters role
Grant SELECT  ON cars TO renters

grant insert on cars to
renters

grant select on rented_cars to renters

grant select on rental to renters

grant select on branch to renters


--grant permission for customer role 
grant select on customer to customers
grant select on payment to customers
grant select on rental to customers
grant select on cars to customers
