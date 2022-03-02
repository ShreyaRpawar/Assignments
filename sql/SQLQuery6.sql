Create Database Assignment16


create table Employee
(
  Empno int Primary Key,
  Empname varchar(100) not null,
  Salary int not null ,
  Designation varChar(100),
  Deptno int not null references department (Deptno),
  Email varchar(100) not null
);
--drop table Employee
insert into Employee Values
(
  101, 'Shreya', 30000,'Manager', 10 ,'shreya@gmail.com'
);
insert into Employee Values
(
  102, 'Annu', 40000,'intern', 20 ,'Annu@gmail.com'
);
insert into Employee Values
(
  103, 'Sam', 350000,'engineer', 30,'Sam@gmail.com'
);
insert into Employee Values
(
  104, 'Ankita', 50000,'CEO',40,'Ankita@gmail.com'
);
insert into Employee Values
(
  105, 'Ankit', 430000,'	Manager', 10,'Ankit@gmail.com'
);
insert into Employee Values
(
  106, 'Shyam', 530000,'intern', 20,'Shyam@gmail.com'
);
insert into Employee Values
(
  107, 'Sid', 68000,'engineer', 30,'Sid@gmail.com'
);
insert into Employee Values
(
 108 , 'Zoya', 530000,'Manager', 10,'Zoya@gmail.com'
);

select *from Employee


--1.Select Second Max Salary Per DeptNo
select DeptNo, max(salary) as Salary  from Employee  where Salary < (Select max(Salary) from Employee ) Group by DeptNo;

--2.Select Max salary for each designation
select Designation, Max(salary) as Salary from Employee Group by Designation;

--3. Select Second Max Salary for Each Designation
select Designation, max(salary) as Salary  from Employee  where Salary < (Select max(Salary) from Employee ) Group by Designation;

go
Create procedure spadd_data
@Empno int ,@Empname varChar(100), @Salary int , @DeptName varChar(100), @Deptno int
AS
BEGIN

insert into Employee(Empno , Empname , Salary , Designation , Deptno)
Values (@Empno ,@Empname,@Salary,@DeptName, @Deptno);

END;
GO
-- 
Exec spadd_data @Empno=100 , @Empname ='Mayur',@Salary=6000, @DeptName='IT',@Deptno=10;
Go
--drop procedure spadd_data;


------------------------------------------
Create table department 
(Deptno int primary key,
Deptname varChar(100) not null,
Location varChar(100),
Capacity int not null
);
--drop table department ;

insert into department values (
10,'IT', 'Pune',100
);
insert into department values (
20,'SL', 'Mumbai',200
);
insert into department values (
30,'HR', 'Delhi',300
);
insert into department values (
40,'AC','Chennai',400
);
 
 select *from department

 --5.Create Strore Proc (SP) that will return Max Salary per DeptName
--Use Group By
Go
create proc sp_MaxSalaryByDeptName_1
as
Begin
    select DeptName, Max(Salary) as Salary
from Employee, Department -- Join
Where Employee.DeptNo = Department.DeptNo
Group by (Department.DeptName) -- Group By
Order By DeptName Desc -- Order by
end;
exec sp_MaxSalaryByDeptName_1;
Go

--drop procedure sp_MaxSalaryByDeptName_1
-------------------------------------

--Create a Stored Provcedure that will perform an Insert Operation on Employee Table.
--But before Performing the insert operation, this SP Must call the ValidateData()
--function which will accept the Employee Row parameters and vbalidate it based on following conditions
--EmpNo Must be +ve integer
--EmpName Must containing Characters
--Salary Must be +Ve integer
--DeptNo Muset be present into Department table (Optional) The alidateData() function will return 0 is any of the record-value is invalid else will return 1. The SP will perform insert operation accordingly
create function  ValidateEmployeeDataNew
(@EmpNo int, @salary int)
returns int
as
begin
            declare @result int
			if @EmpNo<=0 OR @salary<=0 
			     set @result =0;
		   
			Else
			    set @result=1;
				return @result;
End;
GO
--drop function ValidateEmployeeData_2;
---------------------------------------------------------------------------------------------------------------------------------
create proc sp_InsertEmployeeDataNew
(@EmpNo int, @EmpName varchar (200), @salary int, @Designation varchar (200), @DeptNo int,@Email varchar (100))
As
Begin
     if dbo.ValidateEmployeeDataNew(@EmpNo, @salary)=0
	    select 'Enter data is in invalid format';
	else
	     Insert into Employee(EmpNo, EmpName, salary, Designation, DeptNo,Email)
		Values
			(@EmpNo, @EmpName, @salary, @Designation, @DeptNo , @Email )
End;
Exec sp_InsertEmployeeDataNew @EmpNo=109, @EmpName='Manoj', @salary=16000, @Designation=Engineer, @DeptNo=30,@Email ='Manoj@gmail.com';
Exec sp_InsertEmployeeDataNew @EmpNo=-110, @EmpName='Ashish', @salary=14000, @Designation=intern, @DeptNo=20 ,@Email ='Ashish@gmail.com';
Exec sp_InsertEmployeeDataNew @EmpNo=120, @EmpName='Kiran', @salary=11000, @Designation=Engineer, @DeptNo=30,@Email ='Kiran@gmail.com';
Exec sp_InsertEmployeeDataNew @EmpNo=130, @EmpName='Rajendra', @salary=18000,@Designation=Manager, @DeptNo=10,@Email ='Rajendra@gmail.com';
Exec sp_InsertEmployeeDataNew @EmpNo=140, @EmpName='Laxman', @salary=30000, @Designation=CEO,  @DeptNo=40,@Email ='Laxman@gmail.com';
Go
----------------------------------------------------------------------------------------------------------------------------------------
select *from employee
delete from employee where EmpNo= 109
drop procedure sp_InsertEmployeeDataNew