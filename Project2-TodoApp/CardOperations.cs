using System;

namespace Project2_TodoApp
{
    public class Operations
    {
        public void AddCard()
        {
            Console.WriteLine("Kart için başlık bilgisi giriniz");
            string baslik = Console.ReadLine();
            Console.WriteLine("Kart için içerik bilgisi giriniz");
            string icerik = Console.ReadLine();
            Console.WriteLine("Kart için büyüklük bilgisi giriniz, XL,L,M,S,XS");
            string buyukluk = Console.ReadLine();
            Console.WriteLine("Atanacak Kişiyi Yazın BerkAkin,CemSeckin,SemihaAy,ElifKara");
            string kisi = Console.ReadLine();
            KisiListesi atanacakKisi;
            Console.WriteLine(Sizes.M.ToString());

            if (buyukluk == Sizes.XS.ToString() || buyukluk == Sizes.S.ToString() || buyukluk == Sizes.M.ToString() || buyukluk == Sizes.L.ToString() || buyukluk == Sizes.XL.ToString())
            {
                if (Enum.TryParse<KisiListesi>(kisi, out atanacakKisi))
                {
                    try
                    {
                        Card card = new Card(baslik, icerik, buyukluk, atanacakKisi);
                        Board.Todo.Add(card);
                        Console.WriteLine("KART OLUŞTURMA BAŞARILI");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata Oluştu" + ex.Message);
                    }
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

        }

        public void MoveCard()
        {

        }
    }
}