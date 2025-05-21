# Geometrik Şekillerle Alan Hesaplama (Polymorphism Örneği)

Bu basit C# uygulaması, nesne yönelimli programlamada **polymorphism (çok biçimlilik)** ilkesini göstermek amacıyla hazırlanmıştır. Uygulama; Kare, Dikdörtgen ve Dik Üçgen gibi geometrik şekillerin alanlarını hesaplamak için temel bir mimari sunar.

## 🚀 Amaç

- **Kalıtım (Inheritance)** ve **Polymorphism** kullanımını göstermek.
- Temel sınıf üzerinden ortak özelliklerin yönetimi.
- Override edilen metotlarla şekillere özel davranışların tanımlanması.

## 🧱 Yapı

### 🔹 BaseGeometrikSekil (Temel Sınıf)

Ortak property'ler:
- `Genislik`
- `Yukseklik`

Ortak (virtual) metot:
- `AlanHesapla()` → Şeklin alanını hesaplar (default: genişlik × yükseklik)

### 🔹 Alt Sınıflar

#### ▪ Kare
- `Alan = Genislik × Yukseklik`

#### ▪ Dikdörtgen
- `Alan = Genislik × Yukseklik`

#### ▪ Dik Üçgen
- `Alan = (Genislik × Yukseklik) / 2`

Her biri `BaseGeometrikSekil` sınıfından türemektedir ve `AlanHesapla()` metodunu override ederek kendi alan formülünü uygular.
