using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class circle1: rectangle1
    {
        protected float r;
        public void info5(float r5)
        {
            this.r = r5;
        }
        protected override void perimeter()
        {
            Console.WriteLine(2 * (float)Math.PI * r);
        }
        protected override void Square()
        {
            Console.WriteLine((float)Math.PI * (float)Math.Pow(r, 2));
        }
        public void out_info1()
        {
            Console.Write("Периметр фигуры: "); perimeter();
            Console.Write("Площадь фигуры: "); Square();
        }
    } 
}