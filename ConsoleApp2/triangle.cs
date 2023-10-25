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
        private void type(float a2, float b2, float c2)
        {
            if (Math.Pow(c2, 2) == (Math.Pow(a2, 2) + Math.Pow(b2, 2)))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            if (Math.Pow(c2, 2) > (Math.Pow(a2, 2) + Math.Pow(b2, 2)))
            {
                Console.WriteLine("Треугольник тупоугольный");
            }
            if (Math.Pow(c2, 2) < (Math.Pow(a2, 2) + Math.Pow(b2, 2)))
            {
                Console.WriteLine("Треугольник остроугольный");
            }
            if (a2 != c2 && a2 != b2 && b2 != c2)
            {
                Console.WriteLine("Треугольник разносторонний");
            }
            if (a2 == b2 && a2 == c2 && c2 == b2)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (a2 == b2 || b2 == c2 || a2 == c2)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
        }
        public void out_info3(float a2, float b2, float c2)
        {
            Console.WriteLine("Периметр фигуры: " + perimeter2(a2, b2, c2));
            Console.WriteLine("Площадь фигуры: " + Square2(a2, b2, c2));
            type(a2, b2, c2);
        }
    }
}