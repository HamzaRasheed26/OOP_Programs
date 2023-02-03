using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    internal class DegreeProgram
    {
        private string degreeTitle;
        private int duration;
        private int seats;
        private List<Subject> subjects = new List<Subject>();

        // Constructor
        public DegreeProgram(string degreeTitle, int duration, int seats, List<Subject> subjects)
        {
            this.degreeTitle = degreeTitle;
            this.duration = duration;
            this.seats = seats;
            this.subjects = subjects;
            
        }
        public DegreeProgram(DegreeProgram P)
        {
            degreeTitle = P.degreeTitle;
            duration = P.duration;
            seats = P.seats;
            subjects = P.subjects;
        }
        public string getDegreeTitle()
        {
            return degreeTitle;
        }
        public int getDuration()
        {
            return duration;
        }
        public int getSeats()
        {
            return seats;
        }
        public List<Subject> getSubjects()
        {
            if(subjects != null)
            {
                return subjects;
            }
            return null;
        }
        
        public void setSeats(int seats)
        {
            this.seats = seats;
        }
        

        public int CountCreditHour()
        {
            int CH = 0;
            foreach (Subject Sub in subjects)
            {
                CH = CH + Sub.getCreditHour();
            }
            return CH;
        }

        public bool isSubjectExist(Subject s)
        {
            if (subjects != null)
            {
                foreach (Subject sub in subjects)
                {
                    if (s.getCode() == sub.getCode())
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

            if (Ch + sub.getCreditHour() <= 20 && !isSubjectExist(sub))
            {
                subjects.Add(sub);
                return true;
            }
            return false;
        }
    }
}
