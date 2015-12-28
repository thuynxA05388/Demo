using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    // giai thua cua so nguyen n
    class Program
    {
        // bieu thuc nhap vao so n
        public static void input()
        {
            
            for (int i=0; i < 10 ;i++)
            {
                int n;
                Console.Write(" Moi ban nhap vao mot so nguyen duong : ");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    output(n);
                    break;
                }
                if (n == 0)
                {
                    Console.WriteLine(" Boi so cua 0 la : 1");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine(" Ban nhap sai !");
                }
                Console.ReadLine();
            }
            
        }
        private static void output(int input)
        {
            int n = input;
            for(int i=n-1;i< n && i>0; i--)
            {
                n = n * i;
                 
            }
            Console.WriteLine(" Boi so "+input+" la : "+n);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            input();
        }
    }
}
