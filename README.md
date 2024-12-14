blog projesi 
-

# Proje Yapısı

Bu proje, **4 katmanlı mimari** ile yapılandırılmıştır. Her katman, ilgili işlevleri yerine getiren klasör ve dosyaları içerir.

| Katman Adı                      | Açıklama                       | İçindeki Klasörler / Dosyalar             |
|---------------------------------|--------------------------------|------------------------------------------|
| **SensiveProject.BusinessLayer** | İş mantığını içerir.           | `Abstract`, `Concrete`, `Container`, `ValidationRules` |
| **SensiveProject.DataAccessLayer** | Veritabanı erişim katmanı.     | `Abstract`, `Context`, `EntityFramework`, `Migrations`, `Repositories` |
| **SensiveProject.EntityLayer**   | Varlıkların tanımlandığı katman.| `Concrete` |
| **SensiveProject.PresentationLayer** | Kullanıcı arayüzü katmanı.    | `Areas`, `Controllers`, `Models`, `Views`, `ViewComponents`, `wwwroot`, `appsettings.json`, `Program.cs` |

---

### **Detaylı Dosya Yapısı**

```markdown
SensiveProject/
│
├── SensiveProject.BusinessLayer/
│   ├── Dependencies/
│   ├── Abstract/
│   ├── Concrete/
│   ├── Container/
│   ├── ErrorMessages/
│   ├── Logging/
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
│   └── UnitOfWork/
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


![ArticleDetail](https://github.com/user-attachments/assets/05330871-b74b-466f-b16d-447f87b9b3cb)
![home](https://github.com/user-attachments/assets/74f1abbb-bc37-46f9-800c-483d13e36f5e)
![homeContact](https://github.com/user-attachments/assets/67400ebe-8b0a-47e5-906c-0ed168dda4d3)
![Login](https://github.com/user-attachments/assets/698a01b0-d4ca-4908-9ff3-5e652515a5e6)
![Register](https://github.com/user-attachments/assets/87badb39-9f83-47be-8c81-bab90fca847b)
![sql](https://github.com/user-attachments/assets/aadb8543-5063-4d62-a863-403fdd568806)
![1](https://github.com/user-attachments/assets/9494ca18-fbd3-4300-b1d6-3988fccea308)
![2](https://github.com/user-attachments/assets/046de44e-cb3f-4d6b-91f5-7cbb269cbf13)
![3](https://github.com/user-attachments/assets/67087458-153b-446d-9e47-2bacb660f0e9)
![4](https://github.com/user-attachments/assets/0400313d-cd7f-401c-9864-d07bf347c0da)
