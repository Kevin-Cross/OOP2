using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_class2
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Distance(Point other)
        {
            double d = Math.Abs(Math.Sqrt(Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y - other.Y, 2)));
            return d;
            
        }
        public override string ToString()
        {
            
            return $"({this.X}, {this.Y})";
        }
    }
}
