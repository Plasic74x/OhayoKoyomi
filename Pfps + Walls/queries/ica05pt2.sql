select SupplierId, Sum(UnitsInStock) as 'TotalUnits'
from Products
where UnitsInStock >=2
group by SupplierID
having avg(UnitPrice)<20	
select EmployeeId,
count(distinct OrderID) as 'Orders',
count(distinct ShippedDate) as 'Shipped',
Avg(DATEDIFF(day,OrderDate,ShippedDate)) as 'Average (Days)',
MIN(DateDiff(hour,OrderDate,ShippedDate)) as 'Fastest (Hours)',
MAX(DateDiff(day,OrderDate,ShippedDate)) as 'Slowest (Days)',
cast('$'+Sum(Freight) as varchar) as 'Total Freight'
from Orders	
Group by EmployeeID
Having MIN(DateDiff(hour,OrderDate,ShippedDate))>15
Order by Avg(DATEDIFF(day,OrderDate,ShippedDate)),EmployeeID
