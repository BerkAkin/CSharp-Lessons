using System;

namespace Lesson19_Interfaces
{
    class DBLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database'e Logladım");
        }
    }
}