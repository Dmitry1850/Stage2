using System;

namespace SOLID5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggerMachine machine = new LoggerMachine();

            //machine.PushLog(null);
            machine.PushLog("äsdasd");
        }
    }
}
