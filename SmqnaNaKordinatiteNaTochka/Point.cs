using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmqnaNaKordinatiteNaTochka
{
    public class Point<T>
    {
        private T x;
        public T X
        {
            get { return x; }
            set { x = value; }
        }
        private T y;
        public T Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Swap()
        {
            T temp = this.X;
            this.X = this.Y;
            this.Y = temp;
        }
        public double DistanceTo(Point<T> other)
        {
            double x1 = Convert.ToDouble(this.X);
            double y1 = Convert.ToDouble(this.Y);
            double x2 = Convert.ToDouble(other.X);
            double y2 = Convert.ToDouble(other.Y);
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static Point<double> Midpoint(Point<T> p1, Point<T> p2)
        {
            double x1 = Convert.ToDouble(p1.X);
            double y1 = Convert.ToDouble(p1.Y);
            double x2 = Convert.ToDouble(p2.X);
            double y2 = Convert.ToDouble(p2.Y);
            double midX = (x1 + x2) / 2;
            double midY = (y1 + y2) / 2;
            return new Point<double>(midX, midY);
        }
        public void Print()
        {
            Console.WriteLine($"X={this.X}, Y={this.Y}");
        }
    }
}
