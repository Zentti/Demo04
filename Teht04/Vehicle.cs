using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int YearModel { get; set; }
        public string Colour { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Year: " + YearModel + ", Colour: " + Colour;
        }
    }
}
