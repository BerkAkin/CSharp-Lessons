using System;

namespace Lesson20_AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFocus newFocus = new NewFocus();
            NewCorolla newCorolla = new NewCorolla();
            NewCivic newCivic = new NewCivic();

            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());

            Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());

            Console.WriteLine(newCorolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCorolla.KacTekerlektenOlusur());
            Console.WriteLine(newCorolla.StandartRengiNe().ToString());


        }
    }
}
