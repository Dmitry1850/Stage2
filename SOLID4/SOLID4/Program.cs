using System;

namespace SOLID4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            MultiPrinter multiPrinter = new MultiPrinter();

            string Doc = "palitica";

            printer.Print(Doc);

            multiPrinter.Print(Doc);
            multiPrinter.Scan(Doc);
        }
    }
}
