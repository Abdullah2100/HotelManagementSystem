create database HotelDB;

 go

use HotelDB

go

create table Peoples(
personID int identity(1,1) primary key, 
firstName nvarchar(20) not null,
lastName nvarchar(20) not null ,
brithDay DateTime not null,
createdDate Datetime default getDate(),
isBlock bit default 0)


create table EmployeeTypes(
employeeTypeID int identity(1,1) primary key,
name  nvarchar(50) 
)


create table Employees(
employeeID int identity(1,1) primary key,
userName  nvarchar(50) null,
password  nvarchar(max)null,
employeeTypeID int references EmployeeTypes(employeeTypeID),
personID int references Peoples(personID),
address nvarchar(max),
phone nvarchar(15) UNIQUE,
isBlock bit default 0
)



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



create view EmployeeType_view as 
select  
et.employeeTypeID,
et.name,
(select count(*) from Employees where employeeTypeID = et.employeeTypeID)as employeeNumber
from EmployeeTypes et




create PROCEDURE  SP_deletEmployeeByID
    @employeeID int
as 
BEGIN
     Declare  @personID int;
     select @personID = personID from Employees where employeeID = @employeeID;

begin transaction;

begin try
     delete from Employees where employeeID = @employeeID;
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


create view Employee_view as 
select 
e.employeeID ,
e.personID,
et.name as 'job title',
e.userName ,
(p.firstName + '  '+p.lastName) as fullName,
Year(p.brithDay)-Year(getdate()) as age,
p.createdDate,
p.isBlock
from Employees e 
inner join EmployeeTypes et
on e.employeeTypeID = et.employeeTypeID
inner join Peoples p 
on p.personID = e.personID
where p.isBlock != 0;


