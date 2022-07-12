using System;

namespace areac

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the diameter of circle:");
            double d = Convert.ToDouble(Console.ReadLine());
            double area = (3.14* d*d)/4;
            Console.WriteLine(area);
        }
    }
}