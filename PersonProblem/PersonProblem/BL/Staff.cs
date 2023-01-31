using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProblem.BL
{
    internal class Staff : Person
    {
        private string school;
        private double pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string getSchool()
        {
            return school;
        }
        public double getPay()
        {
            return pay;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }

        public override string makeString()
        {
            string msg = "Staff[" + base.makeString() + ",school = " + school.ToString() + ",pay = " + pay.ToString() + "]";
            return msg;
        }
    }
}
