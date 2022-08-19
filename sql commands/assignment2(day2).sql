use demo;
select * from salesman;

CREATE VIEW citynum
AS SELECT city, COUNT (DISTINCT salesmain_id) number_of_salespersons
FROM salesman
GROUP BY city;

select * from citynum;





SELECT salesmain_id,name,city,FORMAT(commission,'P') as percentage from salesman;






select * from match_details1;

insert into match_details1 values(1,'G',1207,'W','N',2,'',80016,160140)
Insert into match_details1 values(1,'G',1216 ,'L','N',1,'',80020 ,160348)
Insert into match_details1 values(2,'G',1201 ,'L','N',0,'',80003 ,160001)
Insert into match_details1 values(2,'G',1207 ,'W','N',1,'',80023 ,160463)
Insert into match_details1 values(3,'G',1214 ,'W','N',2,'',80031 ,160532)
Insert into match_details1 values(3,'G',1213 ,'L','N',1,'',80025 ,160392)
Insert into match_details1 values(4,'G',1206 ,'D','N',1,'',80008 ,160117)
Insert into match_details1 values(4,'G',1210 ,'D','N',1,'',80019 ,160369)
Insert into match_details1 values(5,'G',1211 ,'L','N',0,'',80011 ,160486)
Insert into match_details1 values(5,'G',1204 ,'W','N',1,'',80022 ,160071)
Insert into match_details1 values(6,'G',1213 ,'W','N',1,'',80036 ,160279)
Insert into match_details1 values(6,'G',1212 ,'L','N',0,'',80029 ,160256)
Insert into match_details1 values(7,'G',1208 ,'W','N',2,'',80014 ,160163)
Insert into match_details1 values(7,'G',1201 ,'L','N',0,'',80006 ,160508)
Insert into match_details1 values(8,'G',1205 ,'L','N',0,'',80012 ,160093)
Insert into match_details1 values(8,'G',1204 ,'L','N',0,'',80012 ,160093)
Insert into match_details1 values(9,'G',1214 ,'D','N',1,'',80017 ,160324)
Insert into match_details1 values(9,'G',1201 ,'D','N',1,'',80010 ,160439)
Insert into match_details1 values(10,'G',1203 ,'L','N',0,'',80004 ,160047)
Insert into match_details1 values(10,'G',1211 ,'W','N',2,'',80007 ,160231)
Insert into match_details1 values(11,'G',1202 ,'L','N',0,'',80026 ,160024)
Insert into match_details1 values(11,'G',1209 ,'W','N',2,'',80028 ,160187)
Insert into match_details1 values(12,'G',1214 ,'D','N',1,'',80009 ,160302)
Insert into match_details1 values(12,'G',1210 ,'D','N',1,'',80015 ,160208)

select * from soccer_country;
Insert into soccer_country values(1201,'ALB','Albania')
Insert into soccer_country values(1202,'AUT','Austria')
Insert into soccer_country values(1203,'BEL','Belgium')
Insert into soccer_country values(1204,'CRO','Croatia')
Insert into soccer_country values(1205,'CZE','Czeh')
Insert into soccer_country values(1206,'ENG','England')
Insert into soccer_country values(1207,'FRA','France')
Insert into soccer_country values(1208,'GER','Germany')
Insert into soccer_country values(1209,'HUN','Hungary')
Insert into soccer_country values(1210,'ISL','IceLand')
Insert into soccer_country values(1221,'IT','Italy')
Insert into soccer_country values(1212,'NIR','Northern')
Insert into soccer_country values(1213,'POL','Poland')
Insert into soccer_country values(1214,'POR','Portugal')


SELECT match_no,country_name,goal_score
FROM match_details1 a
JOIN soccer_country b
ON a.team_id=b.country_id
WHERE decided_by='N'
ORDER BY match_no;

select * from studentExam;
insert  into studentExam valueS('sajal',90,'AI')
insert  into studentExam valueS('sajal1',91,'ML')
insert  into studentExam valueS('sajal2',92,'RUBY')
insert  into studentExam valueS('sajal3',89,'C++')
insert  into studentExam valueS('sajal4',40,'C')
insert  into studentExam valueS('sajal5',50,'PYTHON')
insert  into studentExam valueS('sajal6',63,'C#')
insert  into studentExam valueS('sajal7',70,'BIGDATA')
insert  into studentExam valueS('sajal8',92,'ASP.NET')
insert  into studentExam valueS('sajal9',39,'SQL')
insert  into studentExam valueS('sajal10',20,'JAVA')
insert  into studentExam valueS('sajal10',60,'JAVA')


select Name,Marks as Maximum_Mark,SubjectName from StudentExam 
where Marks in (select max(Marks)  from StudentExam 
group by SubjectName)
order by SubjectName;










