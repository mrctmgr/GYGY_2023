using System;
using System.IO;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of edges of the shape: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] edges = new double[n];
            switch (n)
            {
                case 0 :
                    Console.WriteLine("Enter the radius of the circle: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    edges[0] = r;
                    Circle circle = new Circle(edges);
                    Console.WriteLine("The perimeter of the circle is: " + circle.Perimeter());
                    Console.WriteLine("The area of the circle is: " + circle.Area());
                    break;
                case 3 :
                    Console.WriteLine("Enter the edges of the triangle: ");
                    for (int i = 0; i < n; i++)
                    {
                        edges[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    Triangle triangle = new Triangle(edges);
                    Console.WriteLine("The perimeter of the triangle is: " + triangle.Perimeter());
                    Console.WriteLine("The area of the triangle is: " + triangle.Area());
                    break;
                case 4 :
                    Console.WriteLine("Enter the edges of the rectangle: ");
                    for (int i = 0; i < n; i++)
                    {
                        edges[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    Rectangular rectangular = new Rectangular(edges);
                    Console.WriteLine("The perimeter of the rectangle is: " + rectangular.Perimeter());
                    Console.WriteLine("The area of the rectangle is: " + rectangular.Area());
                    break;
                case 5 :
                    Console.WriteLine("Enter the edges of the pentagon: ");
                    for (int i = 0; i < n; i++)
                    {
                        edges[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    Pentagonal pentagonal = new Pentagonal(edges);
                    Console.WriteLine("The perimeter of the pentagon is: " + pentagonal.Perimeter());
                    Console.WriteLine("The area of the pentagon is: " + pentagonal.Area());
                    break;
                case 6 :
                    Console.WriteLine("Enter the edges of the hexagon: ");
                    for (int i = 0; i < n; i++)
                    {
                        edges[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    Hexagonal hexagonal = new Hexagonal(edges);
                    Console.WriteLine("The perimeter of the hexagon is: " + hexagonal.Perimeter());
                    Console.WriteLine("The area of the hexagon is: " + hexagonal.Area());
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            
        }
    }
}