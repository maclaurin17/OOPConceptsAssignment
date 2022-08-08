using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsAssignment
{
    public abstract class Customers// This is an abstract class (Base class)
    {
        public abstract void customerType();
        public void transmission()
        {
            Console.WriteLine("It is Manual"); 
        }
    }
    public class Premium : Customers // This is a derived class
    {
        public override void customerType()
        {
            Console.WriteLine("You are a Premium Customer");
        }
    }
    public class Regular : Customers // This is a derived class
    {
        public override void customerType()
        {
            Console.WriteLine(" You are a regular customer");
        }
    }

    
}

