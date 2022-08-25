use demo;
select * from studentExam;
create or alter function fn8(@subject varchar(30))
returns table as 
return
(select * from studentExam where SubjectName=@subject
and Marks=(select Max(Marks) from studentExam where SubjectName=@subject))


select * from fn8('JAVA') AS FINAL_CODE;

create or alter function fn9(@subject varchar(30))
returns table as 
return

(select * from studentExam where SubjectName=@subject
and Marks=(select Max(Marks) from studentExam where SubjectName=@subject))

USE DEMO;
select * from studentExam;

create or alter function fn9(@subjectName varchar(50))
returns int as
begin
declare @maxmarks int
select @maxmarks=max(Marks) from studentExam where SubjectName=@subjectName
return @maxmarks;
end

select demo.dbo.fn9('JAVA')