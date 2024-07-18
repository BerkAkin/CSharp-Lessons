using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2_TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Card gorev1 = new Card("gorev1", "gorev1 aciklama", Sizes.S.ToString(), KisiListesi.BerkAkin);
            Card gorev2 = new Card("gorev2", "gorev2 aciklama", Sizes.M.ToString(), KisiListesi.CemSeckin);
            Card gorev3 = new Card("gorev3", "gorev3 aciklama", Sizes.XL.ToString(), KisiListesi.SemihaAy);

            //Varsayılan Atamalar
            Board.Todo.Add(gorev1);
            Board.InProgress.Add(gorev2);
            Board.Done.Add(gorev3);


            Operations kartIslem = new Operations();
            kartIslem.AddCard();



        }
    }
}
