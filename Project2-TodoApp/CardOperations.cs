using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Project2_TodoApp
{
    public class Operations

    {
        private Dictionary<int, string> kisiListesi = new Dictionary<int, string>();
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
            int islem = 2;
            do
            {
                Console.WriteLine("Silinmek İstenen Kartın Başlığı Nedir?");
                string baslik = Console.ReadLine();
                bool silindiMi = false;

                List<Card> cardSource = FindCardLocationHelper(baslik);
                DeleteCardHelper(cardSource, baslik);

                if (silindiMi)
                {
                    Console.WriteLine("Silme İşlemi Başarılı");
                }
                else
                {
                    Console.WriteLine("Silme Başarısız İstenen Kriterde Kart Bulunamadı. Silmeyi Sonlandırmak İçin(1), Yeniden Denemek İçin(2)");
                }
            } while (islem != 1);
        }

        public void MoveCard()
        {
            Console.WriteLine("Hareket ettirmek istediğiniz kartın başlığı nedir?");
            string baslik = Console.ReadLine();

            List<Card> sourceList = FindCardLocationHelper(baslik);

            if (sourceList == null)
            {
                Console.WriteLine($"'{baslik}' başlıklı kart bulunamadı.");
                return;
            }

            Console.WriteLine("Hangi yuvaya taşımak istiyorsunuz? (1) TODO, (2) IN PROGRESS, (3) DONE");
            int tasinacakYer = Convert.ToInt32(Console.ReadLine());

            List<Card> destList = SelectDestinationHelper(tasinacakYer);

            if (destList == null)
            {
                Console.WriteLine("Geçersiz bir yuva seçtiniz.");
                return;
            }


            Card tasinacakKart = sourceList.FirstOrDefault(card => card.Title == baslik);
            sourceList.Remove(tasinacakKart);
            destList.Add(tasinacakKart);

            Console.WriteLine("Taşıma İşlemi Başarılı");
        }

        public void ShowCards()
        {
            ShowCardListHelper(Board.Todo, "TODO Line");
            ShowCardListHelper(Board.InProgress, "IN PROGRESS Line");
            ShowCardListHelper(Board.Done, "DONE Line");
        }

        private void ShowCardListHelper(List<Card> cards, string title)
        {
            Console.WriteLine($"{title}\n*********************");
            if (cards.Count > 0)
            {
                foreach (Card card in cards)
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
        private bool DeleteCardHelper(List<Card> cardSource, string baslik)
        {
            var cardToRemove = cardSource.FirstOrDefault(card => card.Title == baslik);
            if (cardToRemove != null)
            {
                cardSource.Remove(cardToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<Card> FindCardLocationHelper(string baslik)
        {
            if (Board.Todo.Any(card => card.Title == baslik))
            {
                return Board.Todo;
            }
            else if (Board.InProgress.Any(card => card.Title == baslik))
            {
                return Board.InProgress;
            }
            else if (Board.Done.Any(card => card.Title == baslik))
            {
                return Board.Done;
            }
            else
            {
                return null;
            }
        }

        private List<Card> SelectDestinationHelper(int tasinacakYer)
        {
            switch (tasinacakYer)
            {
                case 1:
                    return Board.Todo;
                case 2:
                    return Board.InProgress;
                case 3:
                    return Board.Done;
                default:
                    return null;
            }
        }


    }
}