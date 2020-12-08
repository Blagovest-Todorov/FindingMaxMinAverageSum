using System;
using System.Linq;
using System.Collections.Generic;

namespace _20.LinqExersise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                double currNum = double.Parse(Console.ReadLine());
                numbers[i] = currNum;
            }
            Console.WriteLine();
            Console.WriteLine("Min is: {0} ", numbers.Min());
            Console.WriteLine("Max is: {0}", numbers.Max());
            Console.WriteLine("Sum is : {0}", numbers.Sum());
            Console.WriteLine("Average is : {0} ", numbers.Average());


        }
    }
}
