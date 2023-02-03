using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UAMS.BL;

namespace UAMS.DL
{
    internal class DegreeProgramDL
    {
        public static List<DegreeProgram> programs = new List<DegreeProgram>();

        public static void AddDegreeProgramInList(DegreeProgram p)
        {
            programs.Add(p);
        }

        public static DegreeProgram isDegreeExists(string degreeName)
        {
            foreach (DegreeProgram d in programs)
            {
                if (d.getDegreeTitle() == degreeName)
                {
                    return d;
                }
            }
            return null;
        }

        public static void storeintoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (DegreeProgram p in programs)
            {
                string SubjectNames = "";
                List<Subject> s = p.getSubjects();
                for (int x = 0; x < s.Count - 1; x++)
                {

                    SubjectNames = SubjectNames + s[x].getType() + ";";
                }
                SubjectNames = SubjectNames + s[s.Count - 1].getType();
                string degreeName = p.getDegreeTitle();
                int duration = p.getDuration();
                int seats = p.getSeats();
                file.WriteLine(degreeName + "," + duration + "," + seats + "," + SubjectNames);
            }
            file.Flush();
            file.Close();
        }
        public static bool readFromFile(string path)
        {
            
            string record;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((record = file.ReadLine()) != null)
                    while ((record = file.ReadLine()) != null)
                    {
                        string[] splittedRecord = record.Split(',');
                        string degreeName = splittedRecord[0];
                        int degreeDuration = int.Parse(splittedRecord[1]);
                        int seats = int.Parse(splittedRecord[2]);
                        string[] splittedRecordForSubject = splittedRecord[3].Split(';');
                        List<Subject> subjectList = new List<Subject>();
                        for (int x = 0; x < splittedRecordForSubject.Length; x++)
                        {
                            Subject s = SubjectDL.isSubjectExists(splittedRecordForSubject[x]);
                            if (s != null)
                            {
                                subjectList.Add(s);
                            }
                        }
                        DegreeProgram d = new DegreeProgram(degreeName, degreeDuration, seats, subjectList);
                        AddDegreeProgramInList(d);
                    }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
