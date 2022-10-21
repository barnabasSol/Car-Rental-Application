use car_rental_database;

GO

----customer proc------
create proc[update customer change by admin]
@customerid varchar(100), @activity int, @rep int, @admid varchar(200)
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

create proc [search customer]
@searchby varchar(100)
AS
BEGIN
select login_id, fullname, sex, phone_number, home_address, activity, reputation from
             customer_rep WHERE fullname like '%'+@searchby+'%'
                                or login_id like '%'+@searchby+'%'
                                or phone_number like '%'+@searchby+'%'
                                or home_address like '%'+@searchby+'%'
                                order by fullname

END

----customer proc------

GO


create proc [insert cars by admin]
@lp VARCHAR(200), @cname varchar(100), @ctype varchar(100), @ccapacity int,
@cmodel varchar(100), @ccolor VARCHAR(20), @ccondition int, @rep int, @pph Decimal(18,8), @admid varchar(50) 
as 
BEGIN
declare @cbranch NVARCHAR(100)
select @cbranch = branch_loc from admin where login_id = @admid
insert into cars values (@lp,'verified', @cname, @ctype, @ccapacity, @cmodel, @ccolor,1 ,@ccondition, @rep, @pph, @cbranch, @admid)
END

GO

create proc [search audit]
@item varchar(1000), @adminid varchar(100) 
as 
begin
select task, done_date from [audit] where task LIKE '%'+@item+'%' or done_date LIKE '%'+@item+'%'
end

GO

create proc [reset_admin_password]
@admid varchar(100), @newpsw varchar(100)
as 
BEGIN
update [profile] set [password]=@newpsw where login_id = @admid
END

GO

create proc [get branch stats]
AS
BEGIN
select branch_address, branch_vehicles_amount, branch_rating, available_count from branch join 
(select car_branch, count(car_status) as available_count from cars where car_status=1 group by car_status, car_branch) as ftable 
on ftable.car_branch = branch.branch_address order by branch_rating desc
END

go

create proc [search car for admin]
@attribute varchar(200), @filter varchar(100), @admid varchar(200)
as
begin 
declare @admloc varchar(200) = (select branch_loc from admin where login_id=@admid)
if @filter='none'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') and car_branch = @admloc 
end

else if @filter='verified'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') and verification='verified' and car_branch = @admloc 
end

else if @filter='unverified'
begin
	select * from srch_view where (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') and verification='unverified' and car_branch = @admloc 
end

else if @filter='car condition (asc)'
begin
	select * from srch_view where car_branch = @admloc  and (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by car_condition asc
end

else if @filter='car condition (desc)'
begin
	select * from srch_view where car_branch = @admloc and (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by car_condition desc
end

else if @filter='price (asc)'
begin
	select * from srch_view where car_branch = @admloc and (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by price_per_hour asc
end

else if @filter='price (desc)'
begin
	select * from srch_view where car_branch = @admloc and (license_plate_no like '%'+@attribute+'%' or car_name like '%'+@attribute+'%' or
	car_type like '%'+@attribute+'%' or c_login_id like '%'+@attribute+'%') order by price_per_hour desc
end
    end

GO

create PROC [disable car]
@lp varchar(200)
AS
BEGIN
update cars set car_status=0 where license_plate_no=@lp;
END

GO

create PROC [enable car]
@lp varchar(200)
AS
BEGIN
update cars set car_status=1 where license_plate_no=@lp;
END

GO

create proc [delete car]
@lp VARCHAR(200)
AS
BEGIN
    delete from cars where license_plate_no = @lp
END

go

create proc [vehicle card content] 
@admid varchar(200)
AS
begin 
declare @adm_branch varchar(200) = (select branch_loc from admin where login_id=@admid) 
select * from vcc_view where car_branch = @adm_branch
END

GO

create proc [reset_renter_password]
@login_id varchar(200),@new_password  varchar(100)
as
begin
Update profile
set password=@new_password
where login_id=@login_id
end

GO

create PROC [undo added vehicle]
@lp VARCHAR(200)
AS
BEGIN
DELETE from cars where license_plate_no=@lp
END

go

create proc [deactivate_admin_account]
@admid varchar(100), @newpsw varchar(100)
as 
BEGIN
update [profile] set [activity]=0 where login_id = @admid
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
as
begin
insert into profile(login_id, first_name, last_name, sex, phone_number, home_address, [password], profile_type_id,activity)
                           values (@login_id,@first_name,@last_name,@sex,@phone_number,@home_address,@password ,@profile_type_id,@Activity )
end





