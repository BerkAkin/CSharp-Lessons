using System;

namespace Lesson16_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Salı);
            Console.WriteLine((int)Gunler.Pazartesi);


            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Hava Soğuk");
            }



        }

    }
    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }

    class Araba
    {
        static Araba() { }
        public Araba() { }
    }
}
