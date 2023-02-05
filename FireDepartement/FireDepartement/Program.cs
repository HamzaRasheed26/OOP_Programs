using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireDepartement.BL;

namespace FireDepartement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HosePipe pipe = new HosePipe("Fiber", "circle", 3, 10);
            FireFighter f = new FireFighter("Ali");
            FireCheif fc = new FireCheif("Hamza");

            FireTruck truck = new FireTruck(pipe, fc);

            fc.drive();
            fc.extinguishFire();

            fc.delegateResponsibility(f.getName());

            Console.ReadKey();
        }
    }
}
