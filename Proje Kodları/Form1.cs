namespace ArdaNDP2
{

    public partial class Form1 : Form
    {
        bool yukleme = false; // Yükle butonuna basılıp, sözlüğün yüklenip yüklenmediğini kontrol ediyoruz

        public Form1()
        {
            InitializeComponent();

            if(yukleme == false) // Eğer sözlük yükleme işlemi yapılmamışsa
            {
                baslaButton.Enabled = false; // Başla butonu kapatılıyor
                baslaButton.BackColor = Color.FromArgb(128, 255, 255, 255); // Şeffaf görünüm veriliyor
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            sozlukBox1.Items.Add("YOKDIL Fen Bilimleri.txt"); // .exe dosyasının bulunduğu klasöre sözlükler ekleniyor
            sozlukBox1.Items.Add("YOKDIL Sosyal Bilimler.txt"); // ve bu sözlükler sozlukBox1 adlı comboBox'a obje olarak ekleniyor
        }

        public void sozlukBox1_Click(object sender, EventArgs e)
        {
            sozlukBox1.DroppedDown = true; // sozlukBox1'in üzerine tıklanınca seçeneklerin açılması sağlanıyor
        }

        List<string> ingilizceKelimeler = new List<string>(); // İngilizce kelimelerin depolanacağı boş bir liste oluşturuluyor
        List<string> turkceKelimeler = new List<string>(); // Türkçe kelimelerin depolanacağı boş bir liste oluşturuluyor
        public void yukleButton_Click(object sender, EventArgs e)
        {
            string secilen = ""; // secilen isimli değişken, boş olarak oluşturuluyor
            if(sozlukBox1.SelectedItem == null) 
            {
                MessageBox.Show("Önce sözlük seçmelisiniz!"); // Eğer sözlük seçilmemişse sözlük seçme uyarısı veriliyor
                return;
            }
            else
            {
                secilen = sozlukBox1.SelectedItem.ToString(); // Sözlük seçildiğinde, seçilen sözlük objesi, string'e dönüştürülüyor
                string[] satirlar = File.ReadAllLines($"{secilen}"); // Seçilen .txt dosyasının içindeki her bir satırı, satirlar adlı bir diziye dönüştürüyoruz

                foreach (string satir in satirlar)
                {
                    if (!string.IsNullOrWhiteSpace(satir)) // Eğer boş eleman yoksa
                    {
                        string[] parcalar = satir.Split('\t'); // Elemanları tab karakterine göre parçaya ayır
                        if (parcalar.Length >= 2) // Parçaların sayısı 2'den büyük eşitse
                        {
                            ingilizceKelimeler.Add(parcalar[0]); // İlk parçayı ingilizceKelimeler listesine ekle
                            turkceKelimeler.Add(parcalar[1]); // İkinci parçayı turkceKelimeler listesine ekle
                        }
                    }
                }

                if (ingilizceKelimeler.Count != 0 && turkceKelimeler.Count != 0) // Eğer bu listelerin eleman sayıları 0 değilse
                {
                    MessageBox.Show("Sözlük başarıyla yüklendi!");
                    baslaButton.Enabled = true; // Başla butonunu aktifleştir
                    return;
                   
                }
                else // 0'dan farklıysa
                {
                    MessageBox.Show("Sözlük yüklenemedi!"); 
                }
            }   
        }

        public void baslaButton_Click(object sender, EventArgs e)
        {
            if (ingilizceKelimeler.Count == 0 && turkceKelimeler.Count == 0) // Eğer listelerin eleman sayısı sıfırsa
            {
                MessageBox.Show("Önce bir sözlük yüklemelisin!"); // Önce sözlük yüklenmesini iste
                return; // Bu kısım zaten çalışmaz çünkü yükleme yapılmadan başla butonuna basılmıyor. Yine de koyduk.
            }
            else // Eleman sayıları 0'dan farklıysa
            {
                Form2 form2 = new Form2(ingilizceKelimeler, turkceKelimeler); // O listeleri Form2'ye yükleyecek şekilde form2 oluştur
                form2.Show(); // ve form2'yi aç
            }
        }
        public void cikisButton_Click(object sender, EventArgs e)
        {
            Close(); // Çıkış butonuyla tüm programı kapat
        }
    }
}
