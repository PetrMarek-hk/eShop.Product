# eShop.Product

Demo REST API aplikace pro ukázku MVC architektury 

## Packages
.NET 8.0, EntityFramework.SQLLite 9.0.8, EntityFramework 9.0.9

## Projects

 - **eShop.Product.RestService** - StartUp projekt, webová služba
 - eShop.Product.Types - projekt s obecnými typy
 - eShop.Product.Frameworks.Persistence - persistence objektů (SQLLite)
 - eShop.Product.Frameworks.Types - typy použité v rámci Framework
 - eShop.Product.Contracts - contratcs pro použití s externími klienty
 - eShop.Product.ApplicationLogic - aplikační (bussines) logika  

## Database

Databáze pro perzistenci objektů je použita SQLLite, po prvním spuštění se vytvoří databáze Db\eShop.db (pokud neexistuje) a naplní data tabulu Products pokud je prázdná (150 záznamů)
Jako ORM pro přístup k datům je použit EntityFramework 
