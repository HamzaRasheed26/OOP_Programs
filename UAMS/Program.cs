using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
using UAMS.UI;

namespace UAMS
{
    internal class DriverProgram
    {

        static void Main(string[] args)
        {
            string SubjectFilePath = "Subjects.txt";
            string DegreeProgramFilePath = "DegreePrograms.txt";
            string StudentFilePath = "StudentsData.txt";

            SubjectDL.readFromFile(SubjectFilePath);
            DegreeProgramDL.readFromFile(DegreeProgramFilePath);
            StudentDL.readFromFile(StudentFilePath);
            
            string op;

            while(true)
            {
                op = UAMS_UI.Menu();
                if(op == "1")
                {
                    if (DegreeProgramDL.programs.Count != 0)
                    {
                        Student s = StudentUI.takeInputOfStudent();
                        StudentDL.AddStudentintoList(s);
                        StudentDL.storeintoFile(StudentFilePath, s);
                    }     
                }
                else if(op == "2")
                {
                    DegreeProgram p = DegreeProgramUI.takeInputOfDegreeProgram();
                    DegreeProgramDL.AddDegreeProgramInList(p);
                }
                else if(op == "3")
                {
                    List<Student> sortedList = new List<Student>();
                    sortedList = StudentDL.SortListOfStudents();
                    StudentDL.GenerateMerit(sortedList);
                    StudentUI.printStudents();
                }
                else if(op == "4")
                {
                    StudentUI.AllRegisteredStudents();
                }
                else if(op == "5")
                {
                    StudentUI.RedisteredStudentsSpecificDegree();
                }
                else if(op == "6")
                {
                    if (StudentDL.studentList.Count != 0)
                    {
                        StudentUI.RegisterSubject();
                    }
                }
                else if(op == "7")
                {
                    StudentUI.calculateTotalFees();
                }
                else if(op == "8")
                {
                    DegreeProgramDL.storeintoFile(DegreeProgramFilePath);
                    break;
                }
            }
        }    

    }
}
