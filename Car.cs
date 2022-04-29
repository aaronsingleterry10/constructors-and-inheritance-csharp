using System;

namespace ConstructorsInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized with # {0}", registrationNumber);
        }
    }
}
