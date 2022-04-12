using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        // visual studio shortcut: type prop and press tab twice to create a property
        // decimal datatype is reccomended when using currency

        // car make (ford, chrysler, etc)
        public string make { get; set; }
        public string model { get; set; }
        public decimal price { get; set; }

        // constructor for when user makes a car without providing any parameters
        public Car()
        {
            this.make = "None";
            this.model = "None";
            this.price = 0.00M; // use the M letter to specify double
        }

        // constructor for when user provides information for the car they're creating
        public Car(string make, string model, decimal price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
        }
    }
}
