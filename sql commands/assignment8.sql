use demo;



--question 1

select * from StudentReport;
create or alter procedure StudentList @marks int as
select * from StudentReport where (Maths+Economics+Commerce+English+ComputerSceince)<@marks;

exec StudentList 400;

create or alter procedure maxMarksStudent @name varchar(30) as
DECLARE @MaxMarks Int
select @MaxMarks=MAX(Maths+Economics+Commerce+English+ComputerSceince) from StudentReport where StdName=@name;
exec StudentList @MaxMarks;


exec maxMarksStudent 'sajal1' ;




--question2

select * from AccountDetails;

create or alter procedure SetRoi @ACCTYPE varchar(30) as
DECLARE @SETROI Int
IF(@ACCTYPE = 'SAVINGS') SET @SETROI = 5;
IF(@ACCTYPE = 'CURRENT') SET @SETROI = 6;
select * from CalulateInterest(@SETROI,@ACCTYPE);


exec SetRoi 'SAVINGS';

select * Into AccountDetails1 from AccountDetails;
select * from AccountDetails1;
ALTER TABLE AccountDetails1
ADD Interest float;

CREATE or alter FUNCTION CalulateInterest(@ROI INT,@ACCTYPE VARCHAR(30))  
RETURNS @CalulateInterest TABLE  
(AccountType varchar(50),AccountBalance float,Interest float)  
AS  
BEGIN  
insert into @CalulateInterest 
            
            select AccountType,AccountBalance,Interest from AccountDetails1
			update @CalulateInterest SET Interest=(AccountBalance*@ROI)/100	WHERE AccountType=@ACCTYPE;
					
RETURN   
END 


--select * from CalulateInterest('SAVINGS') as result;




--question3

create table AreaSales(
AreaName varchar(30),
month1 int,
month2 int,
month3 int,
month4 int,
month5 int,
)
drop table AreaSales;
select * from AreaSales;

insert into AreaSales values('Delhi',1000,2000,1500,2500,3000)
insert into AreaSales values('Mumbai',2000,2100,1600,2600,3100)
insert into AreaSales values('Pune',3000,22000,1700,2700,3200)
insert into AreaSales values('Banglore',900,1000,2000,500,300)
insert into AreaSales values('Delhi',1000,2000,2500,2500,3500)

create or alter function salesreport(@region varchar(30))
returns int as
begin
declare @totalsales int
select @totalsales = (month1+month2+month3+month4+month5) from AreaSales where  AreaName = @region;
return @totalsales
end

select demo.dbo.salesreport('Delhi');

create or alter function salesreportaverage(@region varchar(30))
returns int as
begin
declare @Averagesales int
select @Averagesales =(select demo.dbo.salesreport(@region))/5;
return @Averagesales;
end

select demo.dbo.salesreportaverage('Pune');