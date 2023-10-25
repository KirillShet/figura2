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
        private float P;
        private float S;
        private float V;
        private float h;
        private float n;
        public void info5(float a5, float h5, float n5, float r5)
        {
            a = a5; this.h = h5; this.r = r5; this.n = n5; 
        }

        private void vich()
        {
            if (r == 0)
            {
                V = (float)(n * h * Math.Pow(a, 2)) / (float)(12 * Math.Tan(Math.PI / n));
                Console.WriteLine(V);
            }
            else
            {
                V = (float)(Math.PI * Math.Pow(r, 2) * h) / 3;
                Console.WriteLine(V);
            }
        }
        protected override void perimeter()
        {
            float Ap = a / (float)(2 * Math.Tan(Math.PI / n));
            if (r == 0)
            {
                P = (a * n) + ((float)(Math.Sqrt(Math.Pow(h, 2) + Math.Pow(Ap, 2))) * n);
                Console.WriteLine(P);
            }
            else
            {
                P = 2 * (float)Math.PI * r;
                Console.WriteLine(P);
            }
        }
        protected override void Square()
        {
            float Ap = a / (float)(2 * Math.Tan(Math.PI / n));
            if (r == 0)
            {
                S = (float)((a * Ap * n) / 2) + (float)((a * n * Math.Sqrt(Math.Pow(h, 2) + Math.Pow(Ap, 2))) / 2);
                Console.WriteLine(S);
            }
            else
            {
                S = (float)Math.PI * r * (float)Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r, 2)) + (float)Math.PI * (float)Math.Pow(r, 2);
                Console.WriteLine(S);
            }
        }
        public void out_info()
        {
            if (r == 0 && a == 0 && n == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write("Периметр пирамидки: "); perimeter();
                Console.Write("Площадь пирамидки: "); Square();
                Console.Write("Объем пирамиды равен: "); vich();

            }
        }
    }
}