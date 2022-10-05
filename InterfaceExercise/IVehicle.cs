using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public double EngineSize { get; set; }  //this should be expressed in units of litres, once implemented, or at least printed to the console, as we cannot express that here as a string, just a number.
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive(); //methods aren't always necessarily pretermined; we can craft them as we go.
        public void Reverse(); //remember, interfaces force derived classes to confomr to them; to their blueprint. So, every derived class, the three vehicles we created, has to make a definition for each 
        public void Park(); //of the properties listed here, as well as the stubbed out methods. Since each derived calss not only confomrs to thsi interface, but also conforms to another interface, the properties
        public void ChangeGears(bool isChanged); //of those must be defined in the scope of each class that utilizes these two interfaces as a base class. The cool thing about interfaces though; they're less picky
    } //than say, abstract classes are -- they want you to implement their methods, but they don't care how, or what else you do with them. You could add however much or little code you wanted in the scope of each method as its called by each derived class.
}
