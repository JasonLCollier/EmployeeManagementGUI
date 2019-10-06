//Jason Collier 214008258
//George Smith 214014959
//Louis van der Westhuizen 214009246

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class FullTime:Employee
    {
        private decimal salary;
        
        public FullTime(string name, string surname, decimal salary) : base(name, surname)
        {
            this.salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + "; Salary: " + salary.ToString("C");
        }
    }
}
