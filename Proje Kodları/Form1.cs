// ��RENC� ADI:      ARDA AKBAL
// ��RENC� NUMARASI: B231210024
// DERS ADI:         NESNEYE DAYALI PROGRAMLAMA
// GRUP:             1 - C 

namespace ArdaNDP2
{

    public partial class Form1 : Form
    {
        bool yukleme = false; // Y�kle butonuna bas�l�p, s�zl���n y�klenip y�klenmedi�ini kontrol ediyoruz

        public Form1()
        {
            InitializeComponent();

            if(yukleme == false) // E�er s�zl�k y�kleme i�lemi yap�lmam��sa
            {
                baslaButton.Enabled = false; // Ba�la butonu kapat�l�yor
                baslaButton.BackColor = Color.FromArgb(128, 255, 255, 255); // �effaf g�r�n�m veriliyor
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            sozlukBox1.Items.Add("YOKDIL Fen Bilimleri.txt"); // .exe dosyas�n�n bulundu�u klas�re s�zl�kler ekleniyor
            sozlukBox1.Items.Add("YOKDIL Sosyal Bilimler.txt"); // ve bu s�zl�kler sozlukBox1 adl� comboBox'a obje olarak ekleniyor
        }

        public void sozlukBox1_Click(object sender, EventArgs e)
        {
            sozlukBox1.DroppedDown = true; // sozlukBox1'in �zerine t�klan�nca se�eneklerin a��lmas� sa�lan�yor
        }

        List<string> ingilizceKelimeler = new List<string>(); // �ngilizce kelimelerin depolanaca�� bo� bir liste olu�turuluyor
        List<string> turkceKelimeler = new List<string>(); // T�rk�e kelimelerin depolanaca�� bo� bir liste olu�turuluyor
        public void yukleButton_Click(object sender, EventArgs e)
        {
            string secilen = ""; // secilen isimli de�i�ken, bo� olarak olu�turuluyor
            if(sozlukBox1.SelectedItem == null) 
            {
                MessageBox.Show("�nce s�zl�k se�melisiniz!"); // E�er s�zl�k se�ilmemi�se s�zl�k se�me uyar�s� veriliyor
                return;
            }
            else
            {
                secilen = sozlukBox1.SelectedItem.ToString(); // S�zl�k se�ildi�inde, se�ilen s�zl�k objesi, string'e d�n��t�r�l�yor
                string[] satirlar = File.ReadAllLines($"{secilen}"); // Se�ilen .txt dosyas�n�n i�indeki her bir sat�r�, satirlar adl� bir diziye d�n��t�r�yoruz

                foreach (string satir in satirlar)
                {
                    if (!string.IsNullOrWhiteSpace(satir)) // E�er bo� eleman yoksa
                    {
                        string[] parcalar = satir.Split('\t'); // Elemanlar� tab karakterine g�re par�aya ay�r
                        if (parcalar.Length >= 2) // Par�alar�n say�s� 2'den b�y�k e�itse
                        {
                            ingilizceKelimeler.Add(parcalar[0]); // �lk par�ay� ingilizceKelimeler listesine ekle
                            turkceKelimeler.Add(parcalar[1]); // �kinci par�ay� turkceKelimeler listesine ekle
                        }
                    }
                }

                if (ingilizceKelimeler.Count != 0 && turkceKelimeler.Count != 0) // E�er bu listelerin eleman say�lar� 0 de�ilse
                {
                    MessageBox.Show("S�zl�k ba�ar�yla y�klendi!");
                    baslaButton.Enabled = true; // Ba�la butonunu aktifle�tir
                    return;
                   
                }
                else // 0'dan farkl�ysa
                {
                    MessageBox.Show("S�zl�k y�klenemedi!"); 
                }
            }   
        }

        public void baslaButton_Click(object sender, EventArgs e)
        {
            if (ingilizceKelimeler.Count == 0 && turkceKelimeler.Count == 0) // E�er listelerin eleman say�s� s�f�rsa
            {
                MessageBox.Show("�nce bir s�zl�k y�klemelisin!"); // �nce s�zl�k y�klenmesini iste
                return; // Bu k�s�m zaten �al��maz ��nk� y�kleme yap�lmadan ba�la butonuna bas�lm�yor. Yine de koyduk.
            }
            else // Eleman say�lar� 0'dan farkl�ysa
            {
                Form2 form2 = new Form2(ingilizceKelimeler, turkceKelimeler); // O listeleri Form2'ye y�kleyecek �ekilde form2 olu�tur
                form2.Show(); // ve form2'yi a�
            }
        }
        public void cikisButton_Click(object sender, EventArgs e)
        {
            Close(); // ��k�� butonuyla t�m program� kapat
        }
    }
}