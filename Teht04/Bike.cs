using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Bike : Vehicle
    {
        public bool Gear { get; set; }
        public string GearName { get; set; }


        public override string ToString()
        {
            return base.ToString() + ", Gears: " + Gear + ", Gears name: " + GearName;
        }
    }
}
