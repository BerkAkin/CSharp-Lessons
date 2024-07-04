using System;

namespace Lesson5_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sayı gir");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sayi:" + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Program Sonlandı");
            }



            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("left");
                int a = int.Parse("-230428912589");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Değer, değişkenin alabileceği uzunluğun dışında");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Program Sonlandı");
            }
        }
    }
}
