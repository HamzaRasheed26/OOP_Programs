using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PointAndLine.BL;
using PointAndLine.UI;


namespace PointAndLine.DL
{
    internal class MyLineDL
    {
        public static MyLine line = new MyLine();

        public static void setLine(MyLine newline)
        {
            line = newline;
        }

        public static void updateBeginPoint(MyPoint point)
        {
            line.setBegin(point);
        }

        public static void updateEndPoint(MyPoint point)
        {
            line.setEnd(point);
        }

        public static void LoadData(string path)
        {
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;

                record = file.ReadLine();
                string[] splaittedRecord = record.Split(',');
                int beginX = int.Parse(splaittedRecord[0]);
                int beginY = int.Parse(splaittedRecord[1]);
                int endX = int.Parse(splaittedRecord[2]);
                int endY = int.Parse(splaittedRecord[3]);

                MyPoint begin = new MyPoint(beginX, beginY);
                MyPoint end = new MyPoint(endX, endY);

                line = new MyLine(begin, end);
                file.Close();
            }
        }

        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path);

            MyPoint begin = line.getBegin();
            MyPoint end = line.getEnd();

            int beginX = begin.getX();
            int beginY = begin.getY();
            int endX = end.getX();
            int endY = end.getY();

            file.WriteLine(beginX + "," + beginY + "," + endX + "," + endY);
            file.Flush();
            file.Close();
        }
    }
}
