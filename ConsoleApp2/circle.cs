using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class circle1: rectangle1
    {
        private float r;
        public void info(float a3)
        {
            this.r = a3;
        }
        public void out_info1(float a3)
        {
                Console.WriteLine("Периметр фигуры: " + perimeter1(a));
                Console.WriteLine("Площадь фигуры: " + Square1(a));
        }
    }
}