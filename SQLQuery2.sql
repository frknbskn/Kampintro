--Select
--ANSII
select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

select * from Customers where  City='London'


--case insensitive büyük, küçük harf duyarsız
select*from Products where CategoryID=1 or CategoryID=3

select*from Products where CategoryID=1 and UnitPrice>10

select*from Products order by ProductName,CategoryID asc --Sırala  ascending=artan asc yazmasa da olur. descending=azalan desc

select*from Products where CategoryID=1 order by UnitPrice desc  --en pahalıdan en ucuza (1. kategroideki)

select count(*) from Products -- kaç ürün olduğunu count=adet 
select count(*) Adet from Products where CategoryID=2 --ürünlerin 2 numaralı kategorideki kaç ürün olduğunu Adet adı altında göster.

select CategoryID from Products group by CategoryId -- bütün kategorileri listele

select CategoryID,count(*) ürün from Products group by CategoryId -- hangi kategoride kaç ürün var?

select CategoryID,count(*) ürün from Products group by CategoryId having count(*)<10   --count kümlatif olduğu için where yerine having yazılır
select CategoryID,count(*) ürün from Products where UnitPrice>20 group by CategoryId having count(*)<10 --birim fiyati 20'den büyük olanları

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from products inner join Categories 
on Products.CategoryID=Categories.CategoryID -- iki tabloyu birleştirmek için  ortak kolon kullanıldı ve görmek istenen tablo oluşturuldu.

--DTO Date Transformation Object

select * from Products P left join [Order Details] OD --solda olup sağda olmayanları da getir ürünlerde olup, satışta olmayanları da
on p.ProductID=OD.ProductID

select*from Customers C left join Orders O --Siparişi olmayan müşterileri de katar. where ile gösterildi.(hiç ürün almayanlar)
on C.CustomerID=O.CustomerID
where O.CustomerID is null

select*from Orders O left join Customers C --aynısı
on C.CustomerID=O.CustomerID
where O.CustomerID is null

select*from Customers C inner join [Order Details] od --2'den fazla tablo birleştirmke
on C.CustomerID=O.CustomerID
inner join Orders O
on O.OrderID=od.OrderId


