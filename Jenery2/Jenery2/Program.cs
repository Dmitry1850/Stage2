using System;

namespace Jenery2
{
    
    internal class Program
    {
        static T FindMin<T>(T[] array) where T : IComparable<T> 
        {
            T min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(min) < 0)
                {
                    min = array[i];
                }
            }


            return min;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 12, 1, 55, -1};

            Console.WriteLine(FindMin(arr));
        }
    }
}
