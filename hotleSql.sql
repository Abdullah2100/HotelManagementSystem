create database HotelDB;

go
use HotelDB



create table Peoples(
personID int identity(1,1) primary key, 
firstName nvarchar(20) not null,
lastName nvarchar(20) not null ,
brithDay DateTime not null,
createdDate Datetime default getDate(),
nationalNo nvarchar(15) not null
)


create table Departments(
departmentID int identity(1,1) primary key,
name  nvarchar(50) 
)



create table Employees(
employeeID int identity(1,1) primary key,
userName  nvarchar(50) null,
password  nvarchar(max)null,
departmentID int references Departments(departmentID),
personID int references Peoples(personID),
address nvarchar(200),
phone nvarchar(15) UNIQUE,
image nvarchar(max) not null,
isBlock bit default 0
)





create table FamilyRelations(
familyRelationID int identity(1,1)primary key,
name nvarchar(50)
)

create table Identities(
identityID int identity(1,1) primary key,
name nvarchar(50)
)


create table Customers(
customerID int identity(1,1) primary key,
familyRelationID  int references FamilyRelations(familyRelationID ),
personID int references Peoples(personID),
addBy int references Employees(employeeID),
identityID int references Identities(identityID),
isBlock bit default 0
)

create table RoomTypes(
roomTypeID int identity(1,1) primary key,
name  nvarchar(50) 
)

create table Rooms(
roomID int identity(1,1) primary key,
roomTypeID int references RoomTypes(roomTypeID),
capacity tinyint not null,
bedNumber tinyint not null,
pricePerDay float not null,
state tinyint not null,
addBy int references Employees(employeeID),
createdDate Datetime default getDate(),
floorNumber smallint not null 
)

create function dbo.getEmployeeNameByPersonID(@personID int)returns nvarchar(max)
as 
  begin
  if @personID = 0
    BEGIN
     return 'none';
    END
  declare @FullName nvarchar(max);
  select @FullName = concat( firstName ,lastName, ' ') from Peoples where personID = @personID;
  return @FullName
  end


create function dbo.getEmployeeNameByID(@ID int)returns nvarchar(max)
as 
  begin
  if @ID = 0 or @ID is null
    BEGIN
     return 'none';
    END
  declare @FullName nvarchar(max);
  select @FullName = concat( p.firstName ,p.lastName, ' ') from Peoples p inner join Employees e on e.personID = p.personID and e.employeeID = @ID;
  return @FullName
  end

create view  room_view as 
select 
r.roomID ,
(select name from RoomTypes where roomTypeID = r.roomTypeID) as roomType,
r.capacity ,
r.bedNumber ,
r.pricePerDay , 
case 
when  r.state =0 then 'None'
when  r.state =1 then 'is booking'
when  r.state = 2 then 'is Cleaning'
else 'out of services'
end as state,
r.createdDate,
dbo.getEmployeeNameByID(addBy) as addBy
from Rooms r



create function dbo.calculateEmployeeNumberInDepartment(@departmentID int)returns INT
as 
  begin
  declare @employeeNumber int;
  select @employeeNumber = (select count(*) from Employees where departmentID =@departmentID)
  return @employeeNumber
  end

go
create view Department_view as 
select  
departmentID,
name,
dbo.calculateEmployeeNumberInDepartment(departmentID)as employeeNumber
from Departments


go
create view Employee_view as 
select 
e.employeeID ,
e.personID,
d.name as department,
e.userName ,
dbo.getEmployeeNameByPersonID(e.personID) as fullName,
Year(getdate())-Year(p.brithDay) as age,
cast (p.createdDate as nvarchar) as createdDate,
e.isBlock
from Employees e 
inner join Departments d
on e.departmentID = d.departmentID
inner join Peoples p 
on p.personID = e.personID;





create table FamilyRelations(
familyRelationID int identity(1,1)primary key,
name nvarchar(50)
)






go
create function dbo.getCustomerPersonID(@customerId int)returns int
as 
  begin
  if @customerId is null
    begin 
	 return 0;
	end
  declare @personID int;
  select @personID = personID from Customers where customerID = @customerId;
  return @personID
  end


go

create view Customer_view as 
select 
c.customerID,
c.personID,
dbo.getEmployeeNameByPersonID(c.personID) as fullName,
fr.name as relationShip,
i.name as kindOfIdentity,
c.isBlock,
p.createdDate as addDate,
case 
when c.addBy is null then 0
else c.addBy 
end as createdBy
from Customers c
inner join FamilyRelations fr 
on c.familyRelationID = fr.familyRelationID
inner join Identities i 
on c.identityID = i.identityID
inner join Peoples p
on c.personID = p.personID







create PROCEDURE  SP_deletEmployeeByID
    @personID int
as 
BEGIN
begin transaction;
begin try
     delete from Employees where personID = @personID;
     print'complate emplyee delete';
	 delete from Peoples where personID = @personID;
     commit;
	 --//return 1;
end try
BEGIN catch
     print'hasError';

     ROLLBACK;
     DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
     DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
     DECLARE @ErrorState INT = ERROR_STATE();
	 Throw @ErrorMessage, @ErrorSeverity, @ErrorState;
END catch;

end;
   -- // return 0;



create PROCEDURE  SP_deleteCustomer
    @personID int
as     
begin transaction;
begin try
     declare @id int;
	 set @id = 0;
	 select @id = customerID from Customers where personID = @personID;
	 delete from Customer where belongTo = @id;
	 delete from Customer where customerID = @id;
	 delete from Peoples where personID = @personID;
     commit;
	 return 1;
end try
BEGIN catch
     ROLLBACK;
     DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
     DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
     DECLARE @ErrorState INT = ERROR_STATE();
	 Throw @ErrorMessage, @ErrorSeverity, @ErrorState;
END catch;
     





create table Bookings(
bookingID int identity (1,1) primary key,
customerID int references Customers(customerID),
roomID int references Rooms(roomID),
addDate datetime default getdate(),
outDate DATETIME  null,
realDayOut DateTime null,
totalPrice DECIMAL(19,4) not null ,
firstPayment DECIMAL(19,4) not null,
reminderPayment DECIMAL(19,4)  not null,
adionalPayment DECIMAL(19,4) null,
isAvilable bit default 1,
addBy int references Employees(employeeID),
belongToBooking int references Bookings(bookingID),
)



create view booking_view as 
select 
b.bookingID,
b.customerID,
CONCAT(p.firstName,p.lastName , '  ') as fullName ,
fr.name as  relationShipe,
i.name as identityName,
p.nationalNo ,
YEAR(getdate())-YEAR(p.brithDay) as age,
b.isAvilable 
from Bookings b
inner join Customers c
on b.customerID = c.customerID
inner join FamilyRelations fr 
on fr.familyRelationID = c.familyRelationID
inner join Identities i 
on c.identityID = i.identityID
inner join Peoples p 
on c.personID = p.personID 
where b.belongToBooking is null




create function dbo.getbooking_by_belong (@BlongID int)returns table 
as 
return (select 
b.bookingID,
b.customerID,
CONCAT(p.firstName,p.lastName , '  ') as fullName ,
fr.name as  relationShipe,
i.name as identityName,
p.nationalNo ,
YEAR(getdate())-YEAR(p.brithDay) as age,
b.isAvilable 
from Bookings b
inner join Customers c
on b.customerID = c.customerID
inner join FamilyRelations fr 
on fr.familyRelationID = c.familyRelationID
inner join Identities i 
on c.identityID = i.identityID
inner join Peoples p 
on c.personID = p.personID 
)



CREATE PROCEDURE SP_joinCustomerToBooking
(
    @CustomerID INT,
    @BookingID INT,
    @AddBy INT
)

AS
BEGIN

    declare @Result int;
    insert  INTO Bookings
    (
        customerID,
        roomID,
        addDate,
        outDate,
        realDayOut,
        totalPrice,
        firstPayment,
        reminderPayment,
        adionalPayment,
        isAvilable,
        addBy,
        belongToBooking
    )
    SELECT
        @CustomerID,
        roomID,
        addDate, 
        outDate,
        realDayOut,
        totalPrice,
        firstPayment,
        reminderPayment,
        adionalPayment,
        isAvilable, 
         @AddBy,
        @bookingID 
    FROM Bookings
    WHERE bookingID = @BookingID; 
    SET @Result = @@ROWCOUNT;
	if @Result>0
	   begin
	     select SCOPE_IDENTITY();
	   end
    else
	  throw 10,'could not join Booking',1
END;


