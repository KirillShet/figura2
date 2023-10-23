using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class figure: Vod
    {
        public float a1;
        public float b1;
        public float c1;
        public float P;
        public float V;
        public float Ap;
        public float S;
        public float perimeter(float a1, float b1)
        {
            P = a1 * 2 + b1 * 2;
            return P;
        }
        public float Square(float a1, float b1)
        {
            S = a1 * b1;
            return S;
        }
        public float perimeter1(float a1)
        {
            P = 2 * (float)Math.PI * a1;
            return P;
        }
        public float Square1(float a1)
        {
            S = (float)Math.PI * (float)Math.Pow(a1, 2);
            return S;
        }

        public float perimeter2(float a1, float b1, float c1)
        {
            P = a1 + b1 + c1;
            return P;
        }
        public float Square2(float a1, float b1, float c1)
        {
            S = (float)Math.Sqrt(perimeter2(a1, b1, c1) / 2 * (perimeter2(a1, b1, c1) / 2 - a1) * (perimeter2(a1, b1, c1) / 2 - b1) * (perimeter2(a1, b1, c1) / 2 - c1));
            return S;
        }
        public float vich(float a1, float h1, float n1, float r1)
        {
            if (n1 == 3)
            {
                V = (float)(h1 * Math.Pow(a1, 2)) / (float)(4 * Math.Sqrt(3));
                return V;
            }
            else if (n1 == 4)
            {
                V = (float)(h1 * Math.Pow(a1, 2) / 3);
                return V;
            }
            else if (n1 == 6)
            {
                V = (float)(Math.Sqrt(3) / 2) * (float)(h1 * Math.Pow(a1, 2));
                return V;
            }
            else
            {
                V = (float)(n1 * h1 * Math.Pow(a1, 2)) / (float)(12 * Math.Tan(Math.PI / n1));
                return V;
            }
        }
        private float A(float a1, float n1)
        {
            Ap = a1 / (float)(2 * Math.Tan(Math.PI / n1));
            return Ap;
        }
        public float square3(float a1, float h1, float n1)
        {
            S = (float)((a1 * A(a1, n1) * n1) / 2) + (float)((a1 * n1 * Math.Sqrt(Math.Pow(h1, 2) + Math.Pow(A(a1, n1), 2))) / 2);
            return S;
        }
        public float perimeter3(float a1, float n1, float h1)
        {
            P = (a1 * n1) + ((float)(Math.Sqrt(Math.Pow(h1, 2) + Math.Pow(A(a1, n1), 2))) * n1);
            return P;
        }
        public float vich2(float r1, float h1)
        {
            V = (float)(Math.PI * Math.Pow(r1, 2) * h1) / 3;
            return V;
        }
        public float square5(float r1, float h1)
        {
            S = (float)Math.PI * r1 * (float)Math.Sqrt(Math.Pow(h1, 2) + Math.Pow(r1, 2)) + (float)Math.PI * (float)Math.Pow(r1, 2);
            return S;
        }
        public float perimeter5(float r1)
        {
            P = (float)(Math.PI * 2 * r1);
            return P;
        }
    }
}
