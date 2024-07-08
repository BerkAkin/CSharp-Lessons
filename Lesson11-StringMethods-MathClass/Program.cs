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
        }
    }
}
