using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    internal class Student
    {
        // data members
        private string name;
        private int age;
        private int fscMarks;
        private int ecatMarks;
        private float aggregate;

        private List<DegreeProgram> prefrences = new List<DegreeProgram>();
        private DegreeProgram enrolled ;
        private List<Subject> regSubjects = new List<Subject>();


        // Constructors
        public Student(string name, int age, int fscMarks, int ecatMarks, List<DegreeProgram> prefrences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.prefrences = prefrences;
        }

        // member function

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public int getFscMarks()
        {
            return fscMarks;
        }
        public int getEcatMarks()
        {
            return ecatMarks;
        }
        public float getAggregate()
        {
            return aggregate;
        }
        public List<DegreeProgram> getPrefernceList()
        {
            return prefrences;
        }
        public DegreeProgram getEnrolledProgram()
        {
            if (enrolled != null)
            {
                return enrolled;
            }
            return null;
        }
        public List<Subject> getRegSubjectList()
        {
            return regSubjects;
        }

        public void EnrolledProgram(DegreeProgram P)
        {
            enrolled = new DegreeProgram(P);
        }
        public float calculateMerit()
        {
            aggregate = (((fscMarks / 1100) * 045F) + ((ecatMarks / 400) * 0.55F)) * 100;
            return aggregate;
        }
        public void print()
        {
            Console.WriteLine(name + "\t" + fscMarks + "\t" + ecatMarks + "\t" + age);
        }

        public int CountCreditHour()
        {
            int CH = 0;
            foreach( Subject Sub in regSubjects)
            {
                CH = CH + Sub.getCreditHour();
            }
            return CH;
        }

        public bool isSubjectExist(Subject s)
        {
            if(regSubjects != null)
            {
                foreach(Subject sub in regSubjects)
                {
                    if(s.getCode() == sub.getCode())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AddSubject(Subject sub)
        {
            int Ch = CountCreditHour();

            if(Ch + sub.getCreditHour() <= 9 && !isSubjectExist(sub))
            {
                regSubjects.Add(sub);
                return true;
            }
            return false;
        }

        public int calculateFees()
        {
            int fees = 0;
            foreach(Subject sub in regSubjects)
            {
                fees = fees + sub.getFees();
            }
            return fees;
        }
    }
}
