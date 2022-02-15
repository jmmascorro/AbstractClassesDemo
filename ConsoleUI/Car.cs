using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }

        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("This Car is in Drive");
        }

        
    }
}
