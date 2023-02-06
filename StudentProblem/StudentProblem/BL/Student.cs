using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProblem.BL
{
    internal class Student
    {
        protected string name;
        protected string session;
        protected bool isDayScholar;
        protected float EntryTestMarks;
        protected float HSMarks;

        public Student(string name, string session, bool isDayScholar, float EntryTestMarks, float HSMarks)
        {
            this.name = name;
            this.session = session;
            this.isDayScholar = isDayScholar;
            this.EntryTestMarks = EntryTestMarks;
            this.HSMarks = HSMarks;
        }

        public string getName()
        {
            return name;
        }
        public string getSession()
        {
            return session;
        }
        public bool getIsDayScholar()
        {
            return isDayScholar;
        }
        public float getEntryTestMarks()
        {
            return EntryTestMarks;
        }
        public float getHSMarks()
        {
            return HSMarks;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setSession(string session)
        {
            this.session = session;
        }
        public void setIsDayScholar(bool isDayScholar)
        {
            this.isDayScholar = isDayScholar;
        }
        public void setEntryTestMarks(float EntryTestMarks)
        {
            this.EntryTestMarks = EntryTestMarks;
        }
        public void setHSMarks(float HSMarks)
        {
            this.HSMarks = HSMarks;
        }

        public double calculateMerit()
        {
            double merit = 0;
            merit = (EntryTestMarks /200 * 0.30) + (HSMarks / 1100 *  0.70) ;
            return merit;
        }
    }
}
