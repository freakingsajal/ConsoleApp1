use demo;

select * into StudentInfo from EmployeeInformation;
select * from StudentInformation;
delete from StudentInfo;

ALTER TABLE StudentInformation alter column CourseId nchar(50);
ALTER TABLE StudentInformation alter column CourseId int;


INSERT INTO StudentInformation VALUES
           (1,'sajal1','1999-10-15','CSE','1234567890')
INSERT INTO StudentInformation VALUES
           (2,'sajal2','1999-10-13','ECE','1234567980')
		   INSERT INTO StudentInformation VALUES
           (3,'sajal3','1999-10-12','ME','1243567890')

		   INSERT INTO StudentInformation VALUES
           (4,'sajal1','1999-10-11','CSE','1234561190')

		   INSERT INTO StudentInformation VALUES
           (5,'sajal5','1999-10-10','EE','1334567890')
		   INSERT INTO StudentInformation VALUES
           (6,'sajal6','1999-10-9','ME','1234467890')

		   delete from StudentInformation;
		   select * from CourseInfo;

		    INSERT INTO CourseInfo VALUES
           (1,'CSE',1)
		   INSERT INTO CourseInfo VALUES
           (2,'ECE',2)
		    INSERT INTO CourseInfo VALUES
           (3,'ME',3)
		   
		    INSERT INTO CourseInfo VALUES
           (4,'EE',5)

		   drop table AccountInformation;
		   
		   create table AccInfo(
		   CustId int,
		   CustName varchar(50),
		   AccNumber Bigint,
		   AccType varchar(50) primary key(CustId,CustName)
		   
		   );
		   select * from AccInfo;
		   insert into AccInfo values(1,'sajal',123456789,'savings');
		   insert into AccInfo values(2,'sajal2',123546789,'savings');
		   insert into AccInfo values(3,'sajal3',123457789,'current');
		   insert into AccInfo values(4,'sajal4',133456789,'debit');

		   insert into AccInfo values(1,'',123456789,'savings');
		    insert into AccInfo values(5,'sajal5',123,'savings');

			 insert into AccInfo values(6,'sajal6',123,'savings');

			 select * into Example from StudentInformation;
			 select * from Example;
INSERT INTO Example VALUES
           (7,'sajal7','1999-10-10','EE','1334567890')
		   INSERT INTO Example VALUES
           (9,'sajal8','1999-10-9','ME','1234467890')


		   select * from StudentInformation intersect select * from Example;

		   select * from Example except select * from StudentInformation;

create view E_Students as select stdName,CourseId from Example where CourseId='EE';

create view CSE_Students as select stdName,CourseId from Example where CourseId='CSE';

SELECT * FROM E_Students;

SELECT * FROM CSE_Students;

DROP VIEW CSE_Students;

SELECT * FROM CourseInfo;

ALTER TABLE StudentInformation alter column CourseId nchar(50);

select ascii(CourseName) as ascii_Name ,CourseName from CourseInfo;

select LEN(CourseName) as coursenamelength,CourseName from CourseInfo;

select CONCAT_WS('-',stdName,CourseId) as s_concat from Example;
use demo;
SELECT FORMAT(StdID,'P') as percentage from StudentInformation;

select CHARINDEX('S',CourseName),CourseName from CourseInfo;

select lower(CourseName) as Coursename from CourseInfo;

select substring(CourseName,1,2) from CourseInfo;

select replace(CourseName,'C','A') from CourseInfo;

select reverse(CourseName),CourseName from CourseInfo;

select * from EmployeeInformation;

select * from empsalary;

select * from EmployeeInformation e
inner join empsalary s on s.EmpId=e.EmpId; 

select * from EmployeeInformation e
full outer join empsalary s on s.EmpId=e.EmpId; 

select * from EmployeeInformation e
right outer join empsalary s on s.EmpId=e.EmpId; 

select * from EmployeeInformation
cross join empsalary ; 


