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
    class Employee:IComparable
    {
        private string name;
        private string surname;
        private string empNum;
        private static int counter = 0;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            int year = DateTime.Today.Year;

            if(counter<9999)
                counter++;
            else
            {
                counter = 0;
                counter++;
            }

            if (counter > 1000)
                empNum = year.ToString() + counter.ToString();
            else if (counter > 100)
                empNum = year.ToString() + "0" + counter.ToString();
            else if (counter > 10)
                empNum = year.ToString() + "00" + counter.ToString();
            else
                empNum = year.ToString() + "000" + counter.ToString();

        }

        public override string ToString()
        {
            return empNum + ": " + name + " " + surname;
        }


        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            Employee temp = (Employee)o;
            if(this.surname.ToUpper()[0] < temp.surname.ToUpper()[0])
                returnVal = 1;
            else
            {
                if (this.surname.ToUpper()[0] > temp.surname.ToUpper()[0])
                    returnVal = -1;
                else
                    returnVal = 0;
            }
            return returnVal;
        }
    }
}
