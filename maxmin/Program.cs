using System;

namespace maxmin

{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number =new int[3];
            
            for(int i =0;i<3;i++)
            {
              number [i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i =0;i<2;i++)
            {
               for(int j =0;j<2-i;j++)
                {
                   if(number [j] > number [j+1])
                    {
                        int temp;
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("max is :" + number[2]);
            Console.WriteLine("min is :" +number[0]);
            //foreach (int i in number)
              //  Console.WriteLine(i);
        }
    }
}