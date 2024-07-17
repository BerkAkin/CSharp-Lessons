using System;

namespace Lesson19_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.Log();

            FileLogger fileLogger = new FileLogger();
            fileLogger.Log();
        }
    }



    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database'e Logladım");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Logladım");
        }
    }
}
