use demo;
select stuff('sajal',2,4,'hello')
select log(40);

select CURRENT_TIMESTAMP
select CAST('sajal' as nchar)

SELECT CAST(DOB AS datetime) FROM EmployeeInformation;

select CURRENT_USER

select SESSIONPROPERTY('ANSI_WARNINGS')

SELECT IIF('SAJAL'>'RITIK','YES','NO')

select ord_no,purch_amt ,IIF(purch_amt>500,'Yes','No') from orders

select nullif('2022-09-09','2022/09/09')

select * from EmployeeInformation;
select  ISNUMERIC(purch_amt) from orders;

select    'data source=' + @@servername +    ';initial catalog=' + db_name() +    case type_desc        when 'WINDOWS_LOGIN'             then ';trusted_connection=true'        else            ';user id=' + suser_name() + ';password=<<YourPassword>>'    end    as ConnectionStringfrom sys.server_principalswhere name = suser_name()


--data source=LAPTOP-67GUMUCA;initial catalog=demo;trusted_connection=true

create or alter procedure SqlExample @aadhar bigint as
create table procedureSqlExample2(
id1 int identity,
aadhar bigint,
foreign key(id1) references procedureExample(id)
);
insert into procedureSqlExample2 values(@aadhar);

select * from procedureSqlExample2;

create procedure accountdetails @id int,@acctype varchar(10) as



select * from EmployeeInformation;
select * from empsalary;

create or alter procedure salaryinformation @increment float as
update  empsalary set EmpSalary = EmpSalary+@increment;
select e.EmpName , s.EmpSalary from EmployeeInformation e inner join empsalary s on e.EmpId = s.EmpId;
