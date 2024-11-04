using System;

namespace SOLID1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Gabben = new Employee(112, "Gabben", 1_000_000_000);

            Console.WriteLine(ReturnSalary.RealSalary(Gabben));
        }
    }
}
