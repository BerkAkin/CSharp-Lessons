using System;

namespace Lesson10_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 2;
            Metotlar ornek = new Metotlar();
            ornek.Yaz(Convert.ToString(Topla(a, b)));

            ornek.Yaz(Convert.ToString(ornek.ArttırVeTopla(ref a, ref b)));
        }
        public static int Topla(int a, int b)
        {
            return a + b;
        }


    }

    class Metotlar
    {
        public void Yaz(string veri)
        {
            Console.WriteLine($"Yaz: {veri}");
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
