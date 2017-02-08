using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return " - Name: " + Name + " Profession: " + Profession + " Salary: " + Salary + "e/kk ";
        }
    }
}
