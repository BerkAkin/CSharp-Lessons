using System;
using System.Collections.Generic;

namespace Lesson12_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Collections ve List
            List<string> renkler = new List<string>();
            renkler.Add("mavi");
            renkler.Add("kırmızı");
            renkler.Add("sarı");
            renkler.Add("yeşil");
            renkler.Add("turuncu");

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(1);
            sayiListesi.Add(2);
            sayiListesi.Add(3);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(6);
            sayiListesi.Add(7);

            Console.WriteLine(sayiListesi.Count);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            sayiListesi.RemoveAt(1);
            renkler.Remove("yeşil");

            if (sayiListesi.Contains(1))
            {
                Console.WriteLine("Var");
            }

            Console.WriteLine(renkler.BinarySearch("sarı"));

            //Diziyi Listeye çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanlarListe = new List<string>(hayvanlar);
            hayvanlarListe.Clear();

            Kullanicilar kullanici1 = new Kullanicilar("Berk", "Akın", 24);
            Kullanicilar kullanici2 = new Kullanicilar("Burak", "Akın", 24);
            Kullanicilar kullanici3 = new Kullanicilar("Emre", "Kolcu", 24);
            List<Kullanicilar> kullanicilar = new List<Kullanicilar>();
            kullanicilar.Add(kullanici1);
            kullanicilar.Add(kullanici2);
            kullanicilar.Add(kullanici3);

            foreach (Kullanicilar kullanicis in kullanicilar)
            {
                Console.WriteLine(kullanicis.Isim + " " + kullanicis.Soyisim + " " + kullanicis.Yas);
            }


            //Dictionary
        }
    }

    public class Kullanicilar
    {

        private string isim;
        private string soyisim;
        private int yas;

        public Kullanicilar(string isim, string soyisim, int yas)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.yas = yas;
        }

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
