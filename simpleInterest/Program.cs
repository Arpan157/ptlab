using System;

namespace simpleInterest

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principle:");
            double p =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate:");
            double r =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time:");
            double t = Convert.ToDouble(Console.ReadLine());

            double interest = (p * t * r) / 100;
            Console.WriteLine("simple interest is" + interest);
        }
    }
}