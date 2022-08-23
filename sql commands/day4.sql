use demo;

create procedure firstProcedure 
as 
select * from orders;
select * from salesman;
go

EXEC firstProcedure;

alter procedure firstProcedure 
as 
select * from orders
select * from salesman
go;

alter procedure demoProcedure as
create table procedureExample(
id int primary key,
name varchar(50),
age int,
address varchar(50)

)

insert into procedureExample values(1,'sajal',22,'chaibasa');
insert into procedureExample values(2,'sajal2',24,'chaibasa2');
insert into procedureExample values(3,'sajal3',25,'chaibasa3');
insert into procedureExample values(4,'sajal4',26,'chaibasa4');
insert into procedureExample values(5,'sajal5',27,'chaibasa5');
insert into procedureExample values(6,'sajal6',28,'chaibasa6');
insert into procedureExample values(7,'sajal7',29,'chaibasa7');

select * from procedureExample where age > 25;
go


drop table procedureExample;


create procedure demoProcedure1 as
create table procedureExample1(
id1 int,
aadhar bigint,
foreign key(id1) references procedureExample(id)

);



insert into procedureExample1 values(1,123456);
insert into procedureExample1 values(2,123455);
insert into procedureExample1 values(3,123454);
insert into procedureExample1 values(4,122455);
insert into procedureExample1 values(5,123355);
insert into procedureExample1 values(6,523455);
insert into procedureExample1 values(7,122455);




select * from procedureExample;



EXEC demoProcedure1;

create or alter procedure joinProcedure @age int as
select a.id,a.name ,a.age,b.aadhar from procedureExample a
join procedureExample1 b on a.id=b.id1
where a.age>@age;

EXEC joinProcedure 27;

drop procedure joinProcedure;

select * from orders;
alter table orders add primary key  (ord_no);

select * from salesman;
alter table salesman add primary key(salesmain_id);

insert into salesman values(5008,'sajal','chaibasa',0.12);

alter table orders add foreign key(salesman_id) references salesman(salesmain_id);


create or alter procedure join2 @salesmain_id int, @purch_amt float as
select * from orders a
join salesman b on a.salesman_id=b.salesmain_id
where salesmain_id>@salesmain_id
and purch_amt > @purch_amt;


select a.ord_no,a.purch_amt,b.city,b.name from orders a
join salesman b on a.salesman_id=b.salesmain_id
where purch_amt < @purch_amt-30;

EXEC join2 5004,270;


create or alter procedure join3  @name varchar(10) as
select * from orders a
join salesman b on a.salesman_id=b.salesmain_id
where b.name=@name;

EXEC join3 'james Hoog';


SELECT * FROM salesman;






declare @transaction varchar(20)
begin transaction @transaction
insert into orders values(70020,451.23,'2012-10-23',3002,5003);
commit transaction @transaction

create or alter procedure orderExample @startdate date ,@enddate date,@purch_amt float as
select purch_amt as purchaseAmount,ord_date
from orders
where  ord_date between @startdate and @enddate and purch_amt>@purch_amt order by purch_amt;


exec orderExample '2012-06-05' ,'2012-10-05',560.98;


create or alter procedure join4  @city1 varchar(10),@city varchar(10) as
delete orders a
join salesman b on a.salesman_id=b.salesmain_id
where b.name=@name;

create or alter procedure insertExample @ord_no int,@purch_amt float,@ord_date date,@customer_id int,@salesmain_id int as
insert into orders values(@ord_no,@purch_amt,@ord_date,@customer_id,@salesmain_id);

exec insertExample 70021,451.24,'2012-10-23',3006,5001;
select * from orders;


create or alter procedure Mathoperation  @num1 int, @num2 int as
declare @total int
set @total = @num1+@num2
print('the total is ' + str(@total)); 

exec Mathoperation 23,56;

select * from StudentExam;
create or alter procedure checkstudent @name varchar(10) as
if exists(select * from studentExam where name = @name)
begin
print('student record is present')
select * from studentExam where name = @name;
end
else
print('student details not found')

exec checkstudent sajal1;

exec orderExample;
use demo;


select * from EmployeeInformation;
exec empinfo;


create or alter procedure empinfo  as
select EmpId,EmpName,BaseOffice from EmployeeInformation where BaseOffice='pune';