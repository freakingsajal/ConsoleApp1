use demo;
select * from studentExam;
insert  into studentExam valueS('sajal',90,'AI')
insert  into studentExam valueS('sajal1',91,'ML')
insert  into studentExam valueS('sajal2',92,'RUBY')
insert  into studentExam valueS('sajal3',89,'C++')
insert  into studentExam valueS('sajal4',40,'C')
insert  into studentExam valueS('sajal5',50,'PYTHON')
insert  into studentExam valueS('sajal6',63,'C#')
insert  into studentExam valueS('sajal7',70,'BIGDATA')
insert  into studentExam valueS('sajal8',92,'ASP.NET')
insert  into studentExam valueS('sajal9',39,'SQL')
insert  into studentExam valueS('sajal10',20,'JAVA')


select * from studentExam
WHERE Marks < (select avg(Marks) from studentExam)


select * from EmployeeInformation;
select * from empsalary;

select * from EmployeeInformation
where EmpId in(select EmpId from empsalary where Empsalary < 400000)

select e.EmpId,e.EmpName,s.EmpSalary from EmployeeInformation e,empsalary s
where e.EmpId=s.EmpId and s.EmpId in(select EmpId from empsalary where Empsalary < 400000)


select * into low_salary1 from empsalary where EmpSalary<=400000

update low_salary1 set EmpSalary=EmpSalary+2000 where EmpId in(select EmpId from empsalary where EmpSalary<300000);

select * from low_salary1;

create table #locallocaltemptable(EmpId int,Salary bigint);

create table ##globaltemptable(EmpId int,Salary bigint);
drop table #locallocaltemptable;

select * from EmployeeInformation;
create index EmployeeIndex on EmployeeInformation(EmpName,EmpId);

create table iteminfo(
itemid int identity(100,1) primary key,
itemname varchar(100),
cost int,
quantity int
);

insert into iteminfo values('t-shirt',500,5);
insert into iteminfo values('shirt',800,7);
insert into iteminfo values('pants',1000,3);

select * from iteminfo;
drop table iteminfo;

select month(DOB),DOB from EmployeeInformation;

select DATEADD(MONTH,2,DOB) FROM EmployeeInformation;

SELECT GETDATE();

SELECT CONVERT(VARCHAR,DOB,107),DOB FROM EmployeeInformation;


select power(10,9);

select round(10.76546974,4);

select round(10.76546974,0);

select BINARY_CHECKSUM(010001);

select cast(6 as varbinary);

select CEILING(35.98);

select FLOOR(35.98);

select * from orders;

select CEILING(purch_amt),purch_amt from orders;

select FLOOR(purch_amt),purch_amt from orders;

SELECT DEGREES(10);

SELECT EXP(2);

SELECT RAND();

--SELECT GREATEST(1,45,67,89,56) AS GREAT_NUMBER;

--SELECT GREATEST(match_no,goal_score) from match_details1;

select DATALENGTH(name),name from salesman;

select * from salesman;

alter table salesman alter column name varchar(20);

select DATALENGTH('sajal');

select * from AccInfo;

with orderInfo(ord_date,purch_amt) as 
(select ord_date,purch_amt from orders where purch_amt > 1000)
select ord_date,purch_amt from orderInfo where ord_date>'2012-09-10';


with CTEACCInfo(custName,AccNumber,AccType) as 
(select CustName,AccNumber,AccType from AccInfo where CustName like 'saj%')
select CustName,AccNumber,AccType from CTEACCInfo where AccType='savings';

select * from StudentInformation;
select * from CourseInfo;

alter table StudentInformation add courseID INT;
alter table StudentInformation drop column CourseId;

--ALTER TABLE StudentInformation ADD CONSTRAINT FK_COURSEID FOREIGN KEY (CourseId) references StudentInformation(CourseId);