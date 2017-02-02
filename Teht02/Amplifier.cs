using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Amplifier
    {
        private readonly int maxVol = 100;
        private readonly int minVol = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= minVol && value <= maxVol) volume = value;
                else
                {
                    Console.WriteLine("Invalid volume number");
                }
            }
        }

        public Amplifier()
        {
            Volume = 1;
        }


    }
}
