using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        // viet chuong trinh nhap vao so tu 1->7 thay the cac ngay trong tuan 
        private static void input()
        {
            int input=0;
            for (int i=0; ; i++ ) {
                Console.Write(" moi ban nhap vao so : ");
                input = int.Parse(Console.ReadLine());
                if ( 1 <= input && input<7)
                {
                    checkDate(input);
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine(" Ban nhap sai !");
                    Console.ReadLine();
                }
                //Console.ReadLine();
            }
        }
        private static void checkDate(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("Monday");
                    
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

            }
        }
        static void Main(string[] args)
        {
            input();
        }
    }
}
