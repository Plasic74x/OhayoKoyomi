Select top 5 *
from Orders
where ShippedDate is NOT NULL 
Order by DATEDIFF(s,ShippedDate , OrderDate)


select OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate
from Orders
where DATEDIFF(day, OrderDate, '2019/08/27') = 0
	
select *
from Orders
where DATEDIFF(day, RequiredDate,ShippedDate ) > 10
order by DATEDIFF(day, RequiredDate, ShippedDate) desc

select *
from Orders
where DATEDIFF(hour, OrderDate, ShippedDate) <10

select *	
from Orders
Where Day(ShippedDate) = Day(GETDATE())
and Month(ShippedDate) = Month(GETDATE())