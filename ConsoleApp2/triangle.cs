using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class triangle1: circle1
    {
        protected float c;
        private float p;
        private float s;

        public void info5(float a5, float b5, float c5)
        {
            a = a5; b = b5; this.c = c5;
        }
        private void type()
        {
            if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            if (Math.Pow(c, 2) > (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                Console.WriteLine("Треугольник тупоугольный");
            }
            if (Math.Pow(c, 2) < (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                Console.WriteLine("Треугольник остроугольный");
            }
            if (a != c && a != b && b != c)
            {
                Console.WriteLine("Треугольник разносторонний");
            }
            if (a == b && a == c && c == b)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
        }
        protected override void perimeter()
        {
            Console.WriteLine(a + b + c);
        }
        protected override void Square()
        {
            p = (a + b + c) / 2;
            s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(s);
        }
        public void out_info3()
        {
            Console.Write("Периметр фигуры: "); perimeter();
            Console.Write("Площадь фигуры: "); Square();
            type();
        }
    }
}