# Gün 1
## C# Nedir
C# .NET platformu üzerinde çalışır
Nesne yönelimli (OOP) bir dildir
Temel programlama mantığını ve sözdizimini C dilinden aldı
Nesne yönelimli programlama mantığını C++ dilinden aldı
Sanal makine, garbage collection, exception handling ve class-based tasarımını Java'dan aldı
## Escape Characters

| İfade | Anlamı       |
| ----- | ------------ |
| `\n`  | Yeni satır   |
| `\r`  | Satır başı   |
| `\t`  | Tab          |
| `\b`  | Backspace    |
| `\v`  | Vertical Tab |
| `\"`  | Çift tırnak  |
| `\'`  | Tek tırnak   |
| `\\`  | Backslash    |
| `\0`  | null         |
| `\u`  | Unicode4     |
| `\U`  | Unicode8     |
| `\x`  | UnicodeHex   |
## Yorum Bırakma
`//` - Tek satırlık Yorum
`/* */`  - Aralık için Yorum
## Variables

| **Tür**     | **Bit**  | **Tuttuğu Değer Aralığı**                  | **Açıklama / Kullanım**       |
| ----------- | -------- | ------------------------------------------ | ----------------------------- |
| **bool**    | 1        | `true` / `false`                           | Mantıksal değer               |
| **byte**    | 8        | $0 - 255$                                  | Küçük pozitif sayılar         |
| **sbyte**   | 8        | $-128 - 127$                               | Küçük sayılar                 |
| **short**   | 16       | $-32,768 - 32,767$                         | Küçük tamsayı                 |
| **ushort**  | 16       | $0 - 65,535$                               | Pozitif tamsayı               |
| **int**     | 32       | $-2,147,483,648 - 2,147,483,647$           | Varsayılan tamsayı            |
| **uint**    | 32       | $0 - 4,294,967,295$                        | Pozitif tamsayı               |
| **long**    | 64       | $-9,2 Kentilyon - 9,2 Kentilyon$           | Çok büyük sayı                |
| **ulong**   | 64       | $0 - 18,4 Kentilyon$                       | Çok büyük pozitif             |
| **float**   | 32       | $\pm 1.5\text{E}-45 - \pm 3.4\text{E}38$   | Ondalıklı (düşük hassasiyet)  |
| **double**  | 64       | $\pm 5.0\text{E}-324 - \pm 1.7\text{E}308$ | Ondalıklı (yüksek hassasiyet) |
| **decimal** | 128      | $\pm 1.0\text{E}-28 - \pm 7.9\text{E}28$   | Para / finans                 |
| **char**    | 16       | `'\u0000'` – `'\uFFFF'`                    | Tek Unicode karakter          |
| **string**  | değişken |                                            | Metinsel ifadeler             |
float değerinin sonunda f koyulmalı
decimal değerinin sonunda m koyulmalı
### Constant Variable
Daha sonrasında değeri değiştirilemeyen değişkenlerdir
Değişken oluştururken değişken türünün başına const eklenir
const float euler = 2.718f;
### Variable Names
Değişken ismi sayı ile başlayamaz
Değişken isminin içinde boşluk veya + - ! gibi özel karakterler olamaz
camelCase = ilk kelime küçük harfle başlar kalan kelimeler büyük harfle
snake_case = kelimelerin hepsi küçük harfle başlar aralarına alt çizgi koyulur
PascalCase = bütün kelimeler büyük harfle başlar 
_camelcase = alt çizgi ile başlar kalanlar camelCase

## Type Casting
### Kapalı Tür Dönüşümü
Daha küçük bir veri türünü daha büyük bir veri türüne dönüştürme
Veri kaybı ihtimali olmadığı için otomatik olarak yapılır
### Açık Tür Dönüşümü
Daha büyük bir veri türünü daha küçük bir veri türüne dönüştürme
Veri kaybı ihtimali olduğu için manul olarak yapılır

| Convert Metodu       | Hedef Veri Tipi | Açıklama                                      |
| :------------------- | :-------------- | :-------------------------------------------- |
| `Convert.ToInt16`    | `short`         | 16-bit işaretli tamsayı                       |
| `Convert.ToInt32`    | `int`           | 32-bit işaretli tamsayı                       |
| `Convert.ToInt64`    | `long`          | 64-bit işaretli tamsayı                       |
| `Convert.ToDouble`   | `double`        | Ondalıklı sayı (64-bit)                       |
| `Convert.ToSingle`   | `float`         | Ondalıklı sayı (32-bit)                       |
| `Convert.ToDecimal`  | `decimal`       | Finansal / yüksek hassasiyetli ondalıklı sayı |
| `Convert.ToByte`     | `byte`          | 8-bit işaretsiz tamsayı (0 - 255)             |
| `Convert.ToSByte`    | `sbyte`         | 8-bit işaretli tamsayı (-128 - 127)           |
| `Convert.ToString`   | `string`        | Metinsel ifade                                |
| `Convert.ToBoolean`  | `bool`          | Mantıksal değer (true/false)                  |
| `Convert.ToChar`     | `char`          | Tek Unicode karakter                          |
| `Convert.ToDateTime` | `DateTime`      | Tarih ve saat verisi                          |
``` C#
double a = 7.41;
int b = (int)a;  // Yuvarlama işlemi yapılmaz

int c = Convert.ToInt32(Console.ReadLine());  // Yuvarlama işlemi yapılır
int d = int.Parse(Console.ReadLine());

int e = 5;  
string eText  = e.ToString();
```
