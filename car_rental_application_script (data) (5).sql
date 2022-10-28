use car_rental_database;

go

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


insert into admin values('adm12', 10000, 'hayat'),
                        ('adm10', 10000, 'cmc')

insert into payment values(1, 'credit card'),
                           (2, 'bank transfer')


-- NATE ----------------------------------------------------------------------
insert into customer values ('cus10', 5)
insert into customer values ('cus21', 2)


------Nati--------------------------------------------------------------------------

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




