using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Radio
    {
        private readonly int maxVol = 9;
        private readonly int minVol = 0;
        private readonly double minFreq = 2000.0;
        private readonly double maxFreq = 26000.0;

        private int volume;
        private double frequency;

        public bool Power { get; set; }
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
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value >= minFreq && value <= maxFreq) frequency = value;
                else if (value > maxFreq)
                {
                    Console.WriteLine("Invalid frequency number, frequency is set to maximum!");
                    frequency = maxFreq;
                }
                else if (value < minFreq)
                {
                    Console.WriteLine("Invalid frequency number, frequency is set to mimimum!");
                    frequency = minFreq;
                }
            }
        }
    }
}
