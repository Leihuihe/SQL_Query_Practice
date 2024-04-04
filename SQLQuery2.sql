---1
select count(*)
from Production.Product p
---2
select count(ProductSubcategoryID)
from Production.Product p
--3
select count(ProductSubcategoryID) as ProductSubcategoryID , count(*) as CountedProducts
from Production.Product p
---4
select count(*) - count(ProductSubcategoryID) as no_subcategory
from Production.Product p
---5
select sum(p.Quantity) as sum_Quantity
from Production.ProductInventory p
---6
select ProductID, sum(Quantity) as TheSum
from Production.ProductInventory p
where LocationID = 40
group by ProductID
having sum(Quantity)<100
---7
select Shelf,ProductID, sum(Quantity) as TheSum
from Production.ProductInventory p
where LocationID = 40
group by Shelf,ProductID
having sum(Quantity)<100


---8
select AVG(Quantity)
from Production.ProductInventory p
where LocationID = 10

--9
select Shelf, AVG(Quantity) as TheAvg
from Production.ProductInventory p
group by Shelf

--10
select Shelf, AVG(Quantity) as TheAvg
from Production.ProductInventory p
group by Shelf
having Shelf != 'N/A'

--11
select Color, Class, count(Color), avg(ListPrice)
from Production.Product
where Color is not null and Class is not null
group by Color, Class


---12
select c.Name as Country, s.Name as Province
from person.CountryRegion c join person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode

---13
select c.Name as Country, s.Name as Province
from person.CountryRegion c join person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode
where c.Name in ('Germany','Canada')


---------

--14
select distinct p.ProductID
from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on od.OrderID = o.OrderID
where o.OrderDate > DATEADD(year, -26, GETDATE())

select *
from Products

select p.ProductID, od.ProductID, *
from Products p left join [Order Details] od on p.ProductID = od.ProductID


--15
select TOP 5 o.ShipPostalCode, SUM(od.Quantity)
from Orders o join [Order Details] od on o.OrderID = od.OrderID
group by o.ShipPostalCode
order by SUM(od.Quantity) DESC

---16

select TOP 5 o.ShipPostalCode, SUM(od.Quantity)
from Orders o join [Order Details] od on o.OrderID = od.OrderID
where o.OrderDate >= DATEADD(year, -26, GETDATE())
group by o.ShipPostalCode
order by SUM(od.Quantity) DESC

--17
select city, count(CustomerID)
from Customers
group by City

--18
select city, count(CustomerID)
from Customers
group by City
having count(CustomerID) > 2

--19
select distinct c.ContactName
from Customers c join Orders o on c.CustomerID = o.CustomerID
where o.OrderDate > '1998-01-01'

--20
select dt.ContactName, dt.OrderDate
from(
select rank() over(partition by c.ContactName order by o.OrderDate DESC) as RNK, c.ContactName,o.OrderDate
from Customers c left join Orders o on c.CustomerID = o.CustomerID
) dt
where dt.RNK = 1;



--21
select c.ContactName, sum(od.Quantity)
from Customers c left join Orders o on c.CustomerID = o.CustomerID left join [Order Details] od on o.OrderID = od.OrderID
group by c.ContactName

--22
select c.ContactName, sum(od.Quantity)
from Customers c left join Orders o on c.CustomerID = o.CustomerID left join [Order Details] od on o.OrderID = od.OrderID
group by c.ContactName
having sum(od.Quantity) > 100

--23
select *
from Suppliers

select *
from Shippers

select *
from Orders

select *
from Products

select *
from Suppliers su left join Products p on su.SupplierID = p.SupplierID 

---24
select o.OrderDate, p.ProductName, row_number() over(partition by o.OrderDate order by p.productname)
from Orders o left join [Order Details] od on o.OrderID = od.OrderID left join Products p on od.ProductID = p.ProductID

--25
select row_number() over(partition by e.title order by e.EmployeeID),e.FirstName, e.Title
from Employees e

--26

select *
from Employees e
where e.EmployeeID in (
	select e.ReportsTo
	from Employees e
	group by e.ReportsTo
	having count(e.ReportsTo) > 2
)

--27
select City,ContactName, 'Supplier' Type
from Suppliers
union
select City,ContactName, 'Customer' Type
from Customers
order by City
