using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract(); //stubbed out method, no implementation, any class that inherits from it will have to 
        //provide specific implementation

        public virtual void DriveVirtual() // has a base implementation and any class that inherits from this can decide to implement
            //this method or come up with its own implementation
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }

    }
    
}
