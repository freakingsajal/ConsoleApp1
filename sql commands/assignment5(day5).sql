
create table passportInfo(
PassportNumber int,
CandidateName varchar(20),
ExpiryDate date,
YearOfValidity int,
ChannelName varchar(20)
);

create or alter procedure passportInformation @Number int ,@Name varchar(20),@ExpiryDate date , @validity int ,@channelName varchar(20) as
if OBJECT_ID ('dbo.passportInfo') IS NULL
begin
create table passportInfo(
PassportNumber int,
CandidateName varchar(20),
ExpiryDate date,
YearOfValidity int,
ChannelName varchar(20)
);
end
insert into passportInfo values(@Number,@Name,@ExpiryDate,@validity,@channelName);

exec passportInformation 2,'sajal2','2022-12-25',14,'online';
use demo;

create or alter procedure fetchPassportInformation as
select * from passportInfo;


create table StudentInfo(
Name varchar(10), 
Age int, 
Sex varchar(10), 
Course varchar(10), 
YearOfStudy int);


create or alter procedure informationOfStudent @studentYear int as
select Name, Age, Sex, Course, YearOfStudy from StudentInfo where YearOfStudy = @studentYear;


create or alter procedure informationOfStudent1 as
insert into StudentInfo values('sajal1',22,'Male','CSE',1);
insert into StudentInfo values('sajal2',23,'Male','CSE',2);
insert into StudentInfo values('sajal3',24,'Male','CSE',3);
insert into StudentInfo values('sajal4',25,'Male','CSE',4);




 exec informationOfStudent1 ;







select * from StudentInfo;

drop table passportInfo;
drop procedure passportInformation;


