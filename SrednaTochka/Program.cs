using SmqnaNaKordinatiteNaTochka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrednaTochka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<double> point1 = new Point<double>(2, 4);
            Point<double> point2 = new Point<double>(6, 8);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Точка 1: ");
            point1.Print();
            Console.WriteLine("Точка 2: ");
            point2.Print();
            Console.WriteLine("-------------------------");
            Point<double> midPoint = Point<double>.Midpoint(point1, point2);
            Console.WriteLine($"Mid points: ");
            midPoint.Print();
        }
    }
}
