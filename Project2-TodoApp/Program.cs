using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2_TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations kartIslem = new Operations();

            Console.WriteLine("-----------------------------------------");
            kartIslem.MoveCard();
            kartIslem.ShowCards();

            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();


        }
    }
}
