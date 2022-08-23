use demo;
select * from orders;

SELECT MAX(purch_amt) AS Maxium_PurchasedAmount FROM orders
where datediff(month, ord_date, getdate()) between 0 and 10;

CREATE INDEX order_information ON orders (ord_no);


select * from EmployeeInformation;
select * from empsalary;

WITH Emp_salary(EmpSalary,EmpName,Designation) as( 
(select s.EmpSalary,e.EmpName, e.Designation from empsalary s,EmployeeInformation e where s.EmpId=e.EmpId and EmpSalary>45000))
select EmpSalary,EmpName,Designation from Emp_salary where EmpSalary>45000;