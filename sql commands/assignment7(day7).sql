use demo;

create table AccountDetails(
AccountNumber bigint primary key,
AccountOpenedDate date,
LastTransDate datetime,
AccountType Varchar(30),
AccountBalance float,
Branch varchar(30)
)


Create table CustomerDetails(
CustomerId int primary key,
CustomerName varchar(20),
AccountNumber bigint UNIQUE,
AadharNumber bigint 
FOREIGN KEY (AccountNumber) REFERENCES AccountDetails(AccountNumber)
)




INSERT into AccountDetails values(123456789,'2010-01-01','2022-01-01','SAVINGS',558000.00,'RANCHI')
INSERT into AccountDetails values(123456799,'2011-02-02','2022-02-02','CURRENT',185450.10,'DELHI')
INSERT into AccountDetails values(123456889,'2012-03-03','2022-03-03','SAVINGS',418499.20,'MUMBAI')
INSERT into AccountDetails values(123457789,'2013-04-04','2022-04-04','CURRENT',446007.54,'PUNE')
INSERT into AccountDetails values(123466789,'2014-05-05','2022-05-05','CURRENT',198670.00,'HYDERABAD')
INSERT into AccountDetails values(123556789,'2015-06-06','2021-06-06','SAVINGS',50000.30,'JALANDHAR')
INSERT into AccountDetails values(124456789,'2016-07-07','2021-07-07','CURRENT',800000.00,'BANGALORE')
INSERT into AccountDetails values(133456789,'2017-08-08','2022-08-08','SAVINGS',123456.00,'MUMBAI')


insert into CustomerDetails values(1,'SAJAL1',123456789,638822223522);
insert into CustomerDetails values(2,'SAJAL2',123456799,688822223522);
insert into CustomerDetails values(3,'SAJAL3',123456889,838822223522);
insert into CustomerDetails values(4,'SAJAL4',123457789,638822223532);
insert into CustomerDetails values(5,'SAJAL5',123466789,628828823522);
insert into CustomerDetails values(6,'SAJAL6',123556789,938822223522);
insert into CustomerDetails values(7,'SAJAL7',124456789,638822225522);
insert into CustomerDetails values(8,'SAJAL8',133456789,638822222222);


CREATE or alter FUNCTION GetBalance(@BalanceSlap int)  
RETURNS @Balance TABLE  
(AccNumber BigInt,CustName varchar(30),AccOpenedDate date,
LastTransDate date,AccBalance float,Aadhar bigint)  
AS  
BEGIN  
insert into @Balance   
            SELECT a.AccountNumber,c.CustomerName,a.AccountOpenedDate,a.LastTransDate,
			a.AccountBalance,c.AadharNumber from AccountDetails a 
			join CustomerDetails c  
			on a.AccountNumber=c.AccountNumber
			where A.AccountBalance>@BalanceSlap		
RETURN   
END 

SELECT * FROM GetBalance(500000);


--questuion-2

create table Movies
(
MovieName Varchar(30),
MovieType Varchar(30),
ReleaseYear int
)



Insert into Movies values('Movie1','Horror',2020);
Insert into Movies values('Movie2','Horror',2019);
Insert into Movies values('Movie3','Horror',2018);
Insert into Movies values('Movie4','kids',2017);
Insert into Movies values('Movie5','Horror',2016);
Insert into Movies values('Movie6','Animated',2015);
Insert into Movies values('Movie7','Kids',2014);
Insert into Movies values('Movie8','Horror',2013);
Insert into Movies values('Movie9','Animated',2012);
Insert into Movies values('Movie10','Horror',2011);
Insert into Movies values('Movie11','Animated',2010);
Insert into Movies values('Movie12','Animated',2009 );
Insert into Movies values('Movie13','Horror',2008);
Insert into Movies values('Movie14','Kids',2007);
Insert into Movies values('Movie15','Animated',2006);
Insert into Movies values('Movie16','Horror',2005);
Insert into Movies values('Movie17','Animated',2004);
Insert into Movies values('Movie18','Kids',2003);
Insert into Movies values('Movie19','Animated',2002);
Insert into Movies values('Movie20','Animated',2001);


CREATE or alter FUNCTION GetMovies(@Type varchar(30)) 
RETURNS @Moviestypes TABLE  
(
MovieName Varchar(30),
MovieType Varchar(30),
ReleaseYear int
)
  
AS  
BEGIN  
insert into @Moviestypes   
            SELECT MovieName,MovieType,ReleaseYear from Movies where MovieType=@Type;
RETURN          
END

select * from GetMovies('Kids');