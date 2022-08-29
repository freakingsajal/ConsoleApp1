create table sales1(
Region varchar(20),
Quantity int,
unitprice int)

use demo;

insert into sales1 values('ranchi',100,2),
('jamshedpur',200,3),
('ranchi',250,2),
('jamshedpur',300,4),
('chaibasa',350,2),
('chaibasa',400,3)

CREATE TYPE salesval AS TABLE(
	salesval int
)


create or alter function avgvalue(@salesval salesval READONLY) 
returns int as
begin
declare @avg int
  select @avg=(select avg(salesval) from @salesval)
  return @avg
end


create or alter function sales(@region varchar(30)) 
returns int as
begin
declare @avg int 
declare @salesval as salesval
insert into @salesval
       select Quantity* unitprice  from sales1 where region=@region;
	  select @avg=(select dbo.avgvalue(@salesval))
	  return @avg
end

SELECT dbo.sales('RANCHI') as average