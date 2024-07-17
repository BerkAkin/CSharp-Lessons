using System;

namespace Lesson19_Interfaces
{
    public class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sms Olarak Logladım");
        }
    }
}