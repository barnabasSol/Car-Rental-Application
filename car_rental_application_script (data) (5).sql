use car_rental_database;

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


insert into admin values('adm12', 10000, 'hayat'),
                        ('adm10', 10000, 'cmc')

insert into payment values(1, 'credit card'),
                           (2, 'bank transfer')


-- NATE ----------------------------------------------------------------------
insert into customer values ('cus10', 5)
insert into customer values ('cus21', 2)

insert into cars values ('0001', 'verified', 'toyota', 'coupe', 4, 'vitz', 'blue', 0, 0, 5, 10.0, null, null)
insert into cars values ('0002', 'unverified', 'nissan', 'coupe', 4, 'almera', 'red', 0, 0, 5, 10.0, null, null)
insert into cars values ('0003', 'verified', 'toyota', 'coupe', 4, 'vitz', 'blue', 0, 0, 2, 10.0, null, null)
insert into cars values ('0004', 'unverified', 'nissan', 'coupe', 4, 'almera', 'red', 0, 0, 5, 10.0, null, null)
insert into cars values ('0005', 'verified', 'toyota', 'coupe', 4, 'vitz', 'blue', 0, 0, 8, 10.0, null, null)
insert into cars values ('0006', 'unverified', 'nissan', 'coupe', 4, 'almera', 'red', 0, 0, 5, 10.0, null, null)

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


insert into  rented_cars (r_id,license_plate_no) values(1,'55555')

insert into  rented_cars (r_id,license_plate_no) values(2,'11111')

insert into  rented_cars (r_id,license_plate_no) values(3,'33333')

insert into  rented_cars (r_id,license_plate_no) values(4,'44444')

insert into  rented_cars (r_id,license_plate_no) values(5,'66666')

insert into  rented_cars (r_id,license_plate_no) values(6,'11111')

insert into  rented_cars (r_id,license_plate_no) values(7,'22222')








