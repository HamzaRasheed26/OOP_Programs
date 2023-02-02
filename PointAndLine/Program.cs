using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;
using PointAndLine.DL;
using PointAndLine.UI;

namespace PointAndLine
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            string op;

            while(true)
            {
                string path = "MyLineFile.txt";
                MyLineDL.LoadData(path);

                op = ProgramUI.Menu();

                if(op == "1")
                {
                    ProgramUI.menuLines(" Make Line");
                    MyLine newline = MyLineUI.makeLine();
                    MyLineDL.setLine(newline);
                }
                else if(op == "2")
                {
                    ProgramUI.menuLines("Update Begin Point");
                    MyPoint point;
                    point = MyLineUI.takePointInput("Begin Point");
                    MyLineDL.updateBeginPoint(point);
                }
                else if(op == "3")
                {
                    ProgramUI.menuLines("Update End Point");
                    MyPoint point;
                    point = MyLineUI.takePointInput("End Point");
                    MyLineDL.updateEndPoint(point);
                }
                else if (op == "4")
                {
                    ProgramUI.menuLines("Display Begin Point");
                    MyPoint point = MyLineDL.line.getBegin();
                    MyLineUI.DisplayPoint(point);
                }
                else if (op == "5")
                {
                    ProgramUI.menuLines("Display End Point");
                    MyPoint point = MyLineDL.line.getEnd();
                    MyLineUI.DisplayPoint(point);
                }
                else if (op == "6")
                {
                    ProgramUI.menuLines("Length of Line");
                    double length;
                    length = MyLineDL.line.getLength();
                    MyLineUI.displayLength(length);
                }
                else if (op == "7")
                {
                    ProgramUI.menuLines("Gradient of Line");
                    double m;
                    m = MyLineDL.line.getGradient();
                    MyLineUI.displayGradient(m);
                }
                else if (op == "8")
                {
                    ProgramUI.menuLines("Distance of Line Begin Point From Zero Cordintes");
                    MyPoint point = MyLineDL.line.getBegin();
                    MyLineUI.pointDistanceFromZero(point);
                }
                else if (op == "9")
                {
                    ProgramUI.menuLines("Distance of Line Begin Point From Zero Cordintes");
                    MyLineUI.pointDistanceFromZero(MyLineDL.line.getEnd());
                }
                else if (op == "10")
                {
                    MyLineDL.StoreData(path);
                    break;
                }

                ProgramUI.press();
            }
        }




        


        

    }
}
