using System;

namespace triangle

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of first side:");
            int l1 =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the lenght of second side:");
            int l2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of third side:");
            int l3 = Convert.ToInt32(Console.ReadLine());

            if(l1 == l2 && l2 == l3)
                {
                Console.WriteLine("Eqquilateral triangle");
            }
            else if(l1== l2 || l2 == l3 || l3==l1)
            {
                Console.WriteLine("Isosceles triangle");
            }
            else
            {
                Console.WriteLine("Scalene triangle");
            }
        }
    }
}