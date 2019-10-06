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
    class PartTime : Employee
    {
        private decimal hoursWorked;
        private decimal hourlyRate;

        public PartTime(string name, string surname, decimal hoursWorked, decimal hourlyRate) : base(name, surname)
        {
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
        }

        public override string ToString()
        {
            return base.ToString() + "; Hours worked : " + hoursWorked.ToString() + "; Rate : " + hourlyRate.ToString("C") + "; Total claims : " + (hourlyRate * hoursWorked).ToString("C");
        }
    }
}
