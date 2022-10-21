use car_rental_database;


GO

 create trigger [set customer rep trigger]
 on profile 
 for insert 
 as 
 begin
 declare @cusid varchar(100)
 set @cusid = (select login_id from inserted)
 if exists (select profile_type_id from inserted where profile_type_id=2)
         insert into customer(login_id) values (@cusid)
 END

GO

------triggers to keep track of the stats of the brances
create trigger [update branch stats of added vehicles] on cars
for insert 
as 
begin
declare @admid varchar(200)
declare @lp varchar(50)
declare @temptb table (
	 tempid int IDENTITY,
	 lp varchar(200), 
     ver varchar(20),
     car_name varchar(100), 
     car_type varchar(100),
     car_capacity int,
     car_model varchar(100),
     car_color varchar(50),
     car_status TINYINT,
     car_condition int, /*new column*/
     rep_min_req int,
     price_per_hour Decimal(18, 2),
     car_branch nvarchar(100), 
     login_id varchar(200)
 )
 insert @temptb (lp, ver, car_name, car_type, car_capacity, car_model, car_color, car_status, car_condition, rep_min_req, price_per_hour, car_branch, login_id)
 select * from inserted
 declare @newamnt int
 declare @i int = 1
 while  @i <= (select top 1 tempid from @temptb order by tempid DESC)
	BEGIN
	 set @newamnt = (select COUNT(*) from @temptb where car_branch = (select car_branch from @temptb where tempid=@i))
	 update branch set branch_vehicles_amount += @newamnt where branch_address = (select car_branch from @temptb where tempid=@i)
	 set @admid = (select login_id from @temptb where tempid=@i)
	 set @lp = (select lp from @temptb where tempid=@i)
	 if exists (select login_id from profile where profile_type_id=1 and login_id = @admid)
	 	insert into [audit] values (@admid, 'you added a vehicle with license plate  -  '+@lp, GETDATE())
	 set @i += 1
	END
END


GO

create trigger [update branch stats of deleted vehicles tr]
on cars 
for delete 
AS
BEGIN
declare @admid varchar(200)
declare @lp varchar(50)
declare @temptb table (
	 tempid int IDENTITY,
	 lp varchar(200), 
     ver varchar(20),
     car_name varchar(100), 
     car_type varchar(100),
     car_capacity int,
     car_model varchar(100),
     car_color varchar(50),
     car_status TINYINT,
     car_condition int, /*new column*/
     rep_min_req int,
     price_per_hour Decimal(18, 2),
     car_branch nvarchar(100), 
     login_id varchar(200)
 )
 insert @temptb (lp, ver, car_name, car_type, car_capacity, car_model, car_color, car_status, car_condition, rep_min_req, price_per_hour, car_branch, login_id)
 select * from deleted
 declare @newamnt int
 declare @i int = 1
 while  @i <= (select top 1 tempid from @temptb order by tempid DESC)
	BEGIN
	 set @newamnt = (select COUNT(*) from @temptb where car_branch = (select car_branch from @temptb where tempid=@i))
	 update branch set branch_vehicles_amount -= @newamnt where branch_address = (select car_branch from @temptb where tempid=@i)
	 set @admid = (select login_id from @temptb where tempid=@i)
	 set @lp = (select lp from @temptb where tempid=@i)
	 if exists (select login_id from profile where profile_type_id=1 and login_id = @admid)
	 	insert into [audit] values (@admid, 'you deleted a vehicle with license plate  -  '+@lp, GETDATE())
	 set @i += 1
	END
END

GO

create trigger [update reviews on branches] on car_reviews
for insert 
AS
BEGIN
declare @branch nvarchar(100)
declare @newrating Decimal(18, 2)
declare @temp_table table(
		average_rating Decimal(18,8),
		b_location nvarchar(100)
)
declare cur_branches cursor 
for select branch_address from branch
open cur_branches
fetch next from cur_branches into @branch
insert @temp_table
	select avg(car_reviews.car_rating) as avgrating, rental.branch_loc as [location] from
	rental join car_reviews on rental.rent_id = car_reviews.rent_id where branch_loc=@branch group by branch_loc
while @@FETCH_STATUS=0
	begin
		set @newrating = (select average_rating from @temp_table)
		update branch set branch_rating = @newrating where branch_address=@branch
		fetch next from cur_branches into @branch
		delete from @temp_table
		insert @temp_table
			select avg(car_reviews.car_rating) as avgrating, rental.branch_loc as [location] from
			rental join car_reviews on rental.rent_id = car_reviews.rent_id where branch_loc=@branch group by branch_loc
	end
	close cur_branches
	deallocate cur_branches
END
