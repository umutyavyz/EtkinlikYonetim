# 🎉 EtkinlikYonetim

**C# ve SQL ile geliştirilmiş bir Etkinlik Yönetim Sistemi**

Bu proje, etkinlik organizasyonlarının dijital ortamda kolayca yönetilmesini sağlar. Kullanıcılar sisteme kaydolup etkinliklere katılabilirken, yöneticiler (admin) yeni etkinlikler oluşturabilir, katılımcıları görüntüleyebilir ve sistemin genel yönetimini gerçekleştirebilir.

## 🚀 Özellikler

### 👤 Kullanıcı Paneli
- Kullanıcı, sisteme TC Kimlik No, Ad Soyad, E-posta gibi bilgilerle kayıt olur.
- Aktif etkinlikleri görüntüler.
- TC Kimlik No ile doğrulama yaptıktan sonra istediği etkinliğe katılabilir.

### 🔐 Admin Paneli
- Yeni etkinlik oluşturabilir.
- Katılımcı ekleyebilir veya silebilir.
- Bilet düzenleyebilir.
- Her etkinlik için kayıtlı katılımcı listesini görüntüleyebilir.

## 🖥️ Ekran Görüntüleri

### Giriş Ekranı
![Giriş Ekranı](login.png)

### Kullanıcı Kayıt Ekranı
![Kullanıcı Kayıt](user_register.png)

### Etkinliğe Katılım Ekranı
![Etkinliğe Katılım](event_register.png)

### Admin Paneli
![Admin Paneli](admin_panel.png)

### Katılımcı Listesi
![Katılımcı Listesi](shows_members.png)

## 🛠️ Kullanılan Teknolojiler

- C# (Windows Forms)
- MSSQL (SQL Server)
- ADO.NET ile veritabanı bağlantısı

## 📦 Kurulum ve Kullanım

1. Bu projeyi GitHub'dan klonlayın:
   ```bash
   git clone https://github.com/kullaniciadi/EtkinlikYonetim.git
   ```

2. Visual Studio'da açın.

3. `databaseHelper.cs` ya da proje içindeki SQL bağlantı string'ini kendi veritabanı bilgilerinizle güncelleyin.

4. MSSQL'de gerekli tabloları oluşturun (Admin, Kullanıcı, Etkinlik, Katılımcı vs.)

5. Uygulamayı çalıştırın ve test edin.

## 📌 Notlar
- TC Kimlik numarası doğrulaması yalnızca sistem içi kontrolle yapılmaktadır.
- Kullanıcıların sisteme birden fazla etkinlik kaydı yapması mümkündür.
- Admin yetkisi giriş ekranında kontrol edilmektedir.

## 📧 İletişim

Proje hakkında sorularınız için benimle iletişime geçebilirsiniz.
