using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        // viet chuong trinh nhap vao 3 so va tim gtri lon nhat 

        public static void input()
        {
            Console.Write("ban nhap vao gia tri thu 1 :");
            int i1 = int.Parse(Console.ReadLine());
            Console.Write("ban nhap vao gia tri thu 1 :");
            int i2 = int.Parse(Console.ReadLine());
            Console.Write("ban nhap vao gia tri thu 1 :");
            int i3 = int.Parse(Console.ReadLine());
            //if (i1 > i2 && i1 > i3)
            //{
            //    Console.WriteLine("gia tri lon nhat trong 3 so la :" + i1);
            //}
            //if (i2 > i1 && i2 > i3)
            //{
            //    Console.WriteLine("gia tri lon nhat trong 3 so la :" + i2);
            //}
            //else
            //{
            //    Console.WriteLine("gia tri lon nhat trong 3 so la :" + i3);
            //}
            int i = checkint(i1, i2, i3);
            Console.WriteLine(" gia tri lon nhat la : "+i);
            Console.ReadLine();
        }
        // so sanh int 
        private static int checkint(int i1, int i2 , int i3)
        {
            if (i1 > i2 && i1 > i3)
            {
                return i1;
            }
            if (i2 > i1 && i2 > i3)
            {
                return i2;
            }
            else
            {
                return i3;
            }
            
        }
        static void Main(string[] args)
        {
            input();
        }
    }
}
