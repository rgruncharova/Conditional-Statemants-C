using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string FigureType = Console.ReadLine();
            double area = 0.0;
            switch (FigureType)
            {
                case "square":
                    {
                        double a = Double.Parse(Console.ReadLine());
                        area = a * a;
                        Console.WriteLine($"{area:f3}");
                        break;
                    }
                case "rectangle":
                    {
                        double a = Double.Parse(Console.ReadLine());
                        double b = Double.Parse(Console.ReadLine());
                        area = a * b;
                        Console.WriteLine($"{area:f3}");
                        break;
                    }
                case "circle":
                    {
                        double r = Double.Parse(Console.ReadLine());
                        area = (r * r * Math.PI);
                        Console.WriteLine($"{area:f3}");
                        break;
                    }
                case "triangle":
                    {
                        double h = Double.Parse(Console.ReadLine());
                        double b = Double.Parse(Console.ReadLine());
                        area = (h * b) / 2;
                        Console.WriteLine($"{area:f3}");
                        break;
                    }

                   
            }
        }
    }
}
