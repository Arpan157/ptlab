using System;

namespace palindrome

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int r, sum = 0, temp;
            temp = n;
            while(n != 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("This is palindrome");
            }
            else
            {
                Console.WriteLine("This is not palindrome");
            }

        }
    }
}