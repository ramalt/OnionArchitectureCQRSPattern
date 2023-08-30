# Onion Architecture: CQRS ve MediatR Kullanımı
![](https://camo.githubusercontent.com/07832a2276c948e197784ba3d53a91b70da3906520b61e7488f70e0f9a6e9ddc/68747470733a2f2f7465616d736d696c65792e6769746875622e696f2f6173736574732f636c65616e2d6172636869746563747572652d646f746e65742e706e67)
Bu proje, .NET platformunda CQRS (Command Query Responsibility Segregation), MediatR kütüphanesi ve Onion Architecture kullanılarak geliştirilmiş bir API örneğini içermektedir. Aşağıda proje kurulumu, CQRS, MediatR, Onion Architecture ve bu kavramların birbiriyle ilişkisi hakkında bilgi bulabilirsiniz.

## Test Edin

1. Projenin son halini indirin veya klonlayın.
2. Proje dizinine gidin: `cd OnionArchitectureCQRSPattern`
3. Gerekli bağımlılıkları yüklemek için aşağıdaki komutu çalıştırın: `dotnet restore`
4. Projeyi başlatmak için: `dotnet run`
5. Tarayıcınızda veya API test aracında `https://localhost:5199` adresine giderek API'yi test edin.

## Onion Architecture Nedir?

Onion Architecture, yazılım projelerini katmanlar halinde organize etmek ve bağımlılıkları kontrol altında tutmak amacıyla kullanılan bir tasarım yaklaşımıdır. Bu yaklaşım, çekirdek iş mantığını dışa açılan katmanlara bağlı hale getirmemek için tasarlanmıştır. Onion mimarisinde genellikle şu katmanlar yer alır:

- **Domain Katmanı**: İş mantığını ve iş alanı kurallarını içerir. Diğer katmanlara bağımlı değildir.
- **Application Katmanı**: Kullanıcı taleplerini alır, iş mantığına ileterek sonuçları döndürür.
- **Infrastructure Katmanı**: Veritabanı erişimi, harici servisler ve dış bağımlılıkları yönetir.
- **Presentation Katmanı**: Kullanıcı arayüzünü oluşturur.

## CQRS ve Onion Architecture İlişkisi

CQRS (Command Query Responsibility Segregation), Onion Architecture'ın ileri düzeyde bir uygulaması olarak görülebilir. Her iki yaklaşım da iş mantığını ve veri akışını düzenlerken, CQRS işlemleri komutlar (veri yazma) ve sorgular (veri okuma) olarak ayrılmış katmanlarla ele alır. Bu, Onion Architecture'ın amacıyla uyumlu bir şekilde, çekirdek iş mantığını dış dünyadan soyutlayarak bakımı ve genişletmeyi kolaylaştırır.

## MediatR Nedir?

MediatR, .NET uygulamalarında mediator (aracı) desenini uygulamayı kolaylaştıran bir kütüphanedir. Bu desen, nesneler arasındaki iletişimi düzenler ve merkezi bir iletişim kanalı sağlar. MediatR, komut ve isteklerin (query) işlenmesi için kullanılırken kodun düzenini basit ve sürdürülebilir tutmayı amaçlar.

## Sonuç

Bu proje, CQRS, MediatR ve Onion Architecture kullanımının temel bir örneğini sunmaktadır. Bu yaklaşımlar, ölçeklenebilirlik, bakım kolaylığı ve kod düzeni açısından önemli avantajlar sağlayabilir.
