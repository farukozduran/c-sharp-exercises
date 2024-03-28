using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Boss : Employee
    {
        public string CompanyCar {  get; set; }

        public Boss(string name, string firstName, int salary, string companyCar): base(name, firstName,salary) 
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"{FirstName} is leading");
        }
    }
}
