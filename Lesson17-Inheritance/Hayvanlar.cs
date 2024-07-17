using System;

namespace Lesson17_Inheritance
{
    public class Hayvanlar : Canlilar
    {
        public Hayvanlar()
        {
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adapte olabilir");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
        }
        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}