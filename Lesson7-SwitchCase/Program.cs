using System;

namespace Lesson7_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                default: Console.WriteLine("default"); break;
            }

        }
    }
}
