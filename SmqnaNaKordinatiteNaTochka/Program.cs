using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmqnaNaKordinatiteNaTochka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<int> point = new Point<int>(3, 4);
            Console.WriteLine("Точките преди размяна: ");
            point.Print();
            point.Swap();
            Console.WriteLine("Точките след размяна: ");
            point.Print();
        }
    }
}
