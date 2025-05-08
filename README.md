# KelimeOyunu
C# Windows Forms Uygulaması ile İngilizce kelime bilme oyunu. .NET 9.0 kurulu olan bilgisayarlarda çalıştırılabilir.

![Image](https://github.com/user-attachments/assets/65afeabd-1a3f-40f8-8c88-7c719e36217a)

Bu oyun C# kullanılarak Visual Studio 2022 IDE'sinde yapılmıştır. Oyun şu şekilde oynanır:

1 - Kullanıcı oyunu başlattığında karşısına hangi kategorideki kelimelerle oynamak istediğinin sorulduğu bir pencere açılır. Seçilebilecek sözlükler YÖKDİL Fen Bilimleri ve YÖKDİL Sosyal Bilimler'dir.

2 - Sözlük seçimi yapıldıktan sonra "Yükle" tuşuna basılır ve sözlüğün içindeki kelimeler sisteme yüklenir. Sorulacak soru, doğru cevaplar, yanlış cevaplar bu aşamada random olarak belirlenir. (Kod incelendiğinde detayları görülebilir)

3 - "Başla" tuşuna basılır ve oyun ekranı olan 2. pencere açılır. 

4 - Sol üstte oyuncunun kaçıncı soruda olduğu, sağ üstte puanı, ortada sorulan kelime, aşağıda ise şıklar bulunmaktadır. 4 şık vardır.
"Fotoğraf buraya"

5 - Herhangi bir süre sınırlaması yoktur. Oyuncu dilediği kadar oynayabilir.

6 - Oyuncunun sorulan soruya karşı ilk cevabı doğru olan cevap ise oyuncu 10 puan kazanır. Sorulan soruya verilen ilk cevap doğru olmadığı durumda, kullanıcı doğru cevabı bulsa bile ne puan kazanır ne puan kaybeder.

7 - Seçilen cevap yanlış ise cevabın bulunduğu buton kırmızı renge döner.

8 - Oyun bu şekilde devam eder. 

# Oyunu Çalıştırma
1 - Oyunu çalıştırmak için "net9.0-windows" zip dosyasını indirmeniz gerekmektedir.(Zip dosyasının içinde ne olduğunu GitHub üzerinden inceleyebilirsiniz)

2 - İndirdikten sonra klasöre çıkartın ve klasör içindeki "ArdaNDP2.exe" dosyasını çalıştırın. Oyun başlayacaktır.

3 - Eğer Windows bilgisayarınızda ".NET 9.0" kurulu değilse önce kurmanızı isteyebilir. Kurulum tamamlandıktan sonra tekrar denemeniz halinde oyun başlayacaktır. 
