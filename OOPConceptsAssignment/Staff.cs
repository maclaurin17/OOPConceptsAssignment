using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsAssignment
{
    internal class Staff
    {
        public string name;
        public int id;
        public string sex;
        private double salary;
        public double Salary // The salary property is associated with the salary field.
                             // To make sure salary data is hidden from other users,
                             // I had to declare it as private then provided
                             // a public get and set methods through properties.   
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
