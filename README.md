Herkese Merhaba,

Bu projede Kafe için admin panelli bir web sitesi geliştirdim.

Projede

🚀 Docker
🚀 Web API
🚀 Docker üzerinde çalışan PostgreSQL
🚀 EntityFramework
🚀 Onion Architecture
🚀 Rapid Api
🚀 Mail Gönderme
🚀 PostgreSQL Trigger

Yapılarını kullandım.
<hr>

<h1>Admin Paneli</h1>

![admin01](https://github.com/user-attachments/assets/524c1217-8ccf-4c91-99b4-3398ae911003)

<h3>Dashboard Alanı</h3>

🚀 Rapid Api'den hava durumu bilgisi çekildi <br>
🚀 Kasa tablosu sayesinde gün içinde elde edilen kazançlar dinamik olarak bir önceki güne göre grafikte gösteriliyor.<br>
🚀 En son yapılan 7 rezervasyonlar burada görüntüleniyor<br>

<h3>Masa Durumları Alanı</h3>

 ![admin02](https://github.com/user-attachments/assets/636720a8-36ed-42fc-afb8-c9f388dccbc1)

🚀 Bu alandan boş masalar dolu masalar ve rezerve edilmiş masalar görüntüleniyor.<br>
🚀 Dolu masalar için sipariş alma ve verilen siparşlerin listesine erişim sağlanılabiliyor.<br>
🚀 Rezerve edilen masalar iptal edilene veya rezervasyon onaylana kadar durumu rezerve olarak kalıyor eğer rezervasyon iptal edilirse masanın durmu boş olarak ayarlaniyor eğer rezervasyon onaylanırsa masanın durumu dolu olarak değişiyor.<br>

 <h3>Ürünler Alanı</h3>
 
![admin03](https://github.com/user-attachments/assets/1f7c4d48-a823-4785-9ebb-c06836c91737)

🚀 Ürün listesi burada görüntüleniyor
🚀 Ürünlere fiyat bilgisi ekleme ve eklenen fiyat bilgilerine buradan görüntülenebiliyor.
🚀 Fiyat bilgisi her ürün için eklenmeyebilir
🚀 Fiyat Bilgisini kahve ürünü için örnek alırsak büyük boy orta boy ve kücük boy kahvelerde fiyatların buradan ayrılması sağlanılıyor.
🚀 büyük boy kucuk boy veya orta boy alanları ise ödeme planları sekmesinde tutuluyor.

 <h3>Rezervasyon Alanı</h3>
 
 ![admin04](https://github.com/user-attachments/assets/9e0eea8c-914f-4759-a9f5-fb3e08397115)

 🚀Burada yapılan rezervasyonların bilgileri gösteriliyor
 🚀Admin, rezervasyon onaylıyabilir rezervasyon durumunu güncelleyebilir rezeravsyonu silebillir veya rezervasyonu iptal edebilir ayrıca bu alandan yeni rezervasyon ekliyebilir.
 🚀Onaylanan iptal edilen ve onay bekliyen rezervasyon ilgili butonlar yardımıyla sadece istenilen duruma göre listleme işlemi yapıyor.

 <h1>CoffeBlend Ana Sayfa</h1>
 
![default01](https://github.com/user-attachments/assets/ac21dde5-c3ba-4e50-9493-d6cff3498c45)

🚀 Bu alanda rezervasyon ilgili alandan rezervasyon oluşturulabiliyor oluşturulan rezervasyon kişinin email adresine ; 

![mail01](https://github.com/user-attachments/assets/60359013-9c54-4fd3-92c9-78dbab37b942)

Formatında mail gönderiliyor.

Eğer Admin, rezervasyonu onaylarsa 

![mail02](https://github.com/user-attachments/assets/223c2d85-91c9-42f6-acde-df1df66dff23)

Formatında mail gönderiliyor ve kullanıcıya bildirim sağlanılıyor.

<hr>

![default02](https://github.com/user-attachments/assets/b8e8d17a-1852-465b-bfc7-c4303d9a5716)

🚀 Ürünler kategorilere göre ayrılıp gösteriliyor istenilen kategorideki ürünü görüntülemek bu alan üzerinden sağlanılıyor.

![default03](https://github.com/user-attachments/assets/12043677-0c85-41de-862e-db6da28cb8c2)

🚀 Ürünlere ait olan detaylar bu sayfadan görüntüleniyor.
🚀 admin tarafında eklenen fiyat bilgileri burada listeniyor.




