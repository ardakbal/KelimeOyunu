// ÖĞRENCİ ADI:      ARDA AKBAL
// ÖĞRENCİ NUMARASI: B231210024
// DERS ADI:         NESNEYE DAYALI PROGRAMLAMA
// GRUP:             1 - C 

using System.Data;
namespace ArdaNDP2
{
    public partial class Form2 : Form
    {
        List<string> ingilizce; // Form1'den gelecek inglizceKelimeler için liste oluşturduk
        List<string> turkce; // Form1'den gelecek turkceKelimeler için liste oluşturduk
        List<int> dogru_cevap_index = new List<int>(); // Arasında seçilen sorunun indeksini taşıyan karışık bir index listesi
        List<int> yanlis_cevap_index = new List<int>(); // Arasında seçilen sorunun indeksinin olmadığı karışık bir index listesi
        int m = 0; // m sayısı, 0'dan başlayarak karışık listelerin içini tarıyor
        int puan = 0; // puan 0 olarak başlıyor
        Random randombuton = new Random(); // Doğru cevabın hangi butonda olacağını belirleyen random nesnesi
        Random rnd_yanlis_index = new Random(); // Rastgele 3 tane yanlış soru indexi seçmek için kullanılacak random nesnesi

        public void karistir() // Belirtilen listelerin karışık olmasını sağlayan fonksiyon
        {
            dogru_cevap_index.Clear();
            yanlis_cevap_index.Clear();

            for (int i = 0; i < ingilizce.Count; i++)
            {
                dogru_cevap_index.Add(i); // Seçilen sözlükte kaç tane eleman varsa, 0'dan başlayacak şekilde o kadar eleman sırayla ekleniyor
                yanlis_cevap_index.Add(i);
            }
            Random dogru = new Random();
            dogru_cevap_index = dogru_cevap_index.OrderBy(x => dogru.Next()).ToList(); // Liste karıştırılıyor
            Random yanlis = new Random();
            yanlis_cevap_index = yanlis_cevap_index.OrderBy(x => yanlis.Next()).ToList(); // Liste karıştırılıyor
        }

        public void dogrucevap() // Doğru cevap verildiğinde çalışacak fonksiyon
        {
            // Kırmızı renkte kalan butonları yeni soruya geçtiğimiz için tekrar beyaz yapıyoruz
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            m++;
            Soru_Cevap();
        }

        public void Soru_Cevap() // Sorunun sorulması ve cevap alma mekanizmalarını barındıran fonksiyon
        {
            if (m < dogru_cevap_index.Count) // m sayısı sözlükteki eleman sayısından küçük ise
            {
                label1.Text = ingilizce[dogru_cevap_index[m]]; // Sorulacak İngilizce kelimenin belirlenmesi ve label'a yazılması
                yanlis_cevap_index.Remove(dogru_cevap_index[m]); // Belirlenen kelimenin indexi, yanlış cevapların indexlerinin bulunduğu listeden çıkartılıyor
                // Bu sayede şıklarda doğru cevabın birden fazla tane gözükmesinin önüne geçiliyor
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.Font = new Font("Arial", 12, FontStyle.Bold);

                label5.Text = $"{m + 1} / {dogru_cevap_index.Count}"; // Kaçıncı soruda olduğumuzun göstergesi(Aşama)
                label5.TextAlign = ContentAlignment.MiddleCenter;

                List<Button> butun_butonlar = new List<Button>(); // Cevap butonlarının barınacağı, Button türünden bir liste
                butun_butonlar = [button1, button2, button3, button4]; // Cevap butonları

                Button dogruButon = butun_butonlar[randombuton.Next(butun_butonlar.Count)]; // Aralarından random olarak bir tanesi doğru cevap butonu olarak belirleniyor
                List<Button> yanlisButonlar = new List<Button>(butun_butonlar); // Cevap butonlarının barındığı listeden bir tane daha oluşturuluyor
                yanlisButonlar.Remove(dogruButon); // O listeden doğru buton çıkarılıyor ve yanlış butonlar listesi meydana geliyor

                // Yanlış cevapların olduğu listenin index listesinden 3 tane rastgele indeks alma işlemi
                // Bunu yapma sebebimiz, yanlış cevapların butonlarına hangi kelimelerin gönderileceğini belirlemek
                List<int> y_index = new List<int>(); // 3 tane elemanın barınacağı alt küme mantığına y_index listesi oluşturuluyor
                for (int j = 0; j < 3; j++)
                {
                    int k = rnd_yanlis_index.Next(yanlis_cevap_index.Count); // yanlis_cevap_index isimli büyük index listesinin eleman sayısından rastgele bir k sayısı seçiliyor
                    y_index.Add(yanlis_cevap_index[k]); // yanlis_cevap_index'inin k. indexinde hangi sayı varsa o sayı y_index listesine ekleniyor
                    yanlis_cevap_index.Remove(yanlis_cevap_index[k]); // O sayı, tekrar seçilmemesi gerektiği için yanlis_cevap_index listesinden çıkartılıyor
                } // Bu işlem 3 kere yapılıyor ve 3 elemanlı y_index listesi tamamlanmış oluyor

                for (int w = 0; w < 3; w++) 
                {
                    yanlisButonlar[w].Text = turkce[y_index[w]]; // Yanlış cevapların gözükeceği butonlara y_index listesindeki indexler sayesinde turkce listesinden elemanlar seçiliyor ve butona yazdırılıyor
                }

                dogruButon.Text = turkce[dogru_cevap_index[m]]; // Doğru cevabın gözüktüğü butona da turkce listesinin m. indexinde bulunan kelime yazdırılıyor

            }
            else //  m sayısı sözlükteki eleman sayısına eşit olduğunda
            {
                MessageBox.Show("Bütün kelimeleri bitirdiniz!"); // Tüm sorular tükenmiş oluyor
            }
        }

        public Form2(List<string> ingilizce, List<string> turkce) 
        {
            InitializeComponent();
            this.ingilizce = ingilizce; // Form1.cs'den getirilen listeler, burada eşleştiriliyor
            this.turkce = turkce;
            karistir(); // karistir fonksiyonu çalıştırılıyor ve o fonksiyonun içindeki listeler hazır hale geliyor. Bu fonksiyonun yalnızca 1 kere çalışması gerekmekte. Buna dikkat edildi.

            Soru_Cevap(); // Ardından soru cevap fonksiyonu çalıştırılarak kelimeler bitene kadar program çalışmaya başlıyor
        }

        private void Form2_Load(object sender, EventArgs e) { }

        public void puanlama() // Puanlama mekanizmasının bulunduğu fonksiyon
        {
            puan += 10; // Fonksiyon çalıştığında 10 puan eklenecek
            label6.Text = puan.ToString();
            label6.TextAlign = ContentAlignment.MiddleCenter;
        }

        bool puan_kesici = false; // Eğer kullanıcı önce yanlış cevabı seçerse, o soru için puan alamamasını sağlayacak
        // puan kesici değişkeni. Başlangıçta false olarak atanıyor. Eğer false ise kullanıcı puan alabilecek. True ise puan alamayacak
        // şekilde bir sistem oluşturuldu. True'ya dönse bile sonraki soruya geçildiğinde tekrardan false oluyor.


        private void button1_Click(object sender, EventArgs e)
        {
            if (turkce[dogru_cevap_index[m]] == button1.Text) // Eğer button1'in içindeki yazı, doğru cevap kelimesi ise
            {
                if(puan_kesici == false) // Eğer puan kesici false ise
                {
                    dogrucevap(); // Doğru cevap işlemlerini başlat
                    puanlama(); // Puanını ver
                }
                else // puan kesici true ise
                {
                    dogrucevap(); // Doğru cevap işlemlerini başlat
                    puan_kesici = false; // puan kesiciyi tekrardan false yap
                }
            }
            else // butonun içindeki yazı, doğru cevap kelimesi değilse
            {
                button1.BackColor = Color.Red; // Butonu kırmızı yap
                puan_kesici = true; // puan kesiciyi true yap ki, o soru bitene kadar puan alama
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turkce[dogru_cevap_index[m]] == button2.Text)
            {
                if (puan_kesici == false)
                {
                    dogrucevap();
                    puanlama();
                }
                else
                {
                    dogrucevap();
                    puan_kesici = false;
                }
            }
            else
            {
                button2.BackColor = Color.Red;
                puan_kesici = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turkce[dogru_cevap_index[m]] == button3.Text)
            {
                if (puan_kesici == false)
                {
                    dogrucevap();
                    puanlama();
                }
                else
                {
                    dogrucevap();
                    puan_kesici = false;
                }
            }
            else
            {
                button3.BackColor = Color.Red;
                puan_kesici = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turkce[dogru_cevap_index[m]] == button4.Text)
            {
                if (puan_kesici == false)
                {
                    dogrucevap();
                    puanlama();
                }
                else
                {
                    dogrucevap();
                    puan_kesici = false;
                }
            }
            else
            {
                button4.BackColor = Color.Red;
                puan_kesici = true;
            }
        }
    }
}