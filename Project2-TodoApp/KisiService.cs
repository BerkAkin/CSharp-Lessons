using System.Collections.Generic;
using System.Linq;
using System;

namespace Project2_TodoApp
{
    class KisiService
    {
        private static Dictionary<int, string> kisiListesi = new Dictionary<int, string>(){
        { 1, "Berk Akın" },
        { 2, "Cem Dara" },
        { 3, "Semah Ay" },
        { 4, "Elif Kara" }
        };

        public static string GetKisiAdi(int kisiId)
        {
            return kisiListesi.ContainsKey(kisiId) ? kisiListesi[kisiId] : null;
        }

        public static void AddKisi(int kisiId, string kisiAdi)
        {
            if (!kisiListesi.ContainsKey(kisiId))
            {
                kisiListesi.Add(kisiId, kisiAdi);
            }
            else
            {
                Console.WriteLine($"Kisi ID'si '{kisiId}' zaten mevcut.");
                return;
            }
        }

        public static void AddKisi()
        {
            Console.WriteLine("Eklenecek Kişinin ID'si Nedir?");
            int kisiId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Eklenecek Kişinin ismi Nedir?");
            string kisiIsim = Console.ReadLine();

            if (!kisiListesi.ContainsKey(kisiId))
            {
                kisiListesi.Add(kisiId, kisiIsim);
            }
            else
            {
                Console.WriteLine($"Kisi ID'si '{kisiId}' zaten mevcut.");
                return;
            }
        }


        public static void RemoveKisi(int id)
        {
            if (kisiListesi.ContainsKey(id))
            {
                kisiListesi.Remove(id);
            }
            else
            {
                Console.WriteLine("Kişi Bulunamadı");
            }
        }

        public static void RemoveKisi()
        {
            Console.WriteLine("Silinecek Kişinin ID'si Nedir");
            int silinecekId = Convert.ToInt32(Console.ReadLine());

            if (kisiListesi.ContainsKey(silinecekId))
            {
                kisiListesi.Remove(silinecekId);
            }
            else
            {
                Console.WriteLine("Kişi Bulunamadı");
            }
        }

        public static void getKisiler()
        {
            Console.WriteLine("Kişiler\n**********************");
            foreach (KeyValuePair<int, string> kisi in kisiListesi)
            {
                Console.WriteLine("ID: " + kisi.Key + " Ad Soyad: " + kisi.Value);
            }
        }

    }
}