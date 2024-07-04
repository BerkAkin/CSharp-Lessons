using System;

namespace Lesson3_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama

            int x = 1;
            int y = 2;
            y = y+2 ;
            y +=2 ;
            y /= 1;
            x *= 2;
            Console.WriteLine(x);
            Console.WriteLine(y);

            //Mantıksal Operatörler
            // || && 

            bool isSucces = false;
            bool isCompleted = true;

            //İlişkisel Operatörler

            if(3<2){
                Console.WriteLine("");
            }
            if(3>2){
                Console.WriteLine("");
            }
            if(3==2){
                Console.WriteLine("");
            }
            if(3!=2){
                Console.WriteLine("");
            }

        }
    }
}
