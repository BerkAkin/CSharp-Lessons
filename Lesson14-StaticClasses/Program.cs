using System;

namespace Lesson14_StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("berk", "akın", "yazılım");
            Console.WriteLine(Calisan.CalisanSayisi);


            Console.WriteLine(Islemler.Topla(100, 200));
            Console.WriteLine(Islemler.Cikar(300, 200));

        }

        class Calisan
        {
            private static int calisanSayisi;
            private string isim;
            private string soyisim;
            private string departman;
            public static int CalisanSayisi { get => calisanSayisi; }

            static Calisan()
            {
                calisanSayisi = 0;
            }

            public Calisan(string isim, string soyisim, string departman)
            {
                this.isim = isim;
                this.soyisim = soyisim;
                this.departman = departman;
                calisanSayisi++;
            }



        }
        public static class Islemler
        {
            public static long Topla(int sayi1, int sayi2)
            {
                return (long)(sayi1 + sayi2);
            }

            public static long Cikar(int sayi1, int sayi2)
            {
                return (long)(sayi1 - sayi2);
            }
        }
    }
}
