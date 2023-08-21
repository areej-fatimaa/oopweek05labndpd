using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLine myline = null;
            MyPoint point = null;
            int choice = 0;
            while(choice!=10)
            {
                Console.Clear();
                choice=UI.Menu();
                if(choice==1)
                {
                    myline=UI.MakeLine();
                }
                if (myline != null)
                {
                 if (choice == 2)
                    {
                        UI.SetBeginPoint(myline);
                    }
                  if (choice == 3)
                    {
                        UI.SetEndPoint(myline);
                    }
                  if(choice==4)
                    {
                        UI.ShowPoint(myline.GetBegin());
                    }
                  if(choice==5)
                    {
                        UI.ShowPoint(myline.GetEnd());
                    }
                  if(choice==6)
                    {
                        UI.GetLength(myline);
                    }
                  if(choice==7)
                    {
                        UI.GetGradient(myline);
                    }
                  if(choice==8)
                    {
                        UI.GetDistanceFromZero(myline.GetBegin());
                    }
                  if(choice==9)
                    {
                        UI.GetDistanceFromZero(myline.GetEnd());
                    }
                }
            }
        }
    }
}
