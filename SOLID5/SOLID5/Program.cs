using System;

namespace SOLID5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new LoggerLevel();
            LoggerMachine machine = new LoggerMachine();
            machine.SetLogger(logger);
            machine.PushLog("2");
        }
    }
}
