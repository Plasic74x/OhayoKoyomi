select CustomerID, ContactName, City, Region
from Customers
where fax is null
and region like '%'
order by Country, City desc
