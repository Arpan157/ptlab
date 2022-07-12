using System;

namespace mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            double quotient = a / b;

            Console.WriteLine("Sum is:" + sum);
            Console.WriteLine("Difference is"+difference);
            Console.WriteLine("Product is {0}\nQuotient is:{1}",product,quotient);
        }
    }
}