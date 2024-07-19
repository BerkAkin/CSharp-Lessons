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

    }
}