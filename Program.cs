using System;
using System.Xml.Serialization;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int s = 0;
            int a;
            int duong = 0;
            int am = 0;
            ConsoleKeyInfo b;
            Console.Write("Nhap so bat ky. An esc de ket thuc: ");
            do
            {
                b = Console.ReadKey();   //nhap vào một ký tự từ bàn phím
                input += b.KeyChar.ToString();    
                if (b.Key == ConsoleKey.Escape)
                {
                    break;
                }
                if (b.Key == ConsoleKey.Enter)
                {
                    int.TryParse(input, out a);
                    input = "";
                    Console.Write("\na= {0}\n", a);
                    s += a;
                    if (a > 0)
                    {
                        duong++;
                    }
                    if (a < 0)
                    {
                        am++;
                    }
                }
            }
            while (true);
            Console.WriteLine("\nTong la: {0}", s);
            Console.WriteLine("\nSo duong la: {0}", duong);
            Console.WriteLine("\nSo am la: {0}", am);

            Console.Read();
        }
    }
}
