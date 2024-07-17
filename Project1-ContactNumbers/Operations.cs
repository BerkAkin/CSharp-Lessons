using System;

namespace Project1_ContactNumbers
{
    public class Operations
    {
        public void Kaydet()
        {
            string isim;
            string soyisim;
            int numara;

            Console.Write("Lütfen İsim Giriniz");
            isim = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen Soyisim Giriniz");
            soyisim = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen Telefon Numarası Giriniz");
            numara = Convert.ToInt32(Console.ReadLine());

            try
            {
                Contacts.liste.Add(new ContactModel(isim, soyisim, numara));
                Console.WriteLine("Kişi Başarıyla Eklendi");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message);
            }

        }
        public void Sil()
        {
            int deneme = 2;
            do
            {
                string input;
                Console.WriteLine("Lütfen Silmek İstediğiniz Kişinin Adını ya da Soyadını Giriniz");
                input = Convert.ToString(Console.ReadLine());
                char onay = ' ';
                bool bulundu = false;
                for (int i = 0; i < Contacts.liste.Count; i++)
                {
                    if (Contacts.liste[i].Name == input || Contacts.liste[i].Surname == input)
                    {
                        bulundu = true;
                        Console.WriteLine(Contacts.liste[i].Name + " " + Contacts.liste[i].Surname + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");

                        onay = Console.ReadKey().KeyChar;
                        if (onay == 'y')
                        {
                            Contacts.liste.RemoveAt(i);
                            Console.WriteLine("Kişi Başarıyla Silindi");

                        }
                        else if (onay == 'n')
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (bulundu == false)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \\n Silmeyi sonlandırmak için : (1) \\n Yeniden denemek için: (2) ");
                    deneme = Convert.ToInt32(Console.ReadLine());
                }
            } while (deneme != 1);


        }

        public void Guncelle()
        {

        }

        public void Ara()
        {

        }

        public void Listele()
        {
            foreach (ContactModel kisi in Contacts.liste)
            {
                Console.WriteLine(kisi.Name + " " + kisi.Surname + " " + kisi.Number);
            }
        }
    }
}