using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Lift
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= minFloor && value <= maxFloor) floor = value;
                else
                {
                    Console.WriteLine("Invalid floor number");
                }
            }
        }

        public Lift()
        {
            Floor = 1;
        }


    }
}
