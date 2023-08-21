using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class MyPoint
    {
        public int X;
        public int Y;
        public MyPoint()
        {
            this.X = 0;
            this.Y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
        public void SetX(int x)
        {
            this.X = x;
        }
        public void SetY(int y)
        {
            this.Y = y;
        }
        public void SetXY(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public double DistanceWithCoords(int X, int Y)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(X - X, 2) + Math.Pow(Y - Y, 2));
            return distance;
        }
        public double DistanceWithPoint(MyPoint point)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));
            return distance;
        }
        public double DistanceWithZero()
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow( X, 2) + Math.Pow( Y, 2));
            return distance;
        }
    }
}
