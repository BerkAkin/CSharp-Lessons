using System;
using System.Security.Cryptography.X509Certificates;

namespace Lesson13_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan();
            calisan._Ad = "Berk";
            calisan._Soyad = "Akın";
            calisan._Departman = "Yazılım";
            calisan._No = 41266212;

            calisan.getBilgi();

        }
    }
    class Calisan
    {

        public string _Ad;
        public string _Soyad;
        public int _No;
        public string _Departman;



        public Calisan(string ad, string soyad, int no, string departman)
        {
            this._Ad = ad;
            this._Soyad = soyad;
            this._No = no;
            this._Departman = departman;
        }

        public Calisan() { }



        public void getBilgi()
        {
            Console.WriteLine("Çalışan Bilgileri: " + this._Ad + ", " + this._Soyad + ", " + this._No + ", " + this._Departman);
        }
    }

}
