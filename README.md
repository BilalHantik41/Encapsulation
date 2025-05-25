# Encapsulation - Araba Örneği

Basit bir C# konsol uygulaması aracılığıyla **Encapsulation (Kapsülleme)** kavramını göstermektedir.

## İçindekiler

* [Hakkında](#hakkında)
* [Gereksinimler](#gereksinimler)
* [Başlarken](#başlarken)
* [Proje Yapısı](#proje-yapısı)
* [Kullanım](#kullanım)
* [Encapsulation Açıklaması](#encapsulation-açıklaması)
* [Katkıda Bulunma](#katkıda-bulunma)
* [Lisans](#lisans)

## Hakkında

Bu proje, C# dilinde bir **Araba** sınıfı üzerinden kapsülleme (encapsulation) kullanımını örnekler. Sınıfın içsel verisi (`_KapıSayısı`) `private` olarak saklanır ve yalnızca tanımlı koşulları sağlayan değeri kabul eder.

## Gereksinimler

* .NET 6.0 SDK veya üzeri
* Visual Studio 2022 veya Visual Studio Code gibi bir IDE

## Başlarken

1. Depoyu klonlayın:

   ```bash
   git clone https://github.com/BilalHantik41/Encapsulation.git
   cd Encapsulation/Encapsulation
   ```
2. Projeyi derleyin:

   ```bash
   dotnet build Encapsulation.sln
   ```
3. Uygulamayı çalıştırın:

   ```bash
   dotnet run --project Encapsulation
   ```

## Proje Yapısı

```
Encapsulation/            # Çözüm klasörü
├─ Encapsulation.sln     # Visual Studio çözümü
├─ Encapsulation/        # C# proje klasörü
│  ├─ Program.cs         # Konsol uygulamasının giriş noktası
│  └─ Araba.cs           # Araba sınıfı (kapsülleme örneği)
├─ README.md             # Bu dosya
├─ .gitignore
└─ .gitattributes
```

## Kullanım

1. Uygulama çalışınca sizden araba bilgileri istenir:

   * Marka
   * Model
   * Renk
   * Kapı Sayısı (2 veya 4 olmalı)

2. Geçerli bir kapı sayısı girilmezse `-1` atanır.

3. Tüm bilgiler ekrana yazdırılır.

```text
Lütfen Araç Bilgilerini Giriniz:
Arabanın Markası: Toyota
Arabanın Modeli: Corolla
Arabanın Rengi: Kırmızı
Arabanın Kapı Sayısı: 3

Arabanın Markası: Toyota
Arabanın Modeli: Corolla
Arabanın Rengi: Kırmızı
Arabanın Kapı Sayısı: -1
```

## Encapsulation Açıklaması

* **Kapsülleme (Encapsulation)**, bir nesnenin verilerini `private` alanlarda saklayıp dışarıya `public` özellikler (properties) veya yöntemler (methods) aracılığıyla sunma tekniğidir.
* Bu sayede veri doğrulama, iş kuralları ve iç veri bütünlüğü kontrolü setter metotlarında gerçekleştirilebilir.
* `Araba` sınıfındaki `KapıSayısı` özelliği yalnızca `2` veya `4` değerini kabul eder; diğer durumlarda `-1` atamasıyla hata durumu temsil edilir.

## Katkıda Bulunma

1. Depoyu fork’layın
2. Yeni bir branch oluşturun (`git checkout -b feature/yenilik`)
3. Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik'`)
4. Branch’inizi push’layın (`git push origin feature/yenilik`)
5. Pull request açın

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Detaylar için `LICENSE` dosyasına bakabilirsiniz.
