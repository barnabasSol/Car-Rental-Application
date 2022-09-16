-- create database todelete

-- GO

-- use todelete 

-- GO



-- -- if not exists (select T.name from sys.tables T where T.name = 'names')
-- --     print 'doesnt exist'
-- -- ELSE
-- --     print 'it exists'

-- -- if exists(select T.name from sys.tables T where T.name = 'names')
-- --     print 'it exists'

-- go

-- -- declare @x int = 20
-- -- print
-- -- case @x%2
-- --     when 0 then  'it is even'
-- --     when 1 then  'it is odd'
-- --     else  'idk'
-- --     end

-- go

-- declare @name varchar(50)='tenet'
-- print stuff(@name, 1, 3, 'bag')

-- GO

-- alter proc p1 (@param1 int output, @param2 int = null, @param3 int = 0)
-- AS
-- BEGIN
-- set @param1 = @param2+@param3
-- END
-- declare @getvalue int 

-- exec p1 @getvalue OUTPUT, 2, 3

-- print @getvalue
-- go
-- create trigger tr_undo 
-- on names 
-- for insert 
-- as 
-- ROLLBACK TRANSACTION
-- drop trigger tr_undo 

GO

declare @errorValue INT
declare @num1 int = 5
declare @num2 int = 10
begin TRANSACTION

set @num1+=5
set @errorValue = @@ERROR
if @errorValue>0
    ROLLBACK TRANSACTION
set @num2-=5
set @errorValue = @@ERROR
if @errorValue>0
    ROLLBACK TRANSACTION

COMMIT TRANSACTION

select * from names

BACKUP database todelete to disk = 'C:\Users\Barnabas Solomon\OneDrive\Desktop\backup\todelete.bak' with differential

use todelete

use master
RESTORE database todelete from disk = 'C:\Users\Barnabas Solomon\OneDrive\Desktop\backup\todelete.bak' 
select * from NAMES


use todelete

select * from names

insert into names values ('.jsfl', 's.khbf')