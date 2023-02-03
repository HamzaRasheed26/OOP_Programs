using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;

namespace UAMS.UI
{
    internal class StudentUI
    {
        public static Student takeInputOfStudent()
        {
            Console.Clear();
            UAMS_UI.head();
            Console.WriteLine(" ADD STUDENT >> ");
            string name = "";
            int age, fscMarks, ecatMarks;
            Console.Write(" Enter Student Name :");
            name = Console.ReadLine();
            Console.Write(" Enter Student Age :");
            age = int.Parse(Console.ReadLine());
            Console.Write(" Enter Student Inter Marks :");
            fscMarks = int.Parse(Console.ReadLine());
            Console.Write(" Enter Student Ecat Marks :");
            ecatMarks = int.Parse(Console.ReadLine());

            Console.WriteLine(" *** Available Degree Programs ***");
            int i = 1;
            foreach (DegreeProgram degree in DegreeProgramDL.programs)
            {
                Console.WriteLine(" " + i + ". " + degree.getDegreeTitle());
                i++;
            }

            int count = 0;
            Console.Write(" Enter how many Prefrences to Enter :");
            count = int.Parse(Console.ReadLine());
            List<DegreeProgram> degrees = new List<DegreeProgram>();
            for (int x = 0; x < count; x++)
            {
                int idx = 0;
                Console.WriteLine("\n Select degree from Available Programs");
                Console.Write(" Enter program for " + (x + 1) + " preference : ");
                idx = int.Parse(Console.ReadLine());
                idx--;
                degrees.Add(DegreeProgramDL.programs[idx]);
            }

            Console.Write(" Press Any key to Continue ... ");
            Console.ReadKey();

            Student temp = new Student(name, age, fscMarks, ecatMarks, degrees);
            return temp;
        }

        public static void printStudents()
        {
            Console.Clear();
            UAMS_UI.head();
            Console.WriteLine(" MERIT LIST >> ");

            foreach (Student s in StudentDL.studentList)
            {
                DegreeProgram enrolled = s.getEnrolledProgram();
                if (enrolled != null)
                {
                    Console.WriteLine(" " + s.getName() + " got Admission in " + enrolled.getDegreeTitle());
                }
                else
                {
                    Console.WriteLine(" " + s.getName() + " did not get Admission");
                }
            }
            Console.Write(" Press Any key to Continue ... ");
            Console.ReadKey();
        }

        public static void RedisteredStudentsSpecificDegree()
        {
            DegreeProgramUI.showProgramList();
            int idx = 0;
            Console.Write(" Select any Program from Available list .. :");
            idx = int.Parse(Console.ReadLine());
            idx--;
            bool flag = false;
            foreach (Student S in StudentDL.studentList)
            {
                DegreeProgram enrolled = S.getEnrolledProgram();
                Console.WriteLine(" Name \t FSC \t Ecat \t Age ");
                if (DegreeProgramDL.programs[idx].getDegreeTitle() == enrolled.getDegreeTitle())
                {
                    flag = true;
                    S.print();
                }
            }
            if (flag == false)
            {
                Console.WriteLine(" No Student is Registered in this Program ");
            }

            Console.Write(" Press any key to continue.. ");
            Console.ReadKey();
        }


        public static void AllRegisteredStudents()
        {
            bool flag = false;
            foreach (Student S in StudentDL.studentList)
            {
                Console.WriteLine(" Name \t FSC \t Ecat \t Age ");
                if (S.getEnrolledProgram() != null)
                {
                    flag = true;
                    S.print();
                }
            }
            if (flag == false)
            {
                Console.WriteLine(" No Student is Registered in any Program ");
            }
            Console.Write(" Press Any key to Continue ... ");
            Console.ReadKey();
        }

        public static void printListOfStudent()
        {
            int i = 1;
            foreach (Student S in StudentDL.studentList)
            {
                Console.WriteLine(" " + i + ". " + S.getName());
                i++;
            }
        }

        public static void RegisterSubject()
        {
            printListOfStudent();
            int idx = 0;
            Console.Write(" Select the student from list : ");
            idx = int.Parse(Console.ReadLine());
            idx--;

            Console.WriteLine(" Subjects Available :");
            int x = 1;
            DegreeProgram enrolled = StudentDL.studentList[idx].getEnrolledProgram();
            foreach (Subject sub in enrolled.getSubjects())
            {
                Console.WriteLine(" " + (x + 1) + ". " + sub.getCode() + " " + sub.getType() + " " + sub.getCreditHour());
                x++;
            }

            while (true)
            {
                Console.Write(" Enter the number of subject you want register :");
                int i = int.Parse(Console.ReadLine());
                i--;
                List<Subject> s = enrolled.getSubjects();

                if (StudentDL.studentList[idx].AddSubject(s[i]))
                {
                    Console.Write(" Want to register another subject (y/n) : ");
                    string ans = Console.ReadLine();
                    if (ans == "y" || ans == "Y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(" Credit Hours Reach its Limit ");
                    break;
                }
            }

            Console.Write(" Press Any key to Continue ... ");
            Console.ReadKey();
        }

        public static void calculateTotalFees()
        {
            if (StudentDL.studentList != null)
            {
                foreach (Student S in StudentDL.studentList)
                {
                    if (S.getEnrolledProgram() != null)
                    {
                        Console.WriteLine(S.getName() + " has " + S.calculateFees() + "/RS fees");
                    }
                }
            }
            else
            {
                Console.WriteLine(" No student is regestered !");
            }
            Console.Write(" Press Any key to Continue ... ");
            Console.ReadKey();
        }
    }
}
