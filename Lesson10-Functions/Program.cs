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


            //fibonacci

            Islemler fib = new Islemler();
            Console.WriteLine(fib.Fibonacci(10));

            //Extension Örneği
            char [] dizi = "Merhaba".ConvertToChars();


        }
        public static int Topla(int a, int b)
        {
            return a + b;
        }

        public static string Topla(string a, string b)
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


    class Islemler
    {
        public int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);

            }
        }
    }


    public static class Extensions
    {
        public static char[] ConvertToChars(this string text)
        {
            char[] chars = new char[text.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = text[i];
            }
            return chars;
        }
    }

}
