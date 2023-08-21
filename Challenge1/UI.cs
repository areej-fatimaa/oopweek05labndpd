using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class UI
    {
        public static int Menu()
        {
            Console.WriteLine("1.Make Line");
            Console.WriteLine("2.Update begin point");
            Console.WriteLine("3.Update end point");
            Console.WriteLine("4.Sow begin point");
            Console.WriteLine("5.Show end point");
            Console.WriteLine("6.Length of line");
            Console.WriteLine("7. Length of gredient");
            Console.WriteLine("8.Distance of begin from zero");
            Console.WriteLine("9.Distance of end from zero");
            Console.WriteLine("10.Exit");
            int choice=int.Parse(Console.ReadLine());
            return choice;
        }

        public static MyLine MakeLine()
        {
            Console.WriteLine("Enter X1");
            int x1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2");
            int y2 = int.Parse(Console.ReadLine());
            MyLine myline = new MyLine(new MyPoint(x1, y1), new MyPoint(x2, y2));
            return myline;
        }
        public static void SetBeginPoint(MyLine line)
        {
            Console.WriteLine("Enter new x");
            int x= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new y");
            int y = int.Parse(Console.ReadLine());
            MyPoint mypoint = new MyPoint(x, y);
            line.SetBegin(mypoint);
        }
        public static void SetEndPoint(MyLine line)
        {
            Console.WriteLine("Enter new x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new y");
            int y = int.Parse(Console.ReadLine());
            MyPoint mypoint = new MyPoint(x, y);
            line.SetEnd(mypoint);
        }
        public static void ShowPoint(MyPoint mypoint)
        {
            Console.WriteLine("The point is "+mypoint.GetX()+","+mypoint.GetY());
        }
        static public void GetLength(MyLine line)
        {
            Console.WriteLine("Length of line:"+line.GetLength());
        }
        static public void GetGradient(MyLine line)
        {
            Console.WriteLine("Length of line:" + line.GetGradient());
        }
        static public void GetDistanceFromZero(MyPoint point)
        {
            Console.WriteLine("Distance with zero is:" + point.DistanceWithZero());
        }
    }
}
