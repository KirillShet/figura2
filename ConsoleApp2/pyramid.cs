using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class pyramid: triangle1
    {
        private float P;
        private float S;
        private float V;
        protected float h;
        protected float n;

        public void info5()
        {
            Console.WriteLine("Введите высоту пирамиды.");
            this.h = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите, какое должно быть основание: круг - 1 или n-угольник - 2");
            int change = Convert.ToInt32(Console.ReadLine());
            if (change == 2)
            {
                Console.WriteLine("Введите количество углов многоугольника.");
                this.n = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите длинну стороны основания.");
                this.a = float.Parse(Console.ReadLine());

            }
            else if (change == 1)
            {
                Console.WriteLine("Введите радиус круга.");
                this.r = float.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Вы ввели не то число.");
            }
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