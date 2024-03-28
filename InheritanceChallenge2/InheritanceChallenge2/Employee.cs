using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }
        
        public Employee() 
        {
            Name = "Furkan";
            FirstName = "Faruk";
            Salary = 20000;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }       
    
        
        public virtual void Work()
        {
            Console.WriteLine("I'm working!");
        }

        public virtual void Pause()
        {
            Console.WriteLine("I'm having a break!");
        }
    }
}
