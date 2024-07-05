using System;
using System.Collections.Generic;

namespace Lesson9_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 1, 2, };
            int[] sayilar2 = new int[2];
            string[] renkler = new string[2];
            renkler[0] = "Kırmızı";
            renkler[1] = "Mavi";
            /* 

                        int[] sayiDizisi = new int[20];
                        int toplam = 0;
                        for (int i = 0; i < sayiDizisi.Length; i++)
                        {
                            Console.Write("Lütfen {0}. sayıyı girin:", i + 1);
                            sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                            toplam += sayiDizisi[i];
                        }
                        double ortalama = toplam / 20;
                        Console.WriteLine("Sayıların ortalaması: " + ortalama);
                        Console.ReadLine(); */

            char[,] ikili = new char[3, 3]{
                {'a','b','c'},
                {'d','e','f'},
                {'g','h','ı'}
            };

            for (int ilk = 0; ilk < 3; ilk++)
            {
                for (int ikinci = 0; ikinci < 3; ikinci++)
                {
                    Console.WriteLine(ikili[ilk, ikinci]);
                }
            }



            int[] sizeAble = new int[] { 1, 76, 3, 8, 43, 12, 7 };
            Array.Sort(sizeAble);
            int index = Array.IndexOf(sizeAble, 1);
            Array.Resize<int>(ref sizeAble, 3);
            foreach (int i in sizeAble)
            {
                Console.WriteLine("Sizeable: " + i);
            }
            Array.Resize<int>(ref sizeAble, 20);
            sizeAble[9] = 123;
            foreach (int i in sizeAble)
            {
                Console.WriteLine("Yeni Sizeable: " + i);
            }

        }
    }
}
