using System;

namespace Lesson6_If_Else_TernaryIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //If Blokları
            int a = 5;
            if (a > 5)
            {
                Console.WriteLine("A  5'ten büyük");
            }
            else if (a < 5)
            {
                Console.WriteLine("A  5'ten küçük");
            }
            else
            {
                Console.WriteLine("A  5'e eşit");
            }

            //Ternary If
            bool bool1 = a < 5 ? true : false;

        }
    }
}
