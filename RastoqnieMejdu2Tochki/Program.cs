using SmqnaNaKordinatiteNaTochka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastoqnieMejdu2Tochki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<double> point1 = new Point<double>(1.0, 2.0);
            Point<double> point2 = new Point<double>(4.0, 6.0);
            Console.WriteLine("Точка 1: ");
            point1.Print();
            Console.WriteLine("Точка 2: ");
            point2.Print();
            double distance = point1.DistanceTo(point2);
            Console.WriteLine($"Разстояние между точките: {distance}");
        }
    }
}
