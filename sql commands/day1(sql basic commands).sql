USE [demo]
GO

INSERT INTO EmployeeInformation VALUES
           (1,'sajal',15-10-1999,'software Developer','Banglore')
	INSERT INTO EmployeeInformation VALUES
           (2,'sajal',15-10-1999,'software Developer','Banglore')
		   INSERT INTO EmployeeInformation VALUES
           (3,'sajal',15-10-1999,'software Developer','Banglore')
		   INSERT INTO EmployeeInformation VALUES
           (4,'sajal',1999-10-10,'software Developer','Banglore')
		   INSERT INTO EmployeeInformation VALUES
           (2,'sajal','1999-10-15 06:40:00','software Developer','Banglore')
		   
		   
		   INSERT INTO EmployeeInformation VALUES
           (3,'sajal1','1999-10-20 06:00:00','Developer','Banglore')
		   INSERT INTO EmployeeInformation VALUES
           (4,'sajal2','1999-10-15 06:40:00','software Developer','')
		   INSERT INTO EmployeeInformation VALUES
           (6,'sajal4','','','Mumbai')
		    INSERT INTO EmployeeInformation VALUES
           (50,'sajal50','1999-10-20 06:00:00','tester','pune')
		    INSERT INTO EmployeeInformation VALUES
           (34,'sajal34','1999-10-20 06:00:00','Q&A','Banglore')
		    INSERT INTO EmployeeInformation VALUES
           (67,'sajal67','1999-10-20 06:00:00','Developer','Banglore')
		   INSERT INTO EmployeeInformation VALUES
           (45,'sajal50','1999-10-20 06:00:00','tester','pune')
		   
		   select EmpName,Designation from EmployeeInformation
		   order by designation;

		   select distinct Designation from EmployeeInformation;
		   select COUNT(distinct BaseOffice) as distintDesignation from EmployeeInformation;


		   select EmpName,Designation,BaseOffice from EmployeeInformation
		   where BaseOffice = 'Banglore' OR Designation = 'Developer';

		   SELECT COUNT(EmpId),BaseOffice from EmployeeInformation
		   group by BaseOffice
		   order by BaseOffice DESC;
		   Select *  into BangloreOffice from EmployeeInformation where BaseOffice = 'Banglore';
		   Select *  into ChennaiOffice from EmployeeInformation where BaseOffice = 'chennai';

		   select * from ChennaiOffice;
		   insert into BangloreOffice select * from EmployeeInformation where BaseOffice = 'Banglore';
		   select * from BangloreOffice;
		   drop table BangloreOffice;





GO
SELECT * FROM EmployeeInformation;
ALTER TABLE EmployeeInformation ADD  PRIMARY KEY(EMPID)
ALTER TABLE EmployeeInformation alter column Designation nchar(50)
delete from EmployeeInformation where EmpId=5;
Update EmployeeInformation set EmpName='ABCD' where BaseOffice='Mumbai'
Update EmployeeInformation set BaseOffice='chennai' where EmpId=1



