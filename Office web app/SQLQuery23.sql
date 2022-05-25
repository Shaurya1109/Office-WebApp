create database office;
use office 
GO

create table employee(id int primary key identity(1,1),employee_name varchar(20),employee_gender varchar(10),employee_age int,employee_phonenumber varchar(10));
 insert into employee values('Shaurya','Male',20,'9876543212');
 insert into employee values('Ritvik','Male',20,'9876543223');
 insert into employee values('Arsh','Male',20,'9876543234');
 insert into employee values('Rishit','Male',20,'9876543245');
 insert into employee values('Navya','Female',21,'9876543256');
 insert into employee values('Saksham','Male',20,'9876543267');
 insert into employee values('Sanya','Female',20,'9876543278');
 
