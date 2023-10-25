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
        private float vich(float a1, float h1, float n1, float r1)
        {
            if (r1 == 0)
            {
                V = (float)(n1 * h1 * Math.Pow(a1, 2)) / (float)(12 * Math.Tan(Math.PI / n1));
            }
            else
            {
                V = (float)(Math.PI * Math.Pow(r1, 2) * h1) / 3;
            }
            return V;
        }
        private float A(float a1, float n1)
        {
            Ap = a1 / (float)(2 * Math.Tan(Math.PI / n1));
            return Ap;
        }
        private float square3(float a1, float h1, float n1, float r1)
        {
            if (r1 == 0)
            {
                S = (float)((a1 * A(a1, n1) * n1) / 2) + (float)((a1 * n1 * Math.Sqrt(Math.Pow(h1, 2) + Math.Pow(A(a1, n1), 2))) / 2);
            }
            else
            {
                S = (float)Math.PI * r1 * (float)Math.Sqrt(Math.Pow(h1, 2) + Math.Pow(r1, 2)) + (float)Math.PI * (float)Math.Pow(r1, 2);
            }
            return S;
        }
        private float perimeter3(float a1, float h1, float n1, float r1)
        {
            if (r1 == 0)
            {
                P = (a1 * n1) + ((float)(Math.Sqrt(Math.Pow(h1, 2) + Math.Pow(A(a1, n1), 2))) * n1);
                
            }
            else
            {
                P = (float)(Math.PI * 2 * r1);
            }
            return P;
        }
        public void out_info(float a1, float h1, float n1, float r1)
        {
            if (r1 == 0 && a1 == 0 && n1 == 0)
            {
                Console.WriteLine();
            }
            else
            {
                    Console.WriteLine("Периметр пирамидки: " + perimeter3(a1, h1, n1, r1));
                    Console.WriteLine("Площадь пирамидки: " + square3(a1, h1, n1, r1));
                    Console.WriteLine("Объем пирамиды равен: " + vich(a1, h1, n1, r1));

            }
        }
    }
}