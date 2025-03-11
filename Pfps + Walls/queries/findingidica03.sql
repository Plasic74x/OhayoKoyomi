select OrderId, CustomerID, EmployeeID, ShipName
from Orders
 where ShippedDate BETWEEN '2019-07-01' AND '2019-08-01'
 and ShipRegion is null 
 and (ShipCountry LIKE 'F%' OR ShipCity LIKE '%er%')
 order by shipCountry, EmployeeID
