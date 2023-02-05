using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeProblem.BL;

namespace BikeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike bike = new MountainBike(7, 2, 5, 50);

            int speed = bike.getSpeed();

            Console.WriteLine("Speed is = " + speed );

            bike.speedUp(10);

            Console.WriteLine("Increasing Speed");
            Console.WriteLine("Speed is = " + bike.getSpeed());

            bike.applyBrake(bike.getSpeed());
            Console.WriteLine("Applying Brake");
            Console.WriteLine("Speed is = " + bike.getSpeed());

            Console.ReadKey();
        }

    }
}
