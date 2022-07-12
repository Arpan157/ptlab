using System;

namespace armstrong

{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, r, temp;
            Console.WriteLine("Enter three digit number:");
            n =Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = sum + r * r * r;
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("This is Armstrong number");
            }
            else
            {
                Console.WriteLine("Not Armstong number");
            }

        }
    }
}