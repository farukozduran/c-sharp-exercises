using InheritanceChallenge2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a main class with the Main Method, then a base class Employee with the properties
// Name, FirstName, Salary, and the methods Work() and Pause().
// Override the methods Work() of the trainee class
// so that it indicates the working hours of the trainee.
// Don’t forget to create constructors.
// Create an object of each of the three classes (with arbitrary values)
// and call the methods, Lead() of Boss and Work() of Trainee.
// Just print out the respective text, what the respective employees do.
// E.g. Lead() should print out something like. I'm leading. It is up to you what you print out.





namespace InheritanceChallenge2
{
    internal class Trainee:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }



        public Trainee() { }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours):base(name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"{FirstName} is learning for {SchoolHours}");
        }

        public override void Work()
        {
            Console.WriteLine("Working hours of {0} is {1}", FirstName, WorkingHours );
        }
    }
}
