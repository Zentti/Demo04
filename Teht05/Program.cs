using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio1  = new Radio();
            int input1;
            double input2;

            while (true)
            {
                Console.WriteLine("Radio volume is set to: " + radio1.Volume);
                Console.WriteLine("Give a new volume value (0 - 9): ");
                input1 = int.Parse(Console.ReadLine());

                radio1.Volume = input1;

                Console.WriteLine("Radio frequency is set to: " + radio1.Frequency);
                Console.WriteLine("Set a new frequency (2000.0 - 26000.0): ");
                input2 = double.Parse(Console.ReadLine());

                radio1.Frequency = input2;

            }
        }
    }
}
