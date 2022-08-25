use demo;

select * from empsalary;

create or alter function fn1(@id int) 
returns varchar(10) as
begin
declare @salslab varchar(10)
declare @salary float
select @salary=EmpSalary from empsalary where EmpId=@id;
if(@salary>600000) set @salslab = 'High';
if(@salary<600000) set @salslab = 'Low';
return @salslab;
end;

select dbo.fn1(3) as result;

create or alter function fn2(@dt date,@dt1 date)
returns table as
return(
select sum(purch_amt) as total from orders where ord_date between @dt and @dt1);

select * from fn2('2012-08-17', '2012-10-05' );

select * from orders;


create or alter function fn4(@dt date,@dt1 date,@checkamt float)
returns varchar(30) as
begin
declare @orderslab varchar(40)
declare @amt float
select @amt=sum(purch_amt) from orders where ord_date between @dt and @dt1;
if(@amt>=@checkamt) set @orderslab = 'High';
if(@amt<=@checkamt) set @orderslab = 'low';
return @orderslab;
end;

select demo.dbo.fn4('2012-08-17', '2012-10-05',40000 ) as amountLimit;

select * from studentExam;

create or alter function fn6(@subjectName varchar(20))
returns varchar(30) as
begin
DECLARE @marksslab varchar(30)
declare @MaxMarks varchar(40)
select @MaxMarks=max(Marks) from studentExam where SubjectName=@subjectName;
if(@MaxMarks>=50) set @marksslab = 'A+';
if(@MaxMarks<=50) set @marksslab = 'A';
return @marksslab;
end;

select demo.dbo.fn6('JAVA') as grade;

create or alter function fn7(@subjectName varchar(20))
returns @student TABLE(Marks int,Name varchar(20) ) as
begin
declare @MaxMarks1 int
declare @name varchar(40)
select @MaxMarks1=MIN(Marks) from studentExam where SubjectName=@subjectName;
select @name = Name ,@MaxMarks1 = Marks from studentExam where Marks = @MaxMarks1;
insert into @student values(@MaxMarks1,@name)
return;
end;

select * FROM fn7('JAVA');


insert into studentExam values('sajal11',60,'JAVA');
create or alter function fn7(@subjectName varchar(20),@maxmarks int)
return table as
begin
select @maxmarks=MAX(Marks) from studentExam where SubjectName=@subjectName;
RETURN (SELECT * FROM studentExam WHERE Marks=@maxmarks and SubjectName=@subjectName);
end;
