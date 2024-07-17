using System;

namespace Lesson18_Polymorphism_SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Hayvan
    {
        public virtual void Sound()
        {
            Console.WriteLine("Hayvanlar Ses Çıkarır");
        }
    }

    class Kopek : Hayvan
    {
        public override void Sound()
        {
            Console.WriteLine("Köpekler Havlar");
        }
    }

    sealed class Bitkiler
    {
        public void Tepki()
        {
            Console.WriteLine("Bitkiler Işığa yönelir");
        }
    }

    /* 
     
    class Gul : Bitkiler{

    } 

    */
}
