select CategoryId, sum(UnitsOnOrder) as 'On Order'
from Products
GROUP BY CategoryID
	


	
select e.Title, count(e.City) 'Unique Cities'
from    Employees e
group by e.Title

select SupplierId,Sum(UnitsInStock) as 'Total Units'
from Products
where UnitsInStock >= 2
Group By SupplierID
HAVING avg(UnitPrice) >= 20

