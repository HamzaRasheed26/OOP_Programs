using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;
using PointAndLine.DL;

namespace PointAndLine.UI
{
    internal class MyLineUI
    {
        public static MyPoint takePointInput(string title)
        {
            int x, y;
            Console.WriteLine(title);
            Console.Write(" Enter X-Point : ");
            x = int.Parse(Console.ReadLine());
            Console.Write(" Enter Y-Point : ");
            y = int.Parse(Console.ReadLine());

            MyPoint point = new MyPoint(x, y);
            return point;
        }

        public static MyLine makeLine()
        {   
            MyPoint begin;
            begin = takePointInput("Begin Point");

            MyPoint end;
            end = takePointInput("End Point");

            MyLine line = new MyLine(begin, end);

            return line;
        }

        public static void DisplayPoint(MyPoint point)
        {
            int x = point.getX();
            int y = point.getY();
            Console.WriteLine(" X-Point : " + x);
            Console.WriteLine(" Y-Point : " + y);
        }

        public static void displayLength(double length)
        {
            
            Console.WriteLine(" Length of Line is : " + length);
        }

        public static void displayGradient(double m)
        {
            Console.WriteLine(" Gradient of Line is : " + m);
        }

        public static void pointDistanceFromZero(MyPoint point)
        {
            double distance;
            distance = point.distanceFromZero();
            Console.WriteLine(" Distance from Zero Cordinates : " + distance);
        }
    }
}
