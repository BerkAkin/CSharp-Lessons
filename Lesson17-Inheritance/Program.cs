using System;

namespace Lesson17_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Surungenler yilan = new Surungenler();
            yilan.SurunerekHareketEtmek();

            TohumluBitkiler gul = new TohumluBitkiler();
            gul.TohumlaCogalma();
        }
    }


}
