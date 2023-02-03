using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;

namespace UAMS.UI
{
    internal class DegreeProgramUI
    {
        public static DegreeProgram takeInputOfDegreeProgram()
        {

            Console.Clear();
            UAMS_UI.head();
            Console.WriteLine(" ADD DEGREE PROGRAM >> ");

            string name, type, code;
            int duration, seats, fees, CH, totalCH = 0;

            Console.Write(" Enter Degree Name :");
            name = Console.ReadLine();
            Console.Write(" Enter Degree Duration :");
            duration = int.Parse(Console.ReadLine());
            Console.Write(" Enter Seats for Degree :");
            seats = int.Parse(Console.ReadLine());

            List<Subject> subjects = new List<Subject>();

            int count = 0;
            Console.Write(" Enter How many Subjects to Enter :");
            count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write(" Enter Subject Code :");
                code = Console.ReadLine();
                Console.Write(" Enter Subject Type :");
                type = Console.ReadLine();
                Console.Write(" Enter Subject Credit Hours :");
                CH = int.Parse(Console.ReadLine());
                totalCH = totalCH + CH;
                Console.Write(" Enter Subject Fees :");
                fees = int.Parse(Console.ReadLine());
                
                if (totalCH <= 20)
                {
                    Subject s = new Subject(code, type, CH, fees);
                    subjects.Add(s);

                    if(!SubjectDL.subjectList.Contains(s) )
                    {
                        SubjectDL.addSubjectIntoList(s);
                        string SubjectFilePath = "Subjects.txt";
                        SubjectDL.storeintoFile(SubjectFilePath, s);
                    }

                }
                else
                {
                    Console.WriteLine(" Credit Hours reach its Limit!");
                    break;
                }
            }

            DegreeProgram temp = new DegreeProgram(name, duration, seats, subjects);

            Console.Write(" Press any key to continue.. ");
            Console.ReadKey();

            return temp;
        }

        public static void showProgramList()
        {
            Console.WriteLine(" Available Degree Programs");
            int i = 1;
            foreach (DegreeProgram degree in DegreeProgramDL.programs)
            {
                Console.WriteLine(" " + i + ". " + degree.getDegreeTitle());
                i++;
            }

        }
    }
}
