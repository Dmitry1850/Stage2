using System;

namespace SOLID4
{
    class Printer : IPrint
    {
        public void Print(string Document) 
        {
            Console.WriteLine("Я печатаю!");
        }
    }

    class MultiPrinter :IPrintAndScan
    {
        public void Print(string Document)
        {
            Console.WriteLine("Я печатаю!");
        }
        public void Scan(string Document)
        {
            Console.WriteLine("А еще я сканирую!");
        }
    }
}
