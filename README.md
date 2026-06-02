# Web Tabanlı Programlama Database First Projesi

Bu proje, ASP.NET Core MVC ve Entity Framework Core kullanılarak hazırlanmış kısa bir Database First örneğidir. Projede var olan SQL Server veritabanından oluşturulan `Category` modeli ve `DatabaseFirstDbContext` sınıfı kullanılır.

## Gereksinimler

- .NET 8 SDK
- SQL Server LocalDB
- Visual Studio 2022 veya terminal

## Veritabanı Kurulumu

SQL Server üzerinde aşağıdaki veritabanı ve tabloyu oluşturun:

```sql
CREATE DATABASE [Web_Tabanlı_Programlama_Database_First_Db];
GO

USE [Web_Tabanlı_Programlama_Database_First_Db];
GO

CREATE TABLE Categories (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(200) NULL
);
GO
```

Bağlantı bilgisi `appsettings.json` dosyasında `DefaultConnection` alanında bulunur.

## Çalıştırma

Proje klasöründe terminal açıp şu komutları çalıştırın:

```bash
dotnet restore
dotnet run --project Web_Tabanlı_Programlama_Database_First_Projesi
```

Uygulama çalıştığında terminalde verilen localhost adresinden açılabilir.

Uygulama ilk açılışta `Categories` tablosu boşsa örnek bir kategori kaydı ekler.

## Proje Yapısı

- `Models/Category.cs`: Kategori modeli
- `Data/DatabaseFirstDbContext.cs`: Veritabanı bağlantı sınıfı
- `Controllers/HomeController.cs`: Ana sayfa kontrolcüsü
- `Views/Home/Index.cshtml`: Ana sayfa görünümü
