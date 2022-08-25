USE DEMO;

select * from EmployeeInformation;
select * from empsalary;
insert into EmployeeInformation values(90,'sajal90','2000-01-01','Manager','pune');
insert into EmployeeInformation values(91,'sajal91','2000-01-01','Manager','banglore');
delete from EmployeeInformation where EmpId = 6;

insert into empsalary values(30,800000);
insert into empsalary values(34,800000);
insert into empsalary values(45,400000);
insert into empsalary values(50,500000);
insert into empsalary values(61,600000);
insert into empsalary values(67,200000);
insert into empsalary values(89,100000);


update  empsalary set EmpSalary = 400000 where EmpId = 90;
update  empsalary set EmpSalary = 500000 where EmpId = 91;

insert into empsalary values(91,490000);


create or alter function IncrSalary(@designation varchar(30))
returns @employee table (Designation varchar(30) ,EmpSalary int) as
begin

BEGIN
Insert into @employee
       select E.Designation,ES.EmpSalary  from EmployeeInformation E
	   INNER JOIN empsalary ES ON E.EmpId = ES.EmpId
	   where E.Designation = @designation
	  
END
if(@Designation = 'Developer') 
BEGIN
	   UPDATE @employee SET EmpSalary = EmpSalary+((EmpSalary*5)/100)
END
if(@Designation = 'Manager') 
BEGIN
	   UPDATE @employee SET EmpSalary = EmpSalary+((EmpSalary*10)/100)
END
return;
end;

select * from EmployeeInformation;
select * from empsalary;
select * from IncrSalary('Developer');


--question 2

use demo;
create table AccDetails(
CustId int primary key,
CustName Varchar(30),
AccNumber Bigint UNIQUE,
AccType varchar(300) ,
Amount float
);
insert into AccDetails VALUES(1,'sajal1',123456789,'savings',24000);
insert into AccDetails VALUES(2,'sajal2',123434678,'checking',35000);
insert into AccDetails VALUES(3,'sajal3',123444678,'saving',78200);
insert into AccDetails VALUES(4,'sajal4',123434688,'checking',84000);
insert into AccDetails VALUES(5,'sajal5',111434678,'savings',82000);
insert into AccDetails VALUES(6,'sajal6',123444678,'checking',15000);
insert into AccDetails VALUES(7,'sajal7',123433678,'checking',90000);

select * from AccDetails;

CREATE or alter FUNCTION IncrementFun(@rate int ,@year int)  
RETURNS @CalulateInterest TABLE  
(CustId int,AccType varchar(50),Interest float)  
AS  
BEGIN  
DECLARE @Acctype varchar(20)
insert into @CalulateInterest     
            SELECT CustId,AccType,Amount from AccDetails
            
			UPDATE @CalulateInterest
			SET Interest =case  WHEN  AccType='Savings'  THEN (Interest*@rate*@year)/100 
                                WHEN AccType='Checking'  THEN ((Interest*5)*@rate*@year)/1000
                                else Interest
								end
RETURN   
END 

select * from IncrementFun(5,8);