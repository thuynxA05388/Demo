using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class boiso
    {
        static void Main(string[] args)
        {
            // viet chuong trinh nhap vao ten dia chi so dien thoai va hien thi
            show();
        }
        public static void show()
        {
            string name, phone=null, address;
            Console.WriteLine("-------- input--------------");
            Console.Write("ban nhap vao ten : ");
            name=Console.ReadLine();
            Console.Write("ban nhap vao dia chi :");
            address = Console.ReadLine();
            
            phone=checkphone();
            Console.WriteLine("-------- output--------------");
            Console.WriteLine("ban vua nhap vao ten :\n" + name);
            Console.WriteLine("ban vua nhap vao dia chi " + address);
            Console.WriteLine("ban vua nhap vao so dien thoai " + phone);
            Console.ReadLine();
        }
        public static string checkphone()
        {
            string phone;
            string c = "0";
            for (int i = 0; ; i++) {
                Console.Write("ban nhap vao so dien thoai: ");
                phone = Console.ReadLine();
                if (phone.StartsWith("0"))
            {

                return phone;
                break;
            }
            else
            {
                    Console.WriteLine( "ban nhap sai ban nhap lai ! ");
            }
        }
            
        }
    }
    
}
