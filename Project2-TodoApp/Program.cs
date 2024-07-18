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
            //kartIslem.AddCard();
            kartIslem.ShowCards();
            kartIslem.DeleteCard();
            kartIslem.ShowCards();
            kartIslem.DeleteCard();
            kartIslem.ShowCards();
            kartIslem.DeleteCard();
            kartIslem.ShowCards();

        }
    }
}
