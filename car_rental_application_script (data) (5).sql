use car_rental_database;

go

insert into branch values ('summit', 0, null), ('cmc', 0, null), ('hayat', 0, null)

insert into profile_type values(1, 'admin'),
                               (2, 'customer'),
                               (3, 'renter')
                               
insert into profile(login_id, first_name, last_name, sex, phone_number, home_address, [password], profile_type_id)
                           values
                           ('adm12', 'Abebe', 'Bekele', 'M', '09001000', 'hayat', '2222',1),
                           ('rntr10', 'Nathnael', 'lastname', 'M', '097426534', 'hayat', '0000',3),
                           ('adm10', 'Barnabas', 'Solomon', 'M', '09093664', 'cmc', '2222',1)

insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                            values ('cus21', 'Ruth', 'Solomon', 'F', '09789786', 'cmc', '2222',2)
 insert into profile(login_id, first_name, last_name, [sex], phone_number, home_address, [password], profile_type_id)
                            values('cus10', 'Nathan', 'Dawit', 'M', '092355534', 'summit', '1111',2)
						   
insert into admin values('adm12', 10000, 'hayat'),
                        ('adm10', 10000, 'cmc')

insert into payment values(1, 'credit card'),
                           (2, 'bank transfer')

