using System;

namespace SOLID5
{
    class LoggerMachine 
    {
        ILogger level;

        public void SetLogger(ILogger log)
        { 
            level = log;
        }

        public void PushLog(string message)
        {
            level.Log(message);
        }
    }
}
