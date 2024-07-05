using System;

namespace Lesson8_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                else
                {
                    if (i == 4)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }

            }

            int b = 0;
            while (b < 12)
            {
                Console.WriteLine(b);
                b++;
            }

            do
            {
                Console.WriteLine(b);
                Console.WriteLine("bir kez çalıştı");
                b++;
            } while (b < 0);

            int[] dizi = new int[] { 1, 2, 3, 4, 45, 5, 7, 8 };
            foreach (int eleman in dizi)
            {
                Console.WriteLine(eleman);
            }
        }
    }
}
