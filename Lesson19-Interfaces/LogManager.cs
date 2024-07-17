using System;

namespace Lesson19_Interfaces
{
    public class LogManager : ILogger
    {
        public ILogger _logger;
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Log()
        {
            _logger.Log();
        }
    }
}