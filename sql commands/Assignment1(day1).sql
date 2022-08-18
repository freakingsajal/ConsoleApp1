USE DEMO;
INSERT INTO salesPeople VALUES
           (5001,'James Hoog','New York',0.15)
INSERT INTO salesPeople VALUES
           (5002,'Nail Knite','Paris',0.13)
INSERT INTO salesPeople VALUES
           (5005,'Pit Alex','London',0.11)
INSERT INTO salesPeople VALUES
           (5006,'Mc Lyon','Paris',0.14)
INSERT INTO salesPeople VALUES
           (5007,'Paul Adam','Rome',0.13)
INSERT INTO salesPeople VALUES
           (5003,'Lauson Hen','San Jose',0.12)

select * from salesman
WHERE commission BETWEEN 0.12 AND 0.14;

sp_rename 'salesPeople','salesman';

INSERT INTO orders VALUES
           (70001,150.5,'2012-10-05',3005,5002)
INSERT INTO orders VALUES
(70009,270.65,'2012-09-10',3001,5005)
INSERT INTO orders VALUES
(70002, 65.26 ,   '2012-10-05'  ,    3002, 5001)
INSERT INTO orders VALUES
(70004 ,110.5 ,   '2012-08-17' ,   3009, 5003)
INSERT INTO orders VALUES
(70007, 948.5   ,'2012-09-10'  ,  3005 ,5002)
INSERT INTO orders VALUES
(70005 ,2400.6  , '2012-07-27'  ,  3007 ,5001)
INSERT INTO orders VALUES
(70008, 5760    , '2012-09-10 '    ,  3002, 5001)
INSERT INTO orders VALUES
(70010, 1983.43  ,  '2012-10-10'  , 3004 ,5006)
INSERT INTO orders VALUES
(70003, 2480.4   , '2012-10-10'  , 3009 ,5003)
INSERT INTO orders VALUES
(70012 ,250.45   ,'2012-06-27'    , 3008 ,5002)
INSERT INTO orders VALUES
(70011 ,75.29   , '2012-08-17'    ,3003 ,5007)
INSERT INTO orders VALUES
(70013 ,3045.6  , '2012-04-25'   , 3002, 5001)

select * from orders
WHERE (purch_amt BETWEEN 500 AND 4000) 
AND NOT purch_amt IN(948.50,1983.43);



INSERT INTO totalvalue VALUES('A001/DJ-402\44_/100/2015');
INSERT INTO totalvalue VALUES
('A001_\DJ-402\44_/100/2015')
INSERT INTO totalvalue VALUES
('A001_DJ-402-2014-2015')
INSERT INTO totalvalue VALUES
('A002_DJ-401-2014-2015')
INSERT INTO totalvalue VALUES
('A001/DJ_401')
INSERT INTO totalvalue VALUES
('A001/DJ_402\44')
INSERT INTO totalvalue VALUES
('A001/DJ_402\44\2015')
INSERT INTO totalvalue VALUES
('A001/DJ-402%45\2015/200')
INSERT INTO totalvalue VALUES
('A001/DJ_402\45\2015%100')
INSERT INTO totalvalue VALUES
('A001/DJ_402%45\2015/300')
INSERT INTO totalvalue VALUES
('A001/DJ-402\44')

select * from totalvalue;
ALTER TABLE totalvalue
ALTER COLUMN [col-1] varchar(50);

EXEC sp_RENAME 'totalvalue.[col-1]','column_1','COLUMN';


select count(column_1) as totalvalue from totalvalue
WHERE column_1 NOT LIKE '%/_%' ESCAPE '/';