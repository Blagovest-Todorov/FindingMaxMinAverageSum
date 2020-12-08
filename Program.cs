using System;
using System.Linq;
using System.Collections.Generic;

namespace _19.LinqUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linq is adding some m ore functional;ity to Objecys to collections, 
            // Linq is attachinmg methods to collections !
            // write a program that reads n intergers and finds its max, its min, its average, it sum;

             //double input = double.Parse(Console.ReadLine());

            double n = Double.Parse(Console.ReadLine()); // how many number we will accept through the Console
            //double numbers = Double.Parse(Console.ReadLine());

            List<double> list = new List<double>();

            for (int i = 1; i <= n; i++)
            {
                double currNum = Double.Parse(Console.ReadLine());
                list.Add(currNum);
            }

            //while (true)
            //{
            //    if ( n < 0 )
            //    {
            //        break;
            //    }
            //    double currNum = n;
            //    list.Add(currNum);

            //}
            Console.WriteLine();
            Console.WriteLine("Min is: " + list.Min());
            Console.WriteLine("Max is : " + list.Max());
            Console.WriteLine("Sum is : " + list.Sum());
            Console.WriteLine("The Average is : " + list.Average());

             





        }
    }
}
