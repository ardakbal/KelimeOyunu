// ÖÐRENCÝ ADI:      ARDA AKBAL
// ÖÐRENCÝ NUMARASI: B231210024
// DERS ADI:         NESNEYE DAYALI PROGRAMLAMA
// GRUP:             1 - C 

namespace ArdaNDP2
{

    public partial class Form1 : Form
    {
        bool yukleme = false; // Yükle butonuna basýlýp, sözlüðün yüklenip yüklenmediðini kontrol ediyoruz

        public Form1()
        {
            InitializeComponent();

            if(yukleme == false) // Eðer sözlük yükleme iþlemi yapýlmamýþsa
            {
                baslaButton.Enabled = false; // Baþla butonu kapatýlýyor
                baslaButton.BackColor = Color.FromArgb(128, 255, 255, 255); // Þeffaf görünüm veriliyor
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            sozlukBox1.Items.Add("YOKDIL Fen Bilimleri.txt"); // .exe dosyasýnýn bulunduðu klasöre sözlükler ekleniyor
            sozlukBox1.Items.Add("YOKDIL Sosyal Bilimler.txt"); // ve bu sözlükler sozlukBox1 adlý comboBox'a obje olarak ekleniyor
        }

        public void sozlukBox1_Click(object sender, EventArgs e)
        {
            sozlukBox1.DroppedDown = true; // sozlukBox1'in üzerine týklanýnca seçeneklerin açýlmasý saðlanýyor
        }

        List<string> ingilizceKelimeler = new List<string>(); // Ýngilizce kelimelerin depolanacaðý boþ bir liste oluþturuluyor
        List<string> turkceKelimeler = new List<string>(); // Türkçe kelimelerin depolanacaðý boþ bir liste oluþturuluyor
        public void yukleButton_Click(object sender, EventArgs e)
        {
            string secilen = ""; // secilen isimli deðiþken, boþ olarak oluþturuluyor
            if(sozlukBox1.SelectedItem == null) 
            {
                MessageBox.Show("Önce sözlük seçmelisiniz!"); // Eðer sözlük seçilmemiþse sözlük seçme uyarýsý veriliyor
                return;
            }
            else
            {
                secilen = sozlukBox1.SelectedItem.ToString(); // Sözlük seçildiðinde, seçilen sözlük objesi, string'e dönüþtürülüyor
                string[] satirlar = File.ReadAllLines($"{secilen}"); // Seçilen .txt dosyasýnýn içindeki her bir satýrý, satirlar adlý bir diziye dönüþtürüyoruz

                foreach (string satir in satirlar)
                {
                    if (!string.IsNullOrWhiteSpace(satir)) // Eðer boþ eleman yoksa
                    {
                        string[] parcalar = satir.Split('\t'); // Elemanlarý tab karakterine göre parçaya ayýr
                        if (parcalar.Length >= 2) // Parçalarýn sayýsý 2'den büyük eþitse
                        {
                            ingilizceKelimeler.Add(parcalar[0]); // Ýlk parçayý ingilizceKelimeler listesine ekle
                            turkceKelimeler.Add(parcalar[1]); // Ýkinci parçayý turkceKelimeler listesine ekle
                        }
                    }
                }

                if (ingilizceKelimeler.Count != 0 && turkceKelimeler.Count != 0) // Eðer bu listelerin eleman sayýlarý 0 deðilse
                {
                    MessageBox.Show("Sözlük baþarýyla yüklendi!");
                    baslaButton.Enabled = true; // Baþla butonunu aktifleþtir
                    return;
                   
                }
                else // 0'dan farklýysa
                {
                    MessageBox.Show("Sözlük yüklenemedi!"); 
                }
            }   
        }

        public void baslaButton_Click(object sender, EventArgs e)
        {
            if (ingilizceKelimeler.Count == 0 && turkceKelimeler.Count == 0) // Eðer listelerin eleman sayýsý sýfýrsa
            {
                MessageBox.Show("Önce bir sözlük yüklemelisin!"); // Önce sözlük yüklenmesini iste
                return; // Bu kýsým zaten çalýþmaz çünkü yükleme yapýlmadan baþla butonuna basýlmýyor. Yine de koyduk.
            }
            else // Eleman sayýlarý 0'dan farklýysa
            {
                Form2 form2 = new Form2(ingilizceKelimeler, turkceKelimeler); // O listeleri Form2'ye yükleyecek þekilde form2 oluþtur
                form2.Show(); // ve form2'yi aç
            }
        }
        public void cikisButton_Click(object sender, EventArgs e)
        {
            Close(); // Çýkýþ butonuyla tüm programý kapat
        }
    }
}