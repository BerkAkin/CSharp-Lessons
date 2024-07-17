using System;

namespace Lesson17_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.Solunum();
            tohumluBitki.Beslenme();
            tohumluBitki.Bosaltim();
            tohumluBitki.TohumlaUreme();
            tohumluBitki.Fotosentez();


            Kopekler kopek = new Kopekler();
            kopek.Beslenme();
            kopek.Bosaltim();
            kopek.Solunum();
            kopek.Suruler();
            kopek.Kosma();

            Hayvanlar hayvan = new Hayvanlar();
            hayvan.Bosaltim();
            hayvan.Solunum();
            hayvan.Beslenme();
            hayvan.Suruler();
        }
    }

    class Canlilar
    {
        protected int CanliSayisi = 12;
        public void Solunum()
        {
            Console.WriteLine("Canlılar Solunum Yapar");
        }
        public void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenme Yapar");
        }
        public void Bosaltim()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar");
        }
    }

    class Hayvanlar : Canlilar
    {

        public void Suruler()
        {
            Console.WriteLine("Canlılar Sürüler Halinde Dolaşır");
        }
    }

    class Bitkiler : Canlilar
    {
        public void Fotosentez()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapar");
        }
    }

    class Kuslar : Hayvanlar
    {
        public void Ucma()
        {
            Console.WriteLine("Kuşlar Uçar");
        }
    }
    class Kopekler : Hayvanlar
    {
        public void Kosma()
        {
            Console.WriteLine("Köpekler Koşar");
        }
    }

    class TohumluBitkiler : Bitkiler
    {
        public void TohumlaUreme()
        {
            Console.WriteLine("Tohumlu Bitkşler Tohumla Üreme Yapar");
        }
    }

    class TohumsuzBitkiler : Bitkiler
    {
        public void SporlaUreme()
        {
            Console.WriteLine("Tohumsuz Bitkiler Sporla Ürer");
        }
    }
}
