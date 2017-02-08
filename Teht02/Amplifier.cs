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
                else if (value > maxVol)
                {
                    Console.WriteLine("Invalid volume number, volume is set to maximum!");
                    volume = maxVol;
                }
                else if (value < minVol)
                {
                    Console.WriteLine("Invalid volume number, volume is set to mimimum!");
                    volume = minVol;
                }
            }
        }

        public Amplifier()
        {
            Volume = 1;
        }


    }
}
