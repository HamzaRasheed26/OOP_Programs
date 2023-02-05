using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartement.BL
{
    internal class FireCheif : FireFighter
    {
        public FireCheif(string name) : base(name)
        {

        }

        public void delegateResponsibility(string fireFighterName)
        {
            Console.WriteLine("Tell " + fireFighterName + " to Extinguish the Fire");
        }
    }
}
