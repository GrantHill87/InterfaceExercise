using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            Console.WriteLine("Here, we will print the objects created from the blueprints of our derived classes, which consquently were forced to conform to their respective base interface classes.");
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car = new Car(); //object #1 -- values of the properties and methods from the respective derived class get stored into this newly crafted variable. We then add this variable to our newly made list.
            var truck = new Truck(); //object #2 //foreach will take the information stored from these variables, and print them to the console, because that's what we're telling foreach to do.
            var suv = new SportUtilityVehicle(); //object #3
            var vehicleList = new List<IVehicle>() { car, truck, suv }; //rather than adding each of these classes one at a time line by line below, we've instead added them here by passing them into the
            //parameters of our new vehicleList.
            foreach (var vehicle in vehicleList) //this is a great way to quickly initialize and assign a variable to do things for us, based on a list we've already made and defined above.
            { //foreach literally will do what you want it to for all items defined in a given list, rather than you having to repeatedly copy and paste or type out the same items to be performed over and over again. #SyntaxSugar.
                Console.WriteLine(); //if you input the assigned vehicle variable here, it will return the name of the namespace for this entire file, which we obviously don't need to do.
                Console.WriteLine($"Vehicle Make; {vehicle.Make}."); //I wanted to display everything we've defined in our derived classes to the console, so I added the properties of each derived class as well.
                Console.WriteLine($"Vehicle Model; {vehicle.Model}."); //couldn't call them as methods here, because they aren't defined as methods, duh. They're defined as properties, so we must call them as such.
                Console.WriteLine($"It has {vehicle.SeatCount} seats."); //I wouldn't bother with calling the ChangeGears method, nothing to really use it for in this case, unless we want change its value.
                Console.WriteLine($"It is equipped with an engine size of about {vehicle.EngineSize} litres."); //I don't see the need for making multiple objects of each derived class here, unless we wanted more information about something of preponderance -- say cost of vehcile, vehcile condition, vehicle year, and so on..... like as if we were a car dealership and had a lot of each of these types of classes to sell in the format of objects.
                Console.WriteLine(); //unfortunately, we can only define one class per list at a time, I tried putting a comma next to 'IVehicle', and writing 'ICompany' next to it, and it errored. Since 'CompanyName' is a porperty expressed in the 'ICompany' base class (interface), and our syntax here wouldn't let us use it at the same as 'IVehicle', we cannot place $"{vehicle.CompanyName}" here.
                vehicle.Drive(); //this method is going to print some stuff to the console for us, because that's what we told it to do.
                vehicle.ChangeGears(true); //this sets all of our derived classes, which have been added to the vehicleList, to driving in a forwards gear. This method is expecting a bool format for its return, that's why it could have true or false inside of its parenthesis.
                vehicle.Reverse(); //these lines of code printing the defined methods derived from our base class 'IVehicle', but remember, these stubbed out methods were told what to do in our derived classes, before calling them here, in the main script.
                vehicle.Park(); //totally forgot to call this method the first time!
            }

        }
    }
}
