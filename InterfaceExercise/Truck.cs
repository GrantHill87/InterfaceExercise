using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany //third derived class.
    {
        public double EngineSize { get; set; } = 6.5;
        public string Make { get; set; } = "Nissan";
        public string Model { get; set; } = "Frontier";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Nissan";
        public string Motto { get; set; } = "Shift the way you Move.";
        public bool HasChangedGears { get; set; }
        public bool CanTowOtherVehicles { get; set; } = true;
        public double PayLoad { get; set; } = 23000.00;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving forwards.");
        }
        public void Reverse()
        {
            Console.WriteLine($"This {Make} {Model} has a payload capacity of about {PayLoad} pounds.");
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
        public void Park()
        {
            Console.WriteLine("Because this truck is listed as 'in drive' already, I think it's safe to suggest that this pick up is not shifted into park.");
            Console.WriteLine();
            if (CanTowOtherVehicles == true)
            {
                Console.WriteLine("This truck has the capacity to tow other vehicles.");
            }
            else
            {
                Console.WriteLine("What? I thought that this truck could tow other vehicles.");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
