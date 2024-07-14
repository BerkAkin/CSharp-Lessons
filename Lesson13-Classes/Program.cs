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


            Ogrenci ogrenci = new Ogrenci("Berk", "AKIN", 3, 213213);
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.Isim = "Cem";
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();


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

    class Ogrenci
    {
        private string _isim;
        private string _soyisim;
        private int _ogrenciNo;
        private int _sinif;

        public string Isim { get => _isim; set => _isim = value; }
        public string Soyisim { get => _soyisim; set => _soyisim = value; }
        public int OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }
        public int Sinif
        {
            get => _sinif;
            set
            {
                if (value <= 1)
                {
                    _sinif = 1;
                    Console.WriteLine("Sınıf En Az 1 Olabilir");
                }
                else
                {
                    _sinif = value;
                }

            }
        }

        public Ogrenci() { }

        public Ogrenci(string isim, string soyisim, int sinif, int ogrenciNo)
        {
            Isim = isim;
            Soyisim = soyisim;
            Sinif = sinif;
            OgrenciNo = ogrenciNo;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("İsim: " + this.Isim + ", Soyisim: " + this.Soyisim + ", No: " + this.OgrenciNo + ", Sınıf: " + this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
