SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 
WHERE ListPrice != 0

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 
WHERE Color is null

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 
WHERE Color is NOT null

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 
WHERE Color is NOT null and ListPrice > 0

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 

SELECT ProductID, Name + ' ' + Color AS Name_Color, ListPrice
FROM Production.Product 
WHERE Color is NOT null

SELECT Name, Color 
FROM Production.Product 
WHERE Color in ('Black','Silver') and (Name like '%Crankarm' or Name like 'Chainring%')

SELECT ProductID, Name, Color
FROM Production.Product 
WHERE Color in ('black','blue')

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 
WHERE Name like 'S%'

SELECT Name, ListPrice
FROM Production.Product 
WHERE Name like 'Seat%' or Name like 'Short-Sleeve%, [L-M]'
ORDER BY Name

SELECT Name, ListPrice
FROM Production.Product 
WHERE Name like 'A%' or Name like 'Seat%' and MakeFlag = 0
ORDER BY Name

SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 
WHERE Name like 'SPO[^K]%' 
ORDER BY Name

SELECT DISTINCT Color
FROM Production.Product 
ORDER BY Color DESC

SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product 
WHERE Color is not null and ProductSubcategoryID is not null
