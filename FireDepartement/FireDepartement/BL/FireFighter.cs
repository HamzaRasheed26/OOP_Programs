using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartement.BL
{
    internal class FireFighter
    {
        protected string name;

        public FireFighter(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public void drive()
        {
            Console.WriteLine(name + " is Driving the Truck");
        }

        public void extinguishFire()
        {
            Console.WriteLine(name + " is Extinguishing the Fire");
        }
    }
}
