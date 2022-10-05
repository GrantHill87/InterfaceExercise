using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SportUtilityVehicle : IVehicle, ICompany //second derived class
    {
        public double EngineSize { get; set; } = 6.1;
        public string Make { get; set; } = "Hyundai";
        public string Model { get; set; } = "Santa Fe";
        public int SeatCount { get; set; } = 7;
        public string CompanyName { get; set; } = "Hyundai";
        public string Motto { get; set; } = "New Thinking, New Possibilities."; //we could at this point even consider writing in properties that we simply wanted to have passed into the methods below, to perhaps make each of these derived classes more unique.
        public bool HasChangedGears { get; set; } //currently set to false, but we could make it true, and get a different string printed to the console, based on our 'if' 'else' script written within the scope of the Drive method.
        public bool HasHighCenterOfGravity { get; set; } = true; //second member that is specific to this class. Perhaps we'll pass it into the Park method below, since it's not really doing anything.
        public bool AllWheelDrive { get; set; } //first member that is specific to this class. We could default this bool to true if we wanted to, otherwise, it will remain false by default of not being defined here.

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving forwards.");
            if (AllWheelDrive == true)
            {
                Console.WriteLine();
                Console.WriteLine($"The {GetType().Name} is also shifted into all wheel drive, at the moment.");
                AllWheelDrive = false;
            }
            else
            {
                Console.WriteLine(); //Below, we call a two properties from the derived class and call a method to print details of this class to the console.
                Console.WriteLine($"This {Model} {GetType().Name} which is manufactured by the {Make} corporation, is not currently shifted into all wheel drive."); //if I implement the
            } //{GetType().BaseType.Name} command here, where I wrote {Make} it doesn't display what it's supposed to.... perhaps because it doesn't know which base class to choose from?
        }
        public void Reverse()
        {
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
        public void Park()
        {
            Console.WriteLine("Because this SUV is listed as 'in drive' already, I think it's safe to suggest that this Utility Vehicle is not shifted into park."); //let's print it to the console anyway :D.
            Console.WriteLine();
            if (HasHighCenterOfGravity == true)
            {
                Console.WriteLine($"Yep, the {Make} {Model} has a high center of gravity.");
            }
            else
            {
                Console.WriteLine("Weird, I was pretty sure this vehicle had a high center of gravity.");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
