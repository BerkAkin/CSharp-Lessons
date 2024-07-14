using System;

namespace Lesson13_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan();
            calisan.Ad = "Berk";
            calisan.Soyad = "Akın";
            calisan.Departman = "Yazılım";
            calisan.No = 41266212;

            calisan.getBilgi();

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void getBilgi()
        {
            Console.WriteLine("Çalışan Bilgileri: " + this.Ad + ", " + this.Soyad + ", " + this.No + ", " + this.Departman);
        }
    }

}
