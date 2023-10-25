using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                
                int var;
                triangle1 tri = new triangle1();
                circle1 cir = new circle1();
                rectangle1 rec = new rectangle1();
                square1 squ = new square1();
                squ = new square1();
                pyramid pyr = new pyramid();
                Console.WriteLine("1 - квадрат, 2 - прямоугольник, 3 - круг, 4 - тругольник, 5 - пирамида.");
                var = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (var == 1)
                {
                    Console.WriteLine("Квадрат");
                    squ.info(out float a);
                    squ.out_info(a, a);
                }
                else if (var == 2)
                {
                    Console.WriteLine("Прямоугольник");
                    rec = new rectangle1();
                    rec.info1(out float a, out float b);
                    rec.out_info2(a, b);
                }
                else if (var == 3)
                {
                    Console.WriteLine("Круг");
                    cir = new circle1();
                    cir.info(out float a);
                    cir.out_info1(a);
                }
                else if (var == 4)
                {
                    Console.WriteLine("Треугольник");
                    tri = new triangle1();
                    tri.info2(out float a, out float b, out float c);
                    tri.out_info3(a, b, c);
                }
                else if (var == 5)
                {
                    Console.WriteLine("Пирамида");
                    pyr = new pyramid();
                    pyr.info3(out float a, out float h, out float r, out float n);
                    pyr.out_info(a, h, r, n);
                }
            }
        }
    }
}