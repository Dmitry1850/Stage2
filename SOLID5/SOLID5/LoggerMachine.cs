using System;

namespace SOLID5
{
    class LoggerMachine 
    {
        LoggerLevel level = new LoggerLevel();

        public void PushLog(string message)
        {
            if (message == null)
                level.Log("1");
            else
                throw new Exception("Все гуд, работай дальше");
        }
    }
}
