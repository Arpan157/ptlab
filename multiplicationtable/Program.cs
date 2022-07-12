using System;

namespace multiplicationtable

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("This is the multipication table of" + n);

            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine("\n{0}*{1} = {2}\n",+n,+i,+n*i);
            }
        }
    }
}