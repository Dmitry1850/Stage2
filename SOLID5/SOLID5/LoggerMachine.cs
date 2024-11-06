using System;

namespace SOLID5
{
    class LoggerMachine 
    {
        LoggerLevel level;

        public void PushLog(string message)
        {
            if (message != null)
                level.Log(message);
            else
                throw new Exception("Все гуд, работай дальше");
        }
    }
}
