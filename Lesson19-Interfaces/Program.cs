using System;

namespace Lesson19_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DBLogger databaseLogger = new DBLogger();
            databaseLogger.Log();

            FileLogger fileLogger = new FileLogger();
            fileLogger.Log();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.Log();
        }
    }




}
