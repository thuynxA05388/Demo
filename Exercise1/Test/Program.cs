using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            int i = 0;
            while (i < 10)
            {
                int j = i + 1;
                while (j < 10)
                {
                    Console.Write("*");
                }
                i+=1;
                j++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
