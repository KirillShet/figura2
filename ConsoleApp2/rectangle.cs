using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class rectangle1 : square1
    {
        private float a2;
        private float b2;
        private void info1(float a2, float b2)
        {
            this.a2 = a2; this.b2 = b2;
        }
        public void out_info2(float a2, float b2)
        {
                Console.WriteLine("Периметр фигуры: " + perimeter(a2, b2));
                Console.WriteLine("Площадь фигуры: " + Square(a2, b2));
        }
    }
}