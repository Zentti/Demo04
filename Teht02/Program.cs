﻿using System;
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
            Amplifier hissi = new Amplifier();
            int input;

            while (true)
            {
                // vaihda nämä
                Console.WriteLine("Elevator is now in floor: " + hissi.Floor);
                Console.WriteLine("Give a new floor number (1-5): ");
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                hissi.Floor = input;

            }
        }
    }
}
