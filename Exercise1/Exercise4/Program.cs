using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    // viet boi so tu 1->9 cua mot so dc nhap vao tu ban phim 
    class Program
    {
        private static int input()
        {
            Console.Write(" Ban nhap vao so :");
            int input = int.Parse(Console.ReadLine());
            return input;
        }
        private static void ouput()
        {
            int i = input();
            multiples(i);
            Console.ReadLine();
        }
        private static void multiples(int i)
        {
            for (int j=1; j<=9; j++)
            {
                int returns = j * i;
                Console.WriteLine(j+" x "+i+" = "+returns);
                //Console.ReadLine(); // Doc tung dong khi enter
                // Console.Read(); // doc them mot dong tiep
            }
        }
        static void Main(string[] args)
        {
            ouput();
        }
    }
}
