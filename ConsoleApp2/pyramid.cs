using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class pyramid: triangle1
    {
        private float result;
        private bool pov;
        public void out_info(float a1, float h1, float n1, float r1)
        {
            if (r1 == 0 && a1 == 0 && n1 == 0)
            {
                Console.WriteLine();
            }
            else
            {
                if (r1 == 0)
                {
                    Console.WriteLine("Периметр пирамидки: " + perimeter3(a1, h1, n1));
                    Console.WriteLine("Площадь пирамидки: " + square3(a1, h1, n1));
                    Console.WriteLine("Объем пирамиды равен: " + vich(a1, h1, n1, r1));
                }
                else if (r1 > 0)
                {
                    Console.WriteLine("Периметр пирамидки: " + perimeter5(r1));
                    Console.WriteLine("Площадь пирамидки: " + square5(h1, r1));
                    Console.WriteLine("Объем пирамиды равен: " + vich2(h1, r1));
                }
            }
        }
    }
}