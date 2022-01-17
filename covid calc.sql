declare @r decimal (14,4)
declare @i float 
declare @daystart int
declare @dayend float

set @r=1.3
set @i= 150
set @dayend = 1

;with covid 
(R, Infected, Nodays)
as
(Select @r as r,
@i as infected,
@dayend as Nodays
Union all
Select r, 
sum(infected) over (order by Nodays+1)*@r as  Infected,
covid.Nodays+1 as Nodays
from covid where Nodays <15)
select 
r, round(infected,2) as infected,isnull(
round(infected,2)-(lag(round(infected,2),1) over (order by nodays)),0)as NewCases,
 Nodays from covid
 where nodays<15