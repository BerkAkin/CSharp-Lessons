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
            int islemKir = 2;
            do
            {
                Console.WriteLine("Lütfen Silmek İstediğiniz Kişinin Adını ya da Soyadını Giriniz");
                string input = Convert.ToString(Console.ReadLine());
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
                            islemKir = 1;

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
                    islemKir = Convert.ToInt32(Console.ReadLine());
                }
            } while (islemKir != 1);


        }

        public void Guncelle()
        {
            int islemKir = 2;
            do
            {
                string input;
                Console.WriteLine("Lütfen Güncellemek İstediğiniz Kişinin Adını veya Soyadını Giriniz");

                input = Convert.ToString(Console.ReadLine());
                char onay = ' ';
                bool bulundu = false;
                for (int i = 0; i < Contacts.liste.Count; i++)
                {
                    if (Contacts.liste[i].Name == input || Contacts.liste[i].Surname == input)
                    {
                        bulundu = true;
                        Console.Write(" Kişi Bulundu ve güncellenmek üzere, onaylıyor musunuz ?(y/n)");

                        onay = Console.ReadKey().KeyChar;
                        if (onay == 'y')
                        {
                            Console.WriteLine("Yeni Numara:");
                            int yeniNumara = Convert.ToInt32(Console.ReadLine());

                            Contacts.liste[i].Number = yeniNumara;

                            Console.WriteLine("Kişi Başarıyla Güncellendi");
                            islemKir = 1;

                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (bulundu == false)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \\n Güncellemeyi sonlandırmak için : (1) \\n Yeniden denemek için: (2) ");
                    islemKir = Convert.ToInt32(Console.ReadLine());
                }
            } while (islemKir != 1);

        }

        public void Ara()
        {
            Console.WriteLine("Arama Yapmak İstediğiniz Tipi Seçiniz, İsim ve Soyisme göre arama için 1, Numaraya göre arama için 2");
            short tip;
            tip = Convert.ToInt16(Console.ReadLine());

            switch (tip)
            {
                case 1:
                    Console.WriteLine("İsim veya Soyisim Giriniz");
                    string isSoy = Convert.ToString(Console.ReadLine());
                    aramaHelper<string>(isSoy);
                    break;
                case 2:
                    Console.WriteLine("Tel No Giriniz");
                    int TelNo = Convert.ToInt32(Console.ReadLine());
                    aramaHelper<int>(TelNo);
                    break;
            }
        }

        public void Listele()
        {
            foreach (ContactModel kisi in Contacts.liste)
            {
                Console.WriteLine(kisi.Name + " " + kisi.Surname + " " + kisi.Number);
            }
        }


        private void aramaHelper<T>(T giris)
        {
            foreach (ContactModel item in Contacts.liste)
            {
                if (giris is string)
                {
                    if (item.Name.Equals(giris) || item.Surname.Equals(giris))
                    {
                        Console.WriteLine(item.Name + " " + item.Surname + " " + item.Number);
                    }
                }
                else
                {
                    if (item.Number.Equals(giris))
                    {
                        Console.WriteLine(item.Name + " " + item.Surname + " " + item.Number);
                    }
                }

            }
        }
    }
}