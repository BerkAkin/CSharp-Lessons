using System;
using System.Collections;
using System.Linq;

namespace Practise_1_2_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                int giris = Convert.ToInt32(Console.ReadLine());

                dizi[i] = giris;
            }
            for (int j = 0; j < 5; j++)
            {
                if (dizi[j] % 2 == 0)
                {
                    Console.WriteLine(dizi[j]);
                }
            }

            //Odev2

            Console.WriteLine("Sayı girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayılar Girin");
            int[] dizi2 = new int[5];

            for (int k = 0; k <= 4; k++)
            {
                int giris = Convert.ToInt32(Console.ReadLine());
                dizi2[k] = giris;
            }
            for (int t = 0; t < 5; t++)
            {
                if (dizi2[t] % sayi == 0)
                {
                    Console.WriteLine(dizi2[t]);
                }
            }

            //Odev3

            Console.WriteLine("Sayı girin");
            int odev3 = Convert.ToInt32(Console.ReadLine());
            if (odev3 > 0)
            {
                string[] odev3dizi = new string[odev3];
                for (int x = 0; x < odev3; x++)
                {
                    Console.WriteLine("Kelime gir");
                    odev3dizi[x] = Convert.ToString(Console.ReadLine());
                }
                for (int son = odev3dizi.Length - 1; son >= 0; son--)
                {
                    Console.WriteLine(odev3dizi[son]);
                }
            }
            else
            {
                throw new Exception("0'dan büyük girin");

            }


            //Odev4
            Console.WriteLine("Cümle Yazın");
            string cumle = Convert.ToString(Console.ReadLine());

            int wordCount = 0, index = 0;

            while (index < cumle.Length && char.IsWhiteSpace(cumle[index]))
                index++;

            while (index < cumle.Length)
            {
                while (index < cumle.Length && !char.IsWhiteSpace(cumle[index]))
                    index++;

                wordCount++;

                while (index < cumle.Length && char.IsWhiteSpace(cumle[index]))
                    index++;
            }





        }
    }
}
