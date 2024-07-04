using System;
using System.Numerics;

namespace Lesson2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
          string str = "SınırsızString"; //sınırsız yer kaplar
          char ch = 'a'; // 2 byte

          byte b = 5; // 1 byte (0,255)
          sbyte c= 2; // 1 byte (-128,127)
          short s= 3; // 2 byte (-32768,32768)
          ushort u= 4; // 2 byte (0, 65365)

          Int16 i16 = 2; // 2 byte 
          int i = 3; // 4 byte
          Int32 i32 = 4; // 4 byte
          Int64 i64 = 5; // 8 byte

          uint ui = 2; // 4 byte
          long lg = 4; // 8 byte
          ulong ulg = 5; // 8 byte

          float f =  21.2f; // 4 byte
          double d = 12.4; // 8 byte
          decimal dec = 123.4m; // 16 byte

          bool b1= true; //
          bool b2= false; //

          DateTime dt = DateTime.Now;

          object o1 = "string";
          object o2= 'a';
          object o3 = 4;
          object o4 = 4.3f;

          //string ifadeler

          string str1 = string.Empty;
          str1 = "Deneme";
          string ad = "Berk";
          string soyad = "Akın";
          string tamIsim= ad + " " + soyad;

          //integer ifadeler
          int i1 = 5;
          int i2 = 6;
          int i3 = 7;
          int carpim = i2 * i1;
          Console.WriteLine(carpim);

          //boolean
          bool b11 = true;
          bool b22 = 10>2;
          bool b33 = false;
          bool b44 = 2>10;

          //Değişken dönüşümleri
          string str4= "4";
          int int4 = 4;
          string yeniDeger = str4 + int4.ToString();

          int YeniDeger = int4 + Convert.ToInt32(str4);


          int int12 = 12;
          int int20 = int12 + int.Parse(str4);

          


        }
        
    }
}
