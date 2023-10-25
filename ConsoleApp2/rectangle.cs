using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class rectangle1 : square1
    {
        public void out_info2(float a2, float b2)
        {
                Console.WriteLine("Периметр фигуры: " + perimeter(a2, b2));
                Console.WriteLine("Площадь фигуры: " + Square(a2, b2));
        }
    }
}