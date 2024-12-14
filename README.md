# 📚 **Blog Projesi**


## 🌟 **Genel Bakış**

Bu proje, yazarların blog yazabilmesi ve birbirleri ile etkileşim halinde olabilmesi için geliştirildi.

- ✍️ Yazarlar, yazar panelinden tüm bilgilerine ulaşabilir ve blog yazma işlemlerini gerçekleştirebilir.
- 🔑 Yazar hesabı olmayan kişiler kolayca kayıt yapabilir.
- 📬 Yazarlar ve ziyaretçiler iletişim menüsünden admin ile iletişime geçebilir.
- 📥 E-Posta ile bültene abone olabilir ve gelişmelerden haberdar olabilir.


## 🚀 **Özellikler**

- 👀 Ziyaretçi olarak kayıt olmadan blog'larda gezinmek
- 💬 Fikirlerini belirtmek için yorum sistemi
- 📋 Genel durumu öğrenmek için 'Dashboard' sayfası
- ✉️ Kullanıcıların düşünce ve istekleri için iletişim formu
- 📱 Bootstrap ile responsive tasarım
- ✏️ Kolay bir şekilde yorum ve blog düzenleme


## ⚙️ **Kullanılan Teknolojiler**

- 💻 Web uygulaması yapısı için **ASP.NET Core MVC 6.0**
- 🛠️ ORM (Object-Relational Mapping) aracı olarak **Entity Framework Core**
- 📄 Proje karmaşıklığını önlemek için **N Katmanlı Mimari**
- ⚙️ **CRUD** işlemleri (Ekle, Listele, Güncelle, Sil)
- 🔑 Kullanıcı Kimliğini Doğrulamak için **Identity**
- 📦 Veri erişim katmanını yönetmek ve uygulamanın esnekliğini artırmak için **Repository Design Pattern**
- ✅ Kullanıcıların veri girişlerini doğrulamak için **Fluent Validation**
- 🗄️ Veritabanı olarak **MSSQL Server**
- 🏗️ Veritabanı modellemesi için **Code First** yaklaşımı
- 🔎 Verileri etkin bir şekilde sorgulamak için **LINQ**
- 🎨 Responsive tasarım için **HTML/CSS** ve **Bootstrap**
- 📑 Verileri sayfalara bölünerek listelenmesi için **Pagination**
  


# Proje Yapısı

Bu proje, **4 katmanlı mimari** ile yapılandırılmıştır. Her katman, ilgili işlevleri yerine getiren klasör ve dosyaları içerir.

| Katman Adı                      | Açıklama                       | İçindeki Klasörler / Dosyalar             |
|---------------------------------|--------------------------------|------------------------------------------|
| **SensiveProject.BusinessLayer** | İş mantığını içerir.           | `Abstract`, `Concrete`, `Container`, `ValidationRules` |
| **SensiveProject.DataAccessLayer** | Veritabanı erişim katmanı.     | `Abstract`, `Context`, `EntityFramework`, `Migrations`, `Repositories` |
| **SensiveProject.EntityLayer**   | Varlıkların tanımlandığı katman.| `Concrete` |
| **SensiveProject.PresentationLayer** | Kullanıcı arayüzü katmanı.    | `Areas`, `Controllers`, `Models`, `Views`, `ViewComponents`, `wwwroot`, `appsettings.json`, `Program.cs` |



### **Detaylı Dosya Yapısı**

```
SensiveProject/
│
├── SensiveProject.BusinessLayer/
│   ├── Dependencies/
│   ├── Abstract/
│   ├── Concrete/
│   ├── Container/
│   └── ValidationRules/
│
├── SensiveProject.DataAccessLayer/
│   ├── Dependencies/
│   ├── Abstract/
│   ├── Concrete/
│   ├── Context/
│   ├── EntityFramework/
│   ├── Migrations/
│   ├── Repositories/
│
├── SensiveProject.EntityLayer/
│   ├── Dependencies/
│   └── Concrete/
│
└── SensiveProject.PresentationLayer/
    ├── Connected Services/
    ├── Dependencies/
    ├── Properties/
    ├── wwwroot/
    ├── Areas/
    ├── Controllers/
    ├── Models/
    ├── ViewComponents/
    ├── Views/
    ├── appsettings.json
    └── Program.cs

```
# 🏠 **Anasayfa**
![home](https://github.com/user-attachments/assets/74f1abbb-bc37-46f9-800c-483d13e36f5e)


# 📝 **Blog Detayları**
![ArticleDetail](https://github.com/user-attachments/assets/05330871-b74b-466f-b16d-447f87b9b3cb)


# 📞 **İletişim**
![homeContact](https://github.com/user-attachments/assets/67400ebe-8b0a-47e5-906c-0ed168dda4d3)


# 🔒 **Giriş**
![Login](https://github.com/user-attachments/assets/698a01b0-d4ca-4908-9ff3-5e652515a5e6)


# 🔑 **Kayıt**
![Register](https://github.com/user-attachments/assets/87badb39-9f83-47be-8c81-bab90fca847b)



# ✍️ **Yazar Paneli**
![1](https://github.com/user-attachments/assets/9494ca18-fbd3-4300-b1d6-3988fccea308)
![2](https://github.com/user-attachments/assets/046de44e-cb3f-4d6b-91f5-7cbb269cbf13)
![3](https://github.com/user-attachments/assets/67087458-153b-446d-9e47-2bacb660f0e9)
![4](https://github.com/user-attachments/assets/0400313d-cd7f-401c-9864-d07bf347c0da)


# 🗄️ **Veri İlişkileri**
![sql](https://github.com/user-attachments/assets/aadb8543-5063-4d62-a863-403fdd568806)


# 🛠️ **Kurulum Adımları**

Bu proje **ASP.NET Core 6.0** ve **Code First** yaklaşımı kullanılarak geliştirilmiştir. Aşağıdaki adımları takip ederek projeyi sorunsuz bir şekilde çalıştırabilirsiniz:



## 📥 **1. Depoyu Klonlayın**  
Proje dosyalarını yerel bilgisayarınıza çekmek için aşağıdaki komutu kullanın:  

```
git clone https://github.com/tunadeveloper/SensiveBlogProject.git
```



## 🖥️ **2. Projeyi Visual Studio'da Açın**  
- Visual Studio 2022 veya daha yeni bir sürüm kullanmanızı öneririm.  
- Ana çözüm dosyasını (`SensitiveProject.sln`) Visual Studio ile açın.



## 🗄️ **3. MSSQL Server Ayarları**  
- **SQL Server**'ın yüklü ve çalıştığından emin olun.  
- SQL Server Management Studio (SSMS) kullanarak bağlantınızı doğrulayabilirsiniz.



## ⚙️ **4. Bağlantı Dizgisini Ayarlayın**  
Bağlantı ayarlarını **SensiveProject.DataAccessLayer** katmanında bulunan `Context` klasörü altındaki **`SensiveContext`** sınıfında yapılandırın:

**`SensiveContext.cs`** dosyasını açın ve aşağıdaki kod satırını kendi SQL Server bağlantı bilgilerinizle güncelleyin:

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("Server=YOUR_SERVER_NAME;Database=SensiveDB;Trusted_Connection=True;");
}
```


## 📦 **5. NuGet Paketlerini Yükleyin**  
Gerekli bağımlılıkları yüklemek için Visual Studio'da **Package Manager Console**'u açarak aşağıdaki komutu çalıştırın:

```bash
Update-Package
```



## 🛠️ **6. Veritabanını Oluşturun**  
Code First yaklaşımı ile veritabanını oluşturmak için aşağıdaki komutları sırasıyla çalıştırın:

```bash
Add-Migration InitialCreate
Update-Database
```



## ▶️ **7. Projeyi Çalıştırın**  
- Ana proje olan **SensiveProject.PresentationLayer**'ı seçin.  
- **IIS Express** veya **Kestrel** kullanarak projeyi çalıştırın.  
- Tarayıcınız otomatik olarak projeyi açacaktır. Eğer açılmazsa, Visual Studio'nun Output penceresinden URL'yi kontrol edin:

```http
http://localhost:xxxx
```
## ✅ **8. Kontroller**  
- 'http://localhost:xxxx/Default/HomePage' Adlı ana sayfanın düzgün şekilde çalıştığından emin olun.  
- Tabloların oluşturulup oluşturulmadığını doğrulamak için SQL Server Management Studio (SSMS) ile veritabanına bağlanabilirsiniz.

