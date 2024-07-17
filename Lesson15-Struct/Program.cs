using System;

namespace Lesson15_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisaKenar = 3;
            dikdortgen.uzunKenar = 4;
            Console.WriteLine("Class Alan: " + dikdortgen.AlanHesapla());


            DikdortgenStruct dikdortgen1 = new DikdortgenStruct(3, 5);
            Console.WriteLine("Struct Alan: " + dikdortgen1.AlanHesapla());
        }

    }


    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    public struct DikdortgenStruct
    {
        public int kisaKenar;
        public int uzunKenar;
        public long AlanHesapla()
        {
            return this.uzunKenar * this.kisaKenar;
        }
        public DikdortgenStruct(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }

    }
}
