using System;

namespace SOLID5
{
    class LoggerLevel : ILogger
    {
        public void Log(string level)
        {
            if (level == "1")
            {
                throw new Exception("ffffff");
            }
        }
    }
}
