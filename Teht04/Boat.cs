using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int Seats { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", Boat type: " + BoatType + ", Seat count: " + Seats;
        }
    }
}
