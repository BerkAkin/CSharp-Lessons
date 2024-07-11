using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practise_2_1_2_3
{
    /*
    Eratosthenes Kalburu Algoritması
      class Program
     {
         static void Main(string[] args)
         {
             List<int> numbers = new List<int>();

             for (int i = 0; i < 4; i++)
             {
                 int sayi = Convert.ToInt32(Console.ReadLine());
                 numbers.Add(sayi);
             }
             int maxNum = numbers.Max();

             List<int>[] primes = findPrimes(maxNum);
             for (var i = 0; i < primes.Length; i++)
             {
                 Console.WriteLine(primes[0][i] + " Asaldır");
                 Console.WriteLine(primes[1][i] + " Asal Değildir");
             }

         }

         static List<int>[] findPrimes(int maxNumber)
         {
             List<int> primes = new List<int>();
             List<int> nonPrimes = new List<int>();
             bool[] isComposite = new bool[maxNumber + 1];

             for (int p = 2; p * p <= maxNumber; p++)
             {
                 if (!isComposite[p])
                 {
                     for (int i = p * p; i <= maxNumber; i += p)
                     {
                         isComposite[i] = true;
                     }
                 }

             }

             for (int p = 2; p <= maxNumber; p++)
             {
                 if (!isComposite[p])
                 {
                     primes.Add(p);
                 }
                 else
                 {
                     nonPrimes.Add(p);
                 }
             }
             List<int>[] numList = new List<int>[]{
                 primes, nonPrimes
             };

             return numList;
         } 
 }*/
    class Program
    {
        static void Main(string[] args)
        {
            //????????????????????????????????? Odev1 ?????????????????????????????????

            List<int> nums = new List<int>();
            List<int> asal = new List<int>();
            List<int> asalDegil = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number <= 0 || number.GetType() != typeof(Int32))
                {
                    continue;
                }
                nums.Add(number);
            }

            foreach (int sayi in nums)
            {
                int sayac = 0;
                for (int k = 1; k <= sayi; k++)
                {

                    if (sayi % k == 0)
                    {
                        sayac++;
                    }
                    if (sayac > 2)
                    {
                        asalDegil.Add(sayi);
                    }
                    else
                    {
                        asal.Add(sayi);
                    }
                }
            }

            asal.Sort();
            asalDegil.Sort();
            double asalOrtalama = 0;
            double asalOlmayanOrtalama = 0;
            if (asal.Count > 0)
            {
                asalOrtalama = asal.Average();
            }
            if (asalDegil.Count > 0)
            {
                asalOlmayanOrtalama = asalDegil.Average();
            }
            Console.WriteLine("Asal Sayısı: " + asal.Count + " Ortalaması: " + asalOrtalama);
            Console.WriteLine("Asal Olmayan Sayısı: " + asalDegil.Count + " Ortalaması: " + asalOlmayanOrtalama);
            Console.WriteLine("Asallar: ");

            foreach (int asallar in asal)
            {
                Console.WriteLine(asallar);
            }
            Console.WriteLine("Asal Olmayanlar: ");

            foreach (int asala in asalDegil)
            {
                Console.WriteLine(asala);
            }


            //????????????????????????????????? Odev2 ?????????????????????????????????

            int[] numbers = new int[20];
            Console.WriteLine("20 Sayı Giriniz");
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            int[] smallestThree = new int[3];
            Array.Copy(numbers, smallestThree, 3);

            int[] largestThree = new int[3];
            Array.Copy(numbers, numbers.Length - 3, largestThree, 0, 3);

            double smallestAverage = CalculateAverage(smallestThree);
            double largestAverage = CalculateAverage(largestThree);
            double totalAverage = CalculateAverage(numbers);

            Console.WriteLine("En küçük 3 sayı: " + string.Join(", ", smallestThree));
            Console.WriteLine("En küçük 3 sayının ortalaması: " + smallestAverage);
            Console.WriteLine();

            Console.WriteLine("En büyük 3 sayı: " + string.Join(", ", largestThree));
            Console.WriteLine("En büyük 3 sayınun ortalaması: " + largestAverage);
            Console.WriteLine();

            Console.WriteLine("Tüm sayıların ortalaması: " + totalAverage);



            //????????????????????????????????? Odev3 ?????????????????????????????????


            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine().ToLower();
            List<char> sesliHarfler = new List<char>();

            foreach (char c in cumle)
            {
                if (IsSesliHarf(c) && !sesliHarfler.Contains(c))
                {
                    sesliHarfler.Add(c);
                }
            }

            sesliHarfler.Sort();

            Console.WriteLine("Cümledeki sesli harfler:");
            foreach (char harf in sesliHarfler)
            {
                Console.WriteLine(harf);
            }

        }
        static double CalculateAverage(int[] array)
        {
            if (array.Length == 0)
                return 0;

            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return sum / array.Length;
        }

        static bool IsSesliHarf(char c)
        {
            switch (c)
            {
                case 'a':
                case 'e':
                case 'ı':
                case 'i':
                case 'o':
                case 'ö':
                case 'u':
                case 'ü':
                    return true;
                default:
                    return false;
            }
        }


    }


}

