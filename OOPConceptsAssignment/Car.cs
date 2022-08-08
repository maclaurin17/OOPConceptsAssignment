using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsAssignment
{
    public class Car // base class (parent)
        {
            public string color { get; set; }
            public string model { get; set; }
            public string make { get; set; }
            public bool Isautomatic { get; set; }
            public bool Iscarkey { get; set; }
            public bool Isfuel { get; set; }
            public bool IsPainted { get; set; }

        public string CarReadyTobeShipped()
        {
            if(IsPainted && Isautomatic && Iscarkey && Isfuel)
            {
                return "Welcome, Your car is ready to be shipped to your location";
            }
            else
            {
                return "Sorry we cannot ship this car at this time";
            }
        }
           public virtual void carEdition()
        {
            Console.WriteLine("We make both Limited Editions and Special Editions");
        }
        }
    public class Toyota : Car // derived class (child). Even though I have not declared any
                              // fields or methods in this class, I am able to make some
                              // declarations on this class because it has inherited the base
                              // class properties
    {
        public override void carEdition() // I am able to call the carEdition method here
        {
            Console.WriteLine("This Car is a Limited Edition Model");
        }
    }

    public class Mercedes : Car // This is derived class. 
    {
        public override void carEdition() // I was able to call the carEdition method here
                                          // to get a different output on the derived class
                                          // due to Polymorphism
        {
            Console.WriteLine("This car is a Special Edition Model");
        }
    }
}
