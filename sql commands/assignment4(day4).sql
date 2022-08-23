use demo;
select * from studentExam ;



insert into EmployeeInformation values(61,'sajal68','1999-11-11','C#','Banglore');
insert into EmployeeInformation values(89,'sajal89','1999-11-01','C#','Banglore');

CREATE or alter procedure LanguageAndLocation as
select EmpId,EmpName,Designation,BaseOffice from EmployeeInformation
where Designation='C#' AND BaseOffice='Banglore';

exec LanguageAndLocation ;



create table StudentReport(
StdId int primary key,
StdName varchar(50),
Maths int,
Economics int,
Commerce int,
English int,
ComputerSceince int); 



insert into StudentReport values(1,'sajal1',97,77,66,93,77);
insert into StudentReport values(2,'sajal2',88,90,76,56,90);
insert into StudentReport values(3,'sajal3',89,77,88,98,72);
insert into StudentReport values(4,'sajal4',90,87,80,68,79);
insert into StudentReport values(5,'sajal5',80,97,86,75,68);
insert into StudentReport values(6,'sajal6',70,72,83,94,75);
insert into StudentReport values(7,'sajal7',77,72,71,70,99);
insert into StudentReport values(8,'sajal8',84,88,85,87,82);
insert into StudentReport values(9,'Sajal9',84,55,66,93,91);
insert into StudentReport values(10,'sajal10',89,77,79,85,89);
insert into StudentReport values(11,'sajal11',66,85,44,88,79);
insert into StudentReport values(12,'sajal12',86,56,80,72,59);


create or alter procedure ResultStatus as
select StdId,StdName, Maths+Economics+Commerce+English+ComputerSceince as TotalMarks,rank() over( order by  Maths+Economics+Commerce+English+ComputerSceince DESC)as Rank
from StudentReport
order by Rank;

exec ResultStatus;