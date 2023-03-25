using System;

namespace Shape
{
    public class Shape
    {
        public double[] edges;
        public double perimeter;
        public double area;
        public Shape(double[] edges)
        {
            this.edges = edges;
        }
        public virtual double Perimeter()
        {
            return perimeter;
        }
        public virtual double Area()
        {
            return area;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double[] edges) : base(edges)
        {
        }
        public override double Perimeter()
        {
            perimeter = edges[0] + edges[1] + edges[2];
            return perimeter;
        }
        public override double Area()
        {
            double p = perimeter / 2;
            area = Math.Sqrt(p * (p - edges[0]) * (p - edges[1]) * (p - edges[2]));
            return area;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
            for (int i = 0; i < edges[0]; i++)
            {
                for (int j = 0; j < edges[0] - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    public class Rectangular : Shape
    {
        public Rectangular(double[] edges) : base(edges)
        {
        }
        public override double Perimeter()
        {
            perimeter = 2 * (edges[0] + edges[1]);
            return perimeter;
        }
        public override double Area()
        {
            area = edges[0] * edges[1];
            return area;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
            for (int i = 0; i < edges[0]; i++)
            {
                for (int j = 0; j < edges[1]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    public class Pentagonal : Shape
    {
        public Pentagonal(double[] edges) : base(edges)
        {
        }
        public override double Perimeter()
        {
            perimeter = edges[0] + edges[1] + edges[2] + edges[3] + edges[4];
            return perimeter;
        }
        public override double Area()
        {
            area = (edges[0] * edges[1]) / 2;
            return area;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a pentagon");
            for (int i = 0; i < edges[0]; i++)
            {
                for (int j = 0; j < edges[0] - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = edges[0] - 2; i >= 0; i--)
            {
                for (int j = 0; j < edges[0] - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    public class Hexagonal : Shape
    {
        public Hexagonal(double[] edges) : base(edges)
        {
        }
        public override double Perimeter()
        {
            perimeter = edges[0] + edges[1] + edges[2] + edges[3] + edges[4] + edges[5];
            return perimeter;
        }
        public override double Area()
        {
            area = (edges[0] * edges[1]) / 2;
            return area;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a hexagon");
            for (int i = 0; i < edges[0]; i++)
            {
                for (int j = 0; j < edges[0] - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = edges[0] - 2; i >= 0; i--)
            {
                for (int j = 0; j < edges[0] - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    public class Circle : Shape
    {
        public Circle(double[] edges) : base(edges)
        {
        }
        public override double Perimeter()
        {
            perimeter = 2 * Math.PI * edges[0];
            return perimeter;
        }
        public override double Area()
        {
            area = Math.PI * Math.Pow(edges[0], 2);
            return area;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
            for (int i = 0; i < edges[0]; i++)
            {
                for (int j = 0; j < edges[0]; j++)
                {
                    if (Math.Pow(i - edges[0] / 2, 2) + Math.Pow(j - edges[0] / 2, 2) <= Math.Pow(edges[0] / 2, 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}