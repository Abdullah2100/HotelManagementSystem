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
belongTo int references Customers(customerID), 
identityID int references Identities(identityID),
isBlock bit default 0
)



go
create view Department_view as 
select  
d.departmentID,
d.name,
(select count(*) from Employees where departmentID = d.departmentID)as employeeNumber
from Departments d

go

create view Employee_view as 
select 
e.employeeID ,
e.personID,
d.name as department,
e.userName ,
(p.firstName + '  '+p.lastName) as fullName,
Year(getdate())-Year(p.brithDay) as age,

p.createdDate,

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





create table Customer(
customerID int identity(1,1) primary key,
userName  nvarchar(50) null,
password  nvarchar(max)null,
familyRelationID  int references FamilyRelations(familyRelationID ),
personID int references Peoples(personID),
addBy int references Employees(employeeID),
)



go
create view Customer_view as 
select 
c.customerID,
c.personID,
CONCAT(p.firstName,p.lastName,' ') as fullName,
case 
when c.belongTo is null then 'none'
else
(select CONCAT(firstName,lastName,'  ') from Peoples where personID =dbo.getCustomerPersonID(c.belongTo) ) 
end as belongToName,
case 
when c.belongTo is null then 0
else c.belongTo 
end  as belongID,
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

select firstName,lastName  from Peoples where personID =22
select * from Peoples





create PROCEDURE  SP_deletEmployeeByID
    @personID int

as 
BEGIN
    

as     

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
     




create PROCEDURE  SP_deletEmployeeByPHone
    @phone nvarchar
as 
BEGIN
     Declare  @personID int;
     select @personID = personID from Employees where phone = @phone;

begin transaction;

begin try
     delete from Employees where employeeID = @phone;
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
     return 0;
end;



select * from Employee_view


select * from Employees
select * from Peoples

delete Employees;
delete Peoples;


exec SP_deletEmployeeByID @personID =20

create function dbo.getCustomerPersonID(@customerId int)returns int
as 
  begin
  declare @personID int;
  select @personID = personID from Customers where customerID = @customerId;
  return @personID
  end




update Customer  set 
addBy = @addBy,
familyRelationID = @familyRelationID,
identityID = @identityID,
personID = @personID
where customerID = @customerID
values (addBy,familyRelationID,identityID,personID);
select SCOPE_IDENTITY();

