using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UAMS.BL;

namespace UAMS.DL
{
    internal class SubjectDL
    {
        public static List<Subject> subjectList = new List<Subject>();

        public static void addSubjectIntoList(Subject s)
        {
            subjectList.Add(s);
        }

        public static bool readFromFile(string path)
        {
            
            string record;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int creditHours = int.Parse(splittedRecord[2]);
                    int subjectFees = int.Parse(splittedRecord[3]);
                    Subject s = new Subject(code, type, creditHours, subjectFees);
                    addSubjectIntoList(s);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeintoFile(string path, Subject s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.getCode() + "," + s.getType() + "," + s.getCreditHour() + "," + s.getFees() );
            f.Flush();
            f.Close();
        }
        public static Subject isSubjectExists(string type)
        {
            foreach (Subject s in subjectList)
            {
                if (s.getType() == type)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
