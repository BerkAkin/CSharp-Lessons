using System;

namespace Lesson19_Interfaces
{
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Logladım");
        }
    }
}