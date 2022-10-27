use car_rental_database;

GO
									-------------admin--------------
create proc[update customer change by admin]
@customerid varchar(100), @activity int, @rep int, @admid varchar(200)
with encryption
as 
BEGIN
	declare @priorvalue varchar(200) = (select activity as VARCHAR from profile where login_id = @customerid)
	declare @priorvaluerep int = (select reputation from customer where login_id = @customerid)
	update profile set activity=@activity where login_id=@customerid
	update customer set reputation=@rep where login_id=@customerid
if @priorvalue != @activity and @activity=0
    insert into [audit] values (@admid, 'you deactivated '+@customerid+''''+'s '+'customer account', getdate())
else if @priorvalue != @activity and @activity=1
    insert into [audit] values (@admid, 'you activated '+@customerid+''''+'s '+'customer account', getdate())

if @priorvaluerep != @rep
    insert into [audit] values
     (@admid, 'you changed reputation of customer - '+@customerid+'  from  '+cast(@priorvaluerep as varchar)+'  to  '+cast(@rep as varchar), GETDATE())
END

GO

create proc [insert cars by admin]
@lp VARCHAR(200), @cname varchar(100), @ctype varchar(100), @ccapacity int,
@cmodel varchar(100), @ccolor VARCHAR(20), @ccondition int, @rep int, @pph Decimal(18,8), @admid varchar(50)
with encryption
as 
BEGIN
declare @cbranch NVARCHAR(100)
select @cbranch = branch_loc from admin where login_id = @admid
insert into cars values (@lp,'verified', @cname, @ctype, @ccapacity, @cmodel, @ccolor,1 ,@ccondition, @rep, @pph, @cbranch, @admid)
insert into [audit] values (@admid, 'you added a new vehicle with license plate  -  '+@lp, GETDATE())
END

GO

create proc [create admin account]
@first_name varchar(50), @last_name varchar(50), @sex varchar(2), @phone varchar(50), @address varchar(100),
@password VARCHAR(100), @branch varchar(100) ,@salary money
AS
BEGIN
declare @id varchar(200) = dbo.[generate admid]()
insert into profile values(@id, @first_name, @last_name, @sex, @phone, @address, @password, 1, 1)
insert into admin VALUES (@id, @salary, @branch)
END

GO

create proc [reset_admin_password]
@admid varchar(100), @newpsw varchar(100)
with encryption
as 
BEGIN
update [profile] set [password]=@newpsw where login_id = @admid
END

GO

create proc [search car for admin]
@attribute varchar(200), @filter varchar(100), @admid varchar(200)
with encryption 
as
begin 
if @filter='none'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') and login_id = @admid 
end

else if @filter='verified'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') and verification='verified' and login_id = @admid
end

else if @filter='unverified'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') and verification='unverified' and login_id = @admid
end

else if @filter='car condition (asc)'
begin
	select * from srch_view where login_id = @admid and (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by car_condition asc
end

else if @filter='car condition (desc)'
begin
	select * from srch_view where login_id = @admid and (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by car_condition desc
end

else if @filter='price (asc)'
begin
	select * from srch_view where login_id = @admid  and (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by price_per_hour asc
end

else if @filter='price (desc)'
begin
	select * from srch_view where login_id = @admid and (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by price_per_hour desc
end
    end

go

create proc [deactivate_admin_account]
@admid varchar(100), @newpsw varchar(100)
with encryption
as 
BEGIN
update [profile] set [activity]=0 where login_id = @admid
END


GO
									-------------audit--------------
create proc [search audit]
@item varchar(1000), @adminid varchar(100) 
with encryption
as 
begin
select task, done_date from [audit] where task LIKE '%'+@item+'%' or done_date LIKE '%'+@item+'%'
end
		
GO
									-------------branch--------------
create proc [get branch stats]
with encryption
AS
BEGIN
select branch_address, branch_vehicles_amount, branch_rating, available_count from branch join 
(select car_branch, count(car_status) as available_count from cars where car_status=1 group by car_status, car_branch) as ftable 
on ftable.car_branch = branch.branch_address order by branch_rating desc
END

GO
									-------------customer--------------


create proc [search customer]
@searchby varchar(100)
with encryption

AS
BEGIN
select login_id, fullname, sex, phone_number, home_address, activity, reputation from
             customer_rep WHERE fullname like '%'+@searchby+'%'
                                or login_id like '%'+@searchby+'%'
                                or phone_number like '%'+@searchby+'%'
                                or home_address like '%'+@searchby+'%'
                                order by fullname

END

go

create procedure [change password]
(
	@cusid varchar(200),
	@oldp varchar(100),
	@newp varchar(100),
	@conp varchar(100),
	@out varchar(100) output
)
with encryption
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
	set @out = @message
end



go
									-------------cars--------------

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
with encryption 
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

GO


create PROC [disable car]
@lp varchar(200)
with encryption
AS
BEGIN
update cars set car_status=0 where license_plate_no=@lp;
END

GO

create PROC [enable car]
@lp varchar(200)
with encryption
AS
BEGIN
update cars set car_status=1 where license_plate_no=@lp;
END

GO
create proc [delete car]
@lp VARCHAR(200)
with encryption
AS
BEGIN
    delete from cars where license_plate_no = @lp
END

go

create proc [vehicle card content] 
@admid varchar(200)
with encryption
AS
begin 
select * from vcc_view where login_id = @admid
END
GO

									-------------car reviews--------------


GO
									-------------profile/renter--------------

create proc [reset_renter_password]
@login_id varchar(200),@new_password  varchar(100)
with encryption
as

begin
Update profile
set password=@new_password
where login_id=@login_id
end

GO
create proc [search renter]
@searchby varchar(100)
with encryption

AS
BEGIN
select login_id, first_name+' '+last_name, sex, phone_number, home_address, activity from
             profile WHERE profile_type_id=3 and first_name+' '+last_name like '%'+@searchby+'%'
                                or login_id like '%'+@searchby+'%'
                                or phone_number like '%'+@searchby+'%'
                                or home_address like '%'+@searchby+'%'
                                order by first_name+' '+last_name

END

go


CREATE PROCEDURE Insert_Profile
    @login_id  varchar(200),
    @first_name varchar(100), 
    @last_name varchar(100),
    @sex varchar(2),
    @phone_number varchar(100), 
    @home_address varchar(100), 
    @password varchar(100) ,
    @profile_type_id int,
	@Activity int
	with encryption
as
begin
insert into profile(login_id, first_name, last_name, sex, phone_number, home_address, [password], profile_type_id,activity)
                           values (@login_id,@first_name,@last_name,@sex,@phone_number,@home_address,@password ,@profile_type_id,@Activity )
end


go

create proc Edit_renter_Account @First_Name varchar(100),@Last_Name varchar(100),@phone varchar(100),@homeaddress varchar(100),@sex varchar(3),@currentuserid varchar(200)
with encryption
as
begin
update profile
set first_name=@First_Name,
last_name=@Last_Name,
sex=@sex,
phone_number=@phone,
home_address=@homeaddress
where login_id=@currentuserid
end

go

create proc [disable renter]
@rid varchar(200)
AS
BEGIN
update profile set activity = 0 where login_id = @rid
END

go

create proc deactivate_renter_account
@renterid varchar(100)
with encryption
as 
BEGIN
update [profile] set [activity]=0 where login_id = @renterid
END

go

create proc get_renter_for_admin 
with encryption 
AS
BEGIN
select login_id, first_name, last_name, sex, phone_number, home_address, activity from
profile where profile_type_id = 3
END											----------profile type----------

											----------rented cars----------
											
											----------rental----------



