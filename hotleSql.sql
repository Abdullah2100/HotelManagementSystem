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