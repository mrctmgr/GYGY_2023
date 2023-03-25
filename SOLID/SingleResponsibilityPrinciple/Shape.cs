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
    }
}