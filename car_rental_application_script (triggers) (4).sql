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
create trigger [update branch stats] on cars
for insert 
as 
begin
declare @branch varchar(200)
set @branch = (select car_branch FROM inserted)
update branch set branch_vehicles_amount+=1 where branch_address=@branch
end

GO

create trigger [update branch stats of deleted vehicles tr]
on cars 
for delete 
AS
BEGIN
declare @admid varchar(200) = (select login_id from deleted)
declare @lp varchar(50) = (select license_plate_no from deleted)
declare @branchloc nvarchar(100) = (select car_branch from deleted)
update branch set branch_vehicles_amount-=1 where branch_address=@branchloc
insert into [audit] values (@admid, 'you deleted a vehicle with license plate  -  '+@lp, GETDATE())
END

GO

create trigger [limit deleting vehicles]
on cars 
for delete
AS
BEGIN
declare @amount int = (select COUNT(*) from deleted)
if @amount>1
    ROLLBACK TRANSACTION
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