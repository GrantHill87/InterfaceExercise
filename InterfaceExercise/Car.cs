using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany //first derived class
    {
        public double EngineSize { get; set; } = 4.7;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Avalon";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "You, asked for it. You got it, Toyota.";
        public bool HasChangedGears { get; set; }
        public int NumberOfUSBPorts { get; set; } = 4;
        public int NumberOfCigarLighters { get; set; } = 3;
       
       public void Drive() //notice here, and in every derived class from the base interface classes that we don't need to override anything? At least method wise. Pretty cool.
        {
            Console.WriteLine($"{GetType().Name} is now driving forwards.");
        }
        public void Reverse()
        {
            Console.WriteLine($"This {Make} {Model} has {NumberOfUSBPorts} usb charging ports, and {NumberOfCigarLighters} heated ports to light cigars.");
            Console.WriteLine();
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now set in reverse.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Sorry, but we cannot go in reverse until gears have been shifted first.");
            }
        }
        public void Park() //even if we pass nothing into this method, it will still run. No override needed either. Interfaces are really laid back compared to abstract classes, haha.
        {
            Console.WriteLine($"Because this car is listed as 'in drive' already, I think it's safe to suggest that this {Make} {Model} is not shifted into park."); //we could actually make a bool property just for this derived class if we wanted to, within its scope somewhere, as part of its 'behavior', or we could have even done the exact
        } //same thing in the scope of this derived class' base class, and at least put a value for the bool, that we could then have elected to print to the console, if we wanted to, much like we did for 'HasChangedGears'.
        public void ChangeGears (bool isChanged) //Doyle did mention in one of his lectures that this 'ChangedGears' method was unnecessary, and consequently obselete as a result of his 'HasChangedGears' property creation.
        { //therefore, setting that same property equal to something else, expressed as a variable, being passed through the method as a parameter, is not necessary here. A potentially more useful way to achieve what this
            HasChangedGears = isChanged; //method was initally trying to would have been to do what I did for the SUV class, or what what was written within the scope of the 'Reverse' method above, and just set the 'HasChangedGears' property set to true.
        }
    }
}
