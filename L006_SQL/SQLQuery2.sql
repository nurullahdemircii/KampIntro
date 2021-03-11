-- Select = Seçim Keyword
-- * = Tüm Kolonları Temsil Eder. 

-- Customers Tablosunu Getir
Select * from Customers

-- Customers Tablosunda ContactName ve CompanyName Sutunlarını Getir.
Select ContactName, CompanyName from Customers

-- ContactName SehirAdi, = Alias kullanımıdır. Sutun Adının nasıl görünmesini istiyorsak o şekilde gösterir.
Select ContactName SehirAdi, CompanyName SirketAdi, City Sehir from Customers

-- where = keyword sonra koşullar yazılır.
Select * from Customers where City = 'London'

-- Case Insensitive - Büyük küçük harf duyarsızdır.
Select * from Products Where categoryId = 1 or categoryId = 3

-- <> = koşula uymayanları getir.
Select * from Products Where categoryId = 1 and UnitPrice <> 10

-- order by = sırala demektir.
Select * from Products order by CategoryId,ProductName

-- ascending(asc) = artan, descending(desc) = azalan => olarak sırala
Select * from Products order by UnitPrice asc

-- count(*) = Products tablosunda kaç tane satır olduğunu gösterir.
Select count(*) Adet from Products

-- Hangi Kategoride Kaç Farklı Ürün Var?
-- Group By = Verileri belli koşula göre gruplamamızı sağlar.
Select CategoryId,count(*) from Products group by CategoryId

-- Ürün sayısı 10'dan az olan categorileri listele.
-- having = count(*) gibi kümülatiflere having uygulanır. Kümülatiflerin koşulunun tanımlanmasını sağlar.
Select CategoryId, count(*) from Products Group By CategoryId having count(*)<10

-- Birim Fiyatı 20'den Büyük olan verileri categoryId e göre grupla ve Ürün sayısı 10'dan küçük olanları göster.
Select CategoryId, count(*) from Products Where UnitPrice >20
Group By CategoryId having count(*)<10

-- Join = Tablo Birleştirmek
-- on = keyword sonra Koşul yazılır ve koşulu sağlayanları gösterir.
Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

-- DTO - Data Transformation Object - Join'li sorgular DTO sağlayan sorgulardır.
-- Inner Join tablolardaki eşleşen verileri getirirken Eşleşmeyen verileri getirmez.
-- left join = soldaki tabloda olup sağdaki tabloda olmayanları da birleştirerek getir. Burada inner koşuluda sağlanır. Artı olarak solda olup sağda olmayanlarda eklenir.
Select *
from Products p left join [Order Details] od
on p.ProductID = od.ProductID

-- is null = buna eşitlenmiş data yok demektir. İki tablo birleştirilmiş soldaki var ama sağdaki yok yani null. İşte o null olanlar getirilir.
Select *
from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

-- right join = sağda olup solda olmayan anlamındadır.
Select *
from [Order Details] od right join Products p
on p.ProductID = od.ProductID

-- Birden Fazla Tabloyu Birleştirmek
Select *
from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

-- Her bir üründen toplamda ne kadar para kazandığımızı bulunuz?
-- İpucu : Group by kullanılacak
-- İpucu : Products, Orders, Order Details tabloları join edilecek.
-- İpucu : Sum kullanılacak.
-- Sonuç aşağıdaki formatta olmalıdır.
-- Ürün Adı, Kazanılan Toplam Miktar
-- Not : Kazanılan tutar toplamı Order Details tablosunda unitPrice ve quantity alanlarının çarpımından beslenecek.
Select *
From Products
Select *
From Customers
Select *
From Country
Select *
From Orders
Select *
From [Order Details]
Order By ProductId Asc

Select p.ProductName AS [Ürün Adı], SUM(od.Quantity*p.UnitPrice) AS [Kazanılan Toplam Miktar]
from Products p 
inner join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on o.OrderID = od.OrderID
Group By p.ProductName
Order By p.ProductName ASC;
-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 

-- 
-- 
