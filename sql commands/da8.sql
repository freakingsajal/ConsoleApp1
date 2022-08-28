use demo;

select * from AccountDetails;

create or alter procedure checkingconnection @amt float as
select * from AccountDetails where AccountBalance>@amt;

exec checkingconnection 400000;

create or alter procedure checkingconnection1 @type varchar(30) as
DECLARE @MAXAMT FLOAT
select @MAXAMT=MAX(AccountBalance) from AccountDetails where AccountType=@type;
exec checkingconnection @MAXAMT;

exec checkingconnection1 'SAVINGS' ;


create function show(@acc int)
returns date as
begin
declare @d date
declare @result date
select @d=AccountOpenedDate from AccountDetails WHERE AccountNumber=@acc

return @d
end


create function show1(@acc int)
returns date as
begin
declare @d date
select @d=LastTransDate from AccountDetails WHERE AccountNumber=@acc
return @d
end


select  demo.dbo.show(123456789);


sp_helpextendedproc;

