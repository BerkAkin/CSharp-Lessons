using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Project2_TodoApp
{
    public class Operations

    {
        public Dictionary<int, string> kisiListesi = new Dictionary<int, string>();
        public Operations()
        {
            //Operations sınıfı ilk başladığında varsayılan olarak tüm atamalar yapılır.
            kisiListesi.Add(1, "Berk Akın");
            kisiListesi.Add(2, "Cem Dara");
            kisiListesi.Add(3, "Semah Ay");
            kisiListesi.Add(4, "Elif Kara");

            Card gorev1 = new Card("gorev1", "gorev1 aciklama", Sizes.S.ToString(), kisiListesi[1]);
            Card gorev2 = new Card("gorev2", "gorev2 aciklama", Sizes.M.ToString(), kisiListesi[2]);
            Card gorev3 = new Card("gorev3", "gorev3 aciklama", Sizes.XL.ToString(), kisiListesi[3]);

            //Varsayılan Atamalar
            Board.Todo.Add(gorev1);
            Board.InProgress.Add(gorev2);
            Board.Done.Add(gorev3);
        }

        public void AddCard()
        {
            Console.WriteLine("Kart için başlık bilgisi giriniz");
            string baslik = Console.ReadLine();
            Console.WriteLine("Kart için içerik bilgisi giriniz");
            string icerik = Console.ReadLine();
            Console.WriteLine("Kart için büyüklük bilgisi giriniz, (5)XL,(4)L,(3)M,(2)S,(1)XS");
            short buyukluk = Convert.ToInt16(Console.ReadLine());
            Sizes boyut = (Sizes)buyukluk;

            Console.WriteLine("Atanacak Kişinin ID'si nedir? ");
            int kisiId = Convert.ToInt32(Console.ReadLine());


            if (buyukluk == 1 || buyukluk == 2 || buyukluk == 3 || buyukluk == 4 || buyukluk == 5)
            {

                try
                {
                    Card card = new Card(baslik, icerik, boyut.ToString(), kisiListesi[kisiId]);
                    Board.Todo.Add(card);
                    Console.WriteLine("KART OLUŞTURMA BAŞARILI");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata Oluştu" + ex.Message);
                }



            }
            else
            {
                Console.WriteLine("Hatalı büyüklük girdiniz lütfen baştan deneyiniz");
            }


        }

        public void UpdateCard()
        {
        }

        public void DeleteCard()
        {
            Console.WriteLine("Silinmek İstenen Kartın Başlığı Nedir?");
            string baslik = Console.ReadLine();

            DeleteCardHelper(Board.Todo, baslik);
            DeleteCardHelper(Board.InProgress, baslik);
            DeleteCardHelper(Board.Done, baslik);
        }
        private void DeleteCardHelper(List<Card> boardField, string baslik)
        {
            var cardToRemove = boardField.FirstOrDefault(card => card.Title == baslik);
            if (cardToRemove != null)
            {
                boardField.Remove(cardToRemove);
            }
        }


        public void MoveCard()
        {

        }


        public void ShowCards()
        {
            Console.WriteLine("TODO Line \n*********************");
            if (Board.Todo.Count > 0)
            {
                foreach (Card card in Board.Todo)
                {
                    Console.WriteLine("Başlık: \t" + card.Title);
                    Console.WriteLine("İçerik: \t" + card.Content);
                    Console.WriteLine("Atanan Kişi: \t" + card.People);
                    Console.WriteLine("Büyüklük: \t" + card.Size);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("~Boş~");
            }



            Console.WriteLine("IN PROGRESS Line \n*********************");
            if (Board.InProgress.Count > 0)
            {
                foreach (Card card in Board.InProgress)
                {
                    Console.WriteLine("Başlık: \t" + card.Title);
                    Console.WriteLine("İçerik: \t" + card.Content);
                    Console.WriteLine("Atanan Kişi: \t" + card.People);
                    Console.WriteLine("Büyüklük: \t" + card.Size);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("~Boş~");
            }



            Console.WriteLine("DONE Line \n*********************");
            if (Board.Done.Count > 0)
            {
                foreach (Card card in Board.Done)
                {
                    Console.WriteLine("Başlık: \t" + card.Title);
                    Console.WriteLine("İçerik: \t" + card.Content);
                    Console.WriteLine("Atanan Kişi: \t" + card.People);
                    Console.WriteLine("Büyüklük: \t" + card.Size);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("~Boş~");
            }

        }
    }
}