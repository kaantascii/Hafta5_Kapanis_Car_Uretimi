🚗 Araba Üretim Simülasyonu (Kapanış Projesi)
Bu proje, kullanıcı etkileşimiyle çalışan basit bir C# konsol uygulamasıdır. Kullanıcıdan araba üretmek için gerekli bilgiler alınır, arabalar bir listeye kaydedilir ve üretim sonlandığında üretilen arabalar ekrana yazdırılır.

💡 Proje Amacı
Nesne yönelimli programlamayı (OOP) uygulamak

List<T>, class, try-catch, kullanıcı girişi gibi temel C# yapılarını pratik etmek

Hatalı girişlerle başa çıkmayı öğrenmek

🛠️ Kullanılan Yapılar
Araba sınıfı: Marka, model, renk, kapı sayısı vb. bilgileri tutar

UretimTarihi: Araba sınıfının yapıcısında otomatik atanır

List<Araba>: Birden fazla arabayı tutmak için dinamik liste

try-catch: Kapı sayısı gibi sayısal girişlerde hataları engellemek için

Konsol Girdileri: Kullanıcıdan veri alınır, doğrulama yapılır

🔁 Program Akışı
Kullanıcıya araba üretmek isteyip istemediği sorulur (E/H).

Cevap evet (E) ise araba üretimi başlatılır:

Seri numarası, marka, model, renk kullanıcıdan alınır.

Kapı sayısı try-catch ile sayısal doğrulamayla alınır.

UretimTarihi otomatik atanır.

Araba listeye eklenir.

Kullanıcıya yeni bir araba daha üretmek isteyip istemediği sorulur.

Hayır (H) cevabında, liste yazdırılır ve program sonlanır.


