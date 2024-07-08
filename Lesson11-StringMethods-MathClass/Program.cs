using System;
using System.Linq;

namespace Lesson11_StringMethods_MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "Kelime";

            Console.WriteLine(kelime.ToLower());
            Console.WriteLine(kelime.ToUpper());
            Console.WriteLine(kelime.Length);
            Console.WriteLine(String.Concat(kelime, " Concatted"));
            Console.WriteLine(kelime.CompareTo("Keli"));
            Console.WriteLine(String.Compare(kelime, "Keli"));
            Console.WriteLine(kelime.Insert(5, "5.INDEX"));
            Console.WriteLine(kelime.Substring(5));
            Console.WriteLine(kelime.EndsWith("d"));
            Console.WriteLine(kelime.StartsWith("K"));
            Console.WriteLine(kelime.IndexOf("e"));
            Console.WriteLine(kelime.LastIndexOf("e"));
            Console.WriteLine(kelime.PadLeft(50, 'a'));
            Console.WriteLine(kelime.PadRight(50, 'a'));
            Console.WriteLine(kelime.Remove(5));
            Console.WriteLine(kelime.Split("")[0]);

            //MATH KÜTÜPHANESİ
            Console.WriteLine(Math.Abs(1));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            Console.WriteLine(Math.Ceiling(12.69134));
            Console.WriteLine(Math.Round(10.6112));
            Console.WriteLine(Math.Floor(10.23));
            Console.WriteLine(Math.Max(10, 15));
            Console.WriteLine(Math.Min(10, 15));
            Console.WriteLine(Math.Exp(10));
            Console.WriteLine(Math.Log(105));
            Console.WriteLine(Math.Sqrt(225));
            Console.WriteLine(Math.Pow(16, 2));
        }
    }
}
