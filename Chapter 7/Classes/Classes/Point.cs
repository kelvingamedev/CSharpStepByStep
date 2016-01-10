#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;
        private static int numPoints = 0;



        public Point()
        {
            this.x = -1;
            this.y = -1;
            Point.numPoints++;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            Point.numPoints++;
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            return Math.Sqrt( (Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2)) );
        }

        public static int NumPoints()
        {
            return numPoints;
        }

        public static double DistanceTo(Point p1, Point p2)
        {
            int xDiff = p1.x - p2.x;
            int yDiff = p1.y - p2.y;

            double diff = double.NaN;
            checked
            {
                diff = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
            }
            return diff;     
        }
    }
}
