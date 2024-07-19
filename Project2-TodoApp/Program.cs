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

            KisiService.AddKisi();
            KisiService.getKisiler();

            KisiService.RemoveKisi();
            KisiService.getKisiler();

            Console.WriteLine("-----------------------------------------");

            kartIslem.ShowCards();

            Console.WriteLine("-----------------------------------------");
            kartIslem.AddCard();
            kartIslem.ShowCards();

            Console.WriteLine("-----------------------------------------");
            kartIslem.DeleteCard();
            kartIslem.ShowCards();

            Console.WriteLine("-----------------------------------------");
            kartIslem.MoveCard();
            kartIslem.ShowCards();

            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

        }
    }
}
