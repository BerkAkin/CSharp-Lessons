using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2_TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Operations kartIslem = new Operations();

            int islem = -1;
            do
            {
                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin, LİSTEYE KİŞİ EKLEME(1), LİSTEDEN KİŞİ SİLME(2), KİŞİ LİSTESİNİ GÖSTERME(3)");
                Console.WriteLine("YENİ KART OLUŞTURMA(4), KART SİLME(5), KART TAŞIMA(6), KARTLARI LİSTELEME(7)");
                Console.WriteLine("ÇIKIŞ(0)");
                islem = Convert.ToInt32(Console.ReadLine());

                switch (islem)
                {
                    case 0:
                        Console.WriteLine("Çıkış Yapılıyor. Lütfen Bir Tuşa Basın");
                        Console.ReadKey();
                        islem = 0;
                        break;
                    case 1:
                        KisiService.AddKisi();
                        break;
                    case 2:
                        KisiService.RemoveKisi();
                        break;
                    case 3:
                        KisiService.getKisiler();
                        break;
                    case 4:
                        kartIslem.AddCard();
                        break;
                    case 5:
                        kartIslem.DeleteCard();
                        break;
                    case 6:
                        kartIslem.MoveCard();
                        break;
                    case 7:
                        kartIslem.ShowCards();
                        break;

                }

            } while (islem != 0);




        }
    }
}
