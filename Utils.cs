using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_class2
{
    public static class Utils
    {
        public static bool IsRelativelyEqual(double d1, double d2)
        {
            if (Math.Abs(d1 - d2) < Math.Abs((d1 + d2) / 2 * .0001))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Tuple<double, double, double, double> GetBoundingBox(List<Point> points)

        {

            double maxX = int.MinValue;
            foreach (Point x in points)
            {
                if (x.X > maxX)
                {
                    maxX = x.X;
                }
            }
            double maxY = int.MinValue;
            foreach (Point x in points)
            {
                if (x.Y > maxY)
                {
                    maxY = x.Y;
                }
            }
            double minX = int.MaxValue;
            foreach (Point x in points)
            {
                if (x.X < minX)
                {
                    minX = x.X;
                }
            }
            double minY = int.MaxValue;
            foreach (Point x in points)
            {
                if (x.Y < minY)
                {
                    minY = x.Y;
                }
            }
            return new Tuple<double, double, double, double>(minX, minY, maxX, maxY);
        }
    }
}
