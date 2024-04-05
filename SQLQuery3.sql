--1
select c.City
from Customers c
where c.City in (
	select City
	from Employees e
)

--2
select c.City
from Customers c
where c.City not in (
	select City
	from Employees e
)

with empCTE as
(
	select City
	from Employees e
)
select c.City
from Customers c, empCTE e
where c.City != e.City

--3
select p.ProductID, sum(od.Quantity)
from Products p left join [Order Details] od on p.ProductID = od.ProductID
group by p.ProductID

--4
select c.City, count(o.OrderID)
from Customers c left join Orders o on c.City =o.ShipCity
group by c.City

--5


select *
from Customers c1
where c1.city in (
	select City
	from Customers c2
	group by City
	having count(City) >= 2
)
order by c1.City


--6
with OrdersETC as
(
	select o.ShipCity, od.ProductID
	from Orders o left join [Order Details] od on o.OrderID = od.OrderID
)
select c.City
from Customers c join OrdersETC o on c.City = o.ShipCity
group by c.City
having count(o.ProductID) >= 2 

---7
select *
from Customers c left join Orders o on c.CustomerID = o.CustomerID
where c.City != o.ShipCity


----8
select *
from [Order Details] od
where ProductID = 67

with popular5 as (
	select od1.ProductID, od1.OrderID, avg(UnitPrice) as avgPrice
	from [Order Details] od1,
	where ProductID in 
	(
		select TOP 5 ProductID
		from [Order Details] od
		group by ProductID
		order by count(ProductID) DESC
	)
	group by ProductID
)
select *
from Orders o left join popular5 p on o.OrderID = p.OrderID


--9
select *
from Employees e
where e.City not in (
	select ShipCity
	from Orders
)

select ShipCity
from Orders o full join Employees e on o.ShipCity != e.City


--10
select top 1 o.ShipCity
from Orders o
group by o.ShipCity
order by count(o.OrderID) DESC
where o.ShipCity in (
	select top 1 o.ShipCity
	from [Order Details] od left join Orders o on od.OrderID = o.OrderID
	group by o.ShipCity
	order by sum(od.Quantity) DESC
)

--11

Union itself

group by
having count(*) = 1

Distinct

