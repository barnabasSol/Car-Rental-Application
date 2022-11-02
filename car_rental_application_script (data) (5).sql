use car_rental_database;

go

--delete from admin
--delete from customer
--delete from payment
--delete from cars

--delete from branch
--delete from profile
--delete from profile_type
delete from rental
delete from payment
insert into payment values (1, 'credit card'), (2, 'bank transfer')
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
                            values ([dbo].[generate admid](), 'Barnabas', 'Solomon', 'M', '0974276534', 'cmc', '0000',1)
insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                            values ([dbo].[generate admid](), 'Markos', 'Kidane', 'M', '0909090909', 'hayat', '1111',1)

insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                            values ([dbo].[generate admid](), 'Abebe', 'Beso', 'M', '0934949422', 'summit', '2222',1)

insert into admin values('a0001', 10000, 'cmc'),
                        ('a0002', 10000, 'hayat'),
                        ('a0003', 10000, 'summit')

insert into payment values(1, 'credit card'),
                           (2, 'bank transfer')

------Nati--------------------------------------------------------------------------

insert into cars values('1111','unverified', 'Toyota', 'Sedan', 4, 'Camri', 'Red', 1, 10, 4, 10.0, 'cmc', 'rntr11')
insert into cars values('2222','verified', 'Toyota', 'Sedan', 4, 'Vitz', 'Blue', 1, 10, 4, 20.0, 'summit', 'rntr12')
insert into cars values('3333','verified', 'Ford', 'Truck', 4, 'F150', 'Violet', 1, 10, 4, 40.0, 'hayat', 'rntr13')

insert into cars values('4444','verified', 'Toyota', 'Sedan', 4, 'Camri', 'Green', 1, 10, 4, 10.0, 'cmc', 'rntr11')
insert into cars values('5555','verified', 'Toyota', 'Sedan', 4, 'Vitz', 'White', 1, 10, 4, 20.0, 'summit', 'rntr12')
insert into cars values('6666','verified', 'Ford', 'Truck', 4, 'F150', 'Black', 1, 10, 4, 40.0, 'hayat', 'rntr13')

insert into cars values('7777','verified', 'Toyota', 'Sedan', 4, 'Camri', 'Yellow', 1, 10, 4, 10.0, 'cmc', 'rntr11')
insert into cars values('8888','verified', 'Toyota', 'Sedan', 4, 'Vitz', 'Orange', 1, 10, 4, 20.0, 'summit', 'rntr12')
insert into cars values('9999','verified', 'Ford', 'Truck', 4, 'F150', 'Pink', 1, 10, 4, 40.0, 'hayat', 'rntr13')

d

