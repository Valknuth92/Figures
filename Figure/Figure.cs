using System;

namespace Figures
{
    public class Figures
    {
        public double area { get; set; }

    }

    public class Circle : Figures
    {
        public double r { get; set; }
        public double FindArea()
        {
            this.area = Math.PI * Math.Pow(r, 2);
            return this.area;
        }
    }

    public class Triangle : Figures
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double FindArea()
        {
            double p = (a + b + c) / 2;
            this.area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return this.area;
        }
        public bool IsRightTriangle()
        {
            return (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) || (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)) || (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2));
        }
    }
    public class Polygon : Figures
    {
        static int verts;
        public double[] x;
        public double[] y;
        public Polygon(int value)
        {
            verts = value;
            x = new double[verts];
            y = new double[verts];
        }

        public double FindArea() // n-угольник
        {

            for (int i = 0; i <= x.Length - 2; i++)
            {
                this.area += x[i] * y[i + 1] - x[i + 1] * y[i];
            }

            this.area += x[^1] * y[0] - x[0] * y[^1];
            this.area = -this.area / 2;
            return this.area;
        }
    }
}
