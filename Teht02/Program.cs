using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier laite = new Amplifier();
            int input;

            while (true)
            {
                Console.WriteLine("Amplifier volume is set to: " + laite.Volume);
                Console.WriteLine("Give a new volume value (0-100): ");
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                laite.Volume = input;

            }
        }
    }
}
