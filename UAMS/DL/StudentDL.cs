using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UAMS.BL;

namespace UAMS.DL
{
    internal class StudentDL
    {
        public static List<Student> studentList = new List<Student>();

        public static void AddStudentintoList(Student s)
        {
            studentList.Add(s);
        }

        public static List<Student> SortListOfStudents()
        {
            List<Student> sortedList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.calculateMerit();
            }
            sortedList = studentList.OrderByDescending(o => o.getAggregate()).ToList();
            return sortedList;
        }

        public static void GenerateMerit(List<Student> sortedList)
        {
            foreach (Student S in sortedList)
            {
                foreach (DegreeProgram P in DegreeProgramDL.programs)
                {
                    int seats = P.getSeats();
                    DegreeProgram enrolled = S.getEnrolledProgram();
                    if (seats > 0 && enrolled == null)
                    {
                        S.EnrolledProgram(P);
                        seats--;
                        P.setSeats(seats);
                        break;
                    }
                }
            }

        }

        public static void storeintoFile(string path, Student s)
        {
            StreamWriter file = new StreamWriter(path, true);
            string degreeNames = "";
            List<DegreeProgram> preference = s.getPrefernceList();
            for (int x = 0; x < preference.Count - 1; x++)
            {
                degreeNames = degreeNames + preference[x].getDegreeTitle() + ";";
            }
            degreeNames = degreeNames + preference[preference.Count - 1].getDegreeTitle();
            file.WriteLine(s.getName() + "," + s.getAge() + "," + s.getFscMarks() + "," + s.getEcatMarks() + "," + degreeNames);
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
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int age = int.Parse(splittedRecord[1]);
                    int fscMarks = int.Parse(splittedRecord[2]);
                    int ecatMarks = int.Parse(splittedRecord[3]);
                    string[] splittedRecordForPreference = splittedRecord[4].Split(';');
                    List<DegreeProgram> preferences = new List<DegreeProgram>();

                    for (int x = 0; x < splittedRecordForPreference.Length; x++)
                    {
                        DegreeProgram d = DegreeProgramDL.isDegreeExists(splittedRecordForPreference[x]);
                        if (d != null)
                        {
                            if (!(preferences.Contains(d)))
                            {
                                preferences.Add(d);
                            }
                        }
                    }
                    Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
                    studentList.Add(s);
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
