# 2024-2025 Uludağ Üniversitesi Görsel Programlama Ödevi
## Açıklama
Kullanıcıdan **ad**, **soyad**, **doğum tarihi**, **boy** ve **kilo** gibi değerleri alan; ekle tuşuna basıldığında **boy** ve **kilo** değeri ile **VKI(Vücut Kitle İndeksi)**, **doğum tarihi** ile de **burç** hesaplayan; **VKI** ve **burç** durumlarına göre **VKIYorum** ve **BurcYorum** adındaki değişkenlere yorumları yazan, bunların sonucundaki değerleri de veri tabanına kaydeden bir windows form uygulamasıdır. 

## 🚀 Özellikler
- **Ekle** Buttonu ile kullanıcı ekleme.
- **Göster** Buttonu ile veri tabanındaki tüm kayıtları gösterme.
- Ekstra olarak **Sil** Buttonu ile kullanıcıları **ad**, **soyad**, **doğum tarihi**, **burç**, **VKI** ve **VKI yorumlarına** göre silme özelliği eklendi. (Eğer tüm değişkenler **boş** bırakılırsa tüm kullanıcılar silinir.)
- Veri tabanı olarak **SQLite** kullanıldı.
  
  - Tablo adı = `Users`
### 💾 Veri tabanı alanları:
- Ad `(TEXT)`
- Soyad `(TEXT)`
- Gun `(INTEGER)`
- Ay `(INTEGER)`
- Yil `(INTEGER)`
- VKI `(REAL)`
- VKIYorum `(TEXT)`
- Burc `(TEXT)`
- BurcYorum `(TEXT)`
- BurcResim `(TEXT)` **Örn:** `koc.png`

#### 🗒️ Ek Notlar:
- Ekrana gösterebilmek için form içerisinde `DataGridView` kullanıldı.
- Burç resimleri resimler klasörü içerisinde bulunmakta.
- Veri tabanına kaydedilen `BurcResim` isimli veri sayesinde dosya yolu bulunmakta ve resim eklenmektedir.(resimler `.png` formatındadır ve resim eklendiğinde `DataGridView` içerisindeki BurcResim kısmı veritabanındaki text `BurcResim` sütununun silinip `Image` olarak tekrar oluşturulmasıyla oluşur.)
