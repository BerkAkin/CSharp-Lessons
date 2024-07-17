using System;

namespace Project1_ContactNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operasyonlar = new Operations();
            int islem = 0;
            do
            {
                Console.WriteLine("Yapılmak İstenen İşlemi Seçiniz \\n (1) Yeni Numara Kaydetmek (2) Varolan Numarayı Silmek (3) Varolan Numarayı Güncelleme (4) Rehberi Listelemek (5) Rehberde Arama Yapmak (0) Çıkış Yapmak");
                islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 0)
                {
                    break;
                }
                else if (islem == 1)
                {
                    operasyonlar.Kaydet();
                }
                else if (islem == 2)
                {
                    operasyonlar.Sil();
                }
                else if (islem == 3)
                {
                    operasyonlar.Guncelle();
                }
                else if (islem == 4)
                {
                    operasyonlar.Listele();
                }
                else if (islem == 5)
                {
                    operasyonlar.Ara();
                }
            } while (islem != 0);
        }
    }
}
