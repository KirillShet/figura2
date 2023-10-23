using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class square1: figure
    {
        private float a2;
        private void info1(float a2)
        {
            this.a = a2;
        }
        public void out_info(float a2, float b)
        {
                Console.WriteLine("Периметр фигуры: " + perimeter(a2, a2));
                Console.WriteLine("Площадь фигуры: " + Square(a2, a2));
        }
    }
}