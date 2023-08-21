using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class MyLine
    {
        MyPoint Begin;
        MyPoint End;
        public MyLine(MyPoint Begin,MyPoint End)
        {
            this.Begin = Begin;
            this.End = End;
        }
        public MyPoint GetBegin()
        {
            return Begin;
        }
        public MyPoint GetEnd()
        {
            return End;
        }
        public void SetBegin(MyPoint begin)
        {
            this.Begin = begin;
        }
        public void SetEnd(MyPoint end)
        {
            this.End = end;
        }
        public double GetLength()
        {
            double length;
            length = End.DistanceWithPoint(Begin);
            return length;
        }
        public double GetGradient()
        {
            double gradient;
            gradient = (End.Y = Begin.Y) / (End.X - Begin.X);
            return gradient;
        }
    }
}
